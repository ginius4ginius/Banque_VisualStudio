using Banque.ihm;
using Banque.metier;
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
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Banque.Controleur;

namespace Banque
{
    

    public partial class Form1 : Form
    {
        //instanciation de Manager.
        Manager manager = new Manager();

        List<Compte> lstcpt = new List<Compte>();
        List<Client> lstclt = new List<Client>();
        public DataTable table = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void créditerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label.Text = "Créditer : ";
            bt.Text = "Valider le crédit";
        }

        

        private void DebiterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label.Text = "Débiter : ";
            bt.Text = "Valider le débit";
        }

        private void DecouvertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label.Text = "Modification :";
            bt.Text = "Valider le découvert";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //manager.chargement(lstcpt);

            label.Text = "Créditer : ";
            bt.Text = "Valider le crédit";
            tb2.Text = "0";

            table = manager.affichage();
            dataGd.DataSource = table;
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manager.sauvegarde(lstcpt);
            Application.Exit();
            
        }

        private void bt_Click(object sender, EventArgs e)
        {
            try {

                if (tb.Text.Length == 0)//gestion de l'exception empty
                    {
                        throw new EmptyException("attention, votre textbox est vide !");
                    }

                double nombre;
                    if (!double.TryParse(tb.Text,out nombre))//gestion de l'exception type
                    {
                        throw new  TypeException("attention, mauvais type !");
                    }

                //

                if (double.Parse(tb.Text) <=0 && bt.Text != "Valider le découvert")//gestion de l'exception negatif
                    {
                        throw new TypeException("attention, le montant doit être supérieur à 0 €");
                    }

                if (double.Parse(tb.Text) < 0 && bt.Text == "Valider le découvert")//gestion de l'exception negatif
                    {
                        throw new TypeException("attention, le montant doit être égale à 0€ ou positif");
                    }

                //

                
                
                if (bt.Text.Equals("Valider le crédit"))
                    {
                    double soldeFinal = Convert.ToDouble(dataGd.CurrentRow.Cells[1].Value) + Double.Parse(tb.Text);
                    manager.crediter(Convert.ToDouble(dataGd.CurrentRow.Cells[0].Value), soldeFinal);
                    table = manager.affichage();
                    dataGd.DataSource = table;
                    tb.Clear();

                }
               
                 if (bt.Text == "Valider le débit")
                    {
                    double decouvertAutorise = (Convert.ToDouble(dataGd.CurrentRow.Cells[2].Value));
                    if (Convert.ToDouble(dataGd.CurrentRow.Cells[1].Value) - Double.Parse(tb.Text) < -decouvertAutorise)

                    {
                        MessageBox.Show("Erreur: découvert non autorisé.");
                        tb.Clear();
                    }
                    else { 
                     double soldeFinal = Convert.ToDouble(dataGd.CurrentRow.Cells[1].Value) - Double.Parse(tb.Text);
                     manager.debiter(Convert.ToDouble(dataGd.CurrentRow.Cells[0].Value), soldeFinal);
                     table = manager.affichage();
                     dataGd.DataSource = table;
                     tb.Clear();
                    }
                }

                  if (bt.Text == "Valider le découvert")
                    {
                    if (Double.Parse(tb.Text) < 0)
                    {
                        MessageBox.Show("Erreur: le montant ne doit pas être inférieur à 0.");
                        tb.Clear();
                    }
                    else {
                        double decouvertTotal = Double.Parse(tb.Text);
                        manager.decouvert(Convert.ToDouble(dataGd.CurrentRow.Cells[0].Value), decouvertTotal);
                        table = manager.affichage();
                        dataGd.DataSource = table;
                        tb.Clear();
                    }
                    
                 }
            }

            catch (EmptyException ex)
            {
                MessageBox.Show("erreur : " + ex.Message);
            }

            catch (TypeException ex)
            {
                MessageBox.Show("erreur : " + ex.Message);
            }
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            string proprioNom = dataGd.CurrentRow.Cells[3].Value.ToString();
            int proprioNum = manager.retourneIdClient(proprioNom);

            Client clt = manager.recupClient(proprioNum);

            FormulaireClient formulaire = new FormulaireClient();

            formulaire.tb1.Text = clt.Nom;
            formulaire.tb2.Text = clt.Prenom;
            formulaire.tb3.Text = clt.Adresse;

            formulaire.ShowDialog(this);

        }
    }
}