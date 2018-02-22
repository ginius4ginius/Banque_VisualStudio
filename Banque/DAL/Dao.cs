using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque.model
{
    public interface Dao
    {
        
        MySqlDataReader recuperationDonnees();
        DataTable affichageDonnee(MySqlDataReader dr);
        void modificationAdresse();
        void openConnection();
        void closeConnection();
        void modificationDecouvert(double id, double nbr);
        void debitCompte(double id, double nbr);
        void creditCompte(double id, double nbr);

    }
}
