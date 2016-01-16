using System;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using HtmlAgilityPack;
using System.Linq;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Collections.Generic;
using Microsoft.CSharp.RuntimeBinder;
using System.Drawing;

namespace PikabuInvaders
{
    public partial class mainForm : Form
    {
        // CSRF protection
        private string csrfToken;
        // Храним cookie после авторизации для повторного использования
        public static CookieContainer CookieContainer;
        // Сосотояние программы
        public bool isRunning;
        // К какой лиге принадлежит пользователь
        public static string userSide { get; set; } = Properties.Settings.Default.userSide;
        Stopwatch stopwatch = new Stopwatch();

        public mainForm()
        {
            InitializeComponent();

            CookieContainer = new CookieContainer();

            ContextMenu trayMenu = new ContextMenu();
            trayMenu.MenuItems.Add("Выход", OnExit);

            notify.ContextMenu = trayMenu;

            if (userSide == "good")
            {
                userSideLabel.Text = "Лига добра";
                userSideLabel.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                userSideLabel.Text = "Лига зла";
                userSideLabel.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            if (Properties.Settings.Default.login != "") loginBox.Text = Properties.Settings.Default.login;
            if (Properties.Settings.Default.password != "") passBox.Text = Properties.Settings.Default.password;

            if (this.WindowState == FormWindowState.Minimized)
            {
                notify.Visible = true;
                base.OnLoad(e);
            }

            if (Properties.Settings.Default.autoStart) run();
        }

        private void logData(object text)
        {
            logBox.AppendText(text + Environment.NewLine);
        }

        private string sendPostRequest(string url, string data = "", string mode = "pikabu")
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            // Без перечисленных ниже настроек пикабу отказывается нормально принимать POST запросы
            if (mode == "pikabu")
            {
                request.CookieContainer = CookieContainer;
                request.Host = "pikabu.ru";
                request.Referer = "http://pikabu.ru/";
                request.Accept = "application/json, text/javascript, */*; q=0.01";
                request.Headers.Add("Origin", "pikabu.ru");
                request.Headers.Add("X-Csrf-Token", csrfToken);
            }

            byte[] bytes = Encoding.UTF8.GetBytes(data);
            request.ContentLength = bytes.Length;

            Stream requestStream = request.GetRequestStream();
            requestStream.Write(bytes, 0, bytes.Length);

            WebResponse response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);

            var result = reader.ReadToEnd();
            dynamic json = JsonConvert.DeserializeObject(result);
            try
            {
                var status = json.status;
                if (status == 2)
                {
                    response = request.GetResponse();
                    stream = response.GetResponseStream();
                    reader = new StreamReader(stream);
                }
            }
            catch (RuntimeBinderException) {}

            stream.Dispose();
            reader.Dispose();

            return result;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                stop();
            }
            else
            {
                run();
            }
        }

        private void run()
        {
            try
            {
                using (var client = new WebClient())
                {
                    using (var stream = client.OpenRead("http://pikabuinvaders.ru"))
                    {
                        userSide = Properties.Settings.Default.userSide;
                        startButton.Enabled = false;

                        logData("Авторизуемся на pikabu...");

                        var req = (HttpWebRequest)WebRequest.Create("http://pikabu.ru");
                        req.CookieContainer = CookieContainer;
                        HttpWebResponse TheRespone = (HttpWebResponse)req.GetResponse();
                        CookieContainer.Add(TheRespone.Cookies);
                        TheRespone.Close();

                        csrfToken = CookieContainer.GetCookies(new Uri("http://pikabu.ru"))["PHPSESS"].Value;

                        var postData = "mode=login";
                            postData += "&username=" + loginBox.Text;
                            postData += "&password=" + passBox.Text;
                            postData += "&remember=0";

                        var result = sendPostRequest("http://pikabu.ru/ajax/auth.php", postData);
                        dynamic data = JsonConvert.DeserializeObject(result);

                        if (data.result == false)
                        {
                            logData(data.message);
                            stop();
                        }
                        else
                        {
                            //TODO: написать пост на пикабу
                            //if (!Properties.Settings.Default.plusPost)
                            //{
                            //    logData("О, первый запуск. Поставим один плюс во славу силы зла.");
                            //    sendPostRequest("http://pikabu.ru/ajax/dig.php", "i=XXX&type=+");
                            //    logData("Готово. Вы прелесть. В ужасном смысле :3");
                            //    Properties.Settings.Default.plusPost = true;
                            //}

                            logData("Успешная авторизация.");

                            if (Properties.Settings.Default.firstRun)
                            {
                                DialogResult dialog = MessageBox.Show("Хотите отправлять информацию о ваших действиях? (сохраняется только ваш логин - пароль нигде не хранится)", "Отправка статистики", MessageBoxButtons.YesNo);
                                if (dialog == DialogResult.Yes) Properties.Settings.Default.sendStatistics = true;

                                var webget = new HtmlWeb();
                                var doc = webget.Load("http://pikabu.ru/new");
                                // Выбираем первый пост из свежего
                                // Так мы запомним откуда минусовать
                                var lastPost = Convert.ToInt32(doc.DocumentNode.SelectNodes("//a[contains(@class,'b-story__link')]").First().Attributes[2].Value);
                                Properties.Settings.Default.firstPost = Properties.Settings.Default.lastPost = lastPost;
                                Properties.Settings.Default.firstRun = false;
                            }

                            // Запоминаем введённые пользователем логин и пароль
                            if (Properties.Settings.Default.saveCredentials)
                            {
                                Properties.Settings.Default.login = loginBox.Text;
                                Properties.Settings.Default.password = passBox.Text;
                            }
                            else
                            {
                                Properties.Settings.Default.login = "Логин";
                                Properties.Settings.Default.password = "Пароль";
                            }

                            Properties.Settings.Default.Save();

                            logData("Начинаем работу.");

                            startButton.Text = "Стоп";
                            stopwatch.Reset();
                            stopwatch.Start();

                            if (Properties.Settings.Default.lastCheckedPost < Properties.Settings.Default.firstPost) checkPosts.Start();
                            if (Properties.Settings.Default.sendStatistics) sendStatistics.Start();
                            checkNewPosts.Start();
                            timeTimer.Start();

                            loginBox.Enabled = false;
                            passBox.Enabled = false;

                            isRunning = true;
                        }

                        startButton.Enabled = true;
                    }
                }
            }
            catch
            {
                DialogResult dialog = MessageBox.Show("Возможно, у вас отсутствует подключение к интернету. Проверьте наличие интернета и повторите попытку.", "Ошибка подключения", MessageBoxButtons.OK);
            }
        }

        private void stop()
        {
            checkPosts.Stop();
            checkNewPosts.Stop();
            sendStatistics.Stop();
            timeTimer.Stop();

            startButton.Text = "Старт";
            loginBox.Enabled = true;
            passBox.Enabled = true;
            isRunning = false;
            stopwatch.Stop();

            logData("Программа остановлена.");
        }

        private void checkPosts_Tick(object sender, EventArgs e)
        {
            var postNumber = Properties.Settings.Default.lastCheckedPost;

            if (userSide == "good")
            {
                sendPostRequest("http://pikabu.ru/ajax/dig.php", "i=" + postNumber + "&type=%2B");
                logData("Посту №" + postNumber + " поставлен +");
            }
            else
            {
                sendPostRequest("http://pikabu.ru/ajax/dig.php", "i=" + postNumber + "&type=-");
                logData("Посту №" + postNumber + " поставлен -");
            }

            Properties.Settings.Default.lastCheckedPost = postNumber + 1;
            Properties.Settings.Default.Save();
        }

        private void checkNewPosts_Tick(object sender, EventArgs e)
        {
            checkPosts.Stop();

            logData("\r\nПроверяем наличие новых постов...");

            int postNumber = 0;
            var webget = new HtmlWeb();
            var doc = webget.Load("http://pikabu.ru/new");
            HtmlNodeCollection nodes = doc.DocumentNode.SelectNodes("//a[contains(@class,'b-story__link')]");
            if (nodes != null)
            {
                logData("Свежие посты найдены.");
                foreach (HtmlNode row in nodes)
                {
                    postNumber = Convert.ToInt32(row.Attributes[2].Value);
                    if (postNumber > Properties.Settings.Default.lastPost)
                    {
                        if (userSide == "good")
                        {
                            sendPostRequest("http://pikabu.ru/ajax/dig.php", "i=" + postNumber + "&type=%2B");
                            logData("Поставили + посту №" + postNumber);
                        }
                        else
                        {
                            sendPostRequest("http://pikabu.ru/ajax/dig.php", "i=" + postNumber + "&type=-");
                            logData("Поставили - посту №" + postNumber);
                        }
                    }
                }

                Properties.Settings.Default.lastPost = postNumber;
                Properties.Settings.Default.Save();

                logData("Готово. Ждём новых постов.\r\n");
            }
            else
            {
                logData("Нет новых постов. Ждём, когда они появятся\r\n");
            }

            checkPosts.Start();
        }

        private void sendStatistics_Tick(object sender, EventArgs e)
        {
            logData("Отправляем статистику на сервер.");
            var webget = new HtmlWeb();
            webget.OverrideEncoding = Encoding.GetEncoding("windows-1251");
            var doc = webget.Load("http://pikabu.ru/profile/" + loginBox.Text);
            HtmlNode profile = doc.DocumentNode.SelectNodes("//div[contains(@class,'profile_wrap')]").First();

            string pattern;
            if (userSide == "good") pattern = "([0-9]*) (плюсов)";
            else pattern = "([0-9]*) (минусов)";
            Match match = Regex.Match(profile.InnerHtml, pattern);
            string key = match.Groups[1].Value;

            var postData = "username=" + loginBox.Text;
                postData += "&side=" + userSide;
                postData += "&posts=" + key;

            sendPostRequest("http://pikabuinvaders.ru/statistics.php", postData, "");
        }

        private void timeTimer_Tick(object sender, EventArgs e)
        {
            inWorkLabel.Text = stopwatch.Elapsed.ToString("hh\\:mm\\:ss");
        }

        private void mainForm_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notify.Visible = true;
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notify.Visible = false;
            }
        }

        private void notify_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            notify.Visible = false;
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            var num = 1;
            var result = sendPostRequest("http://pikabuinvaders.ru/statistics.php?get", "", "");
            dynamic table = JsonConvert.DeserializeObject(result);
            foreach (var row in table)
            {
                ratingGrid.Rows.Add(num, row.username, row.posts);

                if (row.side == "good") ratingGrid.Rows[num-1].DefaultCellStyle.BackColor = Color.DarkOliveGreen;
                else ratingGrid.Rows[num-1].DefaultCellStyle.BackColor = Color.Brown;

                num++;
            }

            loadingLabel.Hide();
            ratingGrid.Show();
        }

        private void tabPage2_Leave(object sender, EventArgs e)
        {
            loadingLabel.Show();
            ratingGrid.Hide();
            ratingGrid.Rows.Clear();
            ratingGrid.Refresh();
        }

        private void settingsMenuitem_Click(object sender, EventArgs e)
        {
            settingsForm settings = new settingsForm();
            settings.ShowDialog();
        }

        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            aboutForm about = new aboutForm();
            about.ShowDialog();
        }

        private void OnExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
