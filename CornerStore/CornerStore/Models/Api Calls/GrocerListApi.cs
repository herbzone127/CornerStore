using CornerStore.Models.viewModels;
using RestSharp;
using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CornerStore.Models.Api_Calls
{
   public class GrocerListApi
    {
        public static ObservableCollection<GroceryModel2> getTop10ProductList()
        {
            ObservableCollection<GroceryModel2> lst = new ObservableCollection<GroceryModel2>();
            var client = new RestClient(Helper.address);
            var request = new RestRequest("api/GetTop10Products", Method.GET);
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
                    GroceryModel2 vm = new GroceryModel2();
                    if (item.PRODUCT_IMAGE == null)
                    { vm.PRODUCT_IMAGE = image;
                        vm.BL_PRODUCT_DESC = item.BL_PRODUCT_DESC;
                        vm.PRICE = "Rs." + item.PRICE;
                        lst.Add(vm);
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
            var request = new RestRequest("api/GetGRMainCategories", Method.GET);
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
            var request = new RestRequest("api/GetGRSubCategories?mainCategoryId="+mainCategory, Method.GET);
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
                    gR.MAIN_CAT_ID= item.MAIN_CAT_ID;
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
            var request = new RestRequest("api/ProductsBySubcategory?subcatId="+subCatID, Method.GET);
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
            var request = new RestRequest("api/ProductsByGroupId?groupId="+groupID, Method.GET);
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

        public static ObservableCollection<SearchMainModel> SearchProductList(string search)
        {
            ObservableCollection<SearchMainModel> lst = new ObservableCollection<SearchMainModel>();
            var client = new RestClient(Helper.address);
            var request = new RestRequest("api/SearchProducts?search="+search, Method.GET);
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
                    SearchMainModel sr = new SearchMainModel();
                   
                        sr.Image = image;
                        sr.Price = "Rs." + item.PRICE;
                        sr.Name = item.BL_PRODUCT_DESC;
                        sr.Id = item.GET_PRODUCT_ID;
                        sr.Weight = item.SKU;
                        lst.Add(sr);
                    

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
