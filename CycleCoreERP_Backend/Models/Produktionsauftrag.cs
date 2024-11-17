namespace CycleCoreERP_Backend.Models
{
    public class Produktionsauftrag
    {
        public int ProduktionsauftragId { get; set; }
        public int ProduktId { get; set; }
        public Produkt Produkt { get; set; }
        public int Menge { get; set; }
        public int Periode { get; set; }

        public Produktionsauftrag(int ProduktionsauftragId, int ProduktId, Produkt Produkt, int Menge, int Periode)
        {
            this.ProduktionsauftragId = ProduktionsauftragId;
            this.ProduktId = ProduktId;
            this.Produkt = Produkt;
            this.Menge = Menge;
            this.Periode = Periode;
        }
    }
}