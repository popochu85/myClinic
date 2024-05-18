namespace myClinic
{
    partial class FormNurse
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPatID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtDisease = new System.Windows.Forms.TextBox();
            this.txtAllergy = new System.Windows.Forms.TextBox();
            this.radioButtonB = new System.Windows.Forms.RadioButton();
            this.radioButtonG = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerBirth = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFirst = new System.Windows.Forms.DateTimePicker();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tabPagePat = new System.Windows.Forms.TabPage();
            this.lblRegId = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtRegId = new System.Windows.Forms.TextBox();
            this.btnListAllPat = new System.Windows.Forms.Button();
            this.dgvPatient = new System.Windows.Forms.DataGridView();
            this.btnReg = new System.Windows.Forms.Button();
            this.tabPageReg = new System.Windows.Forms.TabPage();
            this.btnCancelReg = new System.Windows.Forms.Button();
            this.dgvReg = new System.Windows.Forms.DataGridView();
            this.tabControlP = new System.Windows.Forms.TabControl();
            this.txtOther = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnBackToOption = new System.Windows.Forms.Button();
            this.lblEmp = new System.Windows.Forms.Label();
            this.panelSave = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClearTxt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tabPagePat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).BeginInit();
            this.tabPageReg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReg)).BeginInit();
            this.tabControlP.SuspendLayout();
            this.panelSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.MintCream;
            this.lblTitle.Font = new System.Drawing.Font("微軟正黑體", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(30, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(182, 50);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "掛號系統";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(34, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "生日";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(35, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "性別";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(34, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "姓名";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(34, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "連絡電話";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(35, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "地址";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label8.Location = new System.Drawing.Point(36, 412);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "慢性病";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label9.Location = new System.Drawing.Point(35, 365);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "過敏史";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label10.Location = new System.Drawing.Point(34, 499);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 25);
            this.label10.TabIndex = 22;
            this.label10.Text = "初診日期";
            // 
            // txtPatID
            // 
            this.txtPatID.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPatID.Location = new System.Drawing.Point(132, 101);
            this.txtPatID.Name = "txtPatID";
            this.txtPatID.Size = new System.Drawing.Size(168, 34);
            this.txtPatID.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(132, 141);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(168, 34);
            this.txtName.TabIndex = 2;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPhone.Location = new System.Drawing.Point(132, 273);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(168, 34);
            this.txtPhone.TabIndex = 6;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAddress.Location = new System.Drawing.Point(133, 314);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(304, 34);
            this.txtAddress.TabIndex = 7;
            // 
            // txtDisease
            // 
            this.txtDisease.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDisease.Location = new System.Drawing.Point(133, 405);
            this.txtDisease.Name = "txtDisease";
            this.txtDisease.Size = new System.Drawing.Size(304, 34);
            this.txtDisease.TabIndex = 9;
            // 
            // txtAllergy
            // 
            this.txtAllergy.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAllergy.Location = new System.Drawing.Point(133, 362);
            this.txtAllergy.Name = "txtAllergy";
            this.txtAllergy.Size = new System.Drawing.Size(168, 34);
            this.txtAllergy.TabIndex = 8;
            // 
            // radioButtonB
            // 
            this.radioButtonB.AutoSize = true;
            this.radioButtonB.Checked = true;
            this.radioButtonB.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButtonB.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.radioButtonB.Location = new System.Drawing.Point(6, 15);
            this.radioButtonB.Name = "radioButtonB";
            this.radioButtonB.Size = new System.Drawing.Size(57, 29);
            this.radioButtonB.TabIndex = 3;
            this.radioButtonB.TabStop = true;
            this.radioButtonB.Text = "男";
            this.radioButtonB.UseVisualStyleBackColor = true;
            // 
            // radioButtonG
            // 
            this.radioButtonG.AutoSize = true;
            this.radioButtonG.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButtonG.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.radioButtonG.Location = new System.Drawing.Point(76, 15);
            this.radioButtonG.Name = "radioButtonG";
            this.radioButtonG.Size = new System.Drawing.Size(57, 29);
            this.radioButtonG.TabIndex = 4;
            this.radioButtonG.Text = "女";
            this.radioButtonG.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonG);
            this.groupBox1.Controls.Add(this.radioButtonB);
            this.groupBox1.Location = new System.Drawing.Point(132, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 43);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // dateTimePickerBirth
            // 
            this.dateTimePickerBirth.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePickerBirth.Location = new System.Drawing.Point(132, 227);
            this.dateTimePickerBirth.Name = "dateTimePickerBirth";
            this.dateTimePickerBirth.Size = new System.Drawing.Size(175, 34);
            this.dateTimePickerBirth.TabIndex = 5;
            this.dateTimePickerBirth.Value = new System.DateTime(1990, 1, 1, 10, 18, 0, 0);
            // 
            // dateTimePickerFirst
            // 
            this.dateTimePickerFirst.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePickerFirst.Location = new System.Drawing.Point(132, 492);
            this.dateTimePickerFirst.Name = "dateTimePickerFirst";
            this.dateTimePickerFirst.Size = new System.Drawing.Size(175, 34);
            this.dateTimePickerFirst.TabIndex = 11;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCreate.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCreate.ForeColor = System.Drawing.Color.Khaki;
            this.btnCreate.Location = new System.Drawing.Point(353, 73);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(114, 39);
            this.btnCreate.TabIndex = 37;
            this.btnCreate.Text = "建立資料";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(34, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "病人編號";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnUpdate.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Khaki;
            this.btnUpdate.Location = new System.Drawing.Point(353, 116);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(114, 39);
            this.btnUpdate.TabIndex = 41;
            this.btnUpdate.Text = "修改資料";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tabPagePat
            // 
            this.tabPagePat.Controls.Add(this.lblRegId);
            this.tabPagePat.Controls.Add(this.btnSearch);
            this.tabPagePat.Controls.Add(this.txtRegId);
            this.tabPagePat.Controls.Add(this.btnListAllPat);
            this.tabPagePat.Controls.Add(this.dgvPatient);
            this.tabPagePat.Controls.Add(this.btnReg);
            this.tabPagePat.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.tabPagePat.Location = new System.Drawing.Point(4, 40);
            this.tabPagePat.Name = "tabPagePat";
            this.tabPagePat.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePat.Size = new System.Drawing.Size(363, 465);
            this.tabPagePat.TabIndex = 1;
            this.tabPagePat.Text = "病人列表";
            this.tabPagePat.UseVisualStyleBackColor = true;
            // 
            // lblRegId
            // 
            this.lblRegId.AutoSize = true;
            this.lblRegId.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblRegId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRegId.Location = new System.Drawing.Point(262, 41);
            this.lblRegId.Name = "lblRegId";
            this.lblRegId.Size = new System.Drawing.Size(92, 25);
            this.lblRegId.TabIndex = 93;
            this.lblRegId.Text = "掛號號碼";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Gray;
            this.btnSearch.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSearch.ForeColor = System.Drawing.Color.Khaki;
            this.btnSearch.Location = new System.Drawing.Point(23, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(78, 35);
            this.btnSearch.TabIndex = 92;
            this.btnSearch.Text = "搜尋";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtRegId
            // 
            this.txtRegId.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRegId.Location = new System.Drawing.Point(276, 69);
            this.txtRegId.Name = "txtRegId";
            this.txtRegId.ReadOnly = true;
            this.txtRegId.Size = new System.Drawing.Size(68, 34);
            this.txtRegId.TabIndex = 92;
            this.txtRegId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnListAllPat
            // 
            this.btnListAllPat.BackColor = System.Drawing.Color.Gray;
            this.btnListAllPat.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnListAllPat.ForeColor = System.Drawing.Color.Khaki;
            this.btnListAllPat.Location = new System.Drawing.Point(114, 2);
            this.btnListAllPat.Name = "btnListAllPat";
            this.btnListAllPat.Size = new System.Drawing.Size(147, 35);
            this.btnListAllPat.TabIndex = 91;
            this.btnListAllPat.Text = "列出所有病人";
            this.btnListAllPat.UseVisualStyleBackColor = false;
            this.btnListAllPat.Click += new System.EventHandler(this.btnListAllPat_Click);
            // 
            // dgvPatient
            // 
            this.dgvPatient.AllowUserToAddRows = false;
            this.dgvPatient.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatient.Location = new System.Drawing.Point(23, 44);
            this.dgvPatient.Name = "dgvPatient";
            this.dgvPatient.ReadOnly = true;
            this.dgvPatient.RowHeadersWidth = 62;
            this.dgvPatient.RowTemplate.Height = 31;
            this.dgvPatient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatient.Size = new System.Drawing.Size(238, 395);
            this.dgvPatient.TabIndex = 1;
            this.dgvPatient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatient_CellClick);
            // 
            // btnReg
            // 
            this.btnReg.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnReg.Enabled = false;
            this.btnReg.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReg.ForeColor = System.Drawing.Color.Khaki;
            this.btnReg.Location = new System.Drawing.Point(268, 110);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(86, 39);
            this.btnReg.TabIndex = 90;
            this.btnReg.Text = "掛號";
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // tabPageReg
            // 
            this.tabPageReg.Controls.Add(this.btnCancelReg);
            this.tabPageReg.Controls.Add(this.dgvReg);
            this.tabPageReg.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.tabPageReg.Location = new System.Drawing.Point(4, 40);
            this.tabPageReg.Name = "tabPageReg";
            this.tabPageReg.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReg.Size = new System.Drawing.Size(363, 465);
            this.tabPageReg.TabIndex = 0;
            this.tabPageReg.Text = "掛號名單";
            this.tabPageReg.UseVisualStyleBackColor = true;
            // 
            // btnCancelReg
            // 
            this.btnCancelReg.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCancelReg.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancelReg.ForeColor = System.Drawing.Color.Khaki;
            this.btnCancelReg.Location = new System.Drawing.Point(224, 420);
            this.btnCancelReg.Name = "btnCancelReg";
            this.btnCancelReg.Size = new System.Drawing.Size(111, 39);
            this.btnCancelReg.TabIndex = 94;
            this.btnCancelReg.Text = "取消掛號";
            this.btnCancelReg.UseVisualStyleBackColor = false;
            this.btnCancelReg.Click += new System.EventHandler(this.btnCancelReg_Click);
            // 
            // dgvReg
            // 
            this.dgvReg.AllowUserToAddRows = false;
            this.dgvReg.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvReg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReg.Location = new System.Drawing.Point(27, 18);
            this.dgvReg.Name = "dgvReg";
            this.dgvReg.RowHeadersWidth = 62;
            this.dgvReg.RowTemplate.Height = 31;
            this.dgvReg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReg.Size = new System.Drawing.Size(308, 393);
            this.dgvReg.TabIndex = 2;
            this.dgvReg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReg_CellClick);
            // 
            // tabControlP
            // 
            this.tabControlP.Controls.Add(this.tabPageReg);
            this.tabControlP.Controls.Add(this.tabPagePat);
            this.tabControlP.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControlP.Location = new System.Drawing.Point(485, 62);
            this.tabControlP.Name = "tabControlP";
            this.tabControlP.SelectedIndex = 0;
            this.tabControlP.Size = new System.Drawing.Size(371, 509);
            this.tabControlP.TabIndex = 39;
            // 
            // txtOther
            // 
            this.txtOther.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtOther.Location = new System.Drawing.Point(132, 448);
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(168, 34);
            this.txtOther.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label11.Location = new System.Drawing.Point(34, 451);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 25);
            this.label11.TabIndex = 42;
            this.label11.Text = "備註";
            // 
            // btnBackToOption
            // 
            this.btnBackToOption.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnBackToOption.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBackToOption.ForeColor = System.Drawing.Color.Khaki;
            this.btnBackToOption.Location = new System.Drawing.Point(725, 577);
            this.btnBackToOption.Name = "btnBackToOption";
            this.btnBackToOption.Size = new System.Drawing.Size(114, 39);
            this.btnBackToOption.TabIndex = 44;
            this.btnBackToOption.Text = "返回選單";
            this.btnBackToOption.UseVisualStyleBackColor = false;
            this.btnBackToOption.Click += new System.EventHandler(this.btnBackToOption_Click);
            // 
            // lblEmp
            // 
            this.lblEmp.AutoSize = true;
            this.lblEmp.BackColor = System.Drawing.Color.White;
            this.lblEmp.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblEmp.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblEmp.Location = new System.Drawing.Point(492, 18);
            this.lblEmp.Name = "lblEmp";
            this.lblEmp.Size = new System.Drawing.Size(134, 31);
            this.lblEmp.TabIndex = 79;
            this.lblEmp.Text = "操作人員：";
            // 
            // panelSave
            // 
            this.panelSave.Controls.Add(this.btnCancel);
            this.panelSave.Controls.Add(this.btnSave);
            this.panelSave.Location = new System.Drawing.Point(240, 541);
            this.panelSave.Name = "panelSave";
            this.panelSave.Size = new System.Drawing.Size(239, 44);
            this.panelSave.TabIndex = 88;
            this.panelSave.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCancel.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel.ForeColor = System.Drawing.Color.Khaki;
            this.btnCancel.Location = new System.Drawing.Point(120, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 39);
            this.btnCancel.TabIndex = 86;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSave.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSave.ForeColor = System.Drawing.Color.Khaki;
            this.btnSave.Location = new System.Drawing.Point(3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 39);
            this.btnSave.TabIndex = 85;
            this.btnSave.Text = "確定";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClearTxt
            // 
            this.btnClearTxt.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnClearTxt.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClearTxt.ForeColor = System.Drawing.Color.Khaki;
            this.btnClearTxt.Location = new System.Drawing.Point(353, 161);
            this.btnClearTxt.Name = "btnClearTxt";
            this.btnClearTxt.Size = new System.Drawing.Size(114, 39);
            this.btnClearTxt.TabIndex = 91;
            this.btnClearTxt.Text = "清空欄位";
            this.btnClearTxt.UseVisualStyleBackColor = false;
            this.btnClearTxt.Click += new System.EventHandler(this.btnClearTxt_Click);
            // 
            // FormNurse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(879, 633);
            this.Controls.Add(this.btnClearTxt);
            this.Controls.Add(this.panelSave);
            this.Controls.Add(this.lblEmp);
            this.Controls.Add(this.btnBackToOption);
            this.Controls.Add(this.txtOther);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tabControlP);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dateTimePickerFirst);
            this.Controls.Add(this.dateTimePickerBirth);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtDisease);
            this.Controls.Add(this.txtAllergy);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPatID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormNurse";
            this.Text = "掛號系統";
            this.Load += new System.EventHandler(this.FormNurse_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPagePat.ResumeLayout(false);
            this.tabPagePat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).EndInit();
            this.tabPageReg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReg)).EndInit();
            this.tabControlP.ResumeLayout(false);
            this.panelSave.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPatID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtDisease;
        private System.Windows.Forms.TextBox txtAllergy;
        private System.Windows.Forms.RadioButton radioButtonB;
        private System.Windows.Forms.RadioButton radioButtonG;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirth;
        private System.Windows.Forms.DateTimePicker dateTimePickerFirst;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TabPage tabPagePat;
        private System.Windows.Forms.DataGridView dgvPatient;
        private System.Windows.Forms.TabPage tabPageReg;
        private System.Windows.Forms.TabControl tabControlP;
        private System.Windows.Forms.TextBox txtOther;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnBackToOption;
        private System.Windows.Forms.Label lblEmp;
        private System.Windows.Forms.DataGridView dgvReg;
        private System.Windows.Forms.Panel panelSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnListAllPat;
        private System.Windows.Forms.Button btnClearTxt;
        private System.Windows.Forms.TextBox txtRegId;
        private System.Windows.Forms.Label lblRegId;
        private System.Windows.Forms.Button btnCancelReg;
    }
}

