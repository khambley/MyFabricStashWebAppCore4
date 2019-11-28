using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFabricStashWebAppCore4.Models
{
    // By default interfaces are private, you have to add the public accessor manually.
    public interface IFabricRepository
    {
        IQueryable<Fabric> Fabrics { get; }
    }
}
