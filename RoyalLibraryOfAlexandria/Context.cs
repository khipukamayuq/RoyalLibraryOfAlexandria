using RoyalLibraryOfAlexandria.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RoyalLibraryOfAlexandria
{
   // private static Papyri[] _papyri = new Papyri[]{};

    public class Context : DbContext
    {
        public Context() : base("Default")
        {
            Database.SetInitializer(new MyInitializer());
        }

        public DbSet<Papyrus> Papyri { get; set; }
    }

    public class MyInitializer :
        DropCreateDatabaseIfModelChanges<Context>
    //DropCreateDatabaseAlways<Context>
    {
        protected override void Seed(Context context)
        {
            context.Papyri.Add(new Papyrus()
            {
                Title = "Furrby"
            });
            context.Papyri.Add(new Papyrus()
            {
                Title = "NomNom"
            });
            context.Papyri.Add(new Papyrus()
            {
                Title = "Wagabond"
            });
            base.Seed(context);
        }
    }
}