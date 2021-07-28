using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace pos_system.Model
{
    public class Sale
    {
        [Key]
        public string pid { get; set; }
        public float price { get; set; }
        public string category { get; set; }
        public float size { get; set; }
        public string color { get; set; }
        public string brand { get; set; }
        public string date_of_purchase { get; set; }
    }
}
