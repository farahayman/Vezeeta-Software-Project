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
    public partial class UpdateSystem : Form
    {
       
        OracleDataAdapter Adapter;
        OracleCommandBuilder Builder;
        DataSet DS;
        public UpdateSystem()
        {
            InitializeComponent();

        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            string conStr ="Data source=orcl;User Id=scott; Password=tiger;";
            string cmdStr =  " ";
            if (checkBox_doc.Checked)
            {
                cmdStr = " Select * from Doctors";
            }
            else if(checkBox_patient.Checked)
            {
                cmdStr = " Select * from Patients";
            }
            Adapter = new OracleDataAdapter(cmdStr,conStr);
            DS = new DataSet();
            Adapter.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];


        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Builder = new OracleCommandBuilder(Adapter);
            Adapter.Update(DS.Tables[0]);
        }

       
    }
}
