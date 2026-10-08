using KasteelSimulatieBL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace KasteelSimulatieBL.Domain.BewonerNamespace {
    public sealed class Stalknecht : Bewoner, IStrijder {
        public Stalknecht(string naam)
            : base(naam) {

        }

        public void Strijd() {
            Console.WriteLine($"{Naam} heft een mestvork.");
        }
    }
}
