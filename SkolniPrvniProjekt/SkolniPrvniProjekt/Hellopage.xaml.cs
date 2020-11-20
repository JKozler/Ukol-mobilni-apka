using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SkolniPrvniProjekt
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Hellopage : ContentPage
    {
        public Hellopage(string h)
        {
            InitializeComponent();
            pozdrav.Text = h;
            Console.WriteLine(h);
        }
    }
}