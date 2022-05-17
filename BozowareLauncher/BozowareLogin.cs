using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BozowareLauncher
{
    public partial class BozowareLogin : Form
    {
        public BozowareLogin()
        {
            InitializeComponent();
        }

        private void bozowareIcon_Clicked(object sender, EventArgs e)
        {
            WebUtil.OpenUrl("https://bozoware.rip/");
        }

        private void loginButton_Clicked(object sender, EventArgs e)
        {
            if (!LoginButton.Text.Equals("Login"))
                return;
            if (UsernameTextbox.Text.Equals("") || PasswordTextbox.Text.Equals(""))
            {
                setText(1000, "Invalid Credentials.");
                return;
            }

            LoginButton.Text = "Logging in...";

            var url = "https://skidware.cc/api/v1/authenticate";
            var postData = new Dictionary<string, string>();
            postData.Add("username", UsernameTextbox.Text.ToLower());
            postData.Add("password", SecurityUtil.hashPassword(UsernameTextbox.Text,PasswordTextbox.Text));
            postData.Add("clientver", "Launcher");
            postData.Add("hwid", SecurityUtil.getHWID(UsernameTextbox.Text));
            var requestBody = JsonConvert.SerializeObject(postData);

            var headers = new Dictionary<string, string>();
            Request(HttpMethod.Post, url, requestBody);
        }

        private async void setText(int millis, string text)
        {
            await Task.Run(() =>
            {
                StatusTextBox.Text = text;
                LoginButton.Text = "Login";
                Thread.Sleep(millis);
                if (StatusTextBox.Text.Equals(text))
                    StatusTextBox.Text = "Ready To Login...";
            });
        }

        private async void Request(HttpMethod pMethod, string pUrl, string pJsonContent)
        {
            await Task.Run(() =>
            {
                var httpRequestMessage = new HttpRequestMessage();
                httpRequestMessage.Method = pMethod;
                httpRequestMessage.RequestUri = new Uri(pUrl);
                switch (pMethod.Method)
                {
                    case "POST":
                        HttpContent httpContent = new StringContent(pJsonContent, Encoding.UTF8, "application/json");
                        httpRequestMessage.Content = httpContent;
                        httpContent.Headers.Add("BozowareClient", "Launcher");
                        var responseMessage = new HttpResponseMessage();
                        try
                        {
                            responseMessage = Program.getHttpClient().PostAsync(pUrl, httpContent).Result;
                        }
                        catch (SocketException)
                        {
                            setText(1000, "No Response.");
                            return;
                        }

                        if (!responseMessage.IsSuccessStatusCode)
                        {
                            setText(1000, "An Error has Occurred.");
                            return;
                        }

                        var data = responseMessage.Content.ReadAsStringAsync().Result;
                        JObject dataObject = (JObject) JsonConvert.DeserializeObject(data);
                        if(!dataObject.ContainsKey("response"))
                        {
                            setText(1000, "An Error has Occurred.");
                            return;
                        }

                        string response = (string) dataObject["response"].ToObject(typeof(string));
                        if (!response.Equals("loginsuccess"))
                        {
                            setText(2500, response);
                            return;
                        }

                        string authkey = (string)dataObject["authentication-key"].ToObject(typeof(string));
                        if (authkey.Equals("Launcher"))
                        {
                            setText(1000, "Logged in successfully.");
                        }
                        else
                        {
                            Close();
                        }

                        break;
                }
                
                
            });
        }

        private void UsernameTextbox_TextChanged(object sender, EventArgs e)
        {
        }

        private void PasswordTextbox_TextChanged(object sender, EventArgs e)
        {
        }

        private void StatusTextBox_Click(object sender, EventArgs e)
        {
            
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}