using ClassLibraryDomainePersistance;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPersistanceSQLServer
{
    public class PersistanceFournisseur : IPersistanceFournisseur
    {
        SqlConnection sqlConnection;

        public PersistanceFournisseur(string _connectionString)
        {
            sqlConnection = new SqlConnection();

            sqlConnection.ConnectionString = _connectionString;

        }

        public void Open()
        {
            sqlConnection.Open();
        }

        public void Close()
        {
            sqlConnection.Close();
        }

        public bool IsOpen()
        {
            return sqlConnection != null && sqlConnection.State == ConnectionState.Open;
        }

        public int InsertFournisseur(sFournisseur fournisseur)
        {

            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }

            SqlParameter idOutParameter = null;

            try
            {
                SqlCommand sqlCommand = new SqlCommand("AjoutFournisseur", sqlConnection);

                sqlCommand.CommandType = CommandType.StoredProcedure;

                idOutParameter = new SqlParameter("@idFournisseur", SqlDbType.Int);
                idOutParameter.Direction = ParameterDirection.Output;
                sqlCommand.Parameters.Add(idOutParameter);

                sqlCommand.Parameters.Add(new SqlParameter("@nomFournisseur", fournisseur.nom));
                sqlCommand.Parameters.Add(new SqlParameter("@adresseFournisseur", fournisseur.adresse));
                sqlCommand.Parameters.Add(new SqlParameter("@cpFournisseur", fournisseur.cp));
                sqlCommand.Parameters.Add(new SqlParameter("@villeFournisseur", fournisseur.ville));
                sqlCommand.Parameters.Add(new SqlParameter("@contactFournisseur", fournisseur.contact));
                sqlCommand.Parameters.Add(new SqlParameter("@satisfactionFournisseur", fournisseur.satisfaction));

                if (sqlCommand.ExecuteNonQuery() == 1)
                {
                    //   Trace.TraceInformation($"{DateTime.Now} Création du fournisseur {fournisseur.nom}");
                }
                else
                {
                    // Trace.TraceError($"{DateTime.Now} Execution échouée de la création du fournisseur {fournisseur.nom}");
                }

            }
            catch (Exception e)
            {

                // Trace.TraceError($"{DateTime.Now} Execution échouée de la création d'un fournisseur {e.Message}");
            }

            //  Trace.Flush();

            if (sqlConnection.State != ConnectionState.Closed)
            {
                sqlConnection.Close();
            }

            return (int)idOutParameter.Value;

        }

        public bool UpdateFournisseur(sFournisseur fournisseur)
        {
            bool ok = false;

            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }

            try
            {
                SqlCommand sqlCommand = new SqlCommand("UpdateFournisseur", sqlConnection);

                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.Add(new SqlParameter("@idFournisseur", fournisseur.id));
                sqlCommand.Parameters.Add(new SqlParameter("@nomFournisseur", fournisseur.nom));
                sqlCommand.Parameters.Add(new SqlParameter("@adresseFournisseur", fournisseur.adresse));
                sqlCommand.Parameters.Add(new SqlParameter("@cpFournisseur", fournisseur.cp));
                sqlCommand.Parameters.Add(new SqlParameter("@villeFournisseur", fournisseur.ville));
                sqlCommand.Parameters.Add(new SqlParameter("@contactFournisseur", fournisseur.contact));
                sqlCommand.Parameters.Add(new SqlParameter("@satisfactionFournisseur", fournisseur.satisfaction));

                int nbLigneAffecte = sqlCommand.ExecuteNonQuery();
                if (nbLigneAffecte == 1)
                {
                    ok = true;
                }

                // Trace.TraceInformation($"{DateTime.Now} Mise à jour du fournisseur {fournisseur.nom}");
            }
            catch (Exception e)
            {
                //  Trace.TraceError($"{DateTime.Now} Execution échouée de la mise à jour du fournisseur {fournisseur.nom} {e.Message}");
            }

            if (sqlConnection.State != System.Data.ConnectionState.Closed)
            {
                sqlConnection.Close();
            }

            //  Trace.Flush();

            return ok;
        }
        public bool DeleteFournisseur(sFournisseur fournisseur)
        {
            bool ok = false;

            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }

            try
            {
                SqlCommand sqlCommand = new SqlCommand("DeleteFournisseur", sqlConnection);

                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.Add(new SqlParameter("@idFournisseur", fournisseur.id));

                if (sqlCommand.ExecuteNonQuery() == 1)
                {
                    ok = true;
                    //  Trace.TraceInformation($"{DateTime.Now} Suppression du fournisseur {fournisseur.nom}");
                }

            }
            catch (Exception e)
            {
                // Trace.TraceError($"{DateTime.Now} Execution échouée de la supression du fournisseur {fournisseur.nom} {e.Message}");
            }

            // Trace.Flush();

            if (sqlConnection.State != ConnectionState.Closed)
            {
                sqlConnection.Close();
            }
            return ok;
        }

        public sFournisseur GetFournisseur(int id)
        {
            sFournisseur fournisseur = new sFournisseur
            {
                id = -1
            };

            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }

            try
            {
                SqlCommand sqlCommand = new SqlCommand("select * from Fournisseurs where fournisseur_id=@idFournisseur", sqlConnection);

                sqlCommand.CommandType = CommandType.Text;

                sqlCommand.Parameters.Add(new SqlParameter("@idFournisseur", id));

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                bool ok = false;
                if (sqlDataReader.Read() && ((int)sqlDataReader["fournisseur_id"]).Equals(id))
                {
                    int idFournisseur = (int)sqlDataReader["fournisseur_id"];
                    string nomFournisseur = sqlDataReader["fournisseur_nom"].ToString();
                    string adresseFournisseur = sqlDataReader["fournisseur_adresse"].ToString();
                    string cpFournisseur = sqlDataReader["fournisseur_cp"].ToString();
                    string villeFournisseur = sqlDataReader["fournisseur_ville"].ToString();
                    string contactFournisseur = sqlDataReader["fournisseur_contact"].ToString();
                    byte satisfactionFournisseur = Byte.Parse(sqlDataReader["fournisseur_satisfaction"].ToString());

                    fournisseur = new sFournisseur(idFournisseur, nomFournisseur, adresseFournisseur, cpFournisseur, villeFournisseur, contactFournisseur, satisfactionFournisseur);

                    // Trace.TraceInformation($"{DateTime.Now} Accès au fournisseur {fournisseur_id}");

                    ok = true;
                }

                if (!ok)
                {
                    //  Trace.TraceError($"{DateTime.Now} Tentative d'acces à un fournisseur inexistant : {fournisseur_id}");
                }

                sqlDataReader.Close();
            }
            catch (Exception e)
            {
                // Trace.TraceError($"{DateTime.Now} Echec de la tentative d'accès au fournisseur {fournisseur_id} {e.Message}");

            }

            //  Trace.Flush();

            if (sqlConnection.State != ConnectionState.Closed)
            {
                sqlConnection.Close();
            }


            return fournisseur;
        }

        public List<sFournisseur> GetAllFournisseurs()
        {
            List<sFournisseur> listeFournisseurs = new List<sFournisseur>();

            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }

            try
            {
                SqlCommand sqlCommande = new SqlCommand();
                sqlCommande.Connection = sqlConnection;
                string strSql = "select * from fournisseurs";
                sqlCommande.CommandType = CommandType.Text;
                sqlCommande.CommandText = strSql;
                SqlDataReader sqlReader = sqlCommande.ExecuteReader();

                while (sqlReader.Read())
                {
                    sFournisseur sfournisseur = new sFournisseur((int)sqlReader["fournisseur_id"], sqlReader["fournisseur_nom"].ToString(), sqlReader["fournisseur_adresse"].ToString(), sqlReader["fournisseur_cp"].ToString(), sqlReader["fournisseur_ville"].ToString(), sqlReader["fournisseur_contact"].ToString(), (byte)sqlReader["fournisseur_satisfaction"]);
                    listeFournisseurs.Add(sfournisseur);
                }

                sqlReader.Close();

            }
            catch (Exception e)
            {
                // Trace.TraceError($"{DateTime.Now} Echec de la tentative d'accès au fournisseur {fournisseur_id} {e.Message}");
            }

            if (sqlConnection.State != ConnectionState.Closed)
            {
                sqlConnection.Close();
            }

            return listeFournisseurs;
        }
    }
}
