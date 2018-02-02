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

namespace Banque
{
    public partial class Form1 : Form
    {

        List<Compte> lstcpt = new List<Compte>();
        List<Client> lstclt = new List<Client>();

        public Form1()
        {
            InitializeComponent();
        }

        private void créditerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label.Text = "Créditer : ";
            bt.Text = "Valider le crédit";
        }

        public void DataLoad()
        {
            lb.DataSource = null;
            lb.DataSource = lstcpt;
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
            label.Text = "Créditer : ";
            bt.Text = "Valider le crédit";
            tb2.Text = "0";

            //création des Clients
            Client clt1 = new Client(1, "Derieu", "Vincent", "3 rue des grands champs");
            Client clt2 = new Client(2, "Leponge", "Bob", "rue de l'ocean ");
            //création des comptes
            Compte c1 = new Compte(100, clt1);
            Compte c2 = new Compte(101, clt1);
            Compte c3 = new Compte(102, clt2);
            
            Compte c4 = new Compte(200, clt1);
            Compte c5 = new Compte(201, clt1);
            Compte c6 = new Compte(202, clt2);
            
            clt1.ajouterCompte(c1);
            clt1.ajouterCompte(c2);
            clt1.ajouterCompte(c3);

            clt2.ajouterCompte(c4);
            clt2.ajouterCompte(c5);
            clt2.ajouterCompte(c6);

            lstcpt.Add(c1);
            lstcpt.Add(c2);
            lstcpt.Add(c3);
            lstcpt.Add(c4);
            lstcpt.Add(c5);
            lstcpt.Add(c6);

            lb.DataSource = lstcpt;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
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

                    Compte cpt = lb.SelectedItem as Compte;

                    cpt.crediter(Double.Parse(tb.Text));
                    DataLoad();
                    tb.Clear();

                }
                if (bt.Text == "Valider le débit")
                {

                    Compte cpt = lb.SelectedItem as Compte;

                    cpt.debiter(Double.Parse(tb.Text));
                    DataLoad();
                    tb.Clear();
                }
            
                if (bt.Text == "Valider le découvert")
                {
                    Compte cpt = lb.SelectedItem as Compte;
                    
                    cpt.setDecouvert(Double.Parse(tb.Text));
                    DataLoad();
                    tb2.Text = cpt.Decouvert.ToString();
                    
                    tb.Clear();
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

            Compte cpt = (Compte)lb.SelectedItem;
            FormulaireClient formulaire = new FormulaireClient();

            formulaire.tb1.Text = cpt.Proprietaire.Nom;
            formulaire.tb2.Text = cpt.Proprietaire.Prenom;
            formulaire.tb3.Text = cpt.Proprietaire.Adresse;

            formulaire.ShowDialog(this);

            /* string nom, prenom, adresse;
             Compte cpt = lb.SelectedItem as Compte;
             Client proprio = cpt.Proprietaire;
             nom = proprio.Nom;
             prenom = proprio.prenom;
             adresse = proprio.Adresse;
             FormulaireClient formulaire = new FormulaireClient(nom,prenom,adresse);
             formulaire.Show();
             this.Visible = false;*/


        }

      
    }
}