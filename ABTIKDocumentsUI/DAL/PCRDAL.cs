using ABTIKDocumentsUI.BLL;
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
    public class PCRDAL
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
                string sql = "SELECT * FROM tbl_PCR";

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
        public bool Insert(PCRBLL pcr)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(UserDAL.myconnstrng);

            try
            {
                string sql = "INSERT INTO tbl_PCR (PatientNumber, Name, Age, Sex, Address, PlaceOfIncident, TypeOfIncident, Date, ChiefComplaints, Oxygen, BloodPressure, RespiratoryRate, Temperature, PulseRate, Pupil, PastMedicalHistory, SAMPLE, PhysicalFindings, Treatment, OtherPersonsInvolved, CallerInformation, MaterialsUsed, TransportedToNameOfHospitalOrResidence, EndorsedTo, EmergencyResponseTeam, AmbulanceBodyNoAndPlateNo, WAIVER) VALUES (@PatientNumber, @Name, @Age, @Sex, @Address, @PlaceOfIncident, @TypeOfIncident, @Date, @ChiefComplaints, @Oxygen, @BloodPressure, @RespiratoryRate, @Temperature, @PulseRate, @Pupil, @PastMedicalHistory, @SAMPLE, @PhysicalFindings, @Treatment, @OtherPersonsInvolved, @CallerInformation, @MaterialsUsed, @TransportedToNameOfHospitalOrResidence, @EndorsedTo, @EmergencyResponseTeam, @AmbulanceBodyNoAndPlateNo, @WAIVER)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@PatientNumber", pcr.PatientNumber);
                cmd.Parameters.AddWithValue("@Name", pcr.Name);
                cmd.Parameters.AddWithValue("@Age", pcr.Age);
                cmd.Parameters.AddWithValue("@Sex", pcr.Sex);
                cmd.Parameters.AddWithValue("@Address", pcr.Address);
                cmd.Parameters.AddWithValue("@PlaceOfIncident", pcr.PlaceOfIncident);
                cmd.Parameters.AddWithValue("@TypeOfIncident", pcr.TypeOfIncident);
                cmd.Parameters.AddWithValue("@Date", pcr.Date);
                cmd.Parameters.AddWithValue("@ChiefComplaints", pcr.ChiefComplaints);
                cmd.Parameters.AddWithValue("@Oxygen", pcr.Oxygen);
                cmd.Parameters.AddWithValue("@BloodPressure", pcr.BloodPressure);
                cmd.Parameters.AddWithValue("@RespiratoryRate", pcr.RespiratoryRate);
                cmd.Parameters.AddWithValue("@Temperature", pcr.Temperature);
                cmd.Parameters.AddWithValue("@PulseRate", pcr.PulseRate);
                cmd.Parameters.AddWithValue("@Pupil", pcr.Pupil);
                cmd.Parameters.AddWithValue("@PastMedicalHistory", pcr.PastMedicalHistory);
                cmd.Parameters.AddWithValue("@SAMPLE", pcr.SAMPLE);
                cmd.Parameters.AddWithValue("@PhysicalFindings", pcr.PhysicalFindings);
                cmd.Parameters.AddWithValue("@Treatment", pcr.Treatment);
                cmd.Parameters.AddWithValue("@OtherPersonsInvolved", pcr.OtherPersonsInvolved);
                cmd.Parameters.AddWithValue("@CallerInformation", pcr.CallerInformation);
                cmd.Parameters.AddWithValue("@MaterialsUsed", pcr.MaterialsUsed);
                cmd.Parameters.AddWithValue("@TransportedToNameOfHospitalOrResidence", pcr.TransportedToNameOfHospitalOrResidence);
                cmd.Parameters.AddWithValue("@EndorsedTo", pcr.EndorsedTo);
                cmd.Parameters.AddWithValue("@EmergencyResponseTeam", pcr.EmergencyResponseTeam);
                cmd.Parameters.AddWithValue("@AmbulanceBodyNoAndPlateNo", pcr.AmbulanceBodyNoAndPlateNo);
                cmd.Parameters.AddWithValue("@WAIVER", pcr.WAIVER);

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
        public bool Update(PCRBLL pcr)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(UserDAL.myconnstrng);

            try
            {
                string sql = "UPDATE tbl_PCR SET PatientNumber=@PatientNumber, Name=@Name, Age=@Age, Sex=@Sex, Address=@Address, PlaceOfIncident=@PlaceOfIncident, TypeOfIncident=@TypeOfIncident, Date=@Date, ChiefComplaints=@ChiefComplaints, Oxygen=@Oxygen, BloodPressure=@BloodPressure, RespiratoryRate=@RespiratoryRate, Temperature=@Temperature, PulseRate=@PulseRate, Pupil=@Pupil, PastMedicalHistory=@PastMedicalHistory, SAMPLE=@SAMPLE, PhysicalFindings=@PhysicalFindings, Treatment=@Treatment, OtherPersonsInvolved=@OtherPersonsInvolved, CallerInformation=@CallerInformation, MaterialsUsed=@MaterialsUsed, TransportedToNameOfHospitalOrResidence=@TransportedToNameOfHospitalOrResidence, EndorsedTo=@EndorsedTo, EmergencyResponseTeam=@EmergencyResponseTeam, AmbulanceBodyNoAndPlateNo=@AmbulanceBodyNoAndPlateNo, WAIVER=@WAIVER WHERE ID=@ID";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@PatientNumber", pcr.PatientNumber);
                cmd.Parameters.AddWithValue("@Name", pcr.Name);
                cmd.Parameters.AddWithValue("@Age", pcr.Age);
                cmd.Parameters.AddWithValue("@Sex", pcr.Sex);
                cmd.Parameters.AddWithValue("@Address", pcr.Address);
                cmd.Parameters.AddWithValue("@PlaceOfIncident", pcr.PlaceOfIncident);
                cmd.Parameters.AddWithValue("@TypeOfIncident", pcr.TypeOfIncident);
                cmd.Parameters.AddWithValue("@Date", pcr.Date);
                cmd.Parameters.AddWithValue("@ChiefComplaints", pcr.ChiefComplaints);
                cmd.Parameters.AddWithValue("@Oxygen", pcr.Oxygen);
                cmd.Parameters.AddWithValue("@BloodPressure", pcr.BloodPressure);
                cmd.Parameters.AddWithValue("@RespiratoryRate", pcr.RespiratoryRate);
                cmd.Parameters.AddWithValue("@Temperature", pcr.Temperature);
                cmd.Parameters.AddWithValue("@PulseRate", pcr.PulseRate);
                cmd.Parameters.AddWithValue("@Pupil", pcr.Pupil);
                cmd.Parameters.AddWithValue("@PastMedicalHistory", pcr.PastMedicalHistory);
                cmd.Parameters.AddWithValue("@SAMPLE", pcr.SAMPLE);
                cmd.Parameters.AddWithValue("@PhysicalFindings", pcr.PhysicalFindings);
                cmd.Parameters.AddWithValue("@Treatment", pcr.Treatment);
                cmd.Parameters.AddWithValue("@OtherPersonsInvolved", pcr.OtherPersonsInvolved);
                cmd.Parameters.AddWithValue("@CallerInformation", pcr.CallerInformation);
                cmd.Parameters.AddWithValue("@MaterialsUsed", pcr.MaterialsUsed);
                cmd.Parameters.AddWithValue("@TransportedToNameOfHospitalOrResidence", pcr.TransportedToNameOfHospitalOrResidence);
                cmd.Parameters.AddWithValue("@EndorsedTo", pcr.EndorsedTo);
                cmd.Parameters.AddWithValue("@EmergencyResponseTeam", pcr.EmergencyResponseTeam);
                cmd.Parameters.AddWithValue("@AmbulanceBodyNoAndPlateNo", pcr.AmbulanceBodyNoAndPlateNo);
                cmd.Parameters.AddWithValue("@WAIVER", pcr.WAIVER);
                cmd.Parameters.AddWithValue("@ID", pcr.ID);

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
        public bool Delete(PCRBLL pcr)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(UserDAL.myconnstrng);

            try
            {
                string sql = "DELETE FROM tbl_PCR WHERE ID=@ID";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ID", pcr.ID);

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
                String sql = "SELECT * FROM tbl_PCR WHERE PatientNumber LIKE '%" + keywords + "%' OR Name LIKE '%" + keywords + "%' OR Age LIKE '%" + keywords + "%' OR Sex LIKE '%" + keywords + "%' OR Address LIKE '%" + keywords + "%' OR PlaceOfIncident LIKE '%" + keywords + "%' OR TypeOfIncident LIKE '%" + keywords + "%' OR Date LIKE '%" + keywords + "%' OR OtherPersonsInvolved LIKE '%" + keywords + "%' OR CallerInformation LIKE '%" + keywords + "%' OR TransportedToNameOfHospitalOrResidence LIKE '%" + keywords + "%' OR EndorsedTo LIKE '%" + keywords + "%' OR EmergencyResponseTeam LIKE '%" + keywords + "%' OR AmbulanceBodyNoAndPlateNo LIKE '%" + keywords + "%' ";

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
