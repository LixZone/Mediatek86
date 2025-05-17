namespace Mediatek86.view
{
    partial class FrmAbsence
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
            this.grbAbsence = new System.Windows.Forms.GroupBox();
            this.dateDebut = new System.Windows.Forms.DateTimePicker();
            this.dateFin = new System.Windows.Forms.DateTimePicker();
            this.btnAddMotif = new System.Windows.Forms.Button();
            this.btnDelMotif = new System.Windows.Forms.Button();
            this.txtMotif = new System.Windows.Forms.TextBox();
            this.btnAnnulAbsence = new System.Windows.Forms.Button();
            this.btnEnregAbsence = new System.Windows.Forms.Button();
            this.cboMotif = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbListeAbsences = new System.Windows.Forms.GroupBox();
            this.btnDemandeSupprAbsence = new System.Windows.Forms.Button();
            this.btnDemandeAjoutAbsence = new System.Windows.Forms.Button();
            this.dgvAbsences = new System.Windows.Forms.DataGridView();
            this.grbAbsence.SuspendLayout();
            this.grbListeAbsences.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).BeginInit();
            this.SuspendLayout();
            // 
            // grbAbsence
            // 
            this.grbAbsence.Controls.Add(this.dateDebut);
            this.grbAbsence.Controls.Add(this.dateFin);
            this.grbAbsence.Controls.Add(this.btnAddMotif);
            this.grbAbsence.Controls.Add(this.btnDelMotif);
            this.grbAbsence.Controls.Add(this.txtMotif);
            this.grbAbsence.Controls.Add(this.btnAnnulAbsence);
            this.grbAbsence.Controls.Add(this.btnEnregAbsence);
            this.grbAbsence.Controls.Add(this.cboMotif);
            this.grbAbsence.Controls.Add(this.label5);
            this.grbAbsence.Controls.Add(this.label4);
            this.grbAbsence.Controls.Add(this.label1);
            this.grbAbsence.Location = new System.Drawing.Point(12, 350);
            this.grbAbsence.Name = "grbAbsence";
            this.grbAbsence.Size = new System.Drawing.Size(605, 129);
            this.grbAbsence.TabIndex = 10;
            this.grbAbsence.TabStop = false;
            this.grbAbsence.Text = "ajouter une absence";
            // 
            // dateDebut
            // 
            this.dateDebut.Location = new System.Drawing.Point(72, 19);
            this.dateDebut.Name = "dateDebut";
            this.dateDebut.Size = new System.Drawing.Size(200, 20);
            this.dateDebut.TabIndex = 15;
            // 
            // dateFin
            // 
            this.dateFin.Location = new System.Drawing.Point(356, 19);
            this.dateFin.Name = "dateFin";
            this.dateFin.Size = new System.Drawing.Size(200, 20);
            this.dateFin.TabIndex = 14;
            // 
            // btnAddMotif
            // 
            this.btnAddMotif.Location = new System.Drawing.Point(523, 68);
            this.btnAddMotif.Name = "btnAddMotif";
            this.btnAddMotif.Size = new System.Drawing.Size(78, 23);
            this.btnAddMotif.TabIndex = 13;
            this.btnAddMotif.Text = "ajouter";
            this.btnAddMotif.UseVisualStyleBackColor = true;
            this.btnAddMotif.Click += new System.EventHandler(this.BtnAddMotif_Click);
            // 
            // btnDelMotif
            // 
            this.btnDelMotif.Location = new System.Drawing.Point(523, 43);
            this.btnDelMotif.Name = "btnDelMotif";
            this.btnDelMotif.Size = new System.Drawing.Size(78, 23);
            this.btnDelMotif.TabIndex = 12;
            this.btnDelMotif.Text = "supprimer";
            this.btnDelMotif.UseVisualStyleBackColor = true;
            this.btnDelMotif.Click += new System.EventHandler(this.BtnDelMotif_Click);
            // 
            // txtMotif
            // 
            this.txtMotif.Location = new System.Drawing.Point(357, 70);
            this.txtMotif.Name = "txtMotif";
            this.txtMotif.Size = new System.Drawing.Size(159, 20);
            this.txtMotif.TabIndex = 11;
            // 
            // btnAnnulAbsence
            // 
            this.btnAnnulAbsence.Location = new System.Drawing.Point(87, 98);
            this.btnAnnulAbsence.Name = "btnAnnulAbsence";
            this.btnAnnulAbsence.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulAbsence.TabIndex = 10;
            this.btnAnnulAbsence.Text = "annuler";
            this.btnAnnulAbsence.UseVisualStyleBackColor = true;
            this.btnAnnulAbsence.Click += new System.EventHandler(this.BtnAnnulAbsence_Click);
            // 
            // btnEnregAbsence
            // 
            this.btnEnregAbsence.Location = new System.Drawing.Point(6, 98);
            this.btnEnregAbsence.Name = "btnEnregAbsence";
            this.btnEnregAbsence.Size = new System.Drawing.Size(75, 23);
            this.btnEnregAbsence.TabIndex = 9;
            this.btnEnregAbsence.Text = "enregistrer";
            this.btnEnregAbsence.UseVisualStyleBackColor = true;
            this.btnEnregAbsence.Click += new System.EventHandler(this.BtnEnregAbsence_Click);
            // 
            // cboMotif
            // 
            this.cboMotif.FormattingEnabled = true;
            this.cboMotif.Location = new System.Drawing.Point(356, 45);
            this.cboMotif.Name = "cboMotif";
            this.cboMotif.Size = new System.Drawing.Size(161, 21);
            this.cboMotif.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "motif";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "dateFin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "dateDebut";
            // 
            // grbListeAbsences
            // 
            this.grbListeAbsences.Controls.Add(this.btnDemandeSupprAbsence);
            this.grbListeAbsences.Controls.Add(this.btnDemandeAjoutAbsence);
            this.grbListeAbsences.Controls.Add(this.dgvAbsences);
            this.grbListeAbsences.Location = new System.Drawing.Point(12, 12);
            this.grbListeAbsences.Name = "grbListeAbsences";
            this.grbListeAbsences.Size = new System.Drawing.Size(605, 332);
            this.grbListeAbsences.TabIndex = 9;
            this.grbListeAbsences.TabStop = false;
            this.grbListeAbsences.Text = "Liste des absences";
            // 
            // btnDemandeSupprAbsence
            // 
            this.btnDemandeSupprAbsence.Location = new System.Drawing.Point(87, 300);
            this.btnDemandeSupprAbsence.Name = "btnDemandeSupprAbsence";
            this.btnDemandeSupprAbsence.Size = new System.Drawing.Size(75, 23);
            this.btnDemandeSupprAbsence.TabIndex = 2;
            this.btnDemandeSupprAbsence.Text = "supprimer";
            this.btnDemandeSupprAbsence.UseVisualStyleBackColor = true;
            this.btnDemandeSupprAbsence.Click += new System.EventHandler(this.BtnDemandeSupprAbsence_Click);
            // 
            // btnDemandeAjoutAbsence
            // 
            this.btnDemandeAjoutAbsence.Location = new System.Drawing.Point(6, 300);
            this.btnDemandeAjoutAbsence.Name = "btnDemandeAjoutAbsence";
            this.btnDemandeAjoutAbsence.Size = new System.Drawing.Size(75, 23);
            this.btnDemandeAjoutAbsence.TabIndex = 1;
            this.btnDemandeAjoutAbsence.Text = "modifier";
            this.btnDemandeAjoutAbsence.UseVisualStyleBackColor = true;
            this.btnDemandeAjoutAbsence.Click += new System.EventHandler(this.BtnDemandeModifAbsence_Click);
            // 
            // dgvAbsences
            // 
            this.dgvAbsences.AllowUserToAddRows = false;
            this.dgvAbsences.AllowUserToDeleteRows = false;
            this.dgvAbsences.AllowUserToResizeRows = false;
            this.dgvAbsences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsences.Location = new System.Drawing.Point(6, 19);
            this.dgvAbsences.MultiSelect = false;
            this.dgvAbsences.Name = "dgvAbsences";
            this.dgvAbsences.ReadOnly = true;
            this.dgvAbsences.RowHeadersVisible = false;
            this.dgvAbsences.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvAbsences.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAbsences.Size = new System.Drawing.Size(581, 275);
            this.dgvAbsences.TabIndex = 0;
            // 
            // FrmAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 509);
            this.Controls.Add(this.grbAbsence);
            this.Controls.Add(this.grbListeAbsences);
            this.Name = "FrmAbsence";
            this.Text = "Absences";
            this.grbAbsence.ResumeLayout(false);
            this.grbAbsence.PerformLayout();
            this.grbListeAbsences.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAbsence;
        private System.Windows.Forms.Button btnAddMotif;
        private System.Windows.Forms.Button btnDelMotif;
        private System.Windows.Forms.TextBox txtMotif;
        private System.Windows.Forms.Button btnAnnulAbsence;
        private System.Windows.Forms.Button btnEnregAbsence;
        private System.Windows.Forms.ComboBox cboMotif;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbListeAbsences;
        private System.Windows.Forms.Button btnDemandeAjoutAbsence;
        private System.Windows.Forms.DataGridView dgvAbsences;
        private System.Windows.Forms.DateTimePicker dateDebut;
        private System.Windows.Forms.DateTimePicker dateFin;
        private System.Windows.Forms.Button btnDemandeSupprAbsence;
    }
}