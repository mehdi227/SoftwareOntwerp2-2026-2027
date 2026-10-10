using KasteelSimulatieBL.Domain;
using KasteelSimulatieBL.Domain.BewonerNamespace;
using KasteelSimulatieBL.Interfaces;
using System.Drawing;
using BuildingBlocks.ValueObjects;
using KasteelSimulatieBL.Managers;

namespace KasteelSimulatieConsoleApp {
    internal class Program {
        public static void Main(string[] args) {
            DomeinController controller = new DomeinController();
            
            controller.StartNieuweSimulatie(5,5);
            controller.VoegKasteelToe(2,3,100);
            controller.DoodWillekeurigeBewoner(2,3);
            
           
            //laat alle strijders van een kasteel strijden zonder op concrete bewonertypes te controleren.
            foreach (IStrijder bewoner in controller.Raster.ZoekKasteelOp(new Coordinaat(2, 3)).Bewoners) {
                bewoner.Strijd();
            }

            //zoek kasteel op basis van coordinaat
            Console.WriteLine($"aantal vlaggen: {controller.Raster.ZoekKasteelOp(new Coordinaat(2,3)).AantalVlaggetjes}");
            
        }
    }
}
