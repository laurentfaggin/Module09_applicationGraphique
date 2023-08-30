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
    public partial class fPrincipale : Form
    {
        private IDepotClients m_depotClients;
        public fPrincipale(IDepotClients p_depotClients)
        {
            InitializeComponent();
            this.m_depotClients = p_depotClients;
        }

        private void fPrincipale_Load(object sender, EventArgs e)
        {
            Rafraichir();
        }

        private void tbSaisieUtilisateur_TextChanged(object sender, EventArgs e)
        {
            Rafraichir();
        }

        private void bNouveau_Click(object sender, EventArgs e)
        {
            string recherche = tbSaisieUtilisateur.Text;
            fSaisieClient sc = new fSaisieClient();
            DialogResult dr = sc.ShowDialog(this);

            if (dr == DialogResult.OK)
            {
                Client nouveauClient = sc.Result;
                if (sc.Nouveau)
                {
                    m_depotClients.AjouterClient(nouveauClient);
                }
                List<Client> clientsTrouves = this.m_depotClients.RechercherClient(recherche);
            }
        }

        private void lbListeRecherche_DoubleClick(object sender, EventArgs e)
        {
            if(lbListeRecherche.SelectedItem!= null)
            {
                fSaisieClient fs = new fSaisieClient();
                fs.m_client = (Client)lbListeRecherche.SelectedItem;
                DialogResult dr = fs.ShowDialog(this);

                if (dr == DialogResult.OK)
                {
                    Client clientModifie = fs.Result;
                    m_depotClients.ModifierClient(clientModifie);
                    Rafraichir();
                }
            }
        }

        private void Rafraichir()
        {
            lbListeRecherche.Items.Clear();
            lbListeRecherche.Items.AddRange(this.m_depotClients.RechercherClient(tbSaisieUtilisateur.Text).ToArray());
        }


    }
}
