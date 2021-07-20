using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleApi.Models
{
    public class Users
    {

        public Guid Id { get; set; }
        public string  Name { get; set; }
        public string  Email { get; set; }
        public string  Password { get; set; }
        public string  Phone { get; set; }
        public string  ImageUrl { get; set; }
        public ICollection<Vehicles>  Vehicles { get; set; }
    }
}
