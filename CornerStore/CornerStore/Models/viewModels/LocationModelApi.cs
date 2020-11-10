using System;
using System.Collections.Generic;
using System.Text;

namespace CornerStore.Models.viewModels
{
   public class LocationModelApi
    {
        public int SRNO { get; set; }
        public long LOCATION_ID { get; set; }
        public string LOCATION_DESC { get; set; }
        public string CORDINATES_LNG { get; set; }
        public string CORDINATES_LAT { get; set; }  
    
    }
}
