using System;

namespace CycleCoreERP_Backend.Models
{
    public class Bauteil
    {
        public int Id;
        public int VerbautInTeil;

        public Bauteil(int id, int verbautInTeil)
        {
            this.Id = id;
            this.VerbautInTeil = verbautInTeil;
        }

        public override bool Equals(object obj)
        {
            return obj is Bauteil bauteil &&
                   Id == bauteil.Id &&
                   VerbautInTeil == bauteil.VerbautInTeil;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, VerbautInTeil);
        }

        public override string ToString()
        {
            return string.Format("Bauteil {0} ist verbaut in Teil {1}", Id, VerbautInTeil);
        }
    }


    public class Kaufteil : Bauteil
    {
        public int Menge;

        public Kaufteil(int id, int verbautInTeil, int menge) : base(id, verbautInTeil)
        {
            this.Menge = menge;
        }

        public override bool Equals(object obj)
        {
            return obj is Kaufteil kaufteil &&
                   base.Equals(obj) &&
                   Menge == kaufteil.Menge;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), Menge);
        }

        public override string ToString()
        {
            return string.Format("Kaufteil {0} ist {1}x verbaut in Teil {2}", Id, Menge, VerbautInTeil);
        }
    }
}