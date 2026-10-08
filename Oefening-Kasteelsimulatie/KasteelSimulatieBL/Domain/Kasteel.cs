using KasteelSimulatieBL.Domain.BewonerNamespace;
using KasteelSimulatieBL.Interfaces;
using System.Drawing;

namespace KasteelSimulatieBL.Domain; 
public class Kasteel {
    public Kasteel(Coordinaat positie, int aantalVlaggetjes, Color kleurVanDeMuren) {
        AantalVlaggetjes = aantalVlaggetjes;
        KleurVanDeMuren = kleurVanDeMuren;
        Positie = positie;
    }

    public int AantalVlaggetjes {  get; private set; }
    public void HangVlagBij() {
        AantalVlaggetjes++;
    }
    public Color KleurVanDeMuren {  get; init; }
    public Coordinaat Positie {  get; init; }
    public Prinses? Prinses { get; private set; }

    public void LaatPrinsesIntrekken(Prinses prinses) {
        ArgumentNullException.ThrowIfNull(prinses);
        Prinses = prinses;
    }
    private readonly List<Bewoner> _bewoners;
    public IReadOnlyList<Bewoner> Bewoners => _bewoners.AsReadOnly();

    public void VoegBewonerToe(Bewoner bewoner) {
        ArgumentNullException.ThrowIfNull(bewoner);
        _bewoners.Add(bewoner);
    }
    public bool IsBewoond() {
        return _bewoners.Count > 0;
    }
}
