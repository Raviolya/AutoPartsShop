using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPartsShop.Repository
{
    public class WarehouseRepository
    {
        public List<Warehouse> GetAll()
        {
            using (var context = new AppDbContext())
            {
                return context.Warehouses.ToList();
            }
        }

        public void Add(Warehouse post)
        {
            using (var context = new AppDbContext())
            {
                context.Warehouses.Add(post);
                context.SaveChanges();
            }
        }
    }
}
