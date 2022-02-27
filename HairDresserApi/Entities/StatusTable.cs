using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HairDresserApi.Entities
{
    public class StatusTable
    {
        [Key]
        public int status_id { get; set; }
        public string status_name { get; set; }
    }
}
