using System;
using System.Collections.Generic;
using System.Text;

namespace KasteelSimulatieBL.Domain {
    public class Raster {
        public int Breedte { get; set; }
        public int Hoogte { get; set; }

        private readonly List<Kasteel> _kastelen;
        public IReadOnlyList<Kasteel> Kastelen => _kastelen.AsReadOnly();

        public Raster(int breedte, int hoogte) {
            Breedte = breedte;
            Hoogte = hoogte;
        }
    }
}
