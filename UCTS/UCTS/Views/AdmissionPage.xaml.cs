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
    public partial class AdmissionPage : ContentPage
    {
        public AdmissionPage()
        {
            InitializeComponent();
        }

        private void Show(StackLayout layout)
        {
            layout.IsVisible = true;
            new Animation
            {
                { 0, 1, new Animation (d => layout.Opacity = d, 0, 1) }
            }.Commit(layout, "AnimationShow", 16, 250);
        }

        private void Hide(StackLayout layout)
        {
            new Animation
            {
                { 0, 0.75, new Animation (d => layout.Opacity = d, 1, 0) }
            }.Commit(layout, "AnimationHide", 16, 250);
            layout.IsVisible = false;
        }

        private void Foundprog_Tapped(object sender, EventArgs e)
        {
            if (Postprog.IsVisible)
                Hide(Postprog);
            if (Underprog.IsVisible)
                Hide(Underprog);
            if (Foundprog.IsVisible)
                Hide(Foundprog);
            else
                Show(Foundprog);
        }
        private void Underprog_Tapped(object sender, EventArgs e)
        {
            if (Foundprog.IsVisible)
                Hide(Foundprog);
            if (Postprog.IsVisible)
                Hide(Postprog);
            if (Underprog.IsVisible)
                Hide(Underprog);
            else
                Show(Underprog);
        }
        private void Postprog_Tapped(object sender, EventArgs e)
        {
            if (Foundprog.IsVisible)
                Hide(Foundprog);
            if (Underprog.IsVisible)
                Hide(Underprog);
            if (Postprog.IsVisible)
                Hide(Postprog);
            else
                Show(Postprog);
        }
        private void Applyonline_Tapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("http://oculus.ucts.edu.my/apply/signup.php"));
        }
        private void Downloadfoundation_Tapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("http://international.ucts.edu.my/wp-content/uploads/2016/05/found-studies-application-form.pdf"));
        }
        private void Downloadundergrad_Tapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("http://international.ucts.edu.my/wp-content/uploads/2016/06/undergrad-application-form.pdf"));
        }
        private void International_Tapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("http://www.ucts.edu.my/international/index.php/ucts-international-office/ucts-international-students-application-process/"));
        }
        private void Downloadpostgrad_Tapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("http://www.ucts.edu.my/international/wp-content/uploads/2016/09/UCTS-QA-PG-APPLICATION_Rev-2-sep21.pdf"));
        }
        private void Downloadproposal_Tapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("http://international.ucts.edu.my/wp-content/uploads/2016/05/Research-proposal-form.pdf"));
        }
        private void Downloadreferee_Tapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("http://international.ucts.edu.my/wp-content/uploads/2016/05/Referee-form.pdf"));
        }
        private void Postapplication_Tapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("http://www.ucts.edu.my/international/index.php/schools/school-of-postgraduate-studies/postgraduate-programmes-application/"));
        }
    }
}