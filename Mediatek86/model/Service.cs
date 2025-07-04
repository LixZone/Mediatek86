﻿namespace Mediatek86.model
{
    /// <summary>
    /// Classe Model de Service
    /// </summary>
    public class Service
    {
        /// <summary>
        /// propriété idservice du service
        /// </summary>
        public int Idservice { get; }
        /// <summary>
        /// propriété nom du service
        /// </summary>
        public string Nom { get; }

        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="idservice"></param>
        /// <param name="nom"></param>
        public Service(int idservice, string nom)
        {
            this.Idservice = idservice;
            this.Nom = nom;
        }

        /// <summary>
        /// Définit l'information à afficher (juste le nom)
        /// </summary>
        /// <returns>nom du profil</returns>
        public override string ToString()
        {
            return this.Nom;
        }
    }
}
