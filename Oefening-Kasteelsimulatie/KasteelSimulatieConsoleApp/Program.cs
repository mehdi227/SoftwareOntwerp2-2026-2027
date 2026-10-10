using KasteelSimulatieBL.Domain;
using KasteelSimulatieBL.Domain.BewonerNamespace;
using KasteelSimulatieBL.Interfaces;
using System.Drawing;
using BuildingBlocks.ValueObjects;

namespace KasteelSimulatieConsoleApp {
    internal class Program {
        public static void Main(string[] args) {
            Raster r1 = new(5, 5);
            Coordinaat c1 = new Coordinaat(2, 3);
            Kasteel k1 = new(c1, 1, Color.Tan);
            r1.VoegKasteelToe(k1);
            k1.VoegBewonerToe(new Ridder("Mootje", 10));
            k1.VoegBewonerToe(new Kok("Gordon Ramsey", "Couscous"));
            k1.VoegBewonerToe(new Stalknecht("piet"));

            //k1.LaatPrinsesIntrekken(new Prinses("Elsa", "van die film"));
            foreach (Bewoner bewoner in k1.Bewoners) {
                if (bewoner is not IStrijder) {
                    Console.WriteLine($"{bewoner.Naam} heeft functie {bewoner.GetType()}");
                }
            }
            //laat alle strijders van een kasteel strijden zonder op concrete bewonertypes te controleren.
            foreach (IStrijder bewoner in k1.Bewoners.OfType<IStrijder>()) {
                bewoner.Strijd();
            }

            //zoek kasteel op basis van coordinaat
            Console.WriteLine(r1.ZoekKasteelOp(c1).AantalVlaggetjes);
        }
    }
}
