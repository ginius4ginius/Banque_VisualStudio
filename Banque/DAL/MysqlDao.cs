using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using Banque.ihm;
using Banque.model;

namespace Banque.metier
{
    public class MysqlDao: Dao
    {
        private static MysqlDao connect = null;
        private MySqlConnection cnx;
        private MySqlCommand cmd;
        private MySqlDataReader dr;
        public DataTable table = new DataTable();
        private static readonly object mylock = new object();

        private MysqlDao(string unProvider, string uneDataBase, string unUid, string unMdp)
        {
            try
            {//server=localhost;user id=root;database=oenologie
                string connString;
                connString = "SERVER=" + unProvider + ";" + "DATABASE=" +
                uneDataBase + ";" + "UID=" + unUid + ";" + "PASSWORD=" + unMdp + ";";
                try
                {
                    cnx = new MySqlConnection(connString);
                }
                catch (Exception emp)
                {
                    throw (emp);
                }
            }
            catch (Exception emp)
            {
                throw (emp);
            }
        }

        public static MysqlDao getInstance(string unProvider, string uneDataBase, string unUid, string unMdp)
        {

            lock ((mylock))
            {

                try
                {
                    if (null == connect)
                    { // Premier appel
                        connect = new MysqlDao(unProvider, uneDataBase, unUid, unMdp);
                    }
                }
                catch (Exception emp)
                {
                    throw (emp);
                }
                return connect;

            }
        }

        public void openConnection()
        {
            try
            {
                cnx.Open();
            }
            catch (Exception emp)
            {
                throw (emp);
            }
        }

        public void closeConnection()
        {
            cnx.Close();
        }


        //

        public MySqlCommand reqExec(string req)
        {
            cmd = new MySqlCommand(req, this.cnx);
            return cmd;
        }

        public MySqlDataReader recuperationDonnees()
        {
            try
            {
                
                //construction de la commande sql
                cmd = connect.reqExec("select compte.num as numero_compte, solde, decouvert, nom  from compte join client on client.num = compte.proprio ");
                dr = cmd.ExecuteReader();


            }catch (Exception ex)
                {
                MessageBox.Show(ex.Message);
                }

            return dr;
        }

        public DataTable affichageDonnee(MySqlDataReader dr)
        {
            table = new DataTable();

            for (int i = 0; i <= dr.FieldCount - 1; i++)
            {
                
                table.Columns.Add(dr.GetName(i));

            }

            while (dr.Read())
            {

                DataRow ligne = table.NewRow();

                for (int i = 0; i < dr.FieldCount; i++)
                {
                    ligne[i] = dr.GetValue(i);
                }

                table.Rows.Add(ligne);

            }

            return table;
        }

        public void FermeturedataReader()
        {
            this.dr.Close();
        }

        public void modificationAdresse()
        {
            throw new NotImplementedException();
        }

        public void modificationDecouvert(double id, double nbr)
        {
            try
            {

                //construction de la commande sql

                string req = "update compte set decouvert = " + nbr + " where num = " + id + "";

                //MessageBox.Show(req);
                cmd = connect.reqExec(req);
                dr = cmd.ExecuteReader();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void debitCompte(double id, double nbr)
        {
            
            try
            {

                //construction de la commande sql

                string req = "update compte set solde = " + nbr + " where num = " + id + "";

                //MessageBox.Show(req);
                cmd = connect.reqExec(req);
                dr = cmd.ExecuteReader();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void creditCompte(double id, double nbr)
        {
            try
            {

                //construction de la commande sql

                string req = "update compte set solde = " + nbr + " where num = " + id + "";

                //MessageBox.Show(req);
                cmd = connect.reqExec(req);
                dr = cmd.ExecuteReader();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public Client retourneClient(int nbr)
        {
            string req = "select * from client where num =" + nbr + "";
            
            cmd = connect.reqExec(req);
            dr = cmd.ExecuteReader();
            dr.Read();

            Client clt = new Client(Convert.ToUInt16(dr.GetValue(0)), Convert.ToString(dr.GetValue(1)), Convert.ToString(dr.GetValue(2)), Convert.ToString(dr.GetValue(3)));
            return clt;

        }

        public int retourneIdClient(string nom)
        {
            string req = "select * from client where nom ='"+ nom +"'";

            cmd = connect.reqExec(req);
            dr = cmd.ExecuteReader();
            dr.Read();
            int numeroClient = Convert.ToInt16(dr.GetValue(0).ToString());
            return numeroClient;
        }

    }

}
