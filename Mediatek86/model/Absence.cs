using System;

namespace Mediatek86.model
{
    /// <summary>
    /// Classe Model de Absence
    /// </summary>
    public class Absence
    {
        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="datedebut"></param>
        /// <param name="datefin"></param>
        /// <param name="motif"></param>
        public Absence(int idpersonnel, DateTime datedebut, DateTime datefin, Motif motif)
        {
            this.Idpersonnel = idpersonnel;
            this.Datedebut = datedebut;
            this.Datefin = datefin;
            this.Motif = motif;
        }

        /// <summary>
        /// getter setter propriété idpersonnel
        /// </summary>
        public int Idpersonnel { get; set; }
        /// <summary>
        /// getter setter propriété datedebut
        /// </summary>
        public DateTime Datedebut { get; set; }
        /// <summary>
        /// getter setter propriété datefin
        /// </summary>
        public DateTime Datefin { get; set; }
        /// <summary>
        /// getter setter propriété objet motif
        /// </summary>
        public Motif Motif { get; set; }
    }
}
