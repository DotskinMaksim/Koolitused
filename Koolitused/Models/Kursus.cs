using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Koolitused.Models
{
    public class Kursus
    {
        public int Id { get; set; }
        public int LapsId { get; set; }
        public int KoolitusId { get; set; }

        public virtual Laps Laps { get; set; }
        public virtual Koolitus Koolitus { get; set; }
    }
}