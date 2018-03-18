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
    public partial class SchoolsPage : ContentPage
    {
        public SchoolsPage()
        {
            InitializeComponent();
        }

        StackLayout previousStack = new StackLayout();

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

        private void SBE_Tapped(object sender, EventArgs e)
        {
            if (SBE.IsVisible)
                Hide(SBE);
            else
                Show(SBE);
        }
        private void SBM_Tapped(object sender, EventArgs e)
        {
            if (SBM.IsVisible)
                Hide(SBM);
            else
                Show(SBM);
        }
        private void SET_Tapped(object sender, EventArgs e)
        {
            if (SET.IsVisible)
                Hide(SET);
            else
                Show(SET);
        }
        private void SFS_Tapped(object sender, EventArgs e)
        {
            if (SFS.IsVisible)
                Hide(SFS);
            else
                Show(SFS);
        }
        private void SOC_Tapped(object sender, EventArgs e)
        {
            if (SOC.IsVisible)
                Hide(SOC);
            else
                Show(SOC);
        }
        private void SPG_Tapped(object sender, EventArgs e)
        {
            if (SPG.IsVisible)
                Hide(SPG);
            else
                Show(SPG);
        }
        private void UCU_Tapped(object sender, EventArgs e)
        {
            if (UCU.IsVisible)
                Hide(UCU);
            else
                Show(UCU);
        }
    }
}