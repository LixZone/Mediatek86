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

        /// <summary>
        /// Demande d'ajout d'un personnel
        /// </summary>
        /// <param name="personnel">objet personnel à ajouter</param>
        public void AddPersonnel(Personnel personnel)
        {
            personnelAccess.AddPersonnel(personnel);
        }

        /// <summary>
        /// Demande de modification d'un personnel
        /// </summary>
        /// <param name="personnel">objet personnel à modifier</param>
        public void UpdatePersonnel(Personnel personnel)
        {
            personnelAccess.UpdatePersonnel(personnel);
        }

        /// <summary>
        /// Demande de suppression d'un personnel
        /// </summary>
        /// <param name="personnel">objet personnel à supprimer</param>
        public void DelPersonnel(Personnel personnel)
        {
            personnelAccess.DelPersonnel(personnel);
        }

        /// <summary>
        /// Demande d'ajout d'un service 
        /// </summary>
        /// <param name="service"></param>
        public void AddService(Service service)
        {
            serviceAccess.AddService(service);
        }

        /// <summary>
        /// Demande de suppression d'un service
        /// </summary>
        /// <param name="service">objet service à supprimer</param>
        public void DelService(Service service)
        {
            serviceAccess.DelService(service);
        }
    }
}
