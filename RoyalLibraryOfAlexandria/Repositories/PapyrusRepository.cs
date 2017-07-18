﻿using RoyalLibraryOfAlexandria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RoyalLibraryOfAlexandria.Repositories
{
    public class PapyrusRepository
    {
        public void Create(Papyrus papyrus)
        {
            using (var context = new Context())
            {
                context.Papyri.Add(papyrus);

                context.SaveChanges();
            }
        }
    }
}