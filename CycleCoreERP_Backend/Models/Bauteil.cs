using System;
using System.Collections.Generic;

namespace CycleCoreERP_Backend.Models
{
    public class Bauteil
    {
        public int Id { get; set; }
        public int VerbautInBauteilId { get; set; }
        public Bauteil? VerbautInBauteil { get; set; }
        public List<Bauteil> BenötigteBauteile { get; set; }

        public Bauteil(int id, int verbautInTeil)
        {
            this.Id = id;
            this.VerbautInBauteilId = verbautInTeil;
            this.VerbautInBauteil = null;
            this.BenötigteBauteile = new List<Bauteil>();
        }

        public override bool Equals(object obj)
        {
            return obj is Bauteil bauteil &&
                   Id == bauteil.Id &&
                   VerbautInBauteilId == bauteil.VerbautInBauteilId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, VerbautInBauteilId);
        }

        public override string ToString()
        {
            return string.Format("Bauteil {0} ist verbaut in Teil {1}", Id, VerbautInBauteilId);
        }
    }

    public class Kaufteil : Bauteil
    {
        public int Menge { get; set; }

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
            return string.Format("Kaufteil {0} ist {1}x verbaut in Teil {2}", Id, Menge, VerbautInBauteilId);
        }
    }
}