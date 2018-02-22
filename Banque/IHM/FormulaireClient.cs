using Banque.ihm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Banque
{
    public partial class FormulaireClient : Form
    {
        public FormulaireClient()
        {
            InitializeComponent();
        }
        //test git
        private void button1_Click(object sender, EventArgs e)
        {
            Compte cpt = (Compte)(this.Owner as Form1).lb.SelectedItem;
            cpt.Proprietaire.Adresse = tb3.Text;
            clt.Nom = tb3.Text;
            (this.Owner as Form1).DataLoad();
            FormulaireClient.ActiveForm.Close();
            
        }
    }
}
