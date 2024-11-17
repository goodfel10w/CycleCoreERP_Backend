namespace CycleCoreERP_Backend.Models {
    
    public class Fertigungslos
    {
        public int LosId { get; set; } // ID des Loses
        public bool LetztesLos { get; set; } 
        public int Menge { get; set; }
        public int FertigungsauftragId { get; set; }
    }
}