using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HairDresserApi.Entities
{
    public class Employee
    {
       
        public int employee_id { get; set; }
        public string employee_name { get; set; }
        
        public int position_id { get; set; }
        [ForeignKey("position_id")]
        public virtual Position position { get; set; }
    }
}
