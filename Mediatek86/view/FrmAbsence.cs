using Mediatek86.controller;
using Mediatek86.model;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Mediatek86.view
{
    /// <summary>
    /// Fenêtre d'affichage des absences du personnel selectionné
    /// </summary>
    public partial class FrmAbsence : Form
    {
        /// <summary>
        /// Controleur de la fenêtre
        /// </summary>
        private FrmAbsencesController controller;
        /// <summary>
        /// Objet pour gérer la liste des absences
        /// </summary>
        private readonly BindingSource bdgAbsences = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des motifs
        /// </summary>
        private readonly BindingSource bdgMotifs = new BindingSource();

        /// <summary>
        /// construction des composants graphiques et appel des autres initialisations
        /// </summary>
        /// /// <param name="personnel">objet contenant les informations du personnel sélectionné</param>
        public FrmAbsence(Personnel personnel)
        {
            InitializeComponent();
            Init(personnel);
        }

        /// <summary>
        /// Initialisations :
        /// Création du controleur et remplissage des listes
        /// </summary>
        /// <param name="personnel">objet contenant les informations du personnel sélectionné</param>
        private void Init(Personnel personnel)
        {
            controller = new FrmAbsencesController();
            RemplirListeAbsences(personnel);
        }

        /// <summary>
        /// Affiche la liste des absences du personnel selectionné
        /// </summary>
        private void RemplirListeAbsences(Personnel personnel)
        {
            List<Absence> listeAbsence = controller.GetListeAbsence(personnel);
            bdgAbsences.DataSource = listeAbsence;
            dgvAbsences.DataSource = bdgAbsences;
            dgvAbsences.Columns["idpersonnel"].Visible = false;
            dgvAbsences.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}
