using Mediatek86.model;
using Serilog;
using System;
using System.Collections.Generic;

namespace Mediatek86.dal
{
    /// <summary>
    /// Classe permettant de gérer les demandes concernant les absences
    /// </summary>
    public class AbsenceAccess
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public AbsenceAccess()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// Récupère et retourne la liste du personnel
        /// </summary>
        /// <returns>liste du personnel</returns>
        public List<Absence> GetListeAbsence(Personnel personnel)
        {
            List<Absence> listeAbsence = new List<Absence>();
            if (access.Manager != null)
            {
                string req = "select a.idpersonnel as idpersonnel, a.datedebut as datedebut, a.datefin as datefin, m.idmotif as idmotif, m.libelle as motif ";
                req += "from absence a join motif m on (a.idmotif = m.idmotif) ";
                req += "where a.idpersonnel=@idpersonnel ";
                req += "order by datedebut DESC;";
                Dictionary<string, object> parameters = new Dictionary<string, object> {
                    { "@idpersonnel", personnel.Idpersonnel }
                };
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req, parameters);
                    if (records != null)
                    {
                        Log.Debug("AbsenceAccess.GetListeAbsence nb records = {0}", records.Count);
                        foreach (Object[] record in records)
                        {
                            Log.Debug("AbsenceAccess.GetListeAbsence Motif : id={0} nom={1}", record[3], record[4]);
                            Log.Debug("AbsenceAccess.GetListeAbsence Absence : id={0} datedebut={1} datefin={2} ", record[0], record[1], record[2]);
                            Motif motif = new Motif((int)record[3], (string)record[4]);
                            Absence absence = new Absence((int)record[0], (DateTime)record[1], (DateTime)record[2], motif);
                            listeAbsence.Add(absence);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("AbsenceAccess.GetListeAbsence catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }
            }
            return listeAbsence;
        }

        /// <summary>
        /// Demande d'ajout d'une absence
        /// </summary>
        /// <param name="absence">objet absence à ajouter</param>
        public void AddAbsence(Absence absence)
        {
            if (access.Manager != null)
            {
                string req = "insert into absence(idpersonnel, datedebut, datefin, idmotif) ";
                req += "values (@idpersonnel, @datedebut, @datefin, @idmotif);";
                Dictionary<string, object> parameters = new Dictionary<string, object> {
                    { "@idpersonnel", absence.Idpersonnel },
                    { "@datedebut", absence.Datedebut },
                    { "@datefin", absence.Datefin },
                    { "@idmotif", absence.Motif.Idmotif }
                };
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("AbsenceAccess.AddAbsence catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }
            }
        }

        /// <summary>
        /// Demande de modification d'une absence
        /// </summary>
        /// <param name="absence">objet absence à modifier</param>
        public void UpdateAbsence(Absence absence)
        {
            if (access.Manager != null)
            {
                string req = "update absence set datefin = @datefin, idmotif = @idmotif ";
                req += "where idpersonnel = @idpersonnel and datedebut = @datedebut;";
                Dictionary<string, object> parameters = new Dictionary<string, object> {
                    { "@idpersonnel", absence.Idpersonnel },
                    { "@datedebut", absence.Datedebut },
                    { "@datefin", absence.Datefin },
                    { "@idmotif", absence.Motif.Idmotif }
                };
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("AbsenceAccess.UpdateAbsence catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }
            }
        }
    }
}
