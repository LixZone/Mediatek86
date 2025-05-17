namespace Mediatek86.model
{
    /// <summary>
    /// Classe Model de Responsabke
    /// </summary>
    public class Responsable
    {
        /// <summary>
        /// propriété getter login
        /// </summary>
        public string Login { get; }
        /// <summary>
        /// propriété getter pwd
        /// </summary>
        public string Pwd { get; }

        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        public Responsable(string login,  string pwd)
        {
            this.Login = login;
            this.Pwd = pwd;
        }
    }
}
