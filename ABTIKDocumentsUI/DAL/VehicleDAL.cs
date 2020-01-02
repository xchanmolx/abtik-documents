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
    public class VehicleDAL
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
                string sql = "SELECT * FROM tbl_Vehicle";

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

        #region Insert Vehicle data in Database
        public bool Insert(MotorizedVehicleBLL vehicle)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(UserDAL.myconnstrng);

            try
            {
                string sql = "INSERT INTO tbl_Vehicle (vehicle_no, Motorized_Vehicle, Unit) VALUES (@vehicle_no, @Motorized_Vehicle, @Unit)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@vehicle_no", vehicle.ID);
                cmd.Parameters.AddWithValue("@Motorized_Vehicle", vehicle.MotorizedVehicle);
                cmd.Parameters.AddWithValue("@Unit", vehicle.Unit);

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

        #region Insert GenSet data in Database
        public bool InsertGenSet(GenSetBLL genSet)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(UserDAL.myconnstrng);

            try
            {
                string sql = "INSERT INTO tbl_GenSet (genset_no, Generator_Set, Unit) VALUES (@genset_no, @Generator_Set, @Unit)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@genset_no", genSet.ID);
                cmd.Parameters.AddWithValue("@Generator_Set", null);
                cmd.Parameters.AddWithValue("@Unit", null);

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
        public bool Update(MotorizedVehicleBLL vehicle)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(UserDAL.myconnstrng);

            try
            {
                string sql = "UPDATE tbl_Vehicle SET Motorized_Vehicle=@Motorized_Vehicle, Unit=@Unit WHERE vehicle_no=@vehicle_no";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Motorized_Vehicle", vehicle.MotorizedVehicle);
                cmd.Parameters.AddWithValue("@Unit", vehicle.Unit);
                cmd.Parameters.AddWithValue("@vehicle_no", vehicle.ID);

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
        public bool Delete(MotorizedVehicleBLL vehicle)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(UserDAL.myconnstrng);

            try
            {
                string sql = "DELETE FROM tbl_Vehicle WHERE vehicle_no=@vehicle_no";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@vehicle_no", vehicle.ID);

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
                String sql = "SELECT * FROM tbl_Vehicle WHERE Motorized_Vehicle LIKE '%" + keywords + "%' OR vehicle_no LIKE '%" + keywords + "' ";

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