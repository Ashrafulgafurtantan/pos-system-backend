using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace pos_system.Model
{
    public class Service
    {
        [Key]
        public string pid { get; set; }
        public float price { get; set; }
        public string category { get; set; }
        public float size { get; set; }
        public string color { get; set; }
        public string brand { get; set; }
        public string date_of_purchase { get; set; }
        public string customer_name { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string service_date { get; set; }
        public string return_date { get; set; }
        public float service_charge { get; set; }
    }
}
