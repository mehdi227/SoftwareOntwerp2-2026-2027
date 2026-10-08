using System;
using System.Collections.Generic;
using System.Text;

namespace KasteelSimulatieBL.Domain.BewonerNamespace {
    public abstract class Bewoner {
        protected Bewoner(string naam) {
            Naam = naam;
        }

        public string Naam { get; set; }

    }
}
