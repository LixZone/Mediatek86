using Mediatek86.dal;
using Mediatek86.model;
using System.Collections.Generic;

namespace Mediatek86.controller
{
    /// <summary>
    /// Contrôleur de FrmAbsencesController
    /// </summary>
    public class FrmAbsencesController
    {
        /// <summary>
        /// objet d'accès aux opérations possibles sur Absence
        /// </summary>
        private readonly AbsenceAccess absenceAccess;
        /// <summary>
        /// objet d'accès aux opérations possibles sur Motif
        /// </summary>
        private readonly MotifAccess motifAccess;

        /// <summary>
        /// Récupère les acces aux données
        /// </summary>
        public FrmAbsencesController()
        {
            absenceAccess = new AbsenceAccess();
            motifAccess = new MotifAccess();
        }

        /// <summary>
        /// Récupère et retourne les infos des absences du personnel
        /// </summary>
        /// <returns>liste du absences</returns>
        public List<Absence> GetListeAbsence(Personnel personnel)
        {
            return absenceAccess.GetListeAbsence(personnel);
        }
    }
}
