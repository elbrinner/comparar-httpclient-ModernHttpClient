using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;

using Xamarin.Forms;

namespace TesteServicios1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TesteServicios1.MainPage();
        }

        protected  override void OnStart()
        {


        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
