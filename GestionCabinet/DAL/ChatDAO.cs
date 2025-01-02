using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL_P.Model;


namespace DAL
{
    public class ChatDAO
    {
        
        public void AjoutChatM(string nom, string genre, int age, double poids, double taille, string etatSante, string cp, string ed)
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=" + DataBase.dbPath + ";Version=3;");
            cnx.Open();

            string sqlInsert = "INSERT INTO Chat(Nom, Genre, Age, Poids, Taille, EtatSante, CouleurPelage, EstDomestique) VALUES ('"+nom+"','"+genre+ "','"+age+ "','"+poids+ "','"+taille+ "','"+etatSante+ "','"+cp+ "','"+ed+"');";
            SQLiteCommand cmd1 = new SQLiteCommand(sqlInsert, cnx);
            cmd1.ExecuteNonQuery();
            cnx.Close();
        }

        public List<Chat> AfficheChat() 
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=" + DataBase.dbPath + ";Version=3;");
            cnx.Open();

            string sqlSelect = "SELECT * FROM Chat";
            SQLiteCommand cmd1 = new SQLiteCommand(sqlSelect, cnx);

            SQLiteDataReader dr = cmd1.ExecuteReader();

            List<Chat> l = new List<Chat>();

            while (dr.Read()) 
            {
                l.Add(new Chat(dr.GetString(0) , dr.GetString(1) , dr.GetInt32(2) , dr.GetDouble(3) , dr.GetDouble(4) , dr.GetString(5) , dr.GetString(6) , dr.GetString(7) ));
            }

            cnx.Close();

            return l;
        }

        public void SupprimeChat(Chat chat) 
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=" + DataBase.dbPath + ";Version=3;");
            cnx.Open();

            string sqldelete = "DELETE FROM Chat WHERE Nom='"+chat.Nom+"'AND Genre='"+chat.Genre+"' AND Age='"+chat.Age+"' AND Poids='"+chat.Poids+"'AND Taille='"+chat.Taille+"'AND  EtatSante='"+chat.EtatSante+"'AND CouleurPelage='"+chat.CouleurPelage+"' AND EstDomestique='"+chat.EstDomestique+"';";
            SQLiteCommand cmd1 = new SQLiteCommand(sqldelete, cnx);
            cmd1.ExecuteNonQuery();
            cnx.Close();

        }
    }
}
