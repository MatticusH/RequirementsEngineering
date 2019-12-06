namespace OfficeRoomSYS
{
    partial class frmMainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.mnuBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMkBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCancBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRooms = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddRate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdRate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuListRooms = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRevAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOfficeAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.picMain = new System.Windows.Forms.PictureBox();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBooking,
            this.mnuRooms,
            this.mnuAdmin,
            this.mnuExit});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(737, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // mnuBooking
            // 
            this.mnuBooking.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMkBooking,
            this.mnuCancBooking,
            this.mnuUpdBooking});
            this.mnuBooking.Name = "mnuBooking";
            this.mnuBooking.Size = new System.Drawing.Size(76, 24);
            this.mnuBooking.Text = "Booking";
            // 
            // mnuMkBooking
            // 
            this.mnuMkBooking.Name = "mnuMkBooking";
            this.mnuMkBooking.Size = new System.Drawing.Size(192, 26);
            this.mnuMkBooking.Text = "Make Booking";
            this.mnuMkBooking.Click += new System.EventHandler(this.mnuMkBooking_Click);
            // 
            // mnuCancBooking
            // 
            this.mnuCancBooking.Name = "mnuCancBooking";
            this.mnuCancBooking.Size = new System.Drawing.Size(192, 26);
            this.mnuCancBooking.Text = "Cancel Booking";
            this.mnuCancBooking.Click += new System.EventHandler(this.mnuCancBooking_Click);
            // 
            // mnuUpdBooking
            // 
            this.mnuUpdBooking.Name = "mnuUpdBooking";
            this.mnuUpdBooking.Size = new System.Drawing.Size(192, 26);
            this.mnuUpdBooking.Text = "Update Booking";
            this.mnuUpdBooking.Click += new System.EventHandler(this.mnuUpdBooking_Click);
            // 
            // mnuRooms
            // 
            this.mnuRooms.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddRate,
            this.mnuUpdRate,
            this.mnuListRooms});
            this.mnuRooms.Name = "mnuRooms";
            this.mnuRooms.Size = new System.Drawing.Size(67, 24);
            this.mnuRooms.Text = "Rooms";
            // 
            // mnuAddRate
            // 
            this.mnuAddRate.Name = "mnuAddRate";
            this.mnuAddRate.Size = new System.Drawing.Size(167, 26);
            this.mnuAddRate.Text = "Add Rate";
            this.mnuAddRate.Click += new System.EventHandler(this.mnuAddRate_Click);
            // 
            // mnuUpdRate
            // 
            this.mnuUpdRate.Name = "mnuUpdRate";
            this.mnuUpdRate.Size = new System.Drawing.Size(167, 26);
            this.mnuUpdRate.Text = "Update Rate";
            this.mnuUpdRate.Click += new System.EventHandler(this.mnuUpdRate_Click);
            // 
            // mnuListRooms
            // 
            this.mnuListRooms.Name = "mnuListRooms";
            this.mnuListRooms.Size = new System.Drawing.Size(167, 26);
            this.mnuListRooms.Text = "List Rooms";
            this.mnuListRooms.Click += new System.EventHandler(this.mnuListRooms_Click);
            // 
            // mnuAdmin
            // 
            this.mnuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRevAnalysis,
            this.mnuOfficeAnalysis});
            this.mnuAdmin.Name = "mnuAdmin";
            this.mnuAdmin.Size = new System.Drawing.Size(65, 24);
            this.mnuAdmin.Text = "Admin";
            // 
            // mnuRevAnalysis
            // 
            this.mnuRevAnalysis.Name = "mnuRevAnalysis";
            this.mnuRevAnalysis.Size = new System.Drawing.Size(197, 26);
            this.mnuRevAnalysis.Text = "Revenue Analysis";
            this.mnuRevAnalysis.Click += new System.EventHandler(this.mnuRevAnalysis_Click);
            // 
            // mnuOfficeAnalysis
            // 
            this.mnuOfficeAnalysis.Name = "mnuOfficeAnalysis";
            this.mnuOfficeAnalysis.Size = new System.Drawing.Size(197, 26);
            this.mnuOfficeAnalysis.Text = "Office Analysis";
            this.mnuOfficeAnalysis.Click += new System.EventHandler(this.mnuOfficeAnalysis_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(45, 24);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // picMain
            // 
            this.picMain.Image = ((System.Drawing.Image)(resources.GetObject("picMain.Image")));
            this.picMain.Location = new System.Drawing.Point(0, 31);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(738, 485);
            this.picMain.TabIndex = 2;
            this.picMain.TabStop = false;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 514);
            this.Controls.Add(this.picMain);
            this.Controls.Add(this.menuStrip2);
            this.Name = "frmMainMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem mnuRooms;
        private System.Windows.Forms.ToolStripMenuItem mnuAddRate;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdRate;
        private System.Windows.Forms.ToolStripMenuItem mnuListRooms;
        private System.Windows.Forms.ToolStripMenuItem mnuBooking;
        private System.Windows.Forms.ToolStripMenuItem mnuMkBooking;
        private System.Windows.Forms.ToolStripMenuItem mnuCancBooking;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdBooking;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin;
        private System.Windows.Forms.ToolStripMenuItem mnuRevAnalysis;
        private System.Windows.Forms.ToolStripMenuItem mnuOfficeAnalysis;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.PictureBox picMain;
    }
}

