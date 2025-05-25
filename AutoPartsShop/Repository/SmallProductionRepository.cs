using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPartsShop.Repository
{
    public class SmallProductionRepository
    {
        public List<SmallProduction> GetAll()
        {
            using (var context = new AppDbContext())
            {
                return context.SmallProductions.ToList();
            }
        }

        public void Add(SmallProduction post)
        {
            using (var context = new AppDbContext())
            {
                context.SmallProductions.Add(post);
                context.SaveChanges();
            }
        }
    }
}
