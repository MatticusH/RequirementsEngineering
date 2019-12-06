namespace OfficeRoomSYS
{
    partial class frmUpdRate
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
            this.txtOldOfficeNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewOfficeNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewRate = new System.Windows.Forms.TextBox();
            this.btnUpdRate = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Old OfficeNo: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtOldOfficeNo
            // 
            this.txtOldOfficeNo.Location = new System.Drawing.Point(116, 9);
            this.txtOldOfficeNo.Name = "txtOldOfficeNo";
            this.txtOldOfficeNo.Size = new System.Drawing.Size(42, 22);
            this.txtOldOfficeNo.TabIndex = 2;
            this.txtOldOfficeNo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "New OfficeNo:";
            // 
            // txtNewOfficeNo
            // 
            this.txtNewOfficeNo.Location = new System.Drawing.Point(116, 37);
            this.txtNewOfficeNo.Name = "txtNewOfficeNo";
            this.txtNewOfficeNo.Size = new System.Drawing.Size(42, 22);
            this.txtNewOfficeNo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "New Rate: ";
            // 
            // txtNewRate
            // 
            this.txtNewRate.Location = new System.Drawing.Point(116, 65);
            this.txtNewRate.Name = "txtNewRate";
            this.txtNewRate.Size = new System.Drawing.Size(100, 22);
            this.txtNewRate.TabIndex = 6;
            // 
            // btnUpdRate
            // 
            this.btnUpdRate.Location = new System.Drawing.Point(12, 95);
            this.btnUpdRate.Name = "btnUpdRate";
            this.btnUpdRate.Size = new System.Drawing.Size(204, 82);
            this.btnUpdRate.TabIndex = 8;
            this.btnUpdRate.Text = "Update Rate";
            this.btnUpdRate.UseVisualStyleBackColor = true;
            this.btnUpdRate.Click += new System.EventHandler(this.btnUpdRate_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(12, 192);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(99, 45);
            this.btnReturn.TabIndex = 9;
            this.btnReturn.Text = "Return To Main Menu";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // frmUpdRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 249);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnUpdRate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNewRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNewOfficeNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOldOfficeNo);
            this.Name = "frmUpdRate";
            this.Text = "frmUpdRate";
            this.Load += new System.EventHandler(this.frmUpdRate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOldOfficeNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewOfficeNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNewRate;
        private System.Windows.Forms.Button btnUpdRate;
        private System.Windows.Forms.Button btnReturn;
    }
}