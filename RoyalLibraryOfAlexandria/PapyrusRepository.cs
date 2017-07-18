using RoyalLibraryOfAlexandria.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RoyalLibraryOfAlexandria
{
   // private static Papyri[] _papyri = new Papyri[]{};

    public class PapyrusRepository : DbContext
    {
        public PapyrusRepository() : base("Default")
        {
            
        }

        public DbSet<Papyrus> Papyri { get; set; }
    }
}