using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfficeRoomSYS
{
    public partial class frmAddRate : Form
    {
        public frmAddRate()
        {
            InitializeComponent();
        }

        private void frmAddRate_Load(object sender, EventArgs e)
        {

        }

        private void btnAddRate_Click(object sender, EventArgs e)
        {
            if (txtOfficeNo.Text.Equals(""))
            {
                MessageBox.Show("Office Number must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOfficeNo.Focus();
                return;
            }
            if(txtRate.Equals(""))
            {
                MessageBox.Show("Rate must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRate.Focus();
                return;
            }
            MessageBox.Show("New Office Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtOfficeNo.Clear();
            txtRate.Clear();

            txtOfficeNo.Focus();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainMenu nextForm = new frmMainMenu();
            nextForm.Show();
        }
    }
}
