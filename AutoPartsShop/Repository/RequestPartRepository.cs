using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPartsShop.Repository
{
    public class RequestPartRepository
    {
        public List<RequestPart> GetAll()
        {
            using (var context = new AppDbContext())
            {
                return context.RequestParts.ToList();
            }
        }

        public void Add(RequestPart post)
        {
            using (var context = new AppDbContext())
            {
                context.RequestParts.Add(post);
                context.SaveChanges();
            }
        }
    }
}
