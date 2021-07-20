using System;

namespace VehicleApi.Models
{
    public class Images
    {
        public Guid Id { get; set; }
        public string  ImageUrl { get; set; }

        public Guid VehicleId { get; set; }
    }
}