using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Page_XF
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Page_XF.TipoPagina.Carousel.TipoPage1();
            //para mostrar a pagina no proprio computador sem precisar passar para o celular.

            //MainPage = new MainPage();
            //default
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
