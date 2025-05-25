using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPartsShop.Repository
{
    public class SmallSupplierRepository
    {
        public List<SmallSupplier> GetAll()
        {
            using (var context = new AppDbContext())
            {
                return context.SmallSuppliers.ToList();
            }
        }

        public void Add(SmallSupplier post)
        {
            using (var context = new AppDbContext())
            {
                context.SmallSuppliers.Add(post);
                context.SaveChanges();
            }
        }
    }
}
