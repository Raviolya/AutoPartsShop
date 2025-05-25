using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPartsShop.Repository
{
    public class ManufacturerRepository
    {
        public List<Manufacturer> GetAll()
        {
            using (var context = new AppDbContext())
            {
                return context.Manufacturers.ToList();
            }
        }

        public void Add(Manufacturer post)
        {
            using (var context = new AppDbContext())
            {
                context.Manufacturers.Add(post);
                context.SaveChanges();
            }
        }
    }
}
