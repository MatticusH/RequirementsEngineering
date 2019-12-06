namespace OfficeRoomSYS
{
    partial class frmCancBooking
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
            this.btnMkBooking = new System.Windows.Forms.Button();
            this.lbOfficeNo = new System.Windows.Forms.Label();
            this.txtBookingId = new System.Windows.Forms.TextBox();
            this.cbCancBooking = new System.Windows.Forms.CheckBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Confirm Cancelation:";
            // 
            // btnMkBooking
            // 
            this.btnMkBooking.Location = new System.Drawing.Point(12, 102);
            this.btnMkBooking.Name = "btnMkBooking";
            this.btnMkBooking.Size = new System.Drawing.Size(183, 46);
            this.btnMkBooking.TabIndex = 14;
            this.btnMkBooking.Text = "Make Booking";
            this.btnMkBooking.UseVisualStyleBackColor = true;
            // 
            // lbOfficeNo
            // 
            this.lbOfficeNo.AutoSize = true;
            this.lbOfficeNo.Location = new System.Drawing.Point(12, 13);
            this.lbOfficeNo.Name = "lbOfficeNo";
            this.lbOfficeNo.Size = new System.Drawing.Size(78, 17);
            this.lbOfficeNo.TabIndex = 13;
            this.lbOfficeNo.Text = "Booking Id:";
            // 
            // txtBookingId
            // 
            this.txtBookingId.Location = new System.Drawing.Point(95, 16);
            this.txtBookingId.Name = "txtBookingId";
            this.txtBookingId.Size = new System.Drawing.Size(38, 22);
            this.txtBookingId.TabIndex = 12;
            // 
            // cbCancBooking
            // 
            this.cbCancBooking.AutoSize = true;
            this.cbCancBooking.Location = new System.Drawing.Point(153, 68);
            this.cbCancBooking.Name = "cbCancBooking";
            this.cbCancBooking.Size = new System.Drawing.Size(18, 17);
            this.cbCancBooking.TabIndex = 17;
            this.cbCancBooking.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(12, 154);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(99, 45);
            this.btnReturn.TabIndex = 18;
            this.btnReturn.Text = "Return To Main Menu";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // frmCancBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 210);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.cbCancBooking);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMkBooking);
            this.Controls.Add(this.lbOfficeNo);
            this.Controls.Add(this.txtBookingId);
            this.Name = "frmCancBooking";
            this.Text = "frmCancBooking";
            this.Load += new System.EventHandler(this.frmCancBooking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMkBooking;
        private System.Windows.Forms.Label lbOfficeNo;
        private System.Windows.Forms.TextBox txtBookingId;
        private System.Windows.Forms.CheckBox cbCancBooking;
        private System.Windows.Forms.Button btnReturn;
    }
}