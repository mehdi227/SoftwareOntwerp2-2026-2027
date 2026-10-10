using KasteelSimulatieBL.Domain.BewonerNamespace;
using System;
using System.Collections.Generic;
using System.Text;

namespace KasteelSimulatieBL.Factories {
    public class BewonerFactory {
        public static Bewoner MaakWillekeurigeBewoner() {
            var naam = MaakWillekeurigeString(10);
            var r = new Random();

            return r.Next(4) switch {
                0 => new Prinses(naam, MaakWillekeurigeString(50)),
                1 => new Ridder(naam, 1),
                2 => new Stalknecht(naam),
                3 => new Kok(naam, MaakWillekeurigeString(30)),
                _ => throw new Exception()
            };
        }
        public static List<Bewoner> MaakWillekeurigeBewoners(int aantal) {
            return Enumerable.Repeat(0, aantal)
                .Select(x => MaakWillekeurigeBewoner())
                .ToList();
        }
        private static string MaakWillekeurigeString(int lengte = 10) {
            return string.Join("", Enumerable.Repeat(0, lengte)
                .Select(n => (char)new Random().Next(32, 127)));
        }
    }
}
