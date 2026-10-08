using KasteelSimulatieBL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace KasteelSimulatieBL.Domain.BewonerNamespace {
    public sealed class Ridder : Bewoner, IStrijder {
        public Ridder(string naam, int zwaardLengte) 
            : base(naam) {
            ZwaardLengte = zwaardLengte;
        }
        public int ZwaardLengte { get; set; }
        public void Strijd() {
            Console.WriteLine($"{Naam} trekt een zwaard.");
        }
    }
}
