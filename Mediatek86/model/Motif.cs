namespace Mediatek86.model
{
    /// <summary>
    /// Classe Model de Motif
    /// </summary>
    public class Motif
    {
        /// <summary>
        /// getter propriété idmotif
        /// </summary>
        public int Idmotif { get; }
        /// <summary>
        /// getter propriété nom
        /// </summary>
        public string Nom { get; }

        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="idmotif"></param>
        /// <param name="nom"></param>
        public Motif(int idmotif, string nom)
        {
            this.Idmotif = idmotif;
            this.Nom = nom;
        }

        /// <summary>
        /// Définit l'information à afficher (juste le nom)
        /// </summary>
        /// <returns>nom du profil</returns>
        public override string ToString()
        {
            return this.Nom;
        }
    }
}
