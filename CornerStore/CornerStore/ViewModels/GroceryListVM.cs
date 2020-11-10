using CornerStore.Models;
using CornerStore.Models.Api_Calls;
using CornerStore.Models.viewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CornerStore.ViewModels
{
   public class GroceryListVM:PropertyHelper
    {
        
        public ObservableCollection<GRMainCategoryVM> GroceryListModels { get; set; }
     
        public GroceryListVM()
        {
            GroceryListModels = GrocerListApi.GetGRMainCategories();
        
            //foreach (var item in GroceryListModels)
            //{
               
            //    foreach (var item2 in GrocerListApi.GetGRSubCategories(item.id))
            //    {
            //        GRMainCategoryVM gRMainCategoryVM = new GRMainCategoryVM();

            //        if (item.id == item2.MAIN_CAT_ID)
            //        {
            //            gRMainCategoryVM.id = item.id;
            //            gRMainCategoryVM.Image = item.Image;
            //            gRMainCategoryVM.Name = item.Name;
            //            GroceryListExtendModels.Add(item2);
                   
                       
            //        }
                   
            //    } 
            //}
            //GroceryListExtendModels = GrocerListApi.GetGRSubCategories(Helper.MainCategoryID);
         
        }
        public void refresh()
        {
            OnPropertyChanged(nameof(GroceryListModels));
           
        }

        //public void HidorShow(GroceryListModel grocery)

        //{
        //    if(grocery.ExtendIsVisible==false)
        //    grocery.ExtendIsVisible = true;
        //    else
        //    grocery.ExtendIsVisible = false;
        //}

        //public ICommand VisibilityCommand
        //{
        //    get
        //    {
        //        return new Command((e) =>
        //        {


        //            foreach (var item in GroceryListModels)
        //            {
        //                if(item.Id==Convert.ToInt32())
        //                {
        //                    if (item.ExtendIsVisible == false)
        //                        item.ExtendIsVisible = true;
        //                    else
        //                        item.ExtendIsVisible = false ;
        //                }




        //            }
        //        });
        //    }
        //}
    }
}
