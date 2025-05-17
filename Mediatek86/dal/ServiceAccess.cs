using Serilog;
using System.Collections.Generic;
using System;
using Mediatek86.model;

namespace Mediatek86.dal
{
    /// <summary>
    /// Classe permettant de gérer les demandes concernant les services
    /// </summary>
    public class ServiceAccess
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public ServiceAccess() 
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// Récupère et retourne les services
        /// </summary>
        /// <returns>liste des services</returns>
        public List<Service> GetListeService()
        {
            List<Service> listeService = new List<Service>();
            if (access.Manager != null)
            {
                string req = "select * from service order by nom;";
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req);
                    if (records != null)
                    {
                        Log.Debug("ServiceAccess.GetListeService nb records = {0}", records.Count);
                        foreach (Object[] record in records)
                        {
                            Log.Debug("ServiceAccess.GetListeService id={0} nom={1}", record[0], record[1]);
                            Service service = new Service((int)record[0], (string)record[1]);
                            listeService.Add(service);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("ServiceAccess.GetListeService catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }
            }
            return listeService;
        }

        /// <summary>
        /// Ajout d'un service
        /// </summary>
        /// <param name="service"></param>
        public void AddService(Service service)
        {
            if (access.Manager != null)
            {
                string req = "insert into service (nom) values (@nom);";
                Dictionary<string, object> parameters = new Dictionary<string, object> {
                    { "@nom", service.Nom }
                };
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("ServiceAccess.AddService catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }
            }
        }

        /// <summary>
        /// Suppression d'un service
        /// </summary>
        /// <param name="service"></param>
        public void DelService(Service service)
        {
            if (access.Manager != null)
            {
                string req = "delete from service where idservice = @idservice;";
                Dictionary<string, object> parameters = new Dictionary<string, object> {
                    { "@idservice", service.Idservice }
                };
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("ServiceAccess.DelService catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }
            }
        }
    }
}
