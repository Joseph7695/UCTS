using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace UCTS
{
    public class ExtendedViewCell : ViewCell
    {
        public static readonly BindableProperty SelectedBackgroundColorProperty =
            BindableProperty.Create("SelectedBackgroundColor",
                                    typeof(Color),
                                    typeof(ExtendedViewCell),
                                    Color.Default);

        //public static readonly BindableProperty UnselectedBackgroundColorProperty =
        //    BindableProperty.Create("SelectedBackgroundColor",
        //                            typeof(Color),
        //                            typeof(ExtendedViewCell),
        //                            Color.White);

        public Color SelectedBackgroundColor
        {
            get { return (Color)GetValue(SelectedBackgroundColorProperty); }
            set { SetValue(SelectedBackgroundColorProperty, value); }
        }

        //public Color UnselectedBackgroundColor
        //{
        //    get { return (Color)GetValue(UnselectedBackgroundColorProperty); }
        //    set { SetValue(UnselectedBackgroundColorProperty, value); }
        //}
    }
}
