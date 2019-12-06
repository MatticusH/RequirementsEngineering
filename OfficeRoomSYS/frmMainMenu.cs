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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void mnuRevAnalysis_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRevAnalysis nextForm = new frmRevAnalysis();
            nextForm.Show();
        }

        private void mnuOfficeAnalysis_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOfficeAnalysis nextForm = new frmOfficeAnalysis();
            nextForm.Show();
        }

        private void mnuMkBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMkBooking nextForm = new frmMkBooking();
            nextForm.Show();
        }

        private void mnuCancBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCancBooking nextForm = new frmCancBooking();
            nextForm.Show();
        }

        private void mnuUpdBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdBooking nextForm = new frmUpdBooking();
            nextForm.Show();
        }

        private void mnuAddRate_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddRate nextForm = new frmAddRate();
            nextForm.Show();
        }

        private void mnuUpdRate_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdRate nextForm = new frmUpdRate();
            nextForm.Show();
        }

        private void mnuListRooms_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmListRooms nextForm = new frmListRooms();
            nextForm.Show();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
