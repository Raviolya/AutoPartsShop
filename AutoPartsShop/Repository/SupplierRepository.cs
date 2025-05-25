using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPartsShop.Repository
{
    public class SupplierRepository
    {
        public List<Supplier> GetAll()
        {
            using (var context = new AppDbContext())
            {
                return context.Suppliers.ToList();
            }
        }

        public void Add(Supplier post)
        {
            using (var context = new AppDbContext())
            {
                context.Suppliers.Add(post);
                context.SaveChanges();
            }
        }
    }
}
