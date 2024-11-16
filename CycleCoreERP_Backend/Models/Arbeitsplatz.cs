namespace CycleCoreERP_Backend.Models
{
    public class Arbeitsplatz
    {
        public int ArbeitsplatzId { get; set; }
        public int VerfügbareKapazität { get; set; }
        public int GeplanteKapazität { get; set; }
        public int Periode { get; set; }

        public Arbeitsplatz(int ArbeitsplatzId, int VerfügbareKapazität, int GeplanteKapazität, int Periode)
        {
            this.ArbeitsplatzId = ArbeitsplatzId;
            this.VerfügbareKapazität = VerfügbareKapazität;
            this.GeplanteKapazität = GeplanteKapazität;
            this.Periode = Periode;
        }

        public void KonsumierenFertigungsauftrag(Fertigungsauftrag fertigungsauftrag)
        {
            if (VerfügbareKapazität >= fertigungsauftrag.GesamtZeit)
            {
                VerfügbareKapazität -= fertigungsauftrag.GesamtZeit;
                // Hier könnte Logik hinzugefügt werden, um Bauteile zu erstellen oder umgewandelte Bauteile hinzuzufügen
                // Zum Beispiel:
                // UmwandlungKaufBauteileInNeueBauteile(fertigungsauftrag);
            }
            else
            {
                // Kapazität reicht nicht aus, um den Fertigungsauftrag zu konsumieren
                throw new InvalidOperationException("Nicht genügend Kapazität für den Fertigungsauftrag.");
            }
        }

        // Weitere Funktion zum Umwandeln von Bauteilen könnte hier implementiert werden
        // private void UmwandlungKaufBauteileInNeueBauteile(Fertigungsauftrag fertigungsauftrag) { ... }
    }
}