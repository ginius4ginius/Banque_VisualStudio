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
using System.Data.SqlClient;
using Banque.Controleur;

namespace Banque
{
    public partial class FormulaireClient : Form
    {
        //instanciacion de manager
        Manager manager = new Manager();

        public DataTable table = new DataTable();


        public FormulaireClient()
        {
            InitializeComponent();
        }
        //test git
        private void button1_Click(object sender, EventArgs e)
        {

            manager.modifierAdresse(tb3.Text.ToString(),int.Parse(tb.Text));
            Form1 formulaire = new Form1();
            table = manager.affichage();
            formulaire.dataGd.DataSource = table;
            this.Close();
            formulaire.Show();
        }
    }
}
