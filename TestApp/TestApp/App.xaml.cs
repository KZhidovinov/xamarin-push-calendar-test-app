using Autofac;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestApp
{
    public partial class App : Application
    {
        public static IContainer Container { get; private set; }

        public App(IContainer container)
        {
            Container = container;

            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
