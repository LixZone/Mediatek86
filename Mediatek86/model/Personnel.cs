namespace Mediatek86.model
{
    /// <summary>
    /// Classe Model de Personnel
    /// </summary>
    public class Personnel
    {
        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        /// <param name="service"></param>
        public Personnel(int idpersonnel, string nom, string prenom, string tel, string mail, Service service)
        {
            this.Idpersonnel = idpersonnel;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Tel = tel;
            this.Mail = mail;
            this.Service = service;
        }

        /// <summary>
        /// getter propriété idpersonnel
        /// </summary>
        public int Idpersonnel { get; }
        /// <summary>
        /// getter setter propriété nom
        /// </summary>
        public string Nom { get; set; }
        /// <summary>
        /// getter setter propriété prenom
        /// </summary>
        public string Prenom { get; set; }
        /// <summary>
        /// getter setter propriété tel
        /// </summary>
        public string Tel { get; set; }
        /// <summary>
        /// getter setter propriété mail
        /// </summary>
        public string Mail { get; set; }
        /// <summary>
        /// getter setter propriété objet service
        /// </summary>
        public Service Service { get; set; }
    }
}
