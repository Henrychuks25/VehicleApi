using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleApi.Context;
using VehicleApi.Models;

namespace VehicleApi.Services.ServiceImpl
{
    public class CategoryService
    {
        private readonly VehicleDbContext context;

        public CategoryService(VehicleDbContext dbContext)
        {
            context = dbContext;
        }


        public async Task<IEnumerable<Vehicles>> Get()
        {

            var result = await context.Categories.FindAsync();

            return (result);

        }
    }
}
