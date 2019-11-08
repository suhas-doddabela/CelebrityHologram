using System;
using System.Collections.Generic;
using System.Text;

namespace Rbc.Hologram.Data.Contexts
{
    public class MigrationContext
    {
        public static void Migrate()
        {
            var context = new CelebrityHologramContext();
            ContextSeeder.Seed(context);
        }
    }
}
