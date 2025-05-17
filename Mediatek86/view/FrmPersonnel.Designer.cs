namespace Mediatek86.view
{
    partial class FrmPersonnel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbPersonnel = new System.Windows.Forms.GroupBox();
            this.btnAddService = new System.Windows.Forms.Button();
            this.btnDelService = new System.Windows.Forms.Button();
            this.txtService = new System.Windows.Forms.TextBox();
            this.btnAnnulPersonnel = new System.Windows.Forms.Button();
            this.btnEnregPersonnel = new System.Windows.Forms.Button();
            this.cboService = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.grbListePersonnel = new System.Windows.Forms.GroupBox();
            this.btnAfficherAbsences = new System.Windows.Forms.Button();
            this.btnDemandeSupprPersonnel = new System.Windows.Forms.Button();
            this.btnDemandeModifPersonnel = new System.Windows.Forms.Button();
            this.dgvPersonnel = new System.Windows.Forms.DataGridView();
            this.grbPersonnel.SuspendLayout();
            this.grbListePersonnel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).BeginInit();
            this.SuspendLayout();
            // 
            // grbPersonnel
            // 
            this.grbPersonnel.Controls.Add(this.btnAddService);
            this.grbPersonnel.Controls.Add(this.btnDelService);
            this.grbPersonnel.Controls.Add(this.txtService);
            this.grbPersonnel.Controls.Add(this.btnAnnulPersonnel);
            this.grbPersonnel.Controls.Add(this.btnEnregPersonnel);
            this.grbPersonnel.Controls.Add(this.cboService);
            this.grbPersonnel.Controls.Add(this.label5);
            this.grbPersonnel.Controls.Add(this.label4);
            this.grbPersonnel.Controls.Add(this.label3);
            this.grbPersonnel.Controls.Add(this.label2);
            this.grbPersonnel.Controls.Add(this.txtMail);
            this.grbPersonnel.Controls.Add(this.txtTel);
            this.grbPersonnel.Controls.Add(this.txtPrenom);
            this.grbPersonnel.Controls.Add(this.label1);
            this.grbPersonnel.Controls.Add(this.txtNom);
            this.grbPersonnel.Location = new System.Drawing.Point(12, 350);
            this.grbPersonnel.Name = "grbPersonnel";
            this.grbPersonnel.Size = new System.Drawing.Size(605, 129);
            this.grbPersonnel.TabIndex = 8;
            this.grbPersonnel.TabStop = false;
            this.grbPersonnel.Text = "ajouter un employé";
            // 
            // btnAddService
            // 
            this.btnAddService.Location = new System.Drawing.Point(521, 94);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(78, 23);
            this.btnAddService.TabIndex = 13;
            this.btnAddService.Text = "ajouter";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.BtnAddService_Click);
            // 
            // btnDelService
            // 
            this.btnDelService.Location = new System.Drawing.Point(521, 69);
            this.btnDelService.Name = "btnDelService";
            this.btnDelService.Size = new System.Drawing.Size(78, 23);
            this.btnDelService.TabIndex = 12;
            this.btnDelService.Text = "supprimer";
            this.btnDelService.UseVisualStyleBackColor = true;
            this.btnDelService.Click += new System.EventHandler(this.BtnDelService_Click);
            // 
            // txtService
            // 
            this.txtService.Location = new System.Drawing.Point(355, 96);
            this.txtService.Name = "txtService";
            this.txtService.Size = new System.Drawing.Size(159, 20);
            this.txtService.TabIndex = 11;
            // 
            // btnAnnulPersonnel
            // 
            this.btnAnnulPersonnel.Location = new System.Drawing.Point(87, 98);
            this.btnAnnulPersonnel.Name = "btnAnnulPersonnel";
            this.btnAnnulPersonnel.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulPersonnel.TabIndex = 10;
            this.btnAnnulPersonnel.Text = "annuler";
            this.btnAnnulPersonnel.UseVisualStyleBackColor = true;
            this.btnAnnulPersonnel.Click += new System.EventHandler(this.BtnAnnulPersonnel_Click);
            // 
            // btnEnregPersonnel
            // 
            this.btnEnregPersonnel.Location = new System.Drawing.Point(6, 98);
            this.btnEnregPersonnel.Name = "btnEnregPersonnel";
            this.btnEnregPersonnel.Size = new System.Drawing.Size(75, 23);
            this.btnEnregPersonnel.TabIndex = 9;
            this.btnEnregPersonnel.Text = "enregistrer";
            this.btnEnregPersonnel.UseVisualStyleBackColor = true;
            this.btnEnregPersonnel.Click += new System.EventHandler(this.BtnEnregPersonnel_Click);
            // 
            // cboService
            // 
            this.cboService.FormattingEnabled = true;
            this.cboService.Location = new System.Drawing.Point(354, 71);
            this.cboService.Name = "cboService";
            this.cboService.Size = new System.Drawing.Size(161, 21);
            this.cboService.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "service";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "tel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "prenom";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(354, 19);
            this.txtMail.MaxLength = 50;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(245, 20);
            this.txtMail.TabIndex = 6;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(354, 45);
            this.txtTel.MaxLength = 15;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(161, 20);
            this.txtTel.TabIndex = 7;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(54, 45);
            this.txtPrenom.MaxLength = 20;
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(245, 20);
            this.txtPrenom.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "nom";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(54, 19);
            this.txtNom.MaxLength = 20;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(245, 20);
            this.txtNom.TabIndex = 3;
            // 
            // grbListePersonnel
            // 
            this.grbListePersonnel.Controls.Add(this.btnAfficherAbsences);
            this.grbListePersonnel.Controls.Add(this.btnDemandeSupprPersonnel);
            this.grbListePersonnel.Controls.Add(this.btnDemandeModifPersonnel);
            this.grbListePersonnel.Controls.Add(this.dgvPersonnel);
            this.grbListePersonnel.Location = new System.Drawing.Point(12, 12);
            this.grbListePersonnel.Name = "grbListePersonnel";
            this.grbListePersonnel.Size = new System.Drawing.Size(605, 332);
            this.grbListePersonnel.TabIndex = 7;
            this.grbListePersonnel.TabStop = false;
            this.grbListePersonnel.Text = "Liste des employés";
            // 
            // btnAfficherAbsences
            // 
            this.btnAfficherAbsences.Location = new System.Drawing.Point(168, 300);
            this.btnAfficherAbsences.Name = "btnAfficherAbsences";
            this.btnAfficherAbsences.Size = new System.Drawing.Size(85, 23);
            this.btnAfficherAbsences.TabIndex = 3;
            this.btnAfficherAbsences.Text = "absences";
            this.btnAfficherAbsences.UseVisualStyleBackColor = true;
            this.btnAfficherAbsences.Click += new System.EventHandler(this.BtnAfficherAbsences_Click);
            // 
            // btnDemandeSupprPersonnel
            // 
            this.btnDemandeSupprPersonnel.Location = new System.Drawing.Point(87, 300);
            this.btnDemandeSupprPersonnel.Name = "btnDemandeSupprPersonnel";
            this.btnDemandeSupprPersonnel.Size = new System.Drawing.Size(75, 23);
            this.btnDemandeSupprPersonnel.TabIndex = 2;
            this.btnDemandeSupprPersonnel.Text = "supprimer";
            this.btnDemandeSupprPersonnel.UseVisualStyleBackColor = true;
            this.btnDemandeSupprPersonnel.Click += new System.EventHandler(this.BtnDemandeSupprPersonnel_Click);
            // 
            // btnDemandeModifPersonnel
            // 
            this.btnDemandeModifPersonnel.Location = new System.Drawing.Point(6, 300);
            this.btnDemandeModifPersonnel.Name = "btnDemandeModifPersonnel";
            this.btnDemandeModifPersonnel.Size = new System.Drawing.Size(75, 23);
            this.btnDemandeModifPersonnel.TabIndex = 1;
            this.btnDemandeModifPersonnel.Text = "modifier";
            this.btnDemandeModifPersonnel.UseVisualStyleBackColor = true;
            this.btnDemandeModifPersonnel.Click += new System.EventHandler(this.BtnDemandeModifPersonnel_Click);
            // 
            // dgvPersonnel
            // 
            this.dgvPersonnel.AllowUserToAddRows = false;
            this.dgvPersonnel.AllowUserToDeleteRows = false;
            this.dgvPersonnel.AllowUserToResizeRows = false;
            this.dgvPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonnel.Location = new System.Drawing.Point(6, 19);
            this.dgvPersonnel.MultiSelect = false;
            this.dgvPersonnel.Name = "dgvPersonnel";
            this.dgvPersonnel.ReadOnly = true;
            this.dgvPersonnel.RowHeadersVisible = false;
            this.dgvPersonnel.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvPersonnel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonnel.Size = new System.Drawing.Size(581, 275);
            this.dgvPersonnel.TabIndex = 0;
            // 
            // FrmPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 522);
            this.Controls.Add(this.grbPersonnel);
            this.Controls.Add(this.grbListePersonnel);
            this.Name = "FrmPersonnel";
            this.Text = "f";
            this.grbPersonnel.ResumeLayout(false);
            this.grbPersonnel.PerformLayout();
            this.grbListePersonnel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbPersonnel;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.Button btnDelService;
        private System.Windows.Forms.TextBox txtService;
        private System.Windows.Forms.Button btnAnnulPersonnel;
        private System.Windows.Forms.Button btnEnregPersonnel;
        private System.Windows.Forms.ComboBox cboService;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.GroupBox grbListePersonnel;
        private System.Windows.Forms.Button btnAfficherAbsences;
        private System.Windows.Forms.Button btnDemandeSupprPersonnel;
        private System.Windows.Forms.Button btnDemandeModifPersonnel;
        private System.Windows.Forms.DataGridView dgvPersonnel;
    }
}