namespace Module09_ApplicationGraphique2
{
    partial class fSaisieClient
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
            this.lNom = new System.Windows.Forms.Label();
            this.lPrenom = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.bEnregistrer = new System.Windows.Forms.Button();
            this.bAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lNom
            // 
            this.lNom.AutoSize = true;
            this.lNom.Location = new System.Drawing.Point(23, 20);
            this.lNom.Name = "lNom";
            this.lNom.Size = new System.Drawing.Size(45, 20);
            this.lNom.TabIndex = 0;
            this.lNom.Text = "Nom:";
            // 
            // lPrenom
            // 
            this.lPrenom.AutoSize = true;
            this.lPrenom.Location = new System.Drawing.Point(23, 69);
            this.lPrenom.Name = "lPrenom";
            this.lPrenom.Size = new System.Drawing.Size(63, 20);
            this.lPrenom.TabIndex = 1;
            this.lPrenom.Text = "Prenom:";
            // 
            // tbNom
            // 
            this.tbNom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNom.Location = new System.Drawing.Point(112, 20);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(515, 27);
            this.tbNom.TabIndex = 2;
            // 
            // tbPrenom
            // 
            this.tbPrenom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPrenom.Location = new System.Drawing.Point(112, 62);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(515, 27);
            this.tbPrenom.TabIndex = 3;
            // 
            // bEnregistrer
            // 
            this.bEnregistrer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bEnregistrer.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bEnregistrer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bEnregistrer.Location = new System.Drawing.Point(517, 115);
            this.bEnregistrer.Name = "bEnregistrer";
            this.bEnregistrer.Size = new System.Drawing.Size(110, 29);
            this.bEnregistrer.TabIndex = 4;
            this.bEnregistrer.Text = "Enregistrer";
            this.bEnregistrer.UseVisualStyleBackColor = false;
            this.bEnregistrer.Click += new System.EventHandler(this.bEnregistrer_Click);
            // 
            // bAnnuler
            // 
            this.bAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bAnnuler.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bAnnuler.Location = new System.Drawing.Point(388, 115);
            this.bAnnuler.Name = "bAnnuler";
            this.bAnnuler.Size = new System.Drawing.Size(110, 29);
            this.bAnnuler.TabIndex = 5;
            this.bAnnuler.Text = "Annuler";
            this.bAnnuler.UseVisualStyleBackColor = false;
            this.bAnnuler.Click += new System.EventHandler(this.bAnnuler_Click);
            // 
            // fSaisieClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(657, 189);
            this.Controls.Add(this.bAnnuler);
            this.Controls.Add(this.bEnregistrer);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.lPrenom);
            this.Controls.Add(this.lNom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fSaisieClient";
            this.Text = "Saisie d\'un nouveau client";
            this.Load += new System.EventHandler(this.fSaisieClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lNom;
        private Label lPrenom;
        private TextBox tbNom;
        private TextBox tbPrenom;
        private Button bEnregistrer;
        private Button bAnnuler;
    }
}