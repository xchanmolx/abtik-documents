﻿using ABTIKDocumentsUI.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABTIKDocumentsUI.DAL
{
    public class FirstAidKitDAL
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
                string sql = "SELECT * FROM tbl_FirstAid";

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

        #region Insert First Aid Kit data in Database
        public bool Insert(FirstAidKitBLL firstAidKit)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(UserDAL.myconnstrng);

            try
            {
                string sql = "INSERT INTO tbl_FirstAid (firstAid_no, Medical_Kit, Unit) VALUES (@firstAid_no, @Medical_Kit, @Unit)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@firstAid_no", firstAidKit.ID);
                cmd.Parameters.AddWithValue("@Medical_Kit", firstAidKit.MedicalKit);
                cmd.Parameters.AddWithValue("@Unit", firstAidKit.Unit);

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
        public bool Update(FirstAidKitBLL firstAidKit)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(UserDAL.myconnstrng);

            try
            {
                string sql = "UPDATE tbl_FirstAid SET Medical_Kit=@Medical_Kit, Unit=@Unit WHERE firstAid_no=@firstAid_no";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Medical_Kit", firstAidKit.MedicalKit);
                cmd.Parameters.AddWithValue("@Unit", firstAidKit.Unit);
                cmd.Parameters.AddWithValue("@firstAid_no", firstAidKit.ID);

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
        public bool Delete(FirstAidKitBLL firstAidKit)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(UserDAL.myconnstrng);

            try
            {
                string sql = "DELETE FROM tbl_FirstAid WHERE firstAid_no=@firstAid_no";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@firstAid_no", firstAidKit.ID);

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
                String sql = "SELECT * FROM tbl_FirstAid WHERE Medical_Kit LIKE '%" + keywords + "%' OR firstAid_no LIKE '%" + keywords + "' ";

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
