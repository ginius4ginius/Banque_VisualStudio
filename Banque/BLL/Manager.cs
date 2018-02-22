using Banque.ihm;
using Banque.metier;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banque.Controleur
{
    class Manager
    {
        public DataTable table = new DataTable();

        public void sauvegarde(List<Compte> lstcpt)
        {
            FileStream stream = new FileStream("data", FileMode.Create);
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(stream, lstcpt);
            stream.Close();
        }

        public void chargement(List<Compte> lstcpt)
        {
            if (File.Exists("data"))
            {
                BinaryFormatter deserializer = new BinaryFormatter();
                FileStream stream = new FileStream("data", FileMode.Open);
                lstcpt = (List<Compte>)deserializer.Deserialize(stream);
                stream.Close();
            }
        }

        public DataTable affichage()
        {
            MysqlDao sql = MysqlDao.getInstance("localhost", "banque", "root", "");
            sql.openConnection();
            table = sql.affichageDonnee(sql.recuperationDonnees());
            sql.FermeturedataReader();
            sql.closeConnection();
            return table;
        }

        public void crediter(double id, double nbr)
        {
            MysqlDao sql = MysqlDao.getInstance("localhost", "banque", "root", "");
            sql.openConnection();
            sql.creditCompte(id, nbr);
            sql.FermeturedataReader();
            table = sql.affichageDonnee(sql.recuperationDonnees());
            sql.FermeturedataReader();
            sql.closeConnection();
        }

        public void debiter(double id, double nbr)
        {
            MysqlDao sql = MysqlDao.getInstance("localhost", "banque", "root", "");
            sql.openConnection();
            sql.debitCompte(id, nbr);
            sql.FermeturedataReader();
            table = sql.affichageDonnee(sql.recuperationDonnees());
            sql.FermeturedataReader();
            sql.closeConnection();
        }

        public void decouvert(double id, double nbr)
        {
            MysqlDao sql = MysqlDao.getInstance("localhost", "banque", "root", "");
            sql.openConnection();
            sql.modificationDecouvert(id, nbr);
            sql.FermeturedataReader();
            table = sql.affichageDonnee(sql.recuperationDonnees());
            sql.FermeturedataReader();
            sql.closeConnection();
        }

        public Client recupClient(int num)
        {
            MysqlDao sql = MysqlDao.getInstance("localhost", "banque", "root", "");
            sql.openConnection();
            Client clt = sql.retourneClient(num);
            sql.FermeturedataReader();
            sql.closeConnection();

            return clt;

        }

        public int retourneIdClient(string nom)
        {
            MysqlDao sql = MysqlDao.getInstance("localhost", "banque", "root", "");
            sql.openConnection();
            int numeroClient = sql.retourneIdClient(nom);
            sql.FermeturedataReader();
            sql.closeConnection();
            return numeroClient;

        }

        public void modifierAdresse(string adresse,int num)
        {
            MysqlDao sql = MysqlDao.getInstance("localhost", "banque", "root", "");
            sql.openConnection();
            sql.modificationAdresse(adresse,num);
            sql.FermeturedataReader();
            sql.closeConnection();


        }
}
}
