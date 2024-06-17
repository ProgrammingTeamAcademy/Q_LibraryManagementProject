using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementDataBaseLayer
{
    public static class clsDataBaseSettings
    {
        public static string ConnectionString = "Server = 26.201.28.86,1433;Database = Q_LibraryManagment; User Id = bash; Password = OFTzWGwKidMcLZ[E";
    }


    public class clsAdminDataAccess
    {
        public static bool IsExist(string UserName)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataBaseSettings.ConnectionString);

            string query = "select ID from admins where username = @UserName";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();

                if (Result != null)
                {
                    isFound = true;
                }

            }
            catch { }
            finally { connection.Close(); }

            return isFound;
        }

        public static bool CheckLogin(string UserName, string Password)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataBaseSettings.ConnectionString);

            string query = "select ID from admins where username = @UserName and password = @Password";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();

                if (Result != null)
                {
                    IsFound = true;
                }


            }
            catch { }
            finally { connection.Close(); }

            return IsFound;
        }

        public static bool GetAdminObjectByUserNameAndPassword(string UserName, string Password, ref int ID, ref string FullName, ref int AdminLevel)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataBaseSettings.ConnectionString);

            string query = "select ID, full_name, admin_level from admins where username = @UserName and password = @Password";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName",UserName);
            command.Parameters.AddWithValue("@Password",Password);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    ID = (int)reader["ID"];
                    FullName = (string)reader["full_name"];
                    AdminLevel = (int)reader["admin_level"];
                }

                reader.Close();

            }
            catch {}
            finally { connection.Close(); }

            return isFound;

        }

        public static DataTable GetAdminsList()
        {
            DataTable AdminsDT = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataBaseSettings.ConnectionString);

            string query = "select * from admins";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    AdminsDT.Load(reader);
                }


            }
            catch { }
            finally { connection.Close(); }

            return AdminsDT;

        }





    }

    public class clsCustomerDataAccess
    {
        
    }


    public class clsBookDataAccess
    {

    }

}
