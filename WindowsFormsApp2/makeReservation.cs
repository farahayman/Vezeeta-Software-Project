using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace WindowsFormsApp2
{
    public partial class makeReservation : Form
    {
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;

        public makeReservation()
        {
            InitializeComponent();
        }

        private void makeReservation_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select DOCTOR_NAME from DOCTORS where SPECIALTY = :sp";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("sp", txt_DSpecialty.Text);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmb_Doctors.Items.Add(dr["DOCTOR_NAME"]);
            }
            dr.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "Doctor_Cost";
            c.CommandType = CommandType.StoredProcedure;
            c.Parameters.Add("name", cmb_Doctors.SelectedItem.ToString());
            c.Parameters.Add("cost", OracleDbType.Int32, ParameterDirection.Output);
            c.ExecuteNonQuery();
            txt_cost.Text = c.Parameters["cost"].Value.ToString();

        }

        private void cmb_Doctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = conn;
            cmd1.CommandText = "clinics";
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.Add("name", cmb_Doctors.SelectedItem.ToString());
            cmd1.Parameters.Add("clinic", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                cmb_clinics.Items.Add(dr[0]);
            }
            dr.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OracleCommand oracleCommand = new OracleCommand();
            oracleCommand.Connection = conn;
            oracleCommand.CommandText = "clinic_info";
            oracleCommand.CommandType = CommandType.StoredProcedure;
            oracleCommand.Parameters.Add("name", cmb_clinics.SelectedItem.ToString());
            oracleCommand.Parameters.Add("doc", cmb_Doctors.SelectedItem.ToString());
            oracleCommand.Parameters.Add("info", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = oracleCommand.ExecuteReader();
            while (dr.Read())
            {
                txt_ClinicPhone.Text = dr[0].ToString();
                txt_address.Text = dr[1].ToString();
                txt_startTime.Text = dr[2].ToString();
                txt_endTime.Text = dr[3].ToString();
            }
        }

        private void btn_Book_Click(object sender, EventArgs e)
        {
            int maxID, NewID;
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "GetPID";
            c.CommandType = CommandType.StoredProcedure;
            c.Parameters.Add("id", OracleDbType.Int32, ParameterDirection.Output);
            c.ExecuteNonQuery();
            try
            {
                maxID = Convert.ToInt32(c.Parameters["id"].Value.ToString());
                NewID = maxID + 1;
            }
            catch
            {
                NewID = 1;
            }
            OracleCommand c1 = new OracleCommand();
            c1.Connection = conn;
            c1.CommandText = "insert into reservations values (:Aid,:Aphone,:loaction,:Adate,:Atime,:Pname,:Dname) ";
            c1.CommandType = CommandType.Text;
            c1.Parameters.Add("Aid", NewID);
            c1.Parameters.Add("Aphone", txt_ClinicPhone.Text);
            c1.Parameters.Add("location", txt_address.Text);
            c1.Parameters.Add("Adate", txt_Date.Text);
            c1.Parameters.Add("Atime", txt_Time.Text);
            c1.Parameters.Add("Pname", txt_patient.Text);
            c1.Parameters.Add("Dname", cmb_Doctors.SelectedItem.ToString());
            int r1 = c1.ExecuteNonQuery();
            OracleCommand c2 = new OracleCommand();
            c2.Connection = conn;
            c2.CommandText = "insert into PATIENTS values (:id,:name,:phone,:age)";
            c2.CommandType = CommandType.Text;
            c2.Parameters.Add("id", NewID);
            c2.Parameters.Add("name", txt_patient.Text);
            c2.Parameters.Add("phone", txt_phoneNum.Text);
            c2.Parameters.Add("age", Convert.ToInt32(txt_age.Text));
            int r2 = c2.ExecuteNonQuery();
            if (r1 != -1 && r2 != -1)
            {
                MessageBox.Show("Your Reservation Done Successuflly Thank You ..! ");
            }


        }
    }
}
