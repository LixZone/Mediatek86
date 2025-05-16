using System;

namespace Mediatek86.model
{
    public class Absence
    {
        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="personnel"></param>
        /// <param name="datedebut"></param>
        /// <param name="datefin"></param>
        /// <param name="motif"></param>
        public Absence(Personnel personnel, DateTime datedebut, DateTime datefin, Motif motif)
        {
            this.Personnel = personnel;
            this.Datedebut = datedebut;
            this.Datefin = datefin;
            this.Motif = motif;
        }

        public Personnel Personnel { get; set; }
        public DateTime Datedebut { get; set; }
        public DateTime Datefin { get; set; }
        public Motif Motif { get; set; }
    }
}
