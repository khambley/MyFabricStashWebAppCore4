using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFabricStashWebAppCore4.Models
{
    interface IFabricRepository
    {
        IQueryable<Fabric> Fabrics { get; }
    }
}
