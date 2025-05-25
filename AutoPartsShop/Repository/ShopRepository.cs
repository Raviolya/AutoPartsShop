using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPartsShop.Repository
{
    public class ShopRepository
    {
        public List<Shop> GetAll()
        {
            using (var context = new AppDbContext())
            {
                return context.Shops.ToList();
            }
        }

        public void Add(Shop post)
        {
            using (var context = new AppDbContext())
            {
                context.Shops.Add(post);
                context.SaveChanges();
            }
        }
    }
}
