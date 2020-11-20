using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SkolniPrvniProjekt
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void prepis_Clicked(object sender, EventArgs e)
        {
            nameIs.Text = "Jméno je " + jameno.Text;
            jameno.Text = "";

            Page p = new Hellopage(nameIs.Text);

            Application.Current.MainPage.Navigation.PushAsync(new NavigationPage(p));
        }
    }
}
