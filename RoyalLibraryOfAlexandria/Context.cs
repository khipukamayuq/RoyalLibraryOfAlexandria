using RoyalLibraryOfAlexandria.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RoyalLibraryOfAlexandria
{

    public class Context : DbContext
    {
        public Context() : base("Default")
        {
            Database.SetInitializer(new MyInitializer());
        }

        public DbSet<Papyrus> Papyri { get; set; }
    }

    public class MyInitializer : DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            context.Papyri.Add(new Papyrus()
            {
                Title = "Margites",
                Author = "Homer"
            });
            context.Papyri.Add(new Papyrus()
            {
                Title = "On Sphere-Making",
                Author = "Archimedes"
            });
            context.Papyri.Add(new Papyrus()
            {
                Title = "Hermocrates",
                Author = "Plato"
            });
            base.Seed(context);
        }
    }
}