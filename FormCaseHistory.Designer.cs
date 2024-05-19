namespace myClinic
{
    partial class FormCaseHistory
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblBirth = new System.Windows.Forms.Label();
            this.lblPatId = new System.Windows.Forms.Label();
            this.lblDisease = new System.Windows.Forms.Label();
            this.lblAllergy = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCc = new System.Windows.Forms.Label();
            this.lblDx = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvMedsOfPat = new System.Windows.Forms.DataGridView();
            this.txtCc = new System.Windows.Forms.TextBox();
            this.txtDx = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedsOfPat)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblGender);
            this.groupBox1.Controls.Add(this.lblBirth);
            this.groupBox1.Controls.Add(this.lblPatId);
            this.groupBox1.Controls.Add(this.lblDisease);
            this.groupBox1.Controls.Add(this.lblAllergy);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(31, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(250, 254);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "病人資料";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblGender.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblGender.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblGender.Location = new System.Drawing.Point(8, 89);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(52, 25);
            this.lblGender.TabIndex = 45;
            this.lblGender.Text = "性別";
            // 
            // lblBirth
            // 
            this.lblBirth.AutoSize = true;
            this.lblBirth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblBirth.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblBirth.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblBirth.Location = new System.Drawing.Point(8, 114);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(52, 25);
            this.lblBirth.TabIndex = 44;
            this.lblBirth.Text = "生日";
            // 
            // lblPatId
            // 
            this.lblPatId.AutoSize = true;
            this.lblPatId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblPatId.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPatId.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblPatId.Location = new System.Drawing.Point(8, 39);
            this.lblPatId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPatId.Name = "lblPatId";
            this.lblPatId.Size = new System.Drawing.Size(92, 25);
            this.lblPatId.TabIndex = 16;
            this.lblPatId.Text = "病人編號";
            // 
            // lblDisease
            // 
            this.lblDisease.AutoSize = true;
            this.lblDisease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblDisease.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDisease.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblDisease.Location = new System.Drawing.Point(8, 164);
            this.lblDisease.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisease.Name = "lblDisease";
            this.lblDisease.Size = new System.Drawing.Size(72, 25);
            this.lblDisease.TabIndex = 29;
            this.lblDisease.Text = "慢性病";
            // 
            // lblAllergy
            // 
            this.lblAllergy.AutoSize = true;
            this.lblAllergy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblAllergy.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAllergy.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblAllergy.Location = new System.Drawing.Point(8, 139);
            this.lblAllergy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAllergy.Name = "lblAllergy";
            this.lblAllergy.Size = new System.Drawing.Size(72, 25);
            this.lblAllergy.TabIndex = 30;
            this.lblAllergy.Text = "過敏史";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblName.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblName.Location = new System.Drawing.Point(8, 64);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 25);
            this.lblName.TabIndex = 18;
            this.lblName.Text = "姓名";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDx);
            this.groupBox2.Controls.Add(this.txtCc);
            this.groupBox2.Controls.Add(this.lblCc);
            this.groupBox2.Controls.Add(this.lblDx);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(318, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(250, 254);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "診斷內容";
            // 
            // lblCc
            // 
            this.lblCc.AutoSize = true;
            this.lblCc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblCc.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCc.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblCc.Location = new System.Drawing.Point(24, 38);
            this.lblCc.Name = "lblCc";
            this.lblCc.Size = new System.Drawing.Size(52, 25);
            this.lblCc.TabIndex = 98;
            this.lblCc.Text = "主訴";
            // 
            // lblDx
            // 
            this.lblDx.AutoSize = true;
            this.lblDx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblDx.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDx.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblDx.Location = new System.Drawing.Point(24, 150);
            this.lblDx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDx.Name = "lblDx";
            this.lblDx.Size = new System.Drawing.Size(52, 25);
            this.lblDx.TabIndex = 16;
            this.lblDx.Text = "診斷";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvMedsOfPat);
            this.groupBox3.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.Location = new System.Drawing.Point(31, 275);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(537, 254);
            this.groupBox3.TabIndex = 99;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "使用藥物";
            // 
            // dgvMedsOfPat
            // 
            this.dgvMedsOfPat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvMedsOfPat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedsOfPat.Location = new System.Drawing.Point(27, 34);
            this.dgvMedsOfPat.Name = "dgvMedsOfPat";
            this.dgvMedsOfPat.RowHeadersWidth = 62;
            this.dgvMedsOfPat.RowTemplate.Height = 31;
            this.dgvMedsOfPat.Size = new System.Drawing.Size(478, 204);
            this.dgvMedsOfPat.TabIndex = 0;
            // 
            // txtCc
            // 
            this.txtCc.Location = new System.Drawing.Point(29, 78);
            this.txtCc.Multiline = true;
            this.txtCc.Name = "txtCc";
            this.txtCc.ReadOnly = true;
            this.txtCc.Size = new System.Drawing.Size(189, 61);
            this.txtCc.TabIndex = 99;
            // 
            // txtDx
            // 
            this.txtDx.Location = new System.Drawing.Point(29, 199);
            this.txtDx.Name = "txtDx";
            this.txtDx.ReadOnly = true;
            this.txtDx.Size = new System.Drawing.Size(189, 34);
            this.txtDx.TabIndex = 100;
            // 
            // FormCaseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(605, 550);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCaseHistory";
            this.Text = "病歷紀錄";
            this.Load += new System.EventHandler(this.FormCaseHistory_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedsOfPat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.Label lblPatId;
        private System.Windows.Forms.Label lblDisease;
        private System.Windows.Forms.Label lblAllergy;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCc;
        private System.Windows.Forms.Label lblDx;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvMedsOfPat;
        private System.Windows.Forms.TextBox txtDx;
        private System.Windows.Forms.TextBox txtCc;
    }
}