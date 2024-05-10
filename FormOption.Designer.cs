namespace myClinic
{
    partial class FormOption
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnDoctor = new System.Windows.Forms.Button();
            this.btnNurse = new System.Windows.Forms.Button();
            this.btnMed = new System.Windows.Forms.Button();
            this.btnEmp = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblEmp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MintCream;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 50);
            this.label3.TabIndex = 15;
            this.label3.Text = "主選單";
            // 
            // btnDoctor
            // 
            this.btnDoctor.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDoctor.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDoctor.ForeColor = System.Drawing.Color.White;
            this.btnDoctor.Location = new System.Drawing.Point(107, 195);
            this.btnDoctor.Name = "btnDoctor";
            this.btnDoctor.Size = new System.Drawing.Size(169, 59);
            this.btnDoctor.TabIndex = 2;
            this.btnDoctor.Text = "看診系統";
            this.btnDoctor.UseVisualStyleBackColor = false;
            this.btnDoctor.Click += new System.EventHandler(this.btnDoctor_Click);
            // 
            // btnNurse
            // 
            this.btnNurse.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnNurse.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNurse.ForeColor = System.Drawing.Color.White;
            this.btnNurse.Location = new System.Drawing.Point(107, 121);
            this.btnNurse.Name = "btnNurse";
            this.btnNurse.Size = new System.Drawing.Size(169, 59);
            this.btnNurse.TabIndex = 1;
            this.btnNurse.Text = "掛號系統";
            this.btnNurse.UseVisualStyleBackColor = false;
            this.btnNurse.Click += new System.EventHandler(this.btnNurse_Click);
            // 
            // btnMed
            // 
            this.btnMed.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMed.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMed.ForeColor = System.Drawing.Color.White;
            this.btnMed.Location = new System.Drawing.Point(107, 354);
            this.btnMed.Name = "btnMed";
            this.btnMed.Size = new System.Drawing.Size(169, 59);
            this.btnMed.TabIndex = 4;
            this.btnMed.Text = "藥物維護";
            this.btnMed.UseVisualStyleBackColor = false;
            this.btnMed.Click += new System.EventHandler(this.btnMed_Click);
            // 
            // btnEmp
            // 
            this.btnEmp.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEmp.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEmp.ForeColor = System.Drawing.Color.White;
            this.btnEmp.Location = new System.Drawing.Point(107, 272);
            this.btnEmp.Name = "btnEmp";
            this.btnEmp.Size = new System.Drawing.Size(169, 59);
            this.btnEmp.TabIndex = 3;
            this.btnEmp.Text = "員工維護";
            this.btnEmp.UseVisualStyleBackColor = false;
            this.btnEmp.Click += new System.EventHandler(this.btnEmp_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLogout.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(107, 432);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(169, 59);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "登出";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblEmp
            // 
            this.lblEmp.AutoSize = true;
            this.lblEmp.BackColor = System.Drawing.Color.White;
            this.lblEmp.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblEmp.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblEmp.Location = new System.Drawing.Point(20, 508);
            this.lblEmp.Name = "lblEmp";
            this.lblEmp.Size = new System.Drawing.Size(134, 31);
            this.lblEmp.TabIndex = 93;
            this.lblEmp.Text = "操作人員：";
            // 
            // FormOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(394, 551);
            this.Controls.Add(this.lblEmp);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnEmp);
            this.Controls.Add(this.btnMed);
            this.Controls.Add(this.btnNurse);
            this.Controls.Add(this.btnDoctor);
            this.Controls.Add(this.label3);
            this.Name = "FormOption";
            this.Text = "系統主選單";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormOption_FormClosed);
            this.Load += new System.EventHandler(this.FormOption_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDoctor;
        private System.Windows.Forms.Button btnNurse;
        private System.Windows.Forms.Button btnMed;
        private System.Windows.Forms.Button btnEmp;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblEmp;
    }
}