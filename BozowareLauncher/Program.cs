using System;
using System.Net.Http;
using System.Windows.Forms;
using Guna.UI2;

namespace BozowareLauncher
{
    
    
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BozowareLogin());
        }

        private static readonly HttpClient client = new HttpClient();
        
        public static HttpClient getHttpClient()
        {
            return client;
        }
    }
}