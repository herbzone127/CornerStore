using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using CornerStore.Models;
using CornerStore.Models.Api_Calls;

namespace CornerStore.ViewModels
{
   public class GroceryDetailsVM
    {
        public ObservableCollection<GroceryModel> TabbedModels { get; set; }
   
        public GroceryDetailsVM()
        {
            TabbedModels = GrocerListApi.GetProductsBySubcategory(Helper.SubCategoryID);
           
        }
    }
}
