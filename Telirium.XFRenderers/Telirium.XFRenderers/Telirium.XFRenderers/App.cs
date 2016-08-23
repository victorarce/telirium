using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Telirium.XFRenderers
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            MainPage = new TestView();
        }
    }
}
