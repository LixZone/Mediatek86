namespace Mediatek86.dal
{
    /// <summary>
    /// Classe permettant de gérer les demandes concernant les motifs d'absences
    /// </summary>
    public class MotifAccess
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public MotifAccess()
        {
            access = Access.GetInstance();
        }
    }
}
