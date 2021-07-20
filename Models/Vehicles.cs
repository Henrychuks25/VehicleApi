using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleApi.Models
{
    public class Vehicles
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Double Price { get; set; }
        public string Model { get; set; }
        public string Engine { get; set; }
        public string Color { get; set; }
        public string Company { get; set; }
        public DateTime DatePosted { get; set; }
        public bool  IsHotAndNew { get; set; }
        public bool  IsFeatured { get; set; }
        public string  Location { get; set; }
        public string  Condition { get; set; }
        public Guid  UserId { get; set; }
        public Guid  CategoryId { get; set; }



        public ICollection<Images> Images { get; set; }
    }
}
