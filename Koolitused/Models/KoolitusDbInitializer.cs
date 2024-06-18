using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Koolitused.Models
{
    public class KoolitusDbInitializer : DropCreateDatabaseAlways<KoolitusContext>
    {
        protected override void Seed(KoolitusContext db)
        {
            db.Koolitus.Add(
                new Koolitus
                {
                    Koolitusenimetus = "Eesti keel",
                    Koolitusekirjeldus = "Õpime eesti keelt",
                    Koolitusemaht = 12,
                    Koolitusehind = 100,
                    OpetajaId = 1,
                });
            base.Seed(db);
        }
    }
}