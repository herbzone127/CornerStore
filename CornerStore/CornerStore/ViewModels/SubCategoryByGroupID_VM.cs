using CornerStore.Models;
using CornerStore.Models.Api_Calls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CornerStore.ViewModels
{
   public class SubCategoryByGroupID_VM
    {
        public ObservableCollection<GroceryModel> GroceryDetailsModels { get; set; }
        public SubCategoryByGroupID_VM()
        {
            GroceryDetailsModels = GrocerListApi.GetProductsByGroupId(Helper.SubCategorybyGroupID);
        }

        public void refresh()
        {
            GroceryDetailsModels.Clear();
            GroceryDetailsModels = GrocerListApi.GetProductsByGroupId(Helper.SubCategorybyGroupID);
        }
    }
}
