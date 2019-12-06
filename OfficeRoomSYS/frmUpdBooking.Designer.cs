namespace OfficeRoomSYS
{
    partial class frmUpdBooking
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDateTo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDateFrom = new System.Windows.Forms.TextBox();
            this.btnUpdBooking = new System.Windows.Forms.Button();
            this.lbOfficeNo = new System.Windows.Forms.Label();
            this.txtBookingId = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Date To:";
            // 
            // txtDateTo
            // 
            this.txtDateTo.Location = new System.Drawing.Point(95, 73);
            this.txtDateTo.Name = "txtDateTo";
            this.txtDateTo.Size = new System.Drawing.Size(100, 22);
            this.txtDateTo.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Date From:";
            // 
            // txtDateFrom
            // 
            this.txtDateFrom.Location = new System.Drawing.Point(95, 43);
            this.txtDateFrom.Name = "txtDateFrom";
            this.txtDateFrom.Size = new System.Drawing.Size(100, 22);
            this.txtDateFrom.TabIndex = 15;
            // 
            // btnUpdBooking
            // 
            this.btnUpdBooking.Location = new System.Drawing.Point(12, 101);
            this.btnUpdBooking.Name = "btnUpdBooking";
            this.btnUpdBooking.Size = new System.Drawing.Size(183, 46);
            this.btnUpdBooking.TabIndex = 14;
            this.btnUpdBooking.Text = "Update Booking";
            this.btnUpdBooking.UseVisualStyleBackColor = true;
            this.btnUpdBooking.Click += new System.EventHandler(this.btnUpdBooking_Click);
            // 
            // lbOfficeNo
            // 
            this.lbOfficeNo.AutoSize = true;
            this.lbOfficeNo.Location = new System.Drawing.Point(12, 12);
            this.lbOfficeNo.Name = "lbOfficeNo";
            this.lbOfficeNo.Size = new System.Drawing.Size(78, 17);
            this.lbOfficeNo.TabIndex = 13;
            this.lbOfficeNo.Text = "Booking Id:";
            // 
            // txtBookingId
            // 
            this.txtBookingId.Location = new System.Drawing.Point(95, 15);
            this.txtBookingId.Name = "txtBookingId";
            this.txtBookingId.Size = new System.Drawing.Size(100, 22);
            this.txtBookingId.TabIndex = 12;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(12, 162);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(99, 45);
            this.btnReturn.TabIndex = 19;
            this.btnReturn.Text = "Return To Main Menu";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // frmUpdBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 221);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDateTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDateFrom);
            this.Controls.Add(this.btnUpdBooking);
            this.Controls.Add(this.lbOfficeNo);
            this.Controls.Add(this.txtBookingId);
            this.Name = "frmUpdBooking";
            this.Text = "frmUpdBooking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDateTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDateFrom;
        private System.Windows.Forms.Button btnUpdBooking;
        private System.Windows.Forms.Label lbOfficeNo;
        private System.Windows.Forms.TextBox txtBookingId;
        private System.Windows.Forms.Button btnReturn;
    }
}