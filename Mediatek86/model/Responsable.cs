﻿namespace Mediatek86.model
{
    public class Responsable
    {
        public string Login { get; }
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
