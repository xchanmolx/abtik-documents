using ABTIKDocumentsUI.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABTIKDocumentsUI.DAL
{
    public class RespondersDAL
    {

        #region Select data from Database
        public DataTable Select()
        {
            // Static method to connect Database
            SqlConnection conn = new SqlConnection(UserDAL.myconnstrng);

            // To hold the data from Database
            DataTable dt = new DataTable();
            try
            {
                // SQL Query to get data from Database
                string sql = "SELECT * FROM tbl_Responders";

                // For executing command
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Getting data from Database
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                // Database connection open
                conn.Open();

                // Fill data in our DataTable
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                // Throw message if any error occurs
                MessageBox.Show(ex.Message, "Select data from Database Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                // Closing connection
                conn.Close();
            }

            // Return the value in DataTable
            return dt;
        }
        #endregion

        #region Insert data in Database
        public bool Insert(RespondersBLL resp)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(UserDAL.myconnstrng);

            try
            {
                string sql = "INSERT INTO tbl_Responders (IDNumber, Name, Address, Contact, Email, Age, Gender, Position, Qualifications, Birthdate, Remarks, PathImage) VALUES (@IDNumber, @Name, @Address, @Contact, @Email, @Age, @Gender, @Position, @Qualifications, @Birthdate, @Remarks, @PathImage)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@IDNumber", resp.IDNumber);
                cmd.Parameters.AddWithValue("@Name", resp.Name);
                cmd.Parameters.AddWithValue("@Address", resp.Address);
                cmd.Parameters.AddWithValue("@Contact", resp.Contact);
                cmd.Parameters.AddWithValue("@Email", resp.Email);
                cmd.Parameters.AddWithValue("@Age", resp.Age);
                cmd.Parameters.AddWithValue("@Gender", resp.Gender);
                cmd.Parameters.AddWithValue("@Position", resp.Position);
                cmd.Parameters.AddWithValue("@Qualifications", resp.Qualifications);
                cmd.Parameters.AddWithValue("@Birthdate", resp.Birthdate);
                cmd.Parameters.AddWithValue("@Remarks", resp.Remarks);
                cmd.Parameters.AddWithValue("@PathImage", @"\Images\Responders\" + resp.PathImage);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                // If the query is executed successfully then the value to rows will be greaten than 0 else it will be less than 0
                if (rows > 0)
                {
                    // Query successful
                    isSuccess = true;
                }
                else
                {
                    // Query failed
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                // Throw message if any error occurs
                MessageBox.Show(ex.Message, "Insert data in Database Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
        #endregion

        #region Update data in Database
        public bool Update(RespondersBLL resp)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(UserDAL.myconnstrng);

            try
            {
                string sql = "UPDATE tbl_Responders SET IDNumber=@IDNumber, Name=@Name, Address=@Address, Contact=@Contact, Email=@Email, Age=@Age, Gender=@Gender, Position=@Position, Qualifications=@Qualifications, Birthdate=@Birthdate, Remarks=@Remarks, PathImage=@PathImage WHERE ID=@ID";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ID", resp.ID);
                cmd.Parameters.AddWithValue("@IDNumber", resp.IDNumber);
                cmd.Parameters.AddWithValue("@Name", resp.Name);
                cmd.Parameters.AddWithValue("@Address", resp.Address);
                cmd.Parameters.AddWithValue("@Contact", resp.Contact);
                cmd.Parameters.AddWithValue("@Email", resp.Email);
                cmd.Parameters.AddWithValue("@Age", resp.Age);
                cmd.Parameters.AddWithValue("@Gender", resp.Gender);
                cmd.Parameters.AddWithValue("@Position", resp.Position);
                cmd.Parameters.AddWithValue("@Qualifications", resp.Qualifications);
                cmd.Parameters.AddWithValue("@Birthdate", resp.Birthdate);
                cmd.Parameters.AddWithValue("@Remarks", resp.Remarks);
                cmd.Parameters.AddWithValue("@PathImage", @"\Images\Responders\" + resp.PathImage);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    // Query successful
                    isSuccess = true;
                }
                else
                {
                    // Query failed
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                // Throw message if any error occurs
                MessageBox.Show(ex.Message, "Update data in Database Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
        #endregion

        #region Delete data from Database
        public bool Delete(RespondersBLL resp)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(UserDAL.myconnstrng);

            try
            {
                string sql = "DELETE FROM tbl_Responders WHERE ID=@ID";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ID", resp.ID);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    // Query successful
                    isSuccess = true;
                }
                else
                {
                    // Query failed
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                // Throw message if any error occurs
                MessageBox.Show(ex.Message, "Delete data from Database Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
        #endregion

        #region Method for Search Functionality
        public DataTable Search(string keywords)
        {
            // SQL connection for database connection
            SqlConnection conn = new SqlConnection(UserDAL.myconnstrng);

            // Creating data table to hold the data from database temporarily
            DataTable dt = new DataTable();

            try
            {
                // SQL Query to Search items from database
                String sql = "SELECT * FROM tbl_Responders WHERE IDNumber LIKE '%" + keywords + "%' OR Name LIKE '%" + keywords + "%' OR Address LIKE '%" + keywords + "%' OR Contact LIKE '%" + keywords + "%' OR Email LIKE '%" + keywords + "%' OR Age LIKE '%" + keywords + "%' OR Gender LIKE '%" + keywords + "%' OR Position LIKE '%" + keywords + "%' OR Qualifications LIKE '%" + keywords + "%' OR Birthdate LIKE '%" + keywords + "%' OR Remarks LIKE '%" + keywords + "%' ";

                // Creating SQL Commant to execute the query
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Getting data from database
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                // Open database connection
                conn.Open();

                // Passing values from adapter to Data Table dt
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }
        #endregion        
    }
}
