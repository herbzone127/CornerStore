using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using CornerStore.Models;
using CornerStore.Models.Api_Calls;

namespace CornerStore.ViewModels
{
   public class LocateUsVM
    {
        public ObservableCollection<LocateUsPageModel> LocateUsPageModels { get; set; }
        public LocateUsVM()
        {
            LocateUsPageModels = OtherApi.GetAllLocations();
            //    new ObservableCollection<LocateUsPageModel>();
            //LocateUsPageModels.Add(new LocateUsPageModel() { Address = "307 block C johar town", PhoneNumber = "0092334509932" });
            //LocateUsPageModels.Add(new LocateUsPageModel() { Address = "307 block C johar town", PhoneNumber = "0092334509932" });
            //LocateUsPageModels.Add(new LocateUsPageModel() { Address = "307 block C johar town", PhoneNumber = "0092334509932" });
        }
    }
}
