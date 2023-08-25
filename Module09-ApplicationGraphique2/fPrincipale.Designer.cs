namespace Module09_ApplicationGraphique2
{
    partial class fPrincipale
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbSaisieUtilisateur = new System.Windows.Forms.TextBox();
            this.bNouveau = new System.Windows.Forms.Button();
            this.lbListeRecherche = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recherche clients:";
            // 
            // tbSaisieUtilisateur
            // 
            this.tbSaisieUtilisateur.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSaisieUtilisateur.Location = new System.Drawing.Point(156, 14);
            this.tbSaisieUtilisateur.Name = "tbSaisieUtilisateur";
            this.tbSaisieUtilisateur.Size = new System.Drawing.Size(348, 27);
            this.tbSaisieUtilisateur.TabIndex = 1;
            this.tbSaisieUtilisateur.TextChanged += new System.EventHandler(this.tbSaisieUtilisateur_TextChanged);
            // 
            // bNouveau
            // 
            this.bNouveau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bNouveau.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bNouveau.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bNouveau.Location = new System.Drawing.Point(523, 12);
            this.bNouveau.Name = "bNouveau";
            this.bNouveau.Size = new System.Drawing.Size(116, 27);
            this.bNouveau.TabIndex = 2;
            this.bNouveau.Text = "Nouveau";
            this.bNouveau.UseVisualStyleBackColor = false;
            this.bNouveau.Click += new System.EventHandler(this.bNouveau_Click);
            // 
            // lbListeRecherche
            // 
            this.lbListeRecherche.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbListeRecherche.FormattingEnabled = true;
            this.lbListeRecherche.ItemHeight = 20;
            this.lbListeRecherche.Location = new System.Drawing.Point(24, 66);
            this.lbListeRecherche.Name = "lbListeRecherche";
            this.lbListeRecherche.Size = new System.Drawing.Size(615, 324);
            this.lbListeRecherche.TabIndex = 3;
            this.lbListeRecherche.DoubleClick += new System.EventHandler(this.lbListeRecherche_DoubleClick);
            // 
            // fPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(660, 407);
            this.Controls.Add(this.lbListeRecherche);
            this.Controls.Add(this.bNouveau);
            this.Controls.Add(this.tbSaisieUtilisateur);
            this.Controls.Add(this.label1);
            this.Name = "fPrincipale";
            this.Text = "Gestion des clients";
            this.Load += new System.EventHandler(this.fPrincipale_Load);
            this.TextChanged += new System.EventHandler(this.fPrincipale_TextChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tbSaisieUtilisateur;
        private Button bNouveau;
        private ListBox lbListeRecherche;
    }
}