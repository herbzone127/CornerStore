using CornerStore.Models;
using CornerStore.Models.Api_Calls;
using CornerStore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;
using CornerStore.Models.viewModels;

namespace CornerStore.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DashboardDetail : ContentPage
    {
        ObservableCollection<CartPageModel> lst = new ObservableCollection<CartPageModel>();

        Image oldImage = new Image();
        string path = "Arrow.png";
        ScrollView scrollView = new ScrollView();

        public DashboardDetail()
        {
            InitializeComponent();

            Application.Current.Properties["CartItems"] = lst;
            Device.StartTimer(TimeSpan.FromSeconds(5), () =>
            {
               
                scroller();
                return true;
            });


        }
        public async void scroller()
        {
            var image = cv.FindByName<Image>("img");
            
            await cv.ScrollToAsync(1, 0, false);
            //var cart = cv.BindingContext as CartPageVM;
            //var lastItem = cv.ItemsSource.OfType<object>().Last();
            //await cv.ScrollToAsync(cv, ScrollToPosition.End, true);
        }
        //protected override async void OnAppearing()
        //{
        //    base.OnAppearing();
        //    if (Helper.FirstLogin==0)
        //    {

        //        await Task.Delay(4000);

        //        // Start animation
        //        //await Task.WhenAll(
        //        //    SplashGrid.FadeTo(0, 1500),
        //        //    Logo.TranslateTo(0.5, 1, 1500),
        //        //    Logo.RotateTo(360, 1500),
        //        //    Logo.ScaleTo(10, 1500)

        //        //    );
        //        SplashGrid.IsVisible = false;
        //        Helper.FirstLogin = 1;
        //    }
        //}
        //protected override void OnDisappearing()
        //{
        //    base.OnDisappearing();
        //    var vm = this.BindingContext as DashboardVM;
        //    vm.Isvisible = false;
        //}

        private void TapGestureRecognizer_Tapped1(object sender, EventArgs e)
        {
            StackLayout stackLayout = (StackLayout)sender;
            string Id = ((Label)stackLayout.Children[1]).Text;
            string Name = ((Label)stackLayout.Children[2]).Text;
            Helper.SubCategoryID = Convert.ToInt64(Id);
            Helper.SubCategoryTitle = Name;
           
         

            
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Label label = sender as Label;

            if (label.Text== "Offline Offers")
            {
                Offers_lbl.FontAttributes = FontAttributes.Bold;
                Offers_lbl.TextColor = Color.White;
                Gorcery_lbl.TextColor = Color.Black;
                Gorcery_lbl.FontAttributes = FontAttributes.None;
                Meal_lbl.TextColor = Color.Black;
                Meal_lbl.FontAttributes = FontAttributes.None;
                Home.IsVisible = false;
                GroceryList.IsVisible = false;
                Book.IsVisible = false;
                OfflineOffers.IsVisible = true;
                Title = "Offline Offers";

            }
            else if (label.Text == "Grocery List")
            {
                Gorcery_lbl.FontAttributes = FontAttributes.Bold;
                Gorcery_lbl.TextColor = Color.White;
                Home.IsVisible = false;
                Title = "Grocery";
               Offers_lbl.TextColor = Color.Black;
                Offers_lbl.FontAttributes = FontAttributes.None;
                Meal_lbl.TextColor = Color.Black;
                Meal_lbl.FontAttributes = FontAttributes.None;
                Home.IsVisible = false;
                Book.IsVisible = false;
                OfflineOffers.IsVisible = false;
                ActivityIndicator.IsVisible = true;
                await Task.Delay(400);
                Device.BeginInvokeOnMainThread(() => {
                    GroceryList.IsVisible = true;

                });
                ActivityIndicator.IsVisible = false;
                
              
               
            }
            else if (label.Text == "Book a Meal")
            {
                Meal_lbl.FontAttributes = FontAttributes.Bold;
                Meal_lbl.TextColor = Color.White;
                Home.IsVisible = false;
                Title = "Book a Meal";
                Offers_lbl.TextColor = Color.Black;
                Offers_lbl.FontAttributes = FontAttributes.None;
                Gorcery_lbl.TextColor = Color.Black;
                Gorcery_lbl.FontAttributes = FontAttributes.None;
                Home.IsVisible = false;
                GroceryList.IsVisible = false;
                Book.IsVisible = true;
                OfflineOffers.IsVisible = false;
            }
            
        }

        private async void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            Gorcery_lbl.FontAttributes = FontAttributes.Bold;
            Gorcery_lbl.TextColor = Color.White;
            Home.IsVisible = false;
            Title = "Grocery";
            Offers_lbl.TextColor = Color.Black;
            Offers_lbl.FontAttributes = FontAttributes.None;
            Meal_lbl.TextColor = Color.Black;
            Meal_lbl.FontAttributes = FontAttributes.None;
            Home.IsVisible = false;
          
            Book.IsVisible = false;
            OfflineOffers.IsVisible = false;
            ActivityIndicator.IsVisible = true;
            await Task.Delay(400);
            Device.BeginInvokeOnMainThread( () => {
                GroceryList.IsVisible = true;

            });
            ActivityIndicator.IsVisible = false;
            
           
        }

        private async void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            StackLayout stackLayout = (StackLayout)sender;
            string productID = ((Label)stackLayout.Children[0]).Text;
            Image image = stackLayout.FindByName<Image>("img_Detail"); 
            string Name = ((Label)stackLayout.Children[2]).Text;
            string Price = ((Label)stackLayout.Children[3]).Text;
            Label Weight = stackLayout.FindByName<Label>("Weight");
            Application.Current.Properties["PRODUCTID"] = productID as string;
            Application.Current.Properties["IMAGE"] = (image.Source as FileImageSource).File as string;
            Application.Current.Properties["NAME"] = Name as string;
            Application.Current.Properties["PRICE"] = Price as string;
            Application.Current.Properties["WEIGHT"] = Weight.Text;
            ActivityIndicator.IsVisible = true;
            await Task.Delay(400);
            Device.BeginInvokeOnMainThread(async() => {
              await Navigation.PushAsync(new Detail());

            });
            ActivityIndicator.IsVisible = false;
            
        }

        private async void TapGestureRecognizer_Tapped_3(object sender, EventArgs e)
        {

            oldImage.Source = path;
            GroceryListVM vm = BindingContext as GroceryListVM;
            var stack = ((StackLayout)sender);
            long Id =Convert.ToInt64( stack.FindByName<Label>("MainCategoryID").Text);
            //subCategoryListVM = new SubCategoryListVM(Id);
            ActivityIndicator.IsVisible = true;
            await Task.Delay(400);
            Device.BeginInvokeOnMainThread(() => {
                SubListView(Id);

            });
            ActivityIndicator.IsVisible = false;
            

            Image image = stack.FindByName<Image>("RotateImage"); //getting children of any layout by x:name(Even in listview)
            oldImage = image;
            
            if (!stack.Children.Contains(scrollView))
            {

                stack.Children.Add(scrollView);
                //if ((image.Source as FileImageSource).File == path) **Image Source Comparison**
                //{
                //    image.Source = "Arrow1.png";
                //}
                image.Source = "Arrow1.png";


            }
            else
            {
                stack.Children.Remove(scrollView);
                image.Source = "Arrow.png";
            }
        }
        public void SubListView(long Id)
        {
            Grid grid = new Grid();
            SubCategoryListVM subCategoryListVM = new SubCategoryListVM(Id);
            scrollView.Orientation = ScrollOrientation.Vertical;
            scrollView.Margin = new Thickness(5);
            grid.Margin = new Thickness(7);


            ColumnDefinition column1 = new ColumnDefinition();
            ColumnDefinition column2 = new ColumnDefinition();
            ColumnDefinition column3 = new ColumnDefinition();


            grid.ColumnDefinitions.Add(column1);
            grid.ColumnDefinitions.Add(column2);
            grid.ColumnDefinitions.Add(column3);

            var tapGestureRecognizer = new TapGestureRecognizer();

            decimal items = (subCategoryListVM.GroceryListExtendModels.Count / 3) + 1;
            int a = Convert.ToInt32(items);
            for (int i = 0; i < a; i++)
            {
                RowDefinition row = new RowDefinition();
                row.Height = 160;

                grid.RowDefinitions.Add((row));

            }
            int c = 0;
            for (int i = 0; i < grid.RowDefinitions.Count; i++)
            {
                for (int y = 0; y < grid.ColumnDefinitions.Count && c < subCategoryListVM.GroceryListExtendModels.Count; y++, c++)
                {

                    StackLayout stack = new StackLayout();
                    stack.VerticalOptions = LayoutOptions.FillAndExpand;
                    stack.Margin = new Thickness(1);
                    Label label = new Label();
                    label.Text = subCategoryListVM.GroceryListExtendModels[c].Name;
                    label.TextColor = Color.White;
                    label.Margin = new Thickness(0, 0, 0, 4);
                    label.FontAttributes = FontAttributes.Bold;
                    label.VerticalOptions = LayoutOptions.Center;
                    label.HorizontalTextAlignment = TextAlignment.Center;

                    Label ID = new Label();
                    ID.Text = subCategoryListVM.GroceryListExtendModels[c].id.ToString();
                    ID.IsVisible = false;

                    Image image = new Image();
                    image.HorizontalOptions = LayoutOptions.Center;
                    //image.Margin = new Thickness(0,15,0,0);
                    image.VerticalOptions = LayoutOptions.CenterAndExpand;
                    image.Source = subCategoryListVM.GroceryListExtendModels[c].Image;
                    image.Margin = new Thickness(2);
                    Grid.SetRow(stack, i);
                    Grid.SetColumn(stack, y);

                    stack.Children.Add(image);
                    stack.Children.Add(ID);
                    stack.Children.Add(label);
                    stack.GestureRecognizers.Add(tapGestureRecognizer);


                    grid.Children.Add(stack);

                    scrollView.Content = grid;

                }

            }
            tapGestureRecognizer.Tapped += TapGestureRecognizer_Tapped1;
        }

        private void TGR_Cart_Tapped(object sender, EventArgs e)
        {
            var btn = sender as Button;
            CartListModel_VM cartListModel_VM = new CartListModel_VM();
            var getValues = ((Button)sender).Parent;
            string productID = ((Label)getValues.FindByName<Label>("ProuctID")).Text;
            Image image = ((Image)getValues.FindByName<Image>("img_Detail")) ;
            string prodName = ((Label)getValues.FindByName<Label>("prodName")).Text;
            string prodPrice = ((Label)getValues.FindByName<Label>("prodPrice")).Text;
            CartPageModel cartPageModel = new CartPageModel();
            cartPageModel.Id = Convert.ToInt64(productID);
            cartPageModel.Name = prodName;
            cartPageModel.Image = prodPrice;
            cartPageModel.Image = (image.Source as FileImageSource).File as string;
            cartPageModel.Counter = 1;
            lst.Add(cartPageModel);
          
                Application.Current.Properties["CartItems"] = lst;

            btn.IsEnabled = false;
            


        }

        private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            var search=sender as SearchBar;
            SearchPage.IsVisible = true;
            Helper.SearchText=searchtxt.Text;

            //var vm = search.BindingContext as SearchMainVM;
            //vm.list();
        }

        private void SearchBar_Focused(object sender, FocusEventArgs e)
        {
            SearchPage.IsVisible = false;
        }
        //private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        //{
        //    var vm = BindingContext as GroceryListVM;
        //    var VM = e.Item as GroceryListModel;         
        //    vm.HidorShow(VM);
        //}
    }
}