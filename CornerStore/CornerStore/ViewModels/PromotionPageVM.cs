using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using CornerStore.Models;
using CornerStore.Models.Api_Calls;

namespace CornerStore.ViewModels
{
   public class PromotionPageVM
    {
        public ObservableCollection<PromotionPageModel> PromotionPageModels { get; set; }
        public PromotionPageVM()
        {
            PromotionPageModels = OtherApi.GetAllPromotions();
            //PromotionPageModels.Add(new PromotionPageModel() { Image = "cs_logo.png", Name = "Split the fare", Detail = "Helloo lets begin with the start", DayAgo = "two days ago" });
            //PromotionPageModels.Add(new PromotionPageModel() { Image = "cs_logo.png", Name = "Split the fare", Detail = "Helloo lets begin with the start", DayAgo = "two days ago" });
            //PromotionPageModels.Add(new PromotionPageModel() { Image = "cs_logo.png", Name = "Split the fare", Detail = "Helloo lets begin with the start", DayAgo = "two days ago" });
            //PromotionPageModels.Add(new PromotionPageModel() { Image = "cs_logo.png", Name = "Split the fare", Detail = "Helloo lets begin with the start", DayAgo = "two days ago" });
        }
    }
}
