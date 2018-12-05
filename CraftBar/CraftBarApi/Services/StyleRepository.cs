using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CraftBar.Models;

namespace CraftBar.Services
{
    public class StyleRepository
    {
        public List<Style> GetAllStyles(Database1Entities db)
        {
            if (db != null)
            {
                return db.Styles.ToList();
            }
            return null;
//            return new Style[]
//            {
//                new Style
//                {
//                    Id = 1,
//                    name = "Lager"
//                },
//                new Style
//                {
//                    Id = 2,
//                    name = "IPA"
//                }
//            };
        }
    }
}