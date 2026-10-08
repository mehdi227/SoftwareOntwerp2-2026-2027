using System;
using System.Collections.Generic;
using System.Text;

namespace KasteelSimulatieBL.Domain.BewonerNamespace {
    public sealed class Kok : Bewoner {
        public Kok(string naam, string specialiteit)
            : base(naam) {
            Specialiteit = specialiteit;
        }

        public string Specialiteit { get; set; }
    }
}
