using CornerStore.Models.viewModels;
using RestSharp;
using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CornerStore.Models.Api_Calls
{
   public class OtherApi
    {
        public static ObservableCollection<LocateUsPageModel> GetAllLocations()
        {
            ObservableCollection<LocateUsPageModel> lst = new ObservableCollection<LocateUsPageModel>();
            var client = new RestClient(Helper.address);
            var request = new RestRequest("api/GetAllLocation", Method.GET);
            request.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
            request.RequestFormat = DataFormat.Json;
            IRestResponse restresponse = client.Execute(request);

            var status = restresponse.StatusDescription;
            if (restresponse.IsSuccessful)
            {
                RestSharp.Deserializers.JsonDeserializer deserial = new JsonDeserializer();
               
                var data = deserial.Deserialize<List<LocationModelApi>>(restresponse);
                foreach (LocationModelApi item in data)
                {
                    LocateUsPageModel gR = new LocateUsPageModel();
                    gR.Address = item.LOCATION_DESC;
                    lst.Add(gR);


                }
                return lst;
            }
            else
            {
                throw new ArgumentException("" + status);
            }

        }

        public static ObservableCollection<PromotionPageModel> GetAllPromotions()
        {
            ObservableCollection<PromotionPageModel> lst = new ObservableCollection<PromotionPageModel>();
            var client = new RestClient(Helper.address);
            var request = new RestRequest("api/GetAllPromotion", Method.GET);
            request.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
            request.RequestFormat = DataFormat.Json;
            IRestResponse restresponse = client.Execute(request);
            string image = "teddybear.png";
            var status = restresponse.StatusDescription;
            if (restresponse.IsSuccessful)
            {
                RestSharp.Deserializers.JsonDeserializer deserial = new JsonDeserializer();

                var data = deserial.Deserialize<List<PromotionModelApi>>(restresponse);
                foreach (PromotionModelApi item in data)
                {
                    PromotionPageModel gR = new PromotionPageModel();
                    gR.Image = image;
                    gR.Name = item.PROMOTION_CODE;
                    gR.Detail = item.BL_MARKETING_TEXT;
                    lst.Add(gR);


                }
                return lst;
            }
            else
            {
                throw new ArgumentException("" + status);
            }

        }
    }
}
