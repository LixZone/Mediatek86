namespace Mediatek86.view
{
    partial class FrmAuthentification
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
            this.labelLogin = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.labelPwd = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(28, 38);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(29, 13);
            this.labelLogin.TabIndex = 18;
            this.labelLogin.Text = "login";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(76, 35);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(183, 20);
            this.txtLogin.TabIndex = 14;
            this.txtLogin.Text = "mediatek";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(108, 99);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(91, 23);
            this.btnConnect.TabIndex = 17;
            this.btnConnect.Text = "se connecter";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // labelPwd
            // 
            this.labelPwd.AutoSize = true;
            this.labelPwd.Location = new System.Drawing.Point(28, 64);
            this.labelPwd.Name = "labelPwd";
            this.labelPwd.Size = new System.Drawing.Size(27, 13);
            this.labelPwd.TabIndex = 15;
            this.labelPwd.Text = "pwd";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(76, 61);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(183, 20);
            this.txtPwd.TabIndex = 16;
            this.txtPwd.Text = "mediatek";
            // 
            // FrmAuthentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 163);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.labelPwd);
            this.Controls.Add(this.txtPwd);
            this.Name = "FrmAuthentification";
            this.Text = "Authentification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label labelPwd;
        private System.Windows.Forms.TextBox txtPwd;
    }
}