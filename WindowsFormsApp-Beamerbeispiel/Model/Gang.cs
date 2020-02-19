using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Beamerbeispiel.Model {
    class Gang {
        public static string Name { get; set; }
        private static List<Pirat> piraten = new List<Pirat> ();

        public static void Add (Pirat p) {
            piraten.Add ( p );
        }

        public static List<Pirat> PiratenGangBereitstellen () {
            return piraten;
        }

    }
}
