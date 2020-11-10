using CornerStore.Models.viewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using CornerStore.Models.Api_Calls;
namespace CornerStore.ViewModels
{
   public class SubCategoryListVM
    {
        public ObservableCollection<GRSubCategoryVM> GroceryListExtendModels { get; set; }
        public SubCategoryListVM(long mainID)
        {
            GroceryListExtendModels = GrocerListApi.GetGRSubCategories(mainID);
        }
    }
}
