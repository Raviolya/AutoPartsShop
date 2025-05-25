using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPartsShop.Repository
{
    public class RequestRepository
    {
        public List<Request> GetAll()
        {
            using (var context = new AppDbContext())
            {
                return context.Requests.ToList();
            }
        }

        public void Add(Request post)
        {
            using (var context = new AppDbContext())
            {
                context.Requests.Add(post);
                context.SaveChanges();
            }
        }
    }
}
