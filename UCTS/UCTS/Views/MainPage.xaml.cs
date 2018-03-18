using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCTS.Models;
using UCTS.Views;
using Xamarin.Forms;

namespace UCTS
{
    public partial class MainPage : MasterDetailPage
    {
        public List<MasterPageModel> MenuList { get; set; }
        private Color _backgroundcolor = new Color();


        public MainPage()
        {
            InitializeComponent();

            MenuList = new List<MasterPageModel>();

            var page1 = new MasterPageModel() { Title = "Home", TargetType = typeof(HomePage) };
            var page2 = new MasterPageModel() { Title = "Programmes", TargetType = typeof(ProgrammesPage) };
            var page3 = new MasterPageModel() { Title = "School", TargetType = typeof(SchoolsPage) };
            var page4 = new MasterPageModel() { Title = "Admission", TargetType = typeof(AdmissionPage) };
            var page5 = new MasterPageModel() { Title = "FAQs", TargetType = typeof(FaqsPage) };
            var page6 = new MasterPageModel() { Title = "Contact", TargetType = typeof(ContactPage) };

            MenuList.Add(page1);
            MenuList.Add(page2);
            MenuList.Add(page3);
            MenuList.Add(page4);
            MenuList.Add(page5);
            MenuList.Add(page6);

            navigationMenuList.ItemsSource = MenuList;
            navigationMenuList.ItemSelected += navigationList_ItemSelected;
            //Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(HomePage)));
            this.BindingContext = new
            {
                Header = "",
                Image = "http://www.ucts.edu.my/international/wp-content/uploads/2016/04/cropped-text-blue.png"
            };

            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(HomePage)));            
        }

        private void navigationList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageModel;
            if (item == null)
                return;

            Type page = item.TargetType;

            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            
            IsPresented = false;
            //navigationMenuList.SelectedItem = null;
        }

        StackLayout _previousStack;

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {

            var type = sender.GetType();
            if (sender.GetType().ToString() == "Xamarin.Forms.StackLayout")
            {
                var entity = (StackLayout)sender;
                if (_previousStack != null)
                {
                    _previousStack.BackgroundColor = Color.FromHex("e8e8e8");
                    _previousStack = entity;
                }
                else
                    _previousStack = entity;
                entity.BackgroundColor = Color.FromHex("8f8dd6");
                var item = (MasterPageModel)entity.BindingContext;
                navigationMenuList.SelectedItem = item;
            }
            else if (sender.GetType().ToString() == "Xamarin.Forms.Label")
            {
                var entity = (Label)sender;
                StackLayout parent = entity.Parent as StackLayout;
                if (_previousStack != null)
                {
                    _previousStack.BackgroundColor = Color.FromHex("e8e8e8");
                    _previousStack = parent;
                }
                else
                    _previousStack = parent;
                parent.BackgroundColor = Color.FromHex("8f8dd6");
                var item = (MasterPageModel)entity.BindingContext;
                navigationMenuList.SelectedItem = item;
            }
            else
                return;
        }
    }
}
