using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPartsShop.Repository
{
    public class OrderRepository
    {
        public List<Order> GetAll()
        {
            using (var context = new AppDbContext())
            {
                return context.Orders.ToList();
            }
        }

        public void Add(Order post)
        {
            using (var context = new AppDbContext())
            {
                context.Orders.Add(post);
                context.SaveChanges();
            }
        }
    }
}
