using System;
using System.Collections.Generic;

namespace VehicleApi.Models
{
    public class Categories
    {
        public Guid Id { get; set; }
        public string Type { get; set; }

        public ICollection<Vehicles> Vehicles { get; set; }

    }
}