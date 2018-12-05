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
    public class StyleController : ApiController
    {
        private StyleRepository styleRepository;

        public StyleController()
        {
            this.styleRepository = new StyleRepository();
        }

        public List<Style> Get()
        {
            //return styleRepository.GetAllStyles();
            using (var db = new Database1Entities())
            {
                StyleRepository style = new StyleRepository();
                return (style.GetAllStyles(db).ToList());
            }
        }
    }
}
