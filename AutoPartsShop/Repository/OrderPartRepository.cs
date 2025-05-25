using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPartsShop.Repository
{
    public class OrderPartRepository
    {
        public List<OrderPart> GetAll()
        {
            using (var context = new AppDbContext())
            {
                return context.OrderParts.ToList();
            }
        }

        public void Add(OrderPart post)
        {
            using (var context = new AppDbContext())
            {
                context.OrderParts.Add(post);
                context.SaveChanges();
            }
        }
    }
}
