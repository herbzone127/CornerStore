using CornerStore.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using CornerStore.Models.Api_Calls;
using CornerStore.Models.viewModels;
using Xamarin.Forms;

namespace CornerStore.ViewModels
{
    public class DashboardVM:PropertyHelper
    {
        private bool isVisible=true;

        public bool Isvisible
        {
            get { return isVisible; }
            set { isVisible = value;OnPropertyChanged(nameof(Isvisible)); }
        }

        public ObservableCollection<CarouselModel>  CarouselModels { get; set; }
        public ObservableCollection<GroceryModel2> GroceryModels { get; set; }
        public ObservableCollection<GroceryModel> MealModels { get; set; }
        

        public DashboardVM()
        {
            CarouselModels = new ObservableCollection<CarouselModel>();
            CarouselModels.Add(new CarouselModel() { Image = "one.png" });
            CarouselModels.Add(new CarouselModel() { Image = "two.jpg" });
            CarouselModels.Add(new CarouselModel() { Image = "three.jpg" });
            CarouselModels.Add(new CarouselModel() { Image = "four.png" });
            CarouselModels.Add(new CarouselModel() { Image = "five.jpg" });
            
                GroceryModels = GrocerListApi.getTop10ProductList();


            //GroceryModels.Add(new GroceryModel() { ProductID = "2", Image = "teddybear.png", Name = "Toy", Price = "$4.40" });
            //GroceryModels.Add(new GroceryModel() { ProductID = "3", Image = "coca_cola.png", Name = "Chilli Sauce", Price = "$6.40" });
            //GroceryModels.Add(new GroceryModel() { ProductID = "4", Image = "bottle.png", Name = "Garlic powder", Price = "$5.40" });
            //GroceryModels.Add(new GroceryModel() { ProductID = "5", Image = "lays.png", Name = "Chips", Price = "$1.20" });
            //GroceryModels.Add(new GroceryModel() { ProductID = "6", Image = "jug.png", Name = "Juice", Price = "$2.40" });

            MealModels = MealMenuListApi.getTop10ProductList();
            //MealModels = new ObservableCollection<MealModel>();
            //MealModels.Add(new MealModel() { Image = "plate_1.png", Name = "Salad", Price = "$18.40" });
            //MealModels.Add(new MealModel() { Image = "plate_2.png", Name = "Sandwich", Price = "$15.40" });
            //MealModels.Add(new MealModel() { Image = "plate_3.png", Name = "Tikka", Price = "$19.40" });
            //MealModels.Add(new MealModel() { Image = "plate_4.png", Name = "Burger", Price = "$7.40" });
            //MealModels.Add(new MealModel() { Image = "plate_6.png", Name = "Pizza", Price = "$5.40" });
            //MealModels.Add(new MealModel() { Image = "plate_1.png", Name = "Special", Price = "$20.40" });
        }
      
    }
}
