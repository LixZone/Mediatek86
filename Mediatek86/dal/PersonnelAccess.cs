using Serilog;
using System.Collections.Generic;
using System;
using Mediatek86.model;

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

        /// <summary>
        /// Controle si l'utillisateur a le droit de se connecter (login et pwd)
        /// </summary>
        /// <param name="responsable"></param>
        /// <returns>vrai si l'utilisateur a le bon login et pwd</returns>
        public Boolean ControleAuthentification(Responsable responsable)
        {
            if (access.Manager != null)
            {
                string req = "select * from responsable ";
                req += "where login=@login and pwd=SHA2(@pwd, 256);";
                Dictionary<string, object> parameters = new Dictionary<string, object> {
                    { "@login", responsable.Login },
                    { "@pwd", responsable.Pwd }
                };
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req, parameters);
                    if (records != null)
                    {
                        return (records.Count > 0);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("PersonnelAccess.ControleAuthentification catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }
            }
            return false;
        }


        /// <summary>
        /// Récupère et retourne la liste du personnel
        /// </summary>
        /// <returns>liste du personnel</returns>
        public List<Personnel> GetListePersonnel()
        {
            List<Personnel> listePersonnel = new List<Personnel>();
            if (access.Manager != null)
            {
                string req = "select p.idpersonnel as idpersonnel, p.nom as nom, p.prenom as prenom, p.tel as tel, p.mail as mail, s.idservice as idservice, s.nom as service ";
                req += "from personnel p join service s on (p.idservice = s.idservice) ";
                req += "order by nom, prenom;";
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req);
                    if (records != null)
                    {
                        Log.Debug("PersonnelAccess.GetListePersonnel nb records = {0}", records.Count);
                        foreach (Object[] record in records)
                        {
                            Log.Debug("PersonnelAccess.GetListePersonnel Service : id={0} nom={1}", record[5], record[6]);
                            Log.Debug("PersonnelAccess.GetListePersonnel Personnel : id={0} nom={1} prenom={2} tel={3} mail={4} ", record[0], record[1], record[2], record[3], record[4]);
                            Service service = new Service((int)record[5], (string)record[6]);
                            Personnel personnel = new Personnel((int)record[0], (string)record[1], (string)record[2],
                                (string)record[3], (string)record[4], service);
                            listePersonnel.Add(personnel);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("PersonnelAccess.GetListePersonnel catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }
            }
            return listePersonnel;
        }
    }
}
