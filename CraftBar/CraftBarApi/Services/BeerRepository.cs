using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CraftBar.Models;

namespace CraftBar.Services
{
    public class BeerRepository
    {
        private const string CacheKey = "BeerStore";

        public BeerRepository()
        {
            var ctx = HttpContext.Current;

            if (ctx != null)
            {
                if (ctx.Cache[CacheKey] == null)
                {
                    var beer = new Beer[]
                    {
                        new Beer
                        {
                            Id = 1,
                            Name = "Beer 1",
                            Style = "Lager"
                        },
                        new Beer
                        {
                            Id = 2,
                            Name = "Beer 2",
                            Style = "IPA"
                        }
                    };

                    ctx.Cache[CacheKey] = beer;
                }
            }
        }

        public Beer[] GetAllBeer()
        {
            return new Beer[]
            {
                new Beer
                {
                    Id = 1,
                    Name = "Beer 1",
                    Style = "Lager"
                },
                new Beer
                {
                    Id = 2,
                    Name = "Beer 2",
                    Style = "IPA"
                }
            };
        }
    }
}