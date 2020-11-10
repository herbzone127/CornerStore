using System;
using System.Collections.Generic;
using System.Text;

namespace CornerStore.Models
{
   public class GroceryListModel
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public bool ExtendIsVisible { get; set; }
    }
}
