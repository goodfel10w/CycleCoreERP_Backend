using CycleCoreERP_Backend.Models;
using CycleCoreERP_Backend.Service;
using CycleCoreERP_Backend.Data;

namespace CycleCoreERP_Backend.ProzessKalkulation
{
    public class Disposition
    {
        private List<List<int>> _prognose;
        private List<Bauteil> _bestand;

        private static int _produktionsauftragFahrradP1 = 0;

        // Vertriebswunsch
        // Anz Wie viel wird produziert an Fahhrädern
        // Stückliste * Anzahl
        // Output => ???

        //Pseudo Code Disposition Bauteile


        /*
        PseudoCode Disposition
        Verbindlichen Auftrag übernehmen von Px
        Aufträge in der Warteschlange von Px abfragen
        -- User Input abfragen zu geplanten Lagerbestand -- 
        Lagerbestand von Bauteil auslesen aus xml
        Aufträge in der Warteschlange des Bauteils 
        Aufträge in Bearbeitung des Bauteils 

        ==> Fertigungsauftrag für das Bauteil (int)
         */
        /*        private int _zuProudzierendenFahraeder = 150; // Placeholder für den Userinput
                private int _sicherheitsLagerbestand = 50; // Placeholder für den Userinput
                public static int BerechneFertigungsauftragsVolumenFürBauteil(Bauteil bauteil)
                {
                    int warteschlangeFahrrad = XMLService.GetAnzahlArtikelInWarteschlangen(bauteil.VerbautInTeil);
                    int anzInWarteschlange = XMLService.GetAnzahlArtikelInWarteschlangen(bauteil.Id);
                    int anzahlArtikelInBearbeitung = XMLService.GetAnzahlArtikelInBearbeitung(bauteil.Id);

                    int lagerbestand = XMLService.GetArtikelBestand(bauteil.Id);

                    int ergebnis = 0;

                    return 0;
                }
        */
        public void BerechnungFahrraederAktuellePeriode(List<List<int>> prognose)
        {
            _prognose = prognose;

            foreach (Fahrrad fahrrad in Enum.GetValues(typeof(Fahrrad)))
            {
                var stuekliste = Data.Stueckliste.Bauteile[fahrrad];
                var sicherheitsBestand = 0;

                foreach (var bauteil in stuekliste)
                {
                    var lagerBestand = XMLService.GetArtikelBestand(bauteil.Id);
                    var anzahlInWarteschlange = XMLService.GetAnzahlArtikelInWarteschlangen(bauteil.Id);
                    var anzahlInBearbeitung = XMLService.GetAnzahlArtikelInBearbeitung(bauteil.Id);

                    int produktionsMenge;
                    if (bauteil.Id == (int)fahrrad)
                    {
                        int anzahlFahrraederProduzieren = GetPrognose(periode: 0, bauteil: (int)fahrrad); // Prognose verstehen
                        produktionsMenge = anzahlFahrraederProduzieren + sicherheitsBestand - lagerBestand - anzahlInWarteschlange - anzahlInBearbeitung;
                    }
                    else
                    {
                        produktionsMenge = sicherheitsBestand - lagerBestand - anzahlInWarteschlange - anzahlInBearbeitung;
                    }
                }

            }


        }

        private int GetPrognose(int periode, int bauteil)
        {
            if (periode == 10)
            {
                var insgesamt = _prognose[1][bauteil] + _prognose[2][bauteil] + _prognose[3][bauteil];
                return (int)(insgesamt / 3);
            }
            return _prognose[periode][bauteil];
        }

    }
}