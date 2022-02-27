using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HairDresserApi.Entities
{
    public class Reservation
    {
        [Key]
        public int reservation_id { get; set; }
        public int service_id { get; set; }
        public int employee_id { get; set; }
        public int client_id { get; set; }
        public int status_id { get; set; }
        public DateTime reservation_date { get; set; }
        [ForeignKey("client_id")]
        public virtual Client Client { get; set; }
        [ForeignKey("employee_id")]
        public virtual Employee employee { get; set; }
        [ForeignKey("service_id")]
        public virtual ServiceTable serviceTable { get; set; }
        [ForeignKey("status_id")]
        public virtual StatusTable statusReservation { get; set; }
    }
}
