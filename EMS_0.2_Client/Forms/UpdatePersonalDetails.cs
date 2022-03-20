using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMS_Client.Forms
{
    public partial class UpdatePersonalDetails : Form
    {
        public UpdatePersonalDetails()
        {
            InitializeComponent();
        }

        private void btnX_Click(object sender, EventArgs e) => Close();

        private void btnUpload_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "picture |*.jpg| picture |*.png | all files|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.InitialDirectory = "c:\\";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = openFileDialog1.FileName;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var delete = MessageBox.Show("Are you sure?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }
    }
}
