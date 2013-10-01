using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace mission2
{
    class AdherantDao
    {
        public Int32 verifUtilisateur (String pNom, String pMdp)
        {
            Form1 Application = new Form1();
            string connStr = "Data Source = WIN-921C8FKTGAE; Initial Catalog=m2lCK ;User ID=sio2slam;Password=" ;

            SqlConnection maConnexion; //déclaration d’un objet Command
            SqlCommand maCommande;
            string sqlStr = "Select * from Adherant where nom =" + pNom + " And mdp =" + pMdp ;
            Int32 retour = 2;//si erreur

            try
            {
                maConnexion = new SqlConnection ();
                maConnexion.ConnectionString = connStr;
                maConnexion.Open(); maCommande = new SqlCommand (sqlStr, maConnexion );
                maCommande.CommandType = CommandType .Text;
                SqlDataReader unJeuResultat = maCommande.ExecuteReader();
                if (unJeuResultat.Read())
                {
                    retour = (Int32)unJeuResultat["droit"];
                }
                
            }

            catch (Exception e)
            {
                
            }
            return (retour);
        }
    }
}
