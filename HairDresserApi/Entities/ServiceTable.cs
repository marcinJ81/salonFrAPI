using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HairDresserApi.Entities
{
    public class ServiceTable
    {
        [Key]
        public int service_id  { get; set; }
        public string service_name { get; set; }
        public decimal service_price { get; set; }
    }
}
