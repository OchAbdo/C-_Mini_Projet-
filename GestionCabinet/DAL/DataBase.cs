using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SQLite;

namespace DAL
{
    public class DataBase
    {
        public static string dbPath = "MyData.sqlite";

        public void CreationDB () 
        {
            SQLiteConnection.CreateFile(dbPath);
            SQLiteConnection cnx = new SQLiteConnection("Data Source="+dbPath+";Version=3;");
            cnx.Open();

            string sqlCreate = "CREATE TABLE Chien (Nom VARCHAR(50), Genre VARCHAR(20), Age INTEGER, Poids REAL, Taille REAL, EtatSante VARCHAR(100), Race VARCHAR(30), EstDresse VARCHAR(30));"
                +" CREATE TABLE Chat (Nom VARCHAR(50), Genre VARCHAR(20), Age INTEGER, Poids REAL, Taille REAL, EtatSante VARCHAR(100), CouleurPelage VARCHAR(30), EstDomestique VARCHAR(30) );";

            SQLiteCommand cmd1 = new SQLiteCommand(sqlCreate , cnx);
            cmd1.ExecuteNonQuery();
            cnx.Close();
        }

        public DataBase() 
        {
            if(!File.Exists(dbPath))
                this.CreationDB();
        }

        public static void Main() { DataBase dataBase = new DataBase();}



    }
}
