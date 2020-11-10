using System;
using System.Collections.Generic;
using System.Text;

namespace CornerStore.Models.viewModels
{
   public class GRSubCategoryVM
    {
        public long id { get; set; }
        public string Name { get; set; }
        public string  Image{ get; set; }
        public long MAIN_CAT_ID { get; set; }
        public string MAIN_CAT_Name { get; set; }
    }
}
