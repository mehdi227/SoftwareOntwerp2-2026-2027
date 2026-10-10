using BuildingBlocks.ValueObjects;
using KasteelSimulatieBL.Domain;
using KasteelSimulatieBL.Domain.BewonerNamespace;
using KasteelSimulatieBL.Factories;
using System.Drawing;

namespace KasteelSimulatieBL.Managers;

public class DomeinController {
    private Raster? _raster = null;

    public Raster? Raster {
        get { return _raster; }
    }

    public void StartNieuweSimulatie(int breedte, int hoogte) {
        _raster = new(breedte, hoogte);
    }

    public void StopHuidigeSimulatie() {
        _raster = null;
    }

    public void VoegKasteelToe(int x, int y, int aantalBewoners) {
        var kasteel = new Kasteel(new Coordinaat(x, y));
        var bewoners = BewonerFactory.MaakWillekeurigeBewoners(aantalBewoners);

        kasteel.VoegBewonersToe(bewoners);

        _raster!.VoegKasteelToe(kasteel);
    }

    public bool IsKasteelBewoond(int x, int y) {
        return _raster!.IsKasteelBewoond(x, y);
    }

    public void DoodWillekeurigeBewoner(int x, int y) {
        _raster!.ZoekKasteelOp(new Coordinaat(x, y)).DoodWillekeurigeBewoner();
    }
}
