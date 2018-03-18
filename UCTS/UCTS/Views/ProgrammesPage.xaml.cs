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
    public partial class ProgrammesPage : ContentPage
    {
        private bool _foundationExpanded = false;
        private bool _undergradExpanded = false;
        private bool _postgradExpanded = false;

        public ProgrammesPage()
        {
            InitializeComponent();
        }

        StackLayout previousStack = new StackLayout();
        RowDefinition previousRow = new RowDefinition();

        private void Show(RowDefinition layout, StackLayout layout1/*, double expandedheight*/)
        {
            if (previousStack.IsVisible)
                Hide(previousRow, previousStack);
            layout1.IsVisible = true;
            new Animation
            {
                //{ 0, 1, new Animation (d => layout1.HeightRequest = d, layout1.Height, expandedheight) },
                { 0, 1, new Animation (d => layout1.Opacity = d, 0, 1) }
            }.Commit(layout1, "AnimationShow", 10, 250);
            previousRow = layout;
            previousStack = layout1;
        }

        private void Hide(RowDefinition layout, StackLayout layout1)
        {
            new Animation
            {
                //{ 0, 1, new Animation (d => layout1.HeightRequest = d, layout1.Height, 0) },
                { 0, 0.75, new Animation (d => layout1.Opacity = d, 1, 0) }
            }.Commit(layout1, "AnimationHide", 10, 250);
            layout1.IsVisible = false;
        }

        private void Foundation_Tapped(object sender, EventArgs e)
        {
            //StackLayout layout = sender as StackLayout;
            if (!_foundationExpanded)
            {
                _foundationExpanded = true;
                Show(stackRow, stack/*, _foundationDetailHeight*/);
            }
            else
            {
                _foundationExpanded = false;
                Hide(stackRow, stack);
            }
        }
        private void Undergrad_Tapped(object sender, EventArgs e)
        {
            if (!_undergradExpanded)
            {
                _undergradExpanded = true;
                Show(stack1Row, stack1/*, _foundationDetailHeight*/);
            }
            else
            {
                _undergradExpanded = false;
                Hide(stack1Row, stack1);
            }
        }
        private void Postgrad_Tapped(object sender, EventArgs e)
        {
            if (!_postgradExpanded)
            {
                _postgradExpanded = true;
                Show(stack2Row, stack2/*, _foundationDetailHeight*/);
            }
            else
            {
                _postgradExpanded = false;
                Hide(stack2Row, stack2);
            }
        }

        private void foundation6_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new AdmissionPage());
        }

        private void postgraduate14_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new AdmissionPage());
        }

        private void undergraduate21_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new AdmissionPage());
        }
    }
}