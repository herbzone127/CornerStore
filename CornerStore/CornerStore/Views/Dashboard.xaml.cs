using CornerStore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CornerStore.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Dashboard : MasterDetailPage
    {
        public Dashboard()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as DashboardMenuItem;
            if (item == null)
                return;

            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;
            if (item.Id == 0)
            {
                Detail = new NavigationPage(new DashboardDetail());

                IsPresented = false;

            }
           else if (item.Id == 1)
            {
                Detail = new NavigationPage(new Profile());

                IsPresented = false;

            }
            else if (item.Id == 5)
            {
                Detail = new NavigationPage(new PromotionPage());

                IsPresented = false;

            }
            else if (item.Id == 6)
            {
                Detail = new NavigationPage(new LocateUsPage());

                IsPresented = false;

            }
            else if (item.Id == 11)
            {
                Detail = new NavigationPage(new Login());

                IsPresented = false;

            }
            IsPresented = false;

            MasterPage.ListView.SelectedItem = null;
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
           
            if (Application.Current.Properties["CartItems"]!=null)
            {
                Navigation.PushModalAsync(new NavigationPage(new CartPage()));
            }
            else
            {
                DisplayAlert("Empty", "Nothig is added to cart yet", "Ok");

            }
        }
    }
}