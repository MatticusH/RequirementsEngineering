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
    public partial class frmListRooms : Form
    {
        public frmListRooms()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainMenu nextForm = new frmMainMenu();
            nextForm.Show();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmListRooms_Load(object sender, EventArgs e)
        {
            dtpDate.MinDate = DateTime.Today;
        }
    }
}
