using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace EMS_Client.Forms
{
    public partial class GeneralData : Form
    {
        private ProgressBar[] progressBars;
        public GeneralData()
        {
            InitializeComponent();
            progressBars = new ProgressBar[] {monthBar0, monthBar1 , monthBar2 , monthBar3 , monthBar4 , monthBar5 , monthBar6 , monthBar7 , monthBar8 , monthBar9, monthBar10, monthBar11 };
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            selectEmployee select_Employee = new selectEmployee(this);
            select_Employee.Show();
        }

        private void GeneralData_Load(object sender, EventArgs e)
        {
            int i = 10;
            foreach (var a in progressBars)
                a.Value = i++;

        }
        public void Fill()
        {

        }
    }
}
