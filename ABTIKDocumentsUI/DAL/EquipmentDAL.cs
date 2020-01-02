using ABTIKDocumentsUI.BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABTIKDocumentsUI.DAL
{
    public class EquipmentDAL
    {
        #region Insert data in Database
        public bool Insert(EquipmentBLL equipment_no)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(UserDAL.myconnstrng);

            try
            {
                string sql = "INSERT INTO tbl_Equipment (vehicle_no, genset_no, waterRescue_no, extrication_no, ppe_no, firstAid_no, others_no) VALUES (@vehicle_no, @genset_no, @waterRescue_no, @extrication_no, @ppe_no, @firstAid_no, @others_no)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@vehicle_no", equipment_no.Vehicle_no);
                cmd.Parameters.AddWithValue("@genset_no", equipment_no.Genset_no);
                cmd.Parameters.AddWithValue("@waterRescue_no", equipment_no.WaterRescue_no);
                cmd.Parameters.AddWithValue("@extrication_no", equipment_no.Extrication_no);
                cmd.Parameters.AddWithValue("@ppe_no", equipment_no.PPE_no);
                cmd.Parameters.AddWithValue("@firstAid_no", equipment_no.FirstAid_no);
                cmd.Parameters.AddWithValue("@others_no", equipment_no.Others_no);

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
    }
}
