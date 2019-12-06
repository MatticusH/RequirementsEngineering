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
    public partial class frmMkBooking : Form
    {
        public frmMkBooking()
        {
            InitializeComponent();
        }

        private void frmMkBooking_Load(object sender, EventArgs e)
        {

        }

        private void btnMkBooking_Click(object sender, EventArgs e)
        {

            if (txtOfficeNo.Text.Equals(""))
            {
                MessageBox.Show("Office Number must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOfficeNo.Focus();
                return;
            }
            if (txtDateFrom.Text.Equals(""))
            {
                MessageBox.Show("Start Date must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDateFrom.Focus();
                return;
            }
            if (txtDateTo.Text.Equals(""))
            {
                MessageBox.Show("End Date must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDateTo.Focus();
                return;
            }
            MessageBox.Show("Booking Made", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtOfficeNo.Clear();
            txtDateFrom.Clear();
            txtDateTo.Clear();

            txtOfficeNo.Focus();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainMenu nextForm = new frmMainMenu();
            nextForm.Show();
        }

        private void txtDateTo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
