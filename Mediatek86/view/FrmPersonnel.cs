using Mediatek86.controller;
using Mediatek86.model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Mediatek86.view
{
    public partial class FrmPersonnel : Form
    {
        /// <summary>
        /// Controleur de la fenêtre
        /// </summary>
        private FrmPersonnelController controller;
        /// <summary>
        /// Objet pour gérer la liste du personnel
        /// </summary>
        private readonly BindingSource bdgPersonnel = new BindingSource();

        /// <summary>
        /// Fenêtre d'affichage du personnel
        /// </summary>
        public FrmPersonnel()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// Initialisations :
        /// Création du controleur et remplissage des listes
        /// </summary>
        private void Init()
        {
            controller = new FrmPersonnelController();
            RemplirListePersonnel();
        }

        /// <summary>
        /// Affiche la liste du personnel
        /// </summary>
        private void RemplirListePersonnel()
        {
            List<Personnel> listePersonnel = controller.GetListePersonnel();
            bdgPersonnel.DataSource = listePersonnel;
            dgvPersonnel.DataSource = bdgPersonnel;
            dgvPersonnel.Columns["idpersonnel"].Visible = false;
            dgvPersonnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}
