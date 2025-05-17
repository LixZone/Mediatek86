using Mediatek86.model;
using Mediatek86.dal;
using System;

namespace Mediatek86.controller
{
    /// <summary>
    /// Contrôleur de FrmAuthentification
    /// </summary>
    public class FrmAuthentificationController
    {
        /// <summary>
        /// objet d'accès aux opérations possibles sur Personnel
        /// </summary>
        private readonly PersonnelAccess personnelAccess;

        /// <summary>
        /// Récupère les acces aux données
        /// </summary>
        public FrmAuthentificationController()
        {
            personnelAccess = new PersonnelAccess();
        }

        /// <summary>
        /// Vérifie l'authentification
        /// </summary>
        /// <param name="responsable">objet contenant les informations de connexion</param>
        /// <returns> vrai si les informations de connexion sont correctes</returns>
        public Boolean ControleAuthentification(Responsable responsable)
        {
            return personnelAccess.ControleAuthentification(responsable);
        }

    }
}
