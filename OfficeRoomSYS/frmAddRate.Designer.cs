namespace OfficeRoomSYS
{
    partial class frmAddRate
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
            this.txtOfficeNo = new System.Windows.Forms.TextBox();
            this.lbOfficeNo = new System.Windows.Forms.Label();
            this.btnAddRate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOfficeNo
            // 
            this.txtOfficeNo.Location = new System.Drawing.Point(85, 12);
            this.txtOfficeNo.Name = "txtOfficeNo";
            this.txtOfficeNo.Size = new System.Drawing.Size(38, 22);
            this.txtOfficeNo.TabIndex = 0;
            // 
            // lbOfficeNo
            // 
            this.lbOfficeNo.AutoSize = true;
            this.lbOfficeNo.Location = new System.Drawing.Point(12, 9);
            this.lbOfficeNo.Name = "lbOfficeNo";
            this.lbOfficeNo.Size = new System.Drawing.Size(67, 17);
            this.lbOfficeNo.TabIndex = 1;
            this.lbOfficeNo.Text = "OfficeNo:";
            // 
            // btnAddRate
            // 
            this.btnAddRate.Location = new System.Drawing.Point(12, 87);
            this.btnAddRate.Name = "btnAddRate";
            this.btnAddRate.Size = new System.Drawing.Size(173, 46);
            this.btnAddRate.TabIndex = 2;
            this.btnAddRate.Text = "Add Rate";
            this.btnAddRate.UseVisualStyleBackColor = true;
            this.btnAddRate.Click += new System.EventHandler(this.btnAddRate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rate:";
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(85, 40);
            this.txtRate.MaxLength = 5;
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(100, 22);
            this.txtRate.TabIndex = 3;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(12, 139);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(99, 45);
            this.btnReturn.TabIndex = 10;
            this.btnReturn.Text = "Return To Main Menu";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // frmAddRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 194);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.btnAddRate);
            this.Controls.Add(this.lbOfficeNo);
            this.Controls.Add(this.txtOfficeNo);
            this.Name = "frmAddRate";
            this.Text = "frmAddRate";
            this.Load += new System.EventHandler(this.frmAddRate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOfficeNo;
        private System.Windows.Forms.Label lbOfficeNo;
        private System.Windows.Forms.Button btnAddRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Button btnReturn;
    }
}