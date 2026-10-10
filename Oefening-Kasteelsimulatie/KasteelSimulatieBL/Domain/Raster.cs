using BuildingBlocks.ValueObjects;
using KasteelSimulatieBL.Domain.BewonerNamespace;

namespace KasteelSimulatieBL.Domain {
    public class Raster {
        public Raster(int breedte, int hoogte) {
            Breedte = breedte;
            Hoogte = hoogte;
        }

        public int Breedte { get; init; }
        public int Hoogte { get; init; }
        private readonly List<Kasteel> _kastelen = new();
        public IReadOnlyList<Kasteel> Kastelen => _kastelen.AsReadOnly();

        public void VoegKasteelToe(Kasteel kasteel) {
            if (!Bevat(kasteel.Positie))
                throw new ArgumentException("Het kasteel ligt buiten het raster.", nameof(kasteel));

            var positieIsBezet = _kastelen.Any(bestaandKasteel =>
            bestaandKasteel.Positie.X == kasteel.Positie.X
            && bestaandKasteel.Positie.Y == kasteel.Positie.Y);

            if (positieIsBezet)
                throw new InvalidOperationException("Op deze positie staat al een kasteel.");

            _kastelen.Add(kasteel);
        }
        public bool Bevat(Coordinaat coordinaat) {
            return coordinaat.X >= 0
            && coordinaat.X < Breedte
            && coordinaat.Y >= 0
            && coordinaat.Y < Hoogte;
        }
        public Kasteel ZoekKasteelOp(Coordinaat positie) {
            foreach (Kasteel kasteel in Kastelen) {
                if (kasteel.Positie == positie) {
                    return kasteel;
                }
            }
            return null;
        }
        public bool IsKasteelBewoond(int x, int y) {
            return _kastelen.Single(kasteel =>
                kasteel.Positie.X == x && kasteel.Positie.Y == y)
                .IsBewoond();
        }
    }
}
