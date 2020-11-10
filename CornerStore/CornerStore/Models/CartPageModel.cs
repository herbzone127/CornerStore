using System;
using System.Collections.Generic;
using System.Text;

namespace CornerStore.Models
{
   public class CartPageModel:PropertyHelper
    {
        public long Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public decimal Price { get; set; }
        private int counter;

        public int Counter
        {
            get { return counter; }
            set { counter = value;OnPropertyChanged(nameof(Counter)); }
        }

    }
}
