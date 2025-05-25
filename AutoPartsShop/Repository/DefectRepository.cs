using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPartsShop.Repository
{
    public class DefectRepository
    {
        public List<Defect> GetAll()
        {
            using (var context = new AppDbContext())
            {
                return context.Defects.ToList();
            }
        }

        public void Add(Defect post)
        {
            using (var context = new AppDbContext())
            {
                context.Defects.Add(post);
                context.SaveChanges();
            }
        }
    }
}
