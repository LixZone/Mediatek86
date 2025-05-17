using Mediatek86.controller;
using Mediatek86.model;
using System;
using System.Collections.Generic;
using System.Linq;
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
        /// Objet pour gérer la liste des services
        /// </summary>
        private readonly BindingSource bdgServices = new BindingSource();
        /// <summary>
        /// Titre des fenêtres d'information
        /// </summary>
        private readonly String titreFenetreInformation = "Information";
        /// <summary>
        /// Booléen pour savoir si une modification est demandée
        /// </summary>
        private Boolean enCoursModifPersonnel = false;

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
            RemplirListeService();
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

        /// <summary>
        /// Affiche les services
        /// </summary>
        private void RemplirListeService()
        {
            List<Service> listeService = controller.GetListeService();
            bdgServices.DataSource = listeService;
            cboService.DataSource = bdgServices;
        }

        /// <summary>
        ///  Demande de modification d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDemandeModifPersonnel_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                EnCoursModifPersonnel(true);
                Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                txtNom.Text = personnel.Nom;
                txtPrenom.Text = personnel.Prenom;
                txtTel.Text = personnel.Tel;
                txtMail.Text = personnel.Mail;
                cboService.SelectedIndex = cboService.FindStringExact(personnel.Service.Nom);
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", titreFenetreInformation);
            }
        }

        /// <summary>
        /// Demande de suppression d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDemandeSupprPersonnel_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer " + personnel.Nom + " " + personnel.Prenom + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.DelPersonnel(personnel);
                    RemplirListePersonnel();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", titreFenetreInformation);
            }
        }

        /// <summary>
        /// Annule la demande d'ajout ou de modification d'un personnel
        /// Vide les zones de saisie du personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAnnulPersonnel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EnCoursModifPersonnel(false);
            }
        }

        /// <summary>
        /// Demande d'enregistrement de l'ajout ou de la modification d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEnregPersonnel_Click(object sender, EventArgs e)
        {
            if (!txtNom.Text.Equals("") && !txtPrenom.Text.Equals("") && !txtTel.Text.Equals("") && !txtMail.Text.Equals("") && cboService.SelectedIndex != -1)
            {
                Service service = (Service)bdgServices.List[bdgServices.Position];
                if (enCoursModifPersonnel)
                {
                    Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                    personnel.Nom = txtNom.Text;
                    personnel.Prenom = txtPrenom.Text;
                    personnel.Tel = txtTel.Text;
                    personnel.Mail = txtMail.Text;
                    personnel.Service = service;
                    controller.UpdatePersonnel(personnel);
                }
                else
                {
                    Personnel personnel = new Personnel(0, txtNom.Text, txtPrenom.Text, txtTel.Text, txtMail.Text, service);
                    controller.AddPersonnel(personnel);
                }
                RemplirListePersonnel();
                EnCoursModifPersonnel(false);
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", titreFenetreInformation);
            }
        }

        /// <summary>
        /// Modification d'affichage suivant si on est en cours de modif ou d'ajout d'un personnel
        /// </summary>
        /// <param name="modif"></param>
        private void EnCoursModifPersonnel(Boolean modif)
        {
            enCoursModifPersonnel = modif;
            grbListePersonnel.Enabled = !modif;
            if (modif)
            {
                grbPersonnel.Text = "modifier un employé";
            }
            else
            {
                grbPersonnel.Text = "ajouter un employé";
                txtNom.Text = "";
                txtPrenom.Text = "";
                txtTel.Text = "";
                txtMail.Text = "";
            }
        }


        /// <summary>
        /// Demande d'ajout d'un service
        /// à condition qu'il n'existe pas déjà
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddService_Click(object sender, EventArgs e)
        {
            string nom = txtService.Text.ToString().ToLower();
            if (string.IsNullOrEmpty(nom))
            {
                MessageBox.Show("Saisir un service", "Information");
            }
            else if (cboService.Items.Cast<Service>().Any(service => service.Nom == nom))
            {
                MessageBox.Show("service déjà présent dans la liste", "Information");
            }
            else
            {
                controller.AddService(new Service(0, nom));
                txtService.Text = "";
                RemplirListeService();
            }
        }

        /// <summary>
        /// Demande de suppression d'un service
        /// et qu'il ne soit pas attribué
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDelService_Click(object sender, EventArgs e)
        {
            Service service = (Service)bdgServices.List[bdgServices.Position];
            if (((List<Personnel>)bdgPersonnel.DataSource).Exists(x => x.Service.Idservice == service.Idservice))
            {
                MessageBox.Show("Le service " + service.Nom + " ne peut pas être supprimé car il est utilisé");
            }
            else if (MessageBox.Show("Voulez-vous vraiment supprimer " + service.Nom + " ?",
                    "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                controller.DelService(service);
                RemplirListeService();
            }
        }

        private void BtnAfficherAbsences_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                FrmAbsence frm = new FrmAbsence(personnel);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", titreFenetreInformation);
            }
        }
    }
}
