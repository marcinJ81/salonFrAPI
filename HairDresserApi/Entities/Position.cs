using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HairDresserApi.Entities
{
    public class Position
    {
        [Key]
        public int position_Id { get; set; }
        public string position_name { get; set; }
    }
}
