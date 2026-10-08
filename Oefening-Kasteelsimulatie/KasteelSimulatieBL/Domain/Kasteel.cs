using System.Drawing;
using KasteelSimulatieBL.Domain.BewonerNamespace;

namespace KasteelSimulatieBL.Domain; 
public class Kasteel {
    public Kasteel(Coordinaat positie, int aantalVlaggetjes, Color kleurVanDeMuren) {
        AantalVlaggetjes = aantalVlaggetjes;
        KleurVanDeMuren = kleurVanDeMuren;
        Positie = positie;
    }

    public int AantalVlaggetjes {  get; set; }
    public Color KleurVanDeMuren {  get; set; }
    public Coordinaat Positie {  get; set; }
    private readonly List<Bewoner> _bewoners;
    public IReadOnlyList<Bewoner> Bewoners => _bewoners.AsReadOnly();
}
