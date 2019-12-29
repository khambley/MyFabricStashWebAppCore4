using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyFabricStashWebAppCore4.Models;

namespace MyFabricStashWebAppCore4.Controllers
{
    public class FabricController : Controller
    {
        private IFabricRepository repository;
        public int PageSize = 4;
        public FabricController(IFabricRepository repo)
        {
            repository = repo;
        }
        public ViewResult List(int fabricPage = 1) => View(repository.Fabrics
            .OrderBy(f => f.FabricId)
            .Skip((fabricPage - 1) * PageSize)
            .Take(PageSize)
            );
    }
    
}
