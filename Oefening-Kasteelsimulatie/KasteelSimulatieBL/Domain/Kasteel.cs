using KasteelSimulatieBL.Domain.BewonerNamespace;
using KasteelSimulatieBL.Interfaces;
using System.Drawing;
using BuildingBlocks.ValueObjects;

namespace KasteelSimulatieBL.Domain;

public class Kasteel {
    public Kasteel(Coordinaat positie)
        : this(positie, Color.Gray, aantalVlaggetjes: 3) {
        Positie = positie;
    }

    public Kasteel(Coordinaat positie, Color kleurVanDeMuren, int aantalVlaggetjes) {
        AantalVlaggetjes = aantalVlaggetjes;
        KleurVanDeMuren = kleurVanDeMuren;
        Positie = positie;
    }

    public int AantalVlaggetjes { get; private set; }
    public void HangVlagBij() {
        AantalVlaggetjes++;
    }
    public Color KleurVanDeMuren { get; private set; }
    public Coordinaat Positie { get; init; }
    public Prinses? Prinses { get; private set; }

    public void LaatPrinsesIntrekken(Prinses prinses) {
        ArgumentNullException.ThrowIfNull(prinses);
        Prinses = prinses;
    }
    private readonly List<Bewoner> _bewoners = new();
    public IReadOnlyList<Bewoner> Bewoners => _bewoners.AsReadOnly();

    public void VoegBewonerToe(Bewoner bewoner) {
        ArgumentNullException.ThrowIfNull(bewoner);
        _bewoners.Add(bewoner);
    }
    public void VoegBewonersToe(List<Bewoner> bewoners) {
        foreach (Bewoner bewoner in bewoners) {
            _bewoners.Add(bewoner);
        }
    }
    public bool IsBewoond() {
        return _bewoners.Count > 0;
    }
    public void DoodWillekeurigeBewoner() {
        _bewoners.RemoveAt(new Random().Next(0,_bewoners.Count));
    }
}
