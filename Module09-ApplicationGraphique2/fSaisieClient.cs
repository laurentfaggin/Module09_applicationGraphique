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
        private Client m_client;
        private bool m_nouveau;
        private Client m_result;

        public Client Client
        {
            get { return m_client; }
            set { m_client = value; }
        }

        public bool Nouveau
        {
            get { return m_nouveau; }
        }

        public Client Result
        {
            get { return m_result; }
        }

        public fSaisieClient()
        {
            InitializeComponent();
        }

        private void bEnregistrer_Click(object sender, EventArgs e)
        {
            if (!Nouveau)
            {
                m_result = Client;
            }
            else
            {
                m_result = new Client(Client.ClientId, Client.Nom, Client.Prenom, Client.Adresses);
            }
        }

        private void bAnnuler_Click(object sender, EventArgs e)
        {
            
        }

        private void fSaisieClient_Load(object sender, EventArgs e)
        {
            if (!Nouveau)
            {
                fSaisieClient.ActiveForm.Text = "Modification d'un client";
                tbNom.Text = m_client.Nom;
                tbPrenom.Text = m_client.Prenom;
            }
            else
            {
                fSaisieClient.ActiveForm.Text = "Saisie d'un nouveau client";
            }
        }
    }
}
