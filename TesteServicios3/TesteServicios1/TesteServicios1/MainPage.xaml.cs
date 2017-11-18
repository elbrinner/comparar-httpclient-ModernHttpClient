using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ModernHttpClient;
using Xamarin.Forms;

namespace TesteServicios1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

           

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string page = "http://en.wikipedia.org/";

            DateTime tiempo1 = DateTime.Now;
            Debug.WriteLine("Starting connections");
            for (int i = 0; i < 10; i++)
            {
                using (var client = new HttpClient(new NativeMessageHandler()))
                {
                    var result = client.GetAsync(page).Result;
                    Debug.WriteLine(result.StatusCode);
                }
            }
            Debug.WriteLine("Connections done");
            DateTime tiempo2 = DateTime.Now;
            TimeSpan total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);
            Debug.WriteLine(total.ToString());
            tiempo.Text = total.ToString();
        }
    }
}
