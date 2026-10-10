using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingBlocks.ValueObjects {
    public record Coordinaat {
        public int X { get; init; }
        public int Y { get; init; }

        public Coordinaat(int x, int y) {
            X = x;
            Y = y;
        }

        public bool LigtBinnenRasterVan(int breedte, int hoogte) {

            return breedte > X && hoogte > Y && breedte >= 0 && hoogte >= 0;
        }
    }
}
