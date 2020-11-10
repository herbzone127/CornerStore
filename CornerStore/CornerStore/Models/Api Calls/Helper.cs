using System;
using System.Collections.Generic;
using System.Text;

namespace CornerStore.Models.Api_Calls
{
   public class Helper
    {
        public static string address { get; set; } = "http://202.163.113.237:8099";
        public static long MainCategoryID { get; set; }
        public static long SubCategoryID { get; set; }
        public static long? SubCategorybyGroupID { get; set; }
        public static string SubCategoryTitle { get; set; }
        public static string SearchText { get; set; }
        public static bool Enable { get; set; }
        public static int FirstLogin { get; set; } = 0;
    }
}
