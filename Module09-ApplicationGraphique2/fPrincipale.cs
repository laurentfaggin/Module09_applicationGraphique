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
        
    }
}
