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
    public partial class FaqsPage : ContentPage
    {
        public FaqsPage()
        {
            InitializeComponent();
        }

        private void Show(StackLayout layout)
        {
            if (previousStack.IsVisible)
                Hide(previousStack);
            layout.IsVisible = true;
            new Animation
            {
                { 0, 1, new Animation (d => layout.Opacity = d, 0, 1) }
            }.Commit(layout, "AnimationShow", 16, 250);
            previousStack = layout;
        }

        private void Hide(StackLayout layout)
        {
            new Animation
            {
                { 0, 0.75, new Animation (d => layout.Opacity = d, 1, 0) }
            }.Commit(layout, "AnimationHide", 16, 250);
            layout.IsVisible = false;
        }

        StackLayout previousStack = new StackLayout();

        private void AboutUcts_Tapped(object sender, EventArgs e)
        {
            if (About_UCTS.IsVisible)
                Hide(About_UCTS);
            else
                Show(About_UCTS);
        }
        private void Academic_Tapped(object sender, EventArgs e)
        {
            if (AcademicProgramme.IsVisible)
                Hide(AcademicProgramme);
            else
                Show(AcademicProgramme);
        }
        private void Fullprog_Tapped(object sender, EventArgs e)
        {
            if (Fullprog.IsVisible)
                Hide(Fullprog);
            else
                Show(Fullprog);
        }
        private void Partprog_Tapped(object sender, EventArgs e)
        {
            if (Partprog.IsVisible)
                Hide(Partprog);
            else
                Show(Partprog);
        }
        private void Fee_Tapped(object sender, EventArgs e)
        {
            if (Fee.IsVisible)
                Hide(Fee);
            else
                Show(Fee);
        }
        private void Sponsor_Tapped(object sender, EventArgs e)
        {
            if (Sponsor.IsVisible)
                Hide(Sponsor);
            else
                Show(Sponsor);
        }
        private void Accommodation_Tapped(object sender, EventArgs e)
        {
            if (Accommodation.IsVisible)
                Hide(Accommodation);
            else
                Show(Accommodation);
        }
        private void Admission_Tapped(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new AdmissionPage());
        }
        private void Tuitionfee_Tapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("http://www.ucts.edu.my/international/index.php/programmes/tuition-fees/"));
        }
        private void Sponsorship_Tapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("http://international.ucts.edu.my/index.php/scholarships/"));
        }
        private void Studentaccommodation_Tapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("http://www.ucts.edu.my/international/index.php/home/student-hostel/"));
        }

    }
}