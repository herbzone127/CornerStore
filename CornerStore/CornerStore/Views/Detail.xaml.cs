using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CornerStore.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CornerStore.Models;

namespace CornerStore.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Detail : ContentPage
	{
		public Detail ()
		{
			InitializeComponent ();
           var productID = Application.Current.Properties["PRODUCTID"] as string;
          var Image =   Application.Current.Properties["IMAGE"] as string;
          var Name=  Application.Current.Properties["NAME"]  as string;
           var Price = Application.Current.Properties["PRICE"]  as string;
            var Weight = Application.Current.Properties["WEIGHT"] as string;
            detailImg.Source = Image;
            name.Text = "Item Name:  " + Name;
            price.Text = "Price:  " + Price;
            weight.Text = Weight;
            this.Title = Name;
            title.Text = Name;

        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {

        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {

        }
    }
}