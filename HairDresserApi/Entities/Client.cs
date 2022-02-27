using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HairDresserApi.Entities
{
    public class Client
    {
        public int client_id  { get; set; }
        public string client_name { get; set; }
        public string client_phone { get; set; }
        public string client_description { get; set; }
    }
}
