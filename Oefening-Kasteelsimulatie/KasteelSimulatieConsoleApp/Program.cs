using KasteelSimulatieBL.Domain;
using KasteelSimulatieBL.Domain.BewonerNamespace;
using KasteelSimulatieBL.Interfaces;
using System.Drawing;

namespace KasteelSimulatieConsoleApp {
    internal class Program {
        static void Main(string[] args) {
            Raster r1 = new(5, 5);

            Kasteel k1 = new(new Coordinaat(2, 3), 1, Color.Tan);

            k1.VoegBewonerToe(new Ridder("Mootje", 10));
            k1.VoegBewonerToe(new Kok("Gordon Ramsey", "Couscous"));
            k1.VoegBewonerToe(new Stalknecht("piet"));

            //k1.LaatPrinsesIntrekken(new Prinses("Elsa", "van die film"));
            foreach (IStrijder bewoner in k1.Bewoners) {
                if (bewoner.GetType() == typeof(IStrijder)) {
                    bewoner.Strijd();
                }
                
            }
        }
    }
}
