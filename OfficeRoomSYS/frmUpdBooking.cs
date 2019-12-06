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
    public partial class frmUpdBooking : Form
    {
        public frmUpdBooking()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainMenu nextForm = new frmMainMenu();
            nextForm.Show();
        }

        private void btnUpdBooking_Click(object sender, EventArgs e)
        {
            if (txtBookingId.Text.Equals(""))
            {
                MessageBox.Show("Booking ID must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookingId.Focus();
                return;
            }
            if (txtDateFrom.Equals(""))
            {
                MessageBox.Show("Start Date must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDateFrom.Focus();
                return;
            }
            if (txtDateTo.Equals(""))
            {
                MessageBox.Show("End Date must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDateTo.Focus();
                return;
            }
            MessageBox.Show("Booking Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtDateFrom.Clear();
            txtDateTo.Clear();
            txtBookingId.Clear();

            txtBookingId.Focus();
        }
    }
}
