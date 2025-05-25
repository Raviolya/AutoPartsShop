using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPartsShop.Repository
{
    public class DealerRepository
    {
        public List<Dealer> GetAll()
        {
            using (var context = new AppDbContext())
            {
                return context.Dealers.ToList();
            }
        }

        public void Add(Dealer post)
        {
            using (var context = new AppDbContext())
            {
                context.Dealers.Add(post);
                context.SaveChanges();
            }
        }
    }
}
