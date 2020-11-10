using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using CornerStore.Models;
using System.Windows.Input;
using Xamarin.Forms;
using CornerStore.Models.viewModels;
using System.Linq;

namespace CornerStore.ViewModels
{
   public class CartPageVM:PropertyHelper
    {
       

        public ObservableCollection<CartPageModel> CartPageModels { get; set; }
        //public ObservableCollection<CartPageModel> CartPageModels2 { get; set; }
        public CartPageVM()
        {
            if (Application.Current.Properties["CartItems"]!=null)
            {

                ObservableCollection<CartPageModel> lst = (ObservableCollection<CartPageModel>)Application.Current.Properties["CartItems"];
              var data = lst.GroupBy(i => new { i.Id, i.Name,i.Image,i.Detail }).Select(g => new
              {
                  Id = g.Key.Id,
                  Name = g.Key.Name,
                  Image = g.Key.Image,
                  Detail = g.Key.Detail,
                  TotalQuantity = g.Sum(i => i.Counter),
                  Price = g.Sum(i => i.Price)
              });

            }
            
                //ObservableCollection<CartPageModel> cartPages = new ObservableCollection<CartPageModel>();

            //CartPageModels2 = lst;
       
            //foreach (var item in CartPageModels2)
            //{
            //    CartPageModel model = new CartPageModel();
            //    foreach (var item2 in lst.Distinct())
            //    {
                   
            //        if (item.Id == item2.Id)
            //        {
                     
                        
                        
            //            count = count + 1;
                  
            //        }
                  
            //    }
            //    model.Id = item.Id;
            //    model.Name = item.Name;
            //    model.Image = item.Image;
            //        model.Price = item.Price;
            //    model.Detail = item.Detail;
            //    model.Counter = count;
            //    cartPages.Add(model);
            //}
            CartPageModels = (ObservableCollection<CartPageModel>)Application.Current.Properties["CartItems"];
            //    new ObservableCollection<CartPageModel>();
            //CartPageModels.Add(new CartPageModel() { Id = 0, Image = "cs_logo.png", Name = "Store", Detail = "Store", Price = 120, Counter = 1 });
            //CartPageModels.Add(new CartPageModel() { Id = 1, Image = "cs_logo.png", Name = "Store", Detail = "Store", Price = 120, Counter = 1 });
            //CartPageModels.Add(new CartPageModel() { Id = 2, Image = "cs_logo.png", Name = "Store", Detail = "Store", Price = 120, Counter = 1 });
            //CartPageModels.Add(new CartPageModel() { Id = 3, Image = "cs_logo.png", Name = "Store", Detail = "Store", Price = 120, Counter = 1 });

        }

        private decimal total;

        public decimal Total
        {
            get
            {
                foreach (var item in CartPageModels)
                {
                    total += item.Price*item.Counter;
                }
                return total;
            }

        }

        private decimal deliveryCharges=120;

        public decimal DeliveryCharges
        {
            get { return deliveryCharges; }
            set { deliveryCharges = value; }
        }

        private decimal grandTotal;

        public decimal GrandTotal
        {
            get { return grandTotal = total + deliveryCharges; }
           
        }



        public ICommand AddCounter
        {
            get
            {
                return new Command((e) =>
                {
                    foreach(var item in CartPageModels)
                    {
                        if(item.Id==Convert.ToInt64(e))
                        {
                            total = 0;
                            grandTotal = 0;
                            item.Counter++;
                            OnPropertyChanged(nameof(Total));
                            OnPropertyChanged(nameof(GrandTotal));
                            break;
                        }

                    }
                });
            }
        }
        public ICommand RemoveCounter
        {
            get
            {
                return new Command((e) =>
                {
                    foreach (var item in CartPageModels)
                    {
                        if (item.Id == Convert.ToInt64(e))
                        {
                            if(item.Counter==1)
                            {
                                total = 0;
                                grandTotal = 0;
                                CartPageModels.Remove(item);
                                var vm = new DashboardVM();
                                foreach (var item2 in vm.GroceryModels)
                                {
                                    if(item.Id==item2.GET_PRODUCT_ID)
                                    {
                                        item2.ISENABLED = true;
                                        break;
                                    }
                                }
                                OnPropertyChanged(nameof(Total));
                                OnPropertyChanged(nameof(GrandTotal));
                            }
                            total = 0;
                            grandTotal = 0;
                            item.Counter--;
                            OnPropertyChanged(nameof(Total));
                            OnPropertyChanged(nameof(GrandTotal));
                            break;
                        }
                    }
                });
            }
        }
    }
}
