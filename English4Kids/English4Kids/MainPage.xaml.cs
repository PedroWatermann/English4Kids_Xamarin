using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace English4Kids
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnCores_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageCores());
        }

        private void btnFamilia_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageFamilia());
        }

        private void btnNumeros_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageNumeros());
        }

        private void btnSair_Clicked(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            catch
            {

            }
        }
    }
}
