using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CraftBar.Models;
using CraftBar.Services;

namespace CraftBar.Controllers
{
    public class BeerController : ApiController
    {
        private BeerRepository beerRepository;

        public BeerController()
        {
            this.beerRepository = new BeerRepository();
        }

        public Beer[] Get()
        {
            return beerRepository.GetAllBeer();
        }
    }
}
