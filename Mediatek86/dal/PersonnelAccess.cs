namespace Mediatek86.dal
{
    /// <summary>
    /// Classe permettant de gérer les demandes concernant le personnel
    /// </summary>
    public class PersonnelAccess
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public PersonnelAccess()
        {
            access = Access.GetInstance();
        }
    }
}
