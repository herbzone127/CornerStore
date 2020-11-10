using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using CornerStore.Models;
using CornerStore.Models.Api_Calls;
using System.Windows.Input;
using Xamarin.Forms;

namespace CornerStore.ViewModels
{
   public class SearchMainVM:PropertyHelper
    {
        public string SearchText { get; set; }
        private ObservableCollection<SearchMainModel> searchMainModels;

        public ObservableCollection<SearchMainModel> SearchMainModels
        {
            get { return searchMainModels; }
            set { searchMainModels = value;OnPropertyChanged(nameof(SearchMainModels)); }
        }


        
        public SearchMainVM()
        {

            if (SearchText == null)
            {
                SearchMainModels = new ObservableCollection<SearchMainModel>();
                SearchMainModels.Add(new SearchMainModel() { Name = "Hellowww", Image = "cs_logo.png", Price = "25$", Weight = "700gram" });
                SearchMainModels.Add(new SearchMainModel() { Name = "Hellowww", Image = "cs_logo.png", Price = "25$", Weight = "700gram" });
                SearchMainModels.Add(new SearchMainModel() { Name = "Hellowww", Image = "cs_logo.png", Price = "25$", Weight = "700gram" });
                SearchMainModels.Add(new SearchMainModel() { Name = "Hellowww", Image = "cs_logo.png", Price = "25$", Weight = "700gram" });
                OnPropertyChanged(nameof(SearchMainModels));
                return;
            }
            else
            {
            
                //SearchMainModels = GrocerListApi.SearchProductList(SearchText);
            }
        }
        //public ICommand SearchCommand
        //{
        //    get
        //    {
        //        return new Command(() => {

                    
        //            //GrocerListApi.SearchProductList(SearchText);
        //            //OnPropertyChanged(nameof(SearchMainModels));
        //        });
        //    }
            
        //}

        public void list()
        {
           
            
        }
       

    }
}
