namespace CycleCoreERP_Backend.Models
{
    public class Fertigungsauftrag
    {
        public Fertigungsauftrag(Bauteil erzeugnis)
        {
            Erzeugnis = erzeugnis;
        }

        public int Periode { get; set; } // Die Periode, in der der Fertigungsauftrag geplant ist
        public int FertigungsauftragId { get; set; } // ID des Fertigungsauftrags
        public required List<int> LosIds { get; set; } // Liste von Los-IDs für die Produktion
        public required List<Fertigungslos> Fertigungslose { get; set; }
        public Bauteil Erzeugnis { get; set; } // ID der Komponente (kann ein Bauteil oder Kaufteil sein)
        public int Menge { get; set; } // Die Anzahl der benötigten Einheiten
        public int Ruestzeit { get; set; }
        public int BearbeitungszeitJeLos { get; set; }
        public int GesamtZeit { get; set; } // Die Gesamtzeit für die Fertigung in Minuten
    }
}