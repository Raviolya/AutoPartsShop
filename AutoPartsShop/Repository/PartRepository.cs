using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPartsShop.Repository
{
    public class PartRepository
    {
        public List<Part> GetAll()
        {
            using (var context = new AppDbContext())
            {
                return context.Parts.ToList();
            }
        }

        public void Add(Part post)
        {
            using (var context = new AppDbContext())
            {
                context.Parts.Add(post);
                context.SaveChanges();
            }
        }
    }
}
