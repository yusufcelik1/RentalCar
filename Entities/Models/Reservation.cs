using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public string PhoneNumber {  get; set; }
        public string PickUpLocation { get; set; }
        public string DropOffLocation { get; set; }
        public string PickUpDate { get; set; }
        public string DropOffDate { get; set;}
    }
}
