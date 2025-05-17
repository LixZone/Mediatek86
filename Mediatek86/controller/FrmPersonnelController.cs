using Mediatek86.dal;
using Mediatek86.model;
using System.Collections.Generic;

namespace Mediatek86.controller
{
    /// <summary>
    /// Contrôleur de FrmPersonnelController
    /// </summary>
    public class FrmPersonnelController
    {
        /// <summary>
        /// objet d'accès aux opérations possibles sur Personnel
        /// </summary>
        private readonly PersonnelAccess personnelAccess;
        /// <summary>
        /// objet d'accès aux opérations possible sur Service
        /// </summary>
        private readonly ServiceAccess serviceAccess;

        /// <summary>
        /// Récupère les acces aux données
        /// </summary>
        public FrmPersonnelController() 
        {
            personnelAccess = new PersonnelAccess();
            serviceAccess = new ServiceAccess();
        }

        /// <summary>
        /// Récupère et retourne les infos des personnels
        /// </summary>
        /// <returns>liste du personnel</returns>
        public List<Personnel> GetListePersonnel()
        {
            return personnelAccess.GetListePersonnel();
        }

        /// <summary>
        /// Récupère et retourne les infos des services
        /// </summary>
        /// <returns>liste des services</returns>
        public List<Service> GetListeService()
        {
            return serviceAccess.GetListeService();
        }
    }
}
