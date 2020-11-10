using System;
using System.Collections.Generic;
using System.Text;

namespace CornerStore.Models
{
   
    public class GroceryModel
    {
        public long GET_PRODUCT_ID { get; set; }
        public string BL_PRODUCT_TYPE_DESC { get; set; }
        public string PRODUCT_CODE { get; set; }
        public string BL_PRODUCT_DESC { get; set; }
        public string BAR_CODE { get; set; }
        public long GET_UOM_ID { get; set; }
        public Nullable<long> MAIN_CAT_ID { get; set; }
        public string MAIN_CAT { get; set; }
        public Nullable<long> SUB_CAT_ID { get; set; }
        public string SUB_CAT { get; set; }
        public Nullable<long> PROD_GRP_ID { get; set; }
        public string PROD_GRP { get; set; }
        public string MANUF { get; set; }
        public string BRAND { get; set; }
        public string VARIANTS { get; set; }
        public string PACKING { get; set; }
        public string SKU { get; set; }
        public string PRICE { get; set; }
        public Nullable<decimal> DISCOUNTED_PRICE { get; set; }
        public Nullable<decimal> STOCK_AYN { get; set; }
        public string PRODUCT_IMAGE { get; set; }
        public Nullable<bool> ACTIVE_YN { get; set; }
    }
}
