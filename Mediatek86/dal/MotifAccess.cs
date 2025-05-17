using Mediatek86.model;
using Serilog;
using System.Collections.Generic;
using System;

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

        /// <summary>
        /// Récupère et retourne les motifs
        /// </summary>
        /// <returns>liste des motifs</returns>
        public List<Motif> GetListeMotifs()
        {
            List<Motif> listeMotifs = new List<Motif>();
            if (access.Manager != null)
            {
                string req = "select * from motif order by libelle;";
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req);
                    if (records != null)
                    {
                        Log.Debug("MotifAccess.GetListeMotifs nb records = {0}", records.Count);
                        foreach (Object[] record in records)
                        {
                            Log.Debug("MotifAccess.GetListeMotifs id={0} libelle={1}", record[0], record[1]);
                            Motif motif = new Motif((int)record[0], (string)record[1]);
                            listeMotifs.Add(motif);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("MotifAccess.GetListeMotifs catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }
            }
            return listeMotifs;
        }

        /// <summary>
        /// Ajout d'un motif
        /// </summary>
        /// <param name="motif"></param>
        public void AddMotif(Motif motif)
        {
            if (access.Manager != null)
            {
                string req = "insert into motif (libelle) values (@nom);";
                Dictionary<string, object> parameters = new Dictionary<string, object> {
                    { "@nom", motif.Nom }
                };
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("MotifAccess.AddMotif catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }
            }
        }

        /// <summary>
        /// Suppression d'un motif
        /// </summary>
        /// <param name="motif"></param>
        public void DelMotif(Motif motif)
        {
            if (access.Manager != null)
            {
                string req = "delete from motif where idmotif = @idmotif;";
                Dictionary<string, object> parameters = new Dictionary<string, object> {
                    { "@idmotif", motif.Idmotif }
                };
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("MotifAccess.DelMotif catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }
            }
        }
    }
}
