namespace OfficeRoomSYS
{
    partial class frmMkBooking
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtDateFrom = new System.Windows.Forms.TextBox();
            this.btnMkBooking = new System.Windows.Forms.Button();
            this.lbOfficeNo = new System.Windows.Forms.Label();
            this.txtOfficeNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDateTo = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Date From:";
            // 
            // txtDateFrom
            // 
            this.txtDateFrom.Location = new System.Drawing.Point(95, 40);
            this.txtDateFrom.Name = "txtDateFrom";
            this.txtDateFrom.Size = new System.Drawing.Size(100, 22);
            this.txtDateFrom.TabIndex = 8;
            // 
            // btnMkBooking
            // 
            this.btnMkBooking.Location = new System.Drawing.Point(12, 98);
            this.btnMkBooking.Name = "btnMkBooking";
            this.btnMkBooking.Size = new System.Drawing.Size(183, 46);
            this.btnMkBooking.TabIndex = 7;
            this.btnMkBooking.Text = "Make Booking";
            this.btnMkBooking.UseVisualStyleBackColor = true;
            this.btnMkBooking.Click += new System.EventHandler(this.btnMkBooking_Click);
            // 
            // lbOfficeNo
            // 
            this.lbOfficeNo.AutoSize = true;
            this.lbOfficeNo.Location = new System.Drawing.Point(12, 9);
            this.lbOfficeNo.Name = "lbOfficeNo";
            this.lbOfficeNo.Size = new System.Drawing.Size(67, 17);
            this.lbOfficeNo.TabIndex = 6;
            this.lbOfficeNo.Text = "OfficeNo:";
            // 
            // txtOfficeNo
            // 
            this.txtOfficeNo.Location = new System.Drawing.Point(95, 12);
            this.txtOfficeNo.Name = "txtOfficeNo";
            this.txtOfficeNo.Size = new System.Drawing.Size(38, 22);
            this.txtOfficeNo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Date To:";
            // 
            // txtDateTo
            // 
            this.txtDateTo.Location = new System.Drawing.Point(95, 70);
            this.txtDateTo.Name = "txtDateTo";
            this.txtDateTo.Size = new System.Drawing.Size(100, 22);
            this.txtDateTo.TabIndex = 10;
            this.txtDateTo.TextChanged += new System.EventHandler(this.txtDateTo_TextChanged);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(15, 155);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(99, 45);
            this.btnReturn.TabIndex = 12;
            this.btnReturn.Text = "Return To Main Menu";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // frmMkBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 212);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDateTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDateFrom);
            this.Controls.Add(this.btnMkBooking);
            this.Controls.Add(this.lbOfficeNo);
            this.Controls.Add(this.txtOfficeNo);
            this.Name = "frmMkBooking";
            this.Text = "frmMkBooking";
            this.Load += new System.EventHandler(this.frmMkBooking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDateFrom;
        private System.Windows.Forms.Button btnMkBooking;
        private System.Windows.Forms.Label lbOfficeNo;
        private System.Windows.Forms.TextBox txtOfficeNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDateTo;
        private System.Windows.Forms.Button btnReturn;
    }
}