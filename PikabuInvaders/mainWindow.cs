using System;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using HtmlAgilityPack;

namespace PikabuInvaders
{
    public partial class mainForm : Form
    {
        private string csrfToken;
        // Храним cookie после авторизации для повторного использования
        public static CookieContainer CookieContainer;
        public bool isRunning;

        public mainForm()
        {
            InitializeComponent();
            CookieContainer = new CookieContainer();

            ContextMenu trayMenu = new ContextMenu();
            trayMenu.MenuItems.Add("Открыть");
            trayMenu.MenuItems.Add("Выход", OnExit);

            notify.ContextMenu = trayMenu;
        }

        protected override void OnLoad(EventArgs e)
        {
            if (Properties.Settings.Default.login != "")
            {
                loginBox.Text = Properties.Settings.Default.login;
            }

            if (Properties.Settings.Default.password != "")
            {
                passBox.Text = Properties.Settings.Default.password;
            }

            if (this.WindowState == FormWindowState.Minimized)
            {
                notify.Visible = true;
                base.OnLoad(e);
            }

            if (Properties.Settings.Default.autoAttack)
            {
                // Начинаем атаку!
                runAttack();
            }
        }

        private void OnExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logData(object text)
        {
            logBox.AppendText(text + Environment.NewLine);
        }

        private string sendPostRequest(String url, String data = "")
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.CookieContainer = CookieContainer;
            request.ContentType = "application/x-www-form-urlencoded";
            request.Host = "pikabu.ru";
            request.Referer = "http://pikabu.ru/";
            request.Accept = "application/json, text/javascript, */*; q=0.01";
            request.Headers.Add("Origin", "pikabu.ru");
            request.Headers.Add("X-Csrf-Token", csrfToken);
            byte[] bytes = Encoding.UTF8.GetBytes(data);
            request.ContentLength = bytes.Length;

            Stream requestStream = request.GetRequestStream();
            requestStream.Write(bytes, 0, bytes.Length);

            WebResponse response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);

            var result = reader.ReadToEnd();
            stream.Dispose();
            reader.Dispose();

            return result;
        }

        private void runAttack()
        {
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
                stopAttack();
            }
            else
            {
                checkNewPosts.Enabled = true;
                isRunning = true;
                logData("Успешная авторизация.");
                logData("Начинаем атаку.");
                startButton.Text = "Стоп";
                loginBox.Enabled = false;
                passBox.Enabled = false;
            }

            startButton.Enabled = true;
        }

        private void stopAttack()
        {
            checkNewPosts.Enabled = false;

            logData("Приостанавливаем порабощение мира.");
            startButton.Text = "Старт";
            loginBox.Enabled = true;
            passBox.Enabled = true;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                stopAttack();
            }
            else
            {
                runAttack();
            }
        }

        private void checkNewPosts_Tick(object sender, EventArgs e)
        {
            logData("Проверяем новые посты на pikabu...");

            var webget = new HtmlWeb();
            var doc = webget.Load("http://pikabu.ru/new");
            HtmlNodeCollection nodes = doc.DocumentNode.SelectNodes("//a[contains(@class,'b-story__link')]");
            if (nodes != null)
            {
                logData("Свежие посты найдены. Минусим!");
                foreach (HtmlNode row in nodes)
                {
                    var postData = "i=" + row.Attributes[2].Value;
                        postData += "&type=-";

                    sendPostRequest("http://pikabu.ru/ajax/dig.php", postData);
                }

                logData("Свежие посты успешно заминусены. Ждём новых.");
            }
            else
            {
                logData("Нет новых постов. Ждём, когда они появятся");
            }     
        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Запоминаем введённые пользователем логин и пароль
            Properties.Settings.Default.login = loginBox.Text;
            Properties.Settings.Default.password = passBox.Text;
            Properties.Settings.Default.Save();
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

        private void settingsMenuitem_Click(object sender, EventArgs e)
        {
            settingsForm settings = new settingsForm();
            settings.Show();
        }

        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            aboutForm about = new aboutForm();
            about.Show();
        }
    }
}
