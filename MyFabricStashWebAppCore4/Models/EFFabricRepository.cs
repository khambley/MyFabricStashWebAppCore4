using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFabricStashWebAppCore4.Models
{
    public class EFFabricRepository : IFabricRepository
    {
        private ApplicationDbContext context;

        public EFFabricRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Fabric> Fabrics => context.Fabrics;
    }
}
