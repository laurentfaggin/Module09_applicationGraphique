using GC.ConsoleUI;
using GC.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module09_ApplicationGraphique2
{
    public partial class fSaisieClient : Form
    {
        public Client m_client;
        public bool Nouveau { get { return m_client is null; } }
        public Client Result { get; private set; }

        public Client Client
        {
            get { return m_client; }
            set { m_client = value; }
        }
               

        public fSaisieClient()
        {
            InitializeComponent();
        }

        private void bEnregistrer_Click(object sender, EventArgs e)
        {
            if (Nouveau)
            {
                Result = new Client(Guid.NewGuid(), tbNom.Text, tbPrenom.Text, new List<Adresse>() { GenerateurDonnees.GenererAdresseAleatoire() });
            }
            else
            {
                Result = new Client(m_client.ClientId, tbNom.Text, tbPrenom.Text, new List<Adresse>() { GenerateurDonnees.GenererAdresseAleatoire() });

            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void bAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fSaisieClient_Load(object sender, EventArgs e)
        {
            if (!Nouveau)
            {
                this.Text = "Modification d'un client";
                tbNom.Text = m_client.Nom;
                tbPrenom.Text = m_client.Prenom;
            }
            else
            {
                this.Text = "Saisie d'un nouveau client";
            }
        }
    }
}
