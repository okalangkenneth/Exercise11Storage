using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Storage.Models.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
       public string Name { set; get; }
        [DisplayFormat(DataFormatString = "{0:C}")]
        public int Price { set; get; }

        public int Count{ set; get; }
        [Display(Name="Inventory Value")]
        [DisplayFormat(DataFormatString ="{0:C}")]
       public int InventoryValue { set; get; }
    }
}
