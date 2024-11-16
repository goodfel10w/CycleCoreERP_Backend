using System;

namespace CycleCoreERP_Backend.Models
{
    public class Produkt
    {
        public int id;
        public string name;
        public List<Bauteil> Stückliste;

        public Produkt(int id, string name, List<Bauteil> Stückliste)
        {
            this.id = id;
            this.name = name;
            this.Stückliste = Stückliste;
        }
    }
}