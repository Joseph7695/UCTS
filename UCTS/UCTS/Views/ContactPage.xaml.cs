using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UCTS.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactPage : ContentPage
    {
        public ContactPage()
        {
            InitializeComponent();
        }

        private void Email_Tapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("http://feeds.specificfeeds.com/international36"));
        }
        private void Google_Tapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://plus.google.com/up/accounts/upgrade/?continue=https://plus.google.com/share?app%3D110%26url%3Dhttp://www.ucts.edu.my/international/index.php/admission/"));
        }
        private void Insta_Tapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.instagram.com/uctsofficial/"));
        }
        private void Facebook_Tapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.facebook.com/uctsofficial"));
        }
        private void Youtube_Tapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.youtube.com/user/UCTSOfficial"));
        }
    }
}