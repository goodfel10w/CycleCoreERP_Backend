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
        private int _zuProudzierendenFahraeder = 150; // Placeholder für den Userinput
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

        public void BerechnungFahrraederAktuellePeriode()
        {
            foreach (Fahrrad fahrrad in Enum.GetValues(typeof(Fahrrad)))
            {
                var stuekliste = Data.Stueckliste.Bauteile[fahrrad];

                foreach (var bauteil in stuekliste)
                {

                }

            }


        }

    }
}