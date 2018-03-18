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
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            List<ImageSource> images = new List<ImageSource>
            {
                //new Image(){Source = 
                ImageSource.FromResource("UCTS.Images.1.png"),
                //},
                //new Image(){Source = 
                ImageSource.FromResource("UCTS.Images.2.png"),
                //},
                //new Image(){Source = 
                ImageSource.FromResource("UCTS.Images.3.png"),
                //},
                //new Image(){Source = 
                ImageSource.FromResource("UCTS.Images.4.png"),
                //},
                //new Image(){Source = 
                ImageSource.FromResource("UCTS.Images.5.png"),
                //},
                //new Image(){Source = 
                ImageSource.FromResource("UCTS.Images.7.png"),
                //},
            };
            MainCarouselView.ItemsSource = images;
            //MainCarouselView.MinimumHeightRequest = 200; 
        }

        private void more1TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            label1.IsVisible = true;
            labelVision.IsVisible = true;
            labelVisionText.IsVisible = true;
            labelMission.IsVisible = true;
            labelMissionText.IsVisible = true;
            labelCore.IsVisible = true;
            labelCoreText.IsVisible = true;
            more1.IsVisible = false;
            hide1.IsVisible = true;
        }

        private void hide1TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            label1.IsVisible = false;
            labelVision.IsVisible = false;
            labelVisionText.IsVisible = false;
            labelMission.IsVisible = false;
            labelMissionText.IsVisible = false;
            labelCore.IsVisible = false;
            labelCoreText.IsVisible = false;
            more1.IsVisible = true;
            hide1.IsVisible = false;
        }

        private void Banner4TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("http://www.panomatics.com/nextgen/my/ucts/"));
        }

        private void VirtualTapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("http://www.panomatics.com/nextgen/my/ucts/"));
        }

        //private async void AboutTapGestureRecognizer_Tapped(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new ProgrammesPage());
        //}



        //private async void Banner2TapGestureRecognizer_Tapped(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new ServicesPage());
        //}

        //private async void ScholarshipsTapGestureRecognizer_Tapped(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new ServicesPage());
        //}



        //private async void Banner3TapGestureRecognizer_Tapped(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new HomePage());
        //}

        //private async void LearningTapGestureRecognizer_Tapped(object sender, EventArgs e)
        //{
        //    await Navigation.PushModalAsync(new HomePage());
        //}

    }
}