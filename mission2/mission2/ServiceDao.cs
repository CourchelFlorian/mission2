using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace mission2
{
    class ServiceDao
    {
        public DataGridView listerServices(DataGridView pTableau)
        {
            Form1 Application = new Form1();
            string connStr = "Data Source = WIN-921C8FKTGAE; Initial Catalog=m2lCK ;User ID=sio2slam;Password=";

            SqlConnection maConnexion; //déclaration d’un objet Command
            SqlCommand maCommande;
            string sqlStr = "SELECT Adherant.nom, TypeService.libelle, Service.quantiteService, TypeService.prix, Etat.libelle AS libelleEtat, Service.date FROM Adherant INNER JOIN Service ON Adherant.numero = Service.numAdherant INNER JOIN Etat ON Service.numEtat = Etat.numero INNER JOIN TypeService ON Service.numType = TypeService.numero";

            try
            {
                maConnexion = new SqlConnection();
                maConnexion.ConnectionString = connStr;
                maConnexion.Open(); maCommande = new SqlCommand(sqlStr, maConnexion);
                maCommande.CommandType = CommandType.Text;
                SqlDataReader unJeuResultat = maCommande.ExecuteReader();
                while (unJeuResultat.Read())
                {
                    pTableau.Rows.Add((String)unJeuResultat["nom"], (String)unJeuResultat["libelle"], (Int32)unJeuResultat["quantiteService"], (Double)unJeuResultat["prix"], (String)unJeuResultat["libelleEtat"], (DateTime)unJeuResultat["Date"]); 
                }

            }

            catch (Exception e)
            {

            }
            return (pTableau);
        }
    }
}
