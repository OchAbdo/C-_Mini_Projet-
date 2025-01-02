using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL_P.Model;

namespace DAL
{
    public class ChienDAO
    {
        public void AjoutChienM(string nom, string genre, int age, double poids, double taille, string etatSante, string race, string ed)
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=" + DataBase.dbPath + ";Version=3;");
            cnx.Open();

            string sqlInsert = "INSERT INTO Chien(Nom, Genre, Age, Poids, Taille, EtatSante, Race , EstDresse) VALUES ('" + nom + "','" + genre + "','" + age + "','" + poids + "','" + taille + "','" + etatSante + "','" + race + "','" + ed + "');";
            SQLiteCommand cmd1 = new SQLiteCommand(sqlInsert, cnx);
            cmd1.ExecuteNonQuery();
            cnx.Close();
        }

        public List<Chien> AfficheChien()
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=" + DataBase.dbPath + ";Version=3;");
            cnx.Open();

            string sqlSelect = "SELECT * FROM Chien";
            SQLiteCommand cmd1 = new SQLiteCommand(sqlSelect, cnx);

            SQLiteDataReader dr = cmd1.ExecuteReader();

            List<Chien> l = new List<Chien>();

            while (dr.Read())
            {
                l.Add(new Chien(dr.GetString(0), dr.GetString(1), dr.GetInt32(2), dr.GetDouble(3), dr.GetDouble(4), dr.GetString(5), dr.GetString(6), dr.GetString(7)));
            }

            cnx.Close();

            return l;
        }

        public void SupprimeChien(Chien chien)
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=" + DataBase.dbPath + ";Version=3;");
            cnx.Open();

            string sqldelete = "DELETE FROM Chien WHERE Nom='" + chien.Nom + "'AND Genre='" + chien.Genre + "' AND Age='" + chien.Age + "' AND Poids='" + chien.Poids + "'AND Taille='" + chien.Taille + "'AND  EtatSante='" + chien.EtatSante + "'AND Race='" + chien.Race + "' AND EstDresse='" + chien.EstDresse + "';";
            SQLiteCommand cmd1 = new SQLiteCommand(sqldelete, cnx);
            cmd1.ExecuteNonQuery();
            cnx.Close();

        }


    }
}
