using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppSeguretat
{
    public static class BD
    {
        private static SqlConnection connexio =
            new SqlConnection("Server=localhost\\sqlexpress;Database=seguretat;User Id=sa;Password=cep");


        private static String MissatgeError(SqlException ex)
        {
            String missatge = "";

            switch (ex.Number)
            {
                case 2601:
                case 2627:
                    missatge = "Registre duplicat";
                    break;
                default:
                    missatge = ex.Number + " - " + ex.Message;
                    break;
            }

            return missatge;
        }

        #region Mètodes Rols

        public static String SelectRol(int id)
        {
            SqlCommand sentencia = new SqlCommand();
            SqlDataReader dades;
            String nom;

            sentencia.Connection = connexio;
            sentencia.CommandText =
                "select * from rols where id = @id";
            sentencia.Parameters.Clear();
            sentencia.Parameters.AddWithValue("id", id);

            connexio.Open();
            dades = sentencia.ExecuteReader();
            dades.Read();
            nom = dades["nom"].ToString();
            connexio.Close();

            return nom;
        }

        public static DataTable SelectRols()
        {
            SqlCommand sentencia = new SqlCommand();
            SqlDataReader dades;
            DataTable taula = new DataTable();

            

            sentencia.Connection = connexio;
            sentencia.CommandText =
                "select * from rols";

            try
            {
                connexio.Open();
                dades = sentencia.ExecuteReader();
                taula.Load(dades);
                connexio.Close();
            }
            catch (SqlException ex)
            {

                
            }
           

            return taula;
        }

        public static String InsertRol(String nom)
        {
            String missatge = "";

            SqlCommand sentencia = new SqlCommand();
            DataTable taula = new DataTable();

            sentencia.Connection = connexio;
            sentencia.CommandText =
                "insert into rols values(@nom)";
            sentencia.Parameters.Clear();
            sentencia.Parameters.AddWithValue("nom", nom);

            try
            {
                connexio.Open();
                sentencia.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                missatge = MissatgeError(ex);
            }

            if (connexio.State == ConnectionState.Open)
            {
                connexio.Close();
            }
            
            return missatge;
        }

        public static String DeleteRol(int id)
        {
            String missatge = "";

            SqlCommand sentencia = new SqlCommand();
            DataTable taula = new DataTable();

            sentencia.Connection = connexio;
            sentencia.CommandText =
                "delete from rols where id = @id";
            sentencia.Parameters.Clear();
            sentencia.Parameters.AddWithValue("id", id);

            try
            {
                connexio.Open();
                sentencia.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                missatge = MissatgeError(ex);
            }

            if (connexio.State == ConnectionState.Open)
            {
                connexio.Close();
            }

            return missatge;
        }


        public static String UpdateRol(int id, String nom)
        {
            String missatge = "";

            SqlCommand sentencia = new SqlCommand();
            DataTable taula = new DataTable();

            sentencia.Connection = connexio;
            sentencia.CommandText =
                "update rols set nom = @nom where id = @id";
            sentencia.Parameters.Clear();
            sentencia.Parameters.AddWithValue("id", id);
            sentencia.Parameters.AddWithValue("nom", nom);

            try
            {
                connexio.Open();
                sentencia.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                missatge = MissatgeError(ex);
            }

            if (connexio.State == ConnectionState.Open)
            {
                connexio.Close();
            }

            return missatge;
        }

        #endregion

        #region Mètodes Usuaris

        public static bool SelectUsuari (String correu, String contrasenya)
        {
            SqlCommand sentencia = new SqlCommand();
            SqlDataReader dades;
            DataTable taula = new DataTable();
            bool existeix = false;

            sentencia.Connection = connexio;
            sentencia.CommandText =
                "select * from usuaris where e_mail = @correu and password = @contrasenya";
            sentencia.Parameters.Clear();
            sentencia.Parameters.AddWithValue("correu", correu);
            sentencia.Parameters.AddWithValue("contrasenya", contrasenya);
            

            try
            {
                connexio.Open();
                dades = sentencia.ExecuteReader();
                existeix = dades.HasRows;
                
                
                connexio.Close();
            }
            catch (SqlException ex)
            {
            }

            return existeix;

        }

        public static DataTable SelectUsuaris()
        {
            SqlCommand sentencia = new SqlCommand();
            SqlDataReader dades;
            DataTable taula = new DataTable();

            sentencia.Connection = connexio;
            sentencia.CommandText =
                "select * from usuaris";

            try
            {
                connexio.Open();
                dades = sentencia.ExecuteReader();
                taula.Load(dades);
                connexio.Close();
            }
            catch (SqlException ex)
            {
            }


            return taula;
        }

        public static String InsertUsuari(String nom, String eMail, int idRol, String contrasenya)
        {
            String missatge = "";

            SqlCommand sentencia = new SqlCommand();
            DataTable taula = new DataTable();

            sentencia.Connection = connexio;
            sentencia.CommandText =
                "insert into usuaris values(@nom, @eMail, @contrasenya, @idRol)";
            sentencia.Parameters.Clear();
            sentencia.Parameters.AddWithValue("nom", nom);
            sentencia.Parameters.AddWithValue("eMail", eMail);
            sentencia.Parameters.AddWithValue("contrasenya", contrasenya);
            sentencia.Parameters.AddWithValue("idRol", idRol);

            try
            {
                connexio.Open();
                sentencia.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                missatge = MissatgeError(ex);
            }

            if (connexio.State == ConnectionState.Open)
            {
                connexio.Close();
            }

            return missatge;
        }

        public static String DeleteUsuari(int id)
        {
            String missatge = "";

            SqlCommand sentencia = new SqlCommand();
            DataTable taula = new DataTable();

            sentencia.Connection = connexio;
            sentencia.CommandText =
                "delete from usuaris where id = @id";
            sentencia.Parameters.Clear();
            sentencia.Parameters.AddWithValue("id", id);

            try
            {
                connexio.Open();
                sentencia.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                missatge = MissatgeError(ex);
            }

            if (connexio.State == ConnectionState.Open)
            {
                connexio.Close();
            }

            return missatge;
        }


        public static String UpdateUsuari(int id, String nom, String eMail, int idRol)
        {
            String missatge = "";

            SqlCommand sentencia = new SqlCommand();
            DataTable taula = new DataTable();

            sentencia.Connection = connexio;
            sentencia.CommandText =
                "update usuaris set nom = @nom, e_mail = @eMail, id_rol = @idRol where id = @id";
            sentencia.Parameters.Clear();
            sentencia.Parameters.AddWithValue("id", id);
            sentencia.Parameters.AddWithValue("nom", nom);
            sentencia.Parameters.AddWithValue("eMail", eMail);
            sentencia.Parameters.AddWithValue("idRol", idRol);

            try
            {
                connexio.Open();
                sentencia.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                missatge = MissatgeError(ex);
            }

            if (connexio.State == ConnectionState.Open)
            {
                connexio.Close();
            }

            return missatge;
        }



        #endregion
    }
}
