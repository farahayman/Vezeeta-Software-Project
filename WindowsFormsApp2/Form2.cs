using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        CrystalReport2 CR;
        
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CR = new CrystalReport2();
            foreach(ParameterDiscreteValue i in CR.ParameterFields[0].DefaultValues)
            {
                comboBox1.Items.Add(i.Value);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CR.SetParameterValue(0, Convert.ToInt32(comboBox1.Text));
            crystalReportViewer1.ReportSource = CR;
        }
    }
}
