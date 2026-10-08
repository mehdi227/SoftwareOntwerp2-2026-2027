using System;
using System.Collections.Generic;
using System.Text;

namespace KasteelSimulatieBL.Domain.BewonerNamespace {
    public sealed class Prinses : Bewoner {
        public Prinses(string naam, string beschrijving)
            : base(naam) {
            Beschrijving = beschrijving;
        }

        public string Beschrijving { get; set; }
    }
}
