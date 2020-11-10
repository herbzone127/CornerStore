using CornerStore.Models.viewModels;
using RestSharp;
using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CornerStore.Models.Api_Calls
{
    public class MealMenuListApi
    {
        public static ObservableCollection<GroceryModel> getTop10ProductList()
        {
            ObservableCollection<GroceryModel> lst = new ObservableCollection<GroceryModel>();
            var client = new RestClient(Helper.address);
            var request = new RestRequest("api/GetAllMeal", Method.GET);
            request.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
            request.RequestFormat = DataFormat.Json;




            IRestResponse restresponse = client.Execute(request);

            var status = restresponse.StatusDescription;
            if (restresponse.IsSuccessful)
            {
                RestSharp.Deserializers.JsonDeserializer deserial = new JsonDeserializer();
                string image = "teddybear.png";
                var data = deserial.Deserialize<List<GroceryModel>>(restresponse);
                foreach (GroceryModel item in data)
                {
                    if (item.PRODUCT_IMAGE == null)
                    {
                        item.PRODUCT_IMAGE = image;
                        item.PRICE = "Rs." + item.PRICE;
                        lst.Add(item);
                    }

                }
                return lst;
            }
            else
            {
                throw new ArgumentException("" + status);
            }

        }
        public static ObservableCollection<GRMainCategoryVM> GetGRMainCategories()
        {
            ObservableCollection<GRMainCategoryVM> lst = new ObservableCollection<GRMainCategoryVM>();
            var client = new RestClient(Helper.address);
            var request = new RestRequest("api/GetMealMainCategories", Method.GET);
            request.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
            request.RequestFormat = DataFormat.Json;




            IRestResponse restresponse = client.Execute(request);

            var status = restresponse.StatusDescription;
            if (restresponse.IsSuccessful)
            {
                RestSharp.Deserializers.JsonDeserializer deserial = new JsonDeserializer();
                string image = "teddybear.png";
                var data = deserial.Deserialize<List<GRMainCategory>>(restresponse);
                foreach (GRMainCategory item in data)
                {
                    GRMainCategoryVM gR = new GRMainCategoryVM();
                    gR.id = item.GET_SEGMENT_ID;
                    gR.Image = image;
                    gR.Name = item.BL_SEGMENT_DESC;
                    lst.Add(gR);


                }
                return lst;
            }
            else
            {
                throw new ArgumentException("" + status);
            }

        }
        public static ObservableCollection<GRSubCategoryVM> GetGRSubCategories(long mainCategory)
        {
            ObservableCollection<GRSubCategoryVM> lst = new ObservableCollection<GRSubCategoryVM>();
            var client = new RestClient(Helper.address);
            var request = new RestRequest("api/GetMealSubCategories?mainCategoryId=" + mainCategory, Method.GET);
            request.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
            request.RequestFormat = DataFormat.Json;




            IRestResponse restresponse = client.Execute(request);

            var status = restresponse.StatusDescription;
            if (restresponse.IsSuccessful)
            {
                RestSharp.Deserializers.JsonDeserializer deserial = new JsonDeserializer();
                string image = "teddybear.png";
                var data = deserial.Deserialize<List<GRSubCategory>>(restresponse);
                foreach (GRSubCategory item in data)
                {
                    GRSubCategoryVM gR = new GRSubCategoryVM();
                    gR.id = item.SUB_CAT_ID;
                    gR.Image = image;
                    gR.Name = item.SUB_CAT;
                    gR.MAIN_CAT_ID = item.MAIN_CAT_ID;
                    lst.Add(gR);


                }
                return lst;
            }
            else
            {
                throw new ArgumentException("" + status);
            }

        }
        public static ObservableCollection<GroceryModel> GetProductsBySubcategory(long subCatID)
        {
            ObservableCollection<GroceryModel> lst = new ObservableCollection<GroceryModel>();
            var client = new RestClient(Helper.address);
            var request = new RestRequest("/api/GetMealbyProductCode?subcatId=" + subCatID, Method.GET);
            request.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
            request.RequestFormat = DataFormat.Json;




            IRestResponse restresponse = client.Execute(request);

            var status = restresponse.StatusDescription;
            if (restresponse.IsSuccessful)
            {
                RestSharp.Deserializers.JsonDeserializer deserial = new JsonDeserializer();
                string image = "teddybear.png";
                var data = deserial.Deserialize<List<GroceryModel>>(restresponse);
                foreach (GroceryModel item in data)
                {


                    lst.Add(item);


                }
                return lst;
            }
            else
            {
                throw new ArgumentException("" + status);
            }

        }
        public static ObservableCollection<GroceryModel> GetProductsByGroupId(long? groupID)
        {
            ObservableCollection<GroceryModel> lst = new ObservableCollection<GroceryModel>();
            var client = new RestClient(Helper.address);
            var request = new RestRequest("api/ProductsByGroupId?groupId=" + groupID, Method.GET);
            request.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
            request.RequestFormat = DataFormat.Json;




            IRestResponse restresponse = client.Execute(request);

            var status = restresponse.StatusDescription;
            if (restresponse.IsSuccessful)
            {
                RestSharp.Deserializers.JsonDeserializer deserial = new JsonDeserializer();
                string image = "teddybear.png";
                var data = deserial.Deserialize<List<GroceryModel>>(restresponse);
                foreach (GroceryModel item in data)
                {
                    if (item.PRODUCT_IMAGE == null)
                    {
                        item.PRODUCT_IMAGE = image;
                        item.PRICE = "Rs." + item.PRICE;
                        lst.Add(item);
                    }

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
