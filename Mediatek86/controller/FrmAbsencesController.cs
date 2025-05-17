using Mediatek86.dal;
using Mediatek86.model;
using System;
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

        /// <summary>
        /// Récupère et retourne les infos des motifs
        /// </summary>
        /// <returns>liste des motifs</returns>
        public List<Motif> GetListeMotifs()
        {
            return motifAccess.GetListeMotifs();
        }

        /// <summary>
        /// Demande d'ajout d'une absence
        /// </summary>
        /// <param name="absence">objet absence à ajouter</param>
        public void AddAbsence(Absence absence)
        {
            absenceAccess.AddAbsence(absence);
        }

        /// <summary>
        /// Demande de modification d'une absence
        /// </summary>
        /// <param name="absence">objet absence à modifier</param>
        public void UpdateAbsence(Absence absence)
        {
            absenceAccess.UpdateAbsence(absence);
        }

        /// <summary>
        /// Demande d'ajout d'un motif 
        /// </summary>
        /// <param name="motif"></param>
        public void AddMotif(Motif motif)
        {
            motifAccess.AddMotif(motif);
        }

        /// <summary>
        /// Demande de suppression d'un motif
        /// </summary>
        /// <param name="motif">objet motif à supprimer</param>
        public void DelMotif(Motif motif)
        {
            motifAccess.DelMotif(motif);
        }
    }
}
