namespace myClinic
{
    partial class FormDoctor
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
            this.lblPatId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAllergy = new System.Windows.Forms.Label();
            this.lblDisease = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCaseHxId = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBirth = new System.Windows.Forms.Label();
            this.lblOther = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtCc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblDr = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDx = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblToday = new System.Windows.Forms.Label();
            this.btnBackToOption = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddMed = new System.Windows.Forms.Button();
            this.btnSearchMed = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMed = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtDose = new System.Windows.Forms.TextBox();
            this.comboBoxFreq = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.dgvReg = new System.Windows.Forms.DataGridView();
            this.dgvMedsOfPat = new System.Windows.Forms.DataGridView();
            this.dgvMed = new System.Windows.Forms.DataGridView();
            this.dgvPastHx = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedsOfPat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPastHx)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPatId
            // 
            this.lblPatId.AutoSize = true;
            this.lblPatId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblPatId.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPatId.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblPatId.Location = new System.Drawing.Point(24, 66);
            this.lblPatId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPatId.Name = "lblPatId";
            this.lblPatId.Size = new System.Drawing.Size(92, 25);
            this.lblPatId.TabIndex = 16;
            this.lblPatId.Text = "病人編號";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblName.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblName.Location = new System.Drawing.Point(24, 91);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 25);
            this.lblName.TabIndex = 18;
            this.lblName.Text = "姓名";
            // 
            // lblAllergy
            // 
            this.lblAllergy.AutoSize = true;
            this.lblAllergy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblAllergy.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAllergy.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblAllergy.Location = new System.Drawing.Point(24, 166);
            this.lblAllergy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAllergy.Name = "lblAllergy";
            this.lblAllergy.Size = new System.Drawing.Size(72, 25);
            this.lblAllergy.TabIndex = 30;
            this.lblAllergy.Text = "過敏史";
            // 
            // lblDisease
            // 
            this.lblDisease.AutoSize = true;
            this.lblDisease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblDisease.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDisease.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblDisease.Location = new System.Drawing.Point(24, 191);
            this.lblDisease.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisease.Name = "lblDisease";
            this.lblDisease.Size = new System.Drawing.Size(72, 25);
            this.lblDisease.TabIndex = 29;
            this.lblDisease.Text = "慢性病";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCaseHxId);
            this.groupBox1.Controls.Add(this.lblGender);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblBirth);
            this.groupBox1.Controls.Add(this.lblOther);
            this.groupBox1.Controls.Add(this.lblPatId);
            this.groupBox1.Controls.Add(this.lblDisease);
            this.groupBox1.Controls.Add(this.lblAllergy);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(33, 82);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(250, 254);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "病人資料";
            // 
            // txtCaseHxId
            // 
            this.txtCaseHxId.Enabled = false;
            this.txtCaseHxId.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCaseHxId.Location = new System.Drawing.Point(92, 34);
            this.txtCaseHxId.Name = "txtCaseHxId";
            this.txtCaseHxId.Size = new System.Drawing.Size(113, 34);
            this.txtCaseHxId.TabIndex = 97;
            this.txtCaseHxId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblGender.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblGender.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblGender.Location = new System.Drawing.Point(24, 116);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(52, 25);
            this.lblGender.TabIndex = 45;
            this.lblGender.Text = "性別";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(24, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 28);
            this.label1.TabIndex = 98;
            this.label1.Text = "病歷號碼";
            // 
            // lblBirth
            // 
            this.lblBirth.AutoSize = true;
            this.lblBirth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblBirth.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblBirth.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblBirth.Location = new System.Drawing.Point(24, 141);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(52, 25);
            this.lblBirth.TabIndex = 44;
            this.lblBirth.Text = "生日";
            // 
            // lblOther
            // 
            this.lblOther.AutoSize = true;
            this.lblOther.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblOther.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblOther.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblOther.Location = new System.Drawing.Point(24, 216);
            this.lblOther.Name = "lblOther";
            this.lblOther.Size = new System.Drawing.Size(52, 25);
            this.lblOther.TabIndex = 43;
            this.lblOther.Text = "備註";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Honeydew;
            this.btnSave.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSave.ForeColor = System.Drawing.Color.DimGray;
            this.btnSave.Location = new System.Drawing.Point(784, 591);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 39);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "儲存病歷";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // txtCc
            // 
            this.txtCc.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCc.Location = new System.Drawing.Point(303, 59);
            this.txtCc.Multiline = true;
            this.txtCc.Name = "txtCc";
            this.txtCc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCc.Size = new System.Drawing.Size(382, 114);
            this.txtCc.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(298, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 28);
            this.label2.TabIndex = 44;
            this.label2.Text = "主訴";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.MintCream;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(12, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(182, 50);
            this.label10.TabIndex = 54;
            this.label10.Text = "看診系統";
            // 
            // lblDr
            // 
            this.lblDr.AutoSize = true;
            this.lblDr.BackColor = System.Drawing.Color.White;
            this.lblDr.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDr.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblDr.Location = new System.Drawing.Point(12, 586);
            this.lblDr.Name = "lblDr";
            this.lblDr.Size = new System.Drawing.Size(134, 31);
            this.lblDr.TabIndex = 55;
            this.lblDr.Text = "看診醫師：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label13.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label13.Location = new System.Drawing.Point(298, 195);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 28);
            this.label13.TabIndex = 57;
            this.label13.Text = "診斷";
            // 
            // txtDx
            // 
            this.txtDx.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDx.Location = new System.Drawing.Point(303, 226);
            this.txtDx.Name = "txtDx";
            this.txtDx.Size = new System.Drawing.Size(214, 34);
            this.txtDx.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label14.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label14.Location = new System.Drawing.Point(49, 338);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 28);
            this.label14.TabIndex = 60;
            this.label14.Text = "過去病史";
            // 
            // lblToday
            // 
            this.lblToday.AutoSize = true;
            this.lblToday.BackColor = System.Drawing.Color.White;
            this.lblToday.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblToday.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblToday.Location = new System.Drawing.Point(12, 617);
            this.lblToday.Name = "lblToday";
            this.lblToday.Size = new System.Drawing.Size(134, 31);
            this.lblToday.TabIndex = 61;
            this.lblToday.Text = "看診日期：";
            // 
            // btnBackToOption
            // 
            this.btnBackToOption.BackColor = System.Drawing.Color.Honeydew;
            this.btnBackToOption.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBackToOption.ForeColor = System.Drawing.Color.DimGray;
            this.btnBackToOption.Location = new System.Drawing.Point(640, 591);
            this.btnBackToOption.Name = "btnBackToOption";
            this.btnBackToOption.Size = new System.Drawing.Size(114, 39);
            this.btnBackToOption.TabIndex = 62;
            this.btnBackToOption.Text = "返回選單";
            this.btnBackToOption.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(614, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 28);
            this.label7.TabIndex = 69;
            this.label7.Text = "處方列表";
            // 
            // btnAddMed
            // 
            this.btnAddMed.BackColor = System.Drawing.Color.Honeydew;
            this.btnAddMed.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddMed.ForeColor = System.Drawing.Color.DimGray;
            this.btnAddMed.Location = new System.Drawing.Point(429, 591);
            this.btnAddMed.Name = "btnAddMed";
            this.btnAddMed.Size = new System.Drawing.Size(157, 39);
            this.btnAddMed.TabIndex = 67;
            this.btnAddMed.Text = "新增選取藥物";
            this.btnAddMed.UseVisualStyleBackColor = false;
            this.btnAddMed.Click += new System.EventHandler(this.btnAddMed_Click);
            // 
            // btnSearchMed
            // 
            this.btnSearchMed.BackColor = System.Drawing.Color.Honeydew;
            this.btnSearchMed.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSearchMed.ForeColor = System.Drawing.Color.DimGray;
            this.btnSearchMed.Location = new System.Drawing.Point(462, 297);
            this.btnSearchMed.Name = "btnSearchMed";
            this.btnSearchMed.Size = new System.Drawing.Size(82, 39);
            this.btnSearchMed.TabIndex = 65;
            this.btnSearchMed.Text = "搜尋";
            this.btnSearchMed.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(298, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 28);
            this.label3.TabIndex = 64;
            this.label3.Text = "藥物清單";
            // 
            // txtMed
            // 
            this.txtMed.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMed.Location = new System.Drawing.Point(303, 302);
            this.txtMed.Name = "txtMed";
            this.txtMed.Size = new System.Drawing.Size(153, 34);
            this.txtMed.TabIndex = 63;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(515, 342);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 77);
            this.pictureBox1.TabIndex = 78;
            this.pictureBox1.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label16.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label16.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label16.Location = new System.Drawing.Point(510, 429);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 25);
            this.label16.TabIndex = 46;
            this.label16.Text = "作用";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label17.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label17.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label17.Location = new System.Drawing.Point(510, 482);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 25);
            this.label17.TabIndex = 79;
            this.label17.Text = "副作用";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label18.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label18.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label18.Location = new System.Drawing.Point(430, 554);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 25);
            this.label18.TabIndex = 81;
            this.label18.Text = "每次";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label19.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label19.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label19.Location = new System.Drawing.Point(530, 554);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(32, 25);
            this.label19.TabIndex = 82;
            this.label19.Text = "顆";
            // 
            // txtDose
            // 
            this.txtDose.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDose.Location = new System.Drawing.Point(479, 551);
            this.txtDose.Name = "txtDose";
            this.txtDose.Size = new System.Drawing.Size(53, 34);
            this.txtDose.TabIndex = 5;
            // 
            // comboBoxFreq
            // 
            this.comboBoxFreq.FormattingEnabled = true;
            this.comboBoxFreq.Items.AddRange(new object[] {
            "一天1次",
            "一天3次",
            "一天4次",
            "睡前",
            "早晚",
            "需要時使用"});
            this.comboBoxFreq.Location = new System.Drawing.Point(303, 551);
            this.comboBoxFreq.Name = "comboBoxFreq";
            this.comboBoxFreq.Size = new System.Drawing.Size(121, 31);
            this.comboBoxFreq.TabIndex = 4;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label20.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label20.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label20.Location = new System.Drawing.Point(699, 12);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(144, 28);
            this.label20.TabIndex = 87;
            this.label20.Text = "等待看診名單";
            // 
            // dgvReg
            // 
            this.dgvReg.AllowUserToAddRows = false;
            this.dgvReg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvReg.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvReg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReg.Location = new System.Drawing.Point(704, 43);
            this.dgvReg.Name = "dgvReg";
            this.dgvReg.RowHeadersWidth = 62;
            this.dgvReg.RowTemplate.Height = 31;
            this.dgvReg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReg.Size = new System.Drawing.Size(203, 202);
            this.dgvReg.TabIndex = 93;
            this.dgvReg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReg_CellClick);
            // 
            // dgvMedsOfPat
            // 
            this.dgvMedsOfPat.AllowUserToAddRows = false;
            this.dgvMedsOfPat.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvMedsOfPat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedsOfPat.Location = new System.Drawing.Point(619, 329);
            this.dgvMedsOfPat.Name = "dgvMedsOfPat";
            this.dgvMedsOfPat.RowHeadersWidth = 62;
            this.dgvMedsOfPat.RowTemplate.Height = 31;
            this.dgvMedsOfPat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedsOfPat.Size = new System.Drawing.Size(203, 235);
            this.dgvMedsOfPat.TabIndex = 94;
            // 
            // dgvMed
            // 
            this.dgvMed.AllowUserToAddRows = false;
            this.dgvMed.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvMed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMed.Location = new System.Drawing.Point(303, 342);
            this.dgvMed.Name = "dgvMed";
            this.dgvMed.RowHeadersWidth = 62;
            this.dgvMed.RowTemplate.Height = 31;
            this.dgvMed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMed.Size = new System.Drawing.Size(190, 195);
            this.dgvMed.TabIndex = 95;
            // 
            // dgvPastHx
            // 
            this.dgvPastHx.AllowUserToAddRows = false;
            this.dgvPastHx.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvPastHx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPastHx.Location = new System.Drawing.Point(33, 369);
            this.dgvPastHx.Name = "dgvPastHx";
            this.dgvPastHx.RowHeadersWidth = 62;
            this.dgvPastHx.RowTemplate.Height = 31;
            this.dgvPastHx.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPastHx.Size = new System.Drawing.Size(199, 195);
            this.dgvPastHx.TabIndex = 96;
            // 
            // FormDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(910, 655);
            this.Controls.Add(this.dgvPastHx);
            this.Controls.Add(this.dgvMed);
            this.Controls.Add(this.dgvMedsOfPat);
            this.Controls.Add(this.dgvReg);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.comboBoxFreq);
            this.Controls.Add(this.txtDose);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAddMed);
            this.Controls.Add(this.btnSearchMed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMed);
            this.Controls.Add(this.btnBackToOption);
            this.Controls.Add(this.lblToday);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtDx);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblDr);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCc);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ForeColor = System.Drawing.Color.DimGray;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDoctor";
            this.Text = "看診系統";
            this.Load += new System.EventHandler(this.FormDoctor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedsOfPat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPastHx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPatId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAllergy;
        private System.Windows.Forms.Label lblDisease;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtCc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblDr;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDx;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblToday;
        private System.Windows.Forms.Button btnBackToOption;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAddMed;
        private System.Windows.Forms.Button btnSearchMed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMed;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtDose;
        private System.Windows.Forms.ComboBox comboBoxFreq;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView dgvReg;
        private System.Windows.Forms.DataGridView dgvMedsOfPat;
        private System.Windows.Forms.DataGridView dgvMed;
        private System.Windows.Forms.DataGridView dgvPastHx;
        private System.Windows.Forms.Label lblOther;
        private System.Windows.Forms.TextBox txtCaseHxId;
        private System.Windows.Forms.Label label1;
    }
}