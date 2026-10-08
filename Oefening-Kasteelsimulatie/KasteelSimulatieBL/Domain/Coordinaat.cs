using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace KasteelSimulatieBL.Domain {
    public class Coordinaat {

        public int X { get; set; }
        public int Y { get; set; }

        public Coordinaat(int x, int y) {
            X = x;
            Y = y;
        }

        public bool LigtBinnenRasterVan(int breedte, int hoogte) {

            return breedte > X && hoogte > Y && breedte >= 0 && hoogte >= 0;
        }
    }
}
