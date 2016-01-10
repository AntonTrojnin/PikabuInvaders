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
        public static CookieContainer CookieContainer;

        public mainForm()
        {
            InitializeComponent();
            CookieContainer = new CookieContainer();
        }
 
        private void logData(object text)
        {
            logBox.AppendText(text + Environment.NewLine);
        }

        private void changeStartButtonState()
        {
            if (Properties.Settings.Default.running)
            {
                checkNewPosts.Enabled = false;
                Properties.Settings.Default.running = false;
                logData("Приостанавливаем порабощение мира.");
                startButton.Text = "Старт";
            }
            else
            {
                checkNewPosts.Enabled = true;
                Properties.Settings.Default.running = true;
                logData("Успешная авторизация.");
                logData("Начинаем атаку.");
                startButton.Text = "Стоп";
            }
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

        private async void startButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = false;
            if (!Properties.Settings.Default.running)
            {
                logData("Авторизуемся на pikabu...");

                var req = (HttpWebRequest)WebRequest.Create("http://pikabu.ru");
                req.CookieContainer = CookieContainer;

                using (var res = await req.GetResponseAsync())
                {
                    var temp = (HttpWebResponse)res;
                    using (var read = new StreamReader(res.GetResponseStream()))
                    {
                        var responseResult = read.ReadToEnd();

                    }
                    CookieContainer = req.CookieContainer;
                }

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
                }
                else
                {
                    changeStartButtonState();
                }
            }
            else
            {
                changeStartButtonState();
            }

            startButton.Enabled = true;
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

        private void mainForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.login != "")
            {
                loginBox.Text = Properties.Settings.Default.login;
            }

            if (Properties.Settings.Default.password != "")
            {
                passBox.Text = Properties.Settings.Default.password;
            }
        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.login = loginBox.Text;
            Properties.Settings.Default.password = passBox.Text;
            Properties.Settings.Default.running = false;
            Properties.Settings.Default.Save();
        }
    }
}
