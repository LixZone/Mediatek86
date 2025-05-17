using Mediatek86.controller;
using Mediatek86.model;
using System;
using System.Collections.Generic;
using System.Linq;
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
        /// Booléen pour savoir si une modification est demandée
        /// </summary>
        private Boolean enCoursModifAbsence = false;
        /// <summary>
        /// Objet pour savoir qu'elle est le personnel sélectionné
        /// </summary>
        private Personnel personnel;
        /// <summary>
        /// Titre des fenêtres d'information
        /// </summary>
        private readonly String titreFenetreInformation = "Information";

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
            this.personnel = personnel;
            controller = new FrmAbsencesController();
            RemplirListeAbsences(personnel);
            RemplirListeMotifs();
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

        /// <summary>
        /// Affiche les motifs
        /// </summary>
        private void RemplirListeMotifs()
        {
            List<Motif> listeMotifs = controller.GetListeMotifs();
            bdgMotifs.DataSource = listeMotifs;
            cboMotif.DataSource = bdgMotifs;
        }

        /// <summary>
        ///  Demande de modification d'une absence 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDemandeModifAbsence_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count > 0)
            {
                EnCoursModifAbsence(true);
                Absence absence = (Absence)bdgAbsences.List[bdgAbsences.Position];
                dateDebut.Text = absence.Datedebut.ToString();
                dateFin.Text = absence.Datefin.ToString();
                cboMotif.SelectedIndex = cboMotif.FindStringExact(absence.Motif.Nom);
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", titreFenetreInformation);
            }
        }

        /// <summary>
        /// Demande de suppression d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDemandeSupprAbsence_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count > 0)
            {
                Absence absence = (Absence)bdgAbsences.List[bdgAbsences.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer l'absence du" + absence.Datedebut + " au " + absence.Datefin + " pour " + absence.Motif.Nom + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.DelAbsence(absence);
                    RemplirListeAbsences(this.personnel);
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", titreFenetreInformation);
            }
        }

        /// <summary>
        /// Demande d'enregistrement de l'ajout ou de la modification d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEnregAbsence_Click(object sender, EventArgs e)
        {
            if (!dateDebut.Text.Equals("") && !dateFin.Text.Equals("") && cboMotif.SelectedIndex != -1)
            {
                Motif motif = (Motif)bdgMotifs.List[bdgMotifs.Position];
                if (enCoursModifAbsence)
                {
                    Absence absence = (Absence)bdgAbsences.List[bdgAbsences.Position];
                    if (((List<Absence>)bdgAbsences.DataSource).Any(x => x.Idpersonnel == absence.Idpersonnel && x.Datedebut == dateDebut.Value && x.Datefin == dateFin.Value && x.Motif.Nom == motif.Nom))
                    {
                        MessageBox.Show("Absence déjà présente à cette date dans la liste", "Information");
                    }
                    else
                    {
                        if (dateFin.Value < dateDebut.Value)
                        {
                            MessageBox.Show("La date de fin est antérieure à la date du début", "Alerte");
                        }
                        else if (MessageBox.Show("Voulez-vous vraiment modifier cette absence ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            absence.Datedebut = DateTime.Parse(dateDebut.Text);
                            absence.Datefin = DateTime.Parse(dateFin.Text);
                            absence.Motif = motif;
                            controller.UpdateAbsence(absence);
                        }
                    }
                }
                else
                {
                    Absence absence = new Absence(this.personnel.Idpersonnel, DateTime.Parse(dateDebut.Text), DateTime.Parse(dateFin.Text), motif);
                    if (((List<Absence>)bdgAbsences.DataSource).Any(x => x.Idpersonnel == absence.Idpersonnel && x.Datedebut == absence.Datedebut))
                    {
                        MessageBox.Show("Absence déjà présente à cette date dans la liste", "Information");
                    } else if (dateFin.Value < dateDebut.Value)
                    {
                        MessageBox.Show("La date de fin est antérieure à la date du début", "Alerte");
                    } else
                    {
                        controller.AddAbsence(absence);
                    }
                }
                RemplirListeAbsences(this.personnel);
                EnCoursModifAbsence(false);
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", titreFenetreInformation);
            }
        }

        /// <summary>
        /// Annule la demande d'ajout ou de modification d'une absence
        /// Vide les zones de saisie de l'absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAnnulAbsence_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EnCoursModifAbsence(false);
            }
        }

        /// <summary>
        /// Demande d'ajout d'un motif
        /// à condition qu'il n'existe pas déjà
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddMotif_Click(object sender, EventArgs e)
        {
            string nom = txtMotif.Text.ToString().ToLower();
            if (string.IsNullOrEmpty(nom))
            {
                MessageBox.Show("Saisir un motif", "Information");
            }
            else if (cboMotif.Items.Cast<Motif>().Any(motif => motif.Nom == nom))
            {
                MessageBox.Show("motif déjà présent dans la liste", "Information");
            }
            else
            {
                controller.AddMotif(new Motif(0, nom));
                txtMotif.Text = "";
                RemplirListeMotifs();
            }
        }

        /// <summary>
        /// Demande de suppression d'un motif
        /// et qu'il ne soit pas attribué
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDelMotif_Click(object sender, EventArgs e)
        {
            Motif motif = (Motif)bdgMotifs.List[bdgMotifs.Position];
            List<Motif> listeMotif = controller.GetListeMotifs(); 
            if ((listeMotif).Exists(x => x.Idmotif == motif.Idmotif))
            {
                MessageBox.Show("Le motif " + motif.Nom + " ne peut pas être supprimé car il est utilisé");
            }
            else if (MessageBox.Show("Voulez-vous vraiment supprimer " + motif.Nom + " ?",
                    "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                controller.DelMotif(motif);
                RemplirListeMotifs();
            }
        }

        /// <summary>
        /// Modification d'affichage suivant si on est en cours de modif ou d'ajout d'une absence
        /// </summary>
        /// <param name="modif"></param>
        private void EnCoursModifAbsence(Boolean modif)
        {
            enCoursModifAbsence = modif;
            grbListeAbsences.Enabled = !modif;
            if (modif)
            {
                grbAbsence.Text = "modifier une absence";
            }
            else
            {
                grbAbsence.Text = "ajouter une absence";
                dateDebut.Text = "";
                dateFin.Text = "";
            }
        }
    }
}
