using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using myClinic.Controller;
using myClinic.Model;
using myClinic.Model.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace myClinic
{
    public partial class FormNurse : Form
    {
        private string status = "Default";
        public FormNurse()
        {

            PatientController patientController = new PatientController();
            InitializeComponent();

            lblEmp.Text = $"操作人員：{GlobalSettings.employee.empName}";
            // 設定DataGridView的屬性
            dgvPatient.AutoGenerateColumns = false;
            dgvReg.AutoGenerateColumns = false;

            // 添加DataGridView的欄位
            dgvPatient.Columns.Add("patientId", "病人編號");
            dgvPatient.Columns.Add("patientName", "姓名");
            dgvPatient.Columns.Add("gender", "性別");
            dgvPatient.Columns.Add("patientBirth", "生日");
            dgvPatient.Columns.Add("allergy", "過敏史");
            dgvPatient.Columns.Add("disease", "疾病史");
            dgvPatient.Columns.Add("patientAddress", "地址");
            dgvPatient.Columns.Add("patientPhone", "電話");
            dgvPatient.Columns.Add("patientOther", "備註");
            dgvPatient.Columns.Add("createdDate", "初診日");
            dgvPatient.Columns["disease"].Visible = false;
            dgvPatient.Columns["disease"].Visible = false;
            dgvPatient.Columns["patientAddress"].Visible = false;
            dgvPatient.Columns["disease"].Visible = false;
            dgvPatient.Columns["allergy"].Visible = false;
            dgvPatient.Columns["patientOther"].Visible = false;
            dgvPatient.Columns["createdDate"].Visible = false;

            dgvReg.Columns.Add("regId", "順序");
            dgvReg.Columns.Add("patientId", "病歷號碼");
            dgvReg.Columns.Add("patientName", "姓名");
            dgvReg.Columns.Add("gender", "性別");
            dgvReg.Columns.Add("patientBirth", "生日");
            dgvReg.Columns.Add("allergy", "過敏史");
            dgvReg.Columns.Add("disease", "疾病史");
            dgvReg.Columns.Add("patientAddress", "地址");
            dgvReg.Columns.Add("patientPhone", "電話");
            dgvReg.Columns.Add("patientOther", "備註");
            dgvReg.Columns.Add("createdDate", "初診日");
            dgvReg.Columns["patientId"].Visible = false;
            dgvReg.Columns["allergy"].Visible = false;
            dgvReg.Columns["disease"].Visible = false;
            dgvReg.Columns["patientAddress"].Visible = false;
            dgvReg.Columns["patientPhone"].Visible = false;
            dgvReg.Columns["patientOther"].Visible = false;
            dgvReg.Columns["createdDate"].Visible = false;



            searchAllPat();
        }
        private void FormNurse_Load(object sender, EventArgs e)
        {

            upateRegNum();
        }
        private void upateRegNum()
        {
            txtRegId.Clear();
            PatientController patientController = new PatientController();
            string today = DateTime.Now.ToString("yyyy-MM-dd");
            Console.WriteLine(today);
            string regIdResult = "";
            int regID = patientController.getMaxRegID(today, out regIdResult);
            if (regIdResult.Equals(""))
            {
                txtRegId.Text = (1 + regID ).ToString();
            }
        }
        private void searchAllPat()
        {
            // 清空DataGridView的資料
            dgvPatient.Rows.Clear();
            List<Patient> patients = new List<Patient>();
            List<PatientRegDTO> regs = new List<PatientRegDTO>();
            PatientController patientController = new PatientController();
            
            patients = patientController.getPatients();
            renderDgv(patients);
            string keyDate = DateTime.Now.ToString("yyyy-MM-dd");// 這個畫面預設查詢今天
            regs = patientController.getPatientsReg(keyDate);
            renderDgvReg(regs);
        }
        /// <summary>
        /// 搜尋後DGV呈現資料
        /// </summary>
        /// <param name="employees"></param>
        private void renderDgv(List<Patient> patients)
        {
            // 清空DataGridView的資料
            dgvPatient.Rows.Clear();
            // 將員工資料加入到DataGridView
            foreach (Patient pat in patients)
            {

                dgvPatient.Rows.Add( pat.patientId, pat.patientName, pat.getGender(), pat.patientBirth, pat.allergy, pat.disease, pat.patientAddress, pat.patientPhone, pat.patientOther, pat.createdDate);
            }
        }
        private void renderDgvReg(List<PatientRegDTO> regs)
        {
            // 清空DataGridView的資料
            dgvReg.Rows.Clear();
            // 將資料加入到DataGridView
            foreach (PatientRegDTO reg in regs)
            {
                dgvReg.Rows.Add(reg.patientReg.regId, reg.patientReg.patientId, reg.patient.patientName, reg.patient.getGender(), reg.patient.patientBirth, reg.patient.allergy, reg.patient.disease, reg.patient.patientAddress, reg.patient.patientPhone, reg.patient.patientOther, reg.patient.createdDate);
            }
        }
        private void clearTxt()
        {
            radioButtonB.Checked = true;
            dateTimePickerBirth.Value =new DateTime(1990,01,01);
            dateTimePickerFirst.Value=DateTime.Now;
            txtPatID.Clear();
            txtName.Clear();
            txtAllergy.Clear();
            txtDisease.Clear();
            txtOther.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
        }
        private void btnBackToOption_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void dgvPatient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                btnReg.Enabled = true;

                upateRegNum();
                txtPatID.Text = dgvPatient.Rows[e.RowIndex].Cells["patientId"].Value.ToString();
                txtName.Text = dgvPatient.Rows[e.RowIndex].Cells["patientName"].Value.ToString();
                if ((dgvPatient.Rows[e.RowIndex].Cells["gender"].Value.ToString().Equals("男")))
                {
                    radioButtonB.Checked = true;
                }
                else
                {
                    radioButtonG.Checked = true;
                }
                dateTimePickerBirth.Text = dgvPatient.Rows[e.RowIndex].Cells["patientBirth"].Value.ToString();

                txtAllergy.Text = dgvPatient.Rows[e.RowIndex].Cells["allergy"].Value.ToString();
                txtDisease.Text = dgvPatient.Rows[e.RowIndex].Cells["disease"].Value.ToString();
                txtAddress.Text = dgvPatient.Rows[e.RowIndex].Cells["patientAddress"].Value.ToString();
                txtPhone.Text = dgvPatient.Rows[e.RowIndex].Cells["patientPhone"].Value.ToString();
                txtOther.Text = dgvPatient.Rows[e.RowIndex].Cells["patientOther"].Value.ToString();
                dateTimePickerFirst.Text = dgvPatient.Rows[e.RowIndex].Cells["createdDate"].Value.ToString();

            }
        }



        private void checkStatus()
        {
            switch (status)
            {
                case "Create":
                    lblTitle.Text = "病人資料-新增";
                    btnCreate.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnSearch.Enabled = false;
                    dgvPatient.Enabled = false;
                    dgvReg.Enabled = false;
                    panelSave.Visible = true;
                    btnClearTxt.Enabled = true;
                    break;
                case "Update":
                    lblTitle.Text = "病人資料-修改";
                    btnCreate.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnSearch.Enabled = false;
                    dgvPatient.Enabled = false;
                    dgvReg.Enabled = false;
                    panelSave.Visible = true;
                    btnClearTxt.Enabled = false;
                    break;
                //case "Registered":
                //    lblTitle.Text = "掛號";
                //    btnCreate.Enabled = false;
                //    btnUpdate.Enabled = false;
                //    btnSearch.Enabled = false;
                //    dgvPatient.Enabled = false;
                //    dgvReg.Enabled = false;
                //    panelSave.Visible = true;
                //    btnReg.Enabled = true;
                //    break;

                case "Default":
                    lblTitle.Text = "掛號系統";
                    btnCreate.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnSearch.Enabled = true;
                    dgvPatient.Enabled = true;
                    dgvReg.Enabled = true;
                    panelSave.Visible = false;
                    btnClearTxt.Enabled = true;
                    break;
            }
            controlSetting();
        }
        private void controlSetting()
        {
            switch (status)
            {
                case "Create":
                    txtPatID.ReadOnly = false;
                    txtName.ReadOnly = false;
                    txtAddress.ReadOnly = false;
                    txtAllergy.ReadOnly = false;
                    txtDisease.ReadOnly = false;
                    txtOther.ReadOnly = false;
                    txtPhone.ReadOnly = false;
                    radioButtonB.Enabled = true;
                    radioButtonG.Enabled = true;
                    dateTimePickerBirth.Enabled = true;
                    dateTimePickerFirst.Enabled = true;
                    break;
                case "Update":
                    txtPatID.ReadOnly = true;
                    txtName.ReadOnly = false;
                    txtAddress.ReadOnly = false;
                    txtAllergy.ReadOnly = false;
                    txtDisease.ReadOnly = false;
                    txtOther.ReadOnly = false;
                    txtPhone.ReadOnly = false;
                    radioButtonB.Enabled = true;
                    radioButtonG.Enabled = true;
                    dateTimePickerBirth.Enabled = true;
                    dateTimePickerFirst.Enabled = false;
                    break;
                //case "Registered":
                //    txtPatID.ReadOnly = true;
                //    txtName.ReadOnly = true;
                //    txtAddress.ReadOnly = true;
                //    txtAllergy.ReadOnly = true;
                //    txtDisease.ReadOnly = true;
                //    txtOther.ReadOnly = true;
                //    txtPhone.ReadOnly = true;
                //    radioButtonB.Enabled = false;
                //    radioButtonG.Enabled = false;
                //    dateTimePickerBirth.Enabled = false;
                //    dateTimePickerFirst.Enabled = false;
                //    break;
                case "Default":
                    txtPatID.ReadOnly = false;
                    txtName.ReadOnly = false;
                    txtAddress.ReadOnly = false;
                    txtAllergy.ReadOnly = false;
                    txtDisease.ReadOnly = false;
                    txtOther.ReadOnly = false;
                    txtPhone.ReadOnly = false;
                    radioButtonB.Enabled = true;
                    radioButtonG.Enabled = true;
                    dateTimePickerBirth.Enabled = true;
                    dateTimePickerFirst.Enabled = true;
                    break;
            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {

            
            upateRegNum();
            //要把資料存到[myClinic].[dbo].[PatientReg]
            PatientController patientController = new PatientController();
            if (txtPatID.Text.Equals(""))
            {
                MessageBox.Show("請選擇一筆資料!");
                return;
            }
            else
            {
                if (dgvPatient.SelectedRows.Count > 0)
                {
                    string selectV1= dgvPatient.SelectedRows[0].Cells["patientName"].Value.ToString();
                    string selectV2= dgvPatient.SelectedRows[0].Cells["patientPhone"].Value.ToString();
                    string selectV3 = dgvPatient.SelectedRows[0].Cells["patientBirth"].Value.ToString();
                    foreach (DataGridViewRow row in dgvReg.Rows)
                    {
                        // 取得 DataGridView2 中指定資料欄的值
                        string V1 = row.Cells["patientName"].Value.ToString();
                        string V2 = row.Cells["patientPhone"].Value.ToString();
                        string V3 = row.Cells["patientBirth"].Value.ToString();
                        // 檢查是否不相等
                        if ((selectV1 == V1)&&(selectV2 == V2)&&(selectV3 == V3))
                        {
                            MessageBox.Show("請勿重複掛號!!");
                            return;
                            // 如果找到不相等的情況，執行你的後續處理
                            // 這裡可以是你想要執行的程式碼
                            // 例如顯示訊息、更新資料、呼叫其他方法等
                        }
                    }
                }
                PatientReg reg = getBindingReg();
                Patient patient = getBindingPat();
                DialogResult result = MessageBox.Show($"確認病人{patient.patientName}掛號?", "確認掛號", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                // 根據使用者的選擇執行相應的動作
                if (result == DialogResult.OK)
                {
                    string msg = patientController.regPat(reg);
                    if (msg == "")
                    {
                        MessageBox.Show("掛號成功!");
                        tabControlP.SelectedTab = tabPageReg;
                    }
                    else
                    {
                        MessageBox.Show("掛號失敗。:"+ msg);
                    }

                    searchAllPat();
                }
                else
                {
                    // 使用者選擇了取消，不執行刪除動作
                    MessageBox.Show("取消掛號。");
                }
            }



        }



        /// <summary>
        /// 把畫面元件蒐集匯聚成新的Emp
        /// </summary>
        /// <returns></returns>
        private Patient getBindingPat()
        {

            Patient pat = new Patient();
            pat.patientId = txtPatID.Text;
            pat.patientName = txtName.Text;
            pat.gender = (radioButtonB.Checked) ? "B" : "G";
            pat.patientBirth = dateTimePickerBirth.Value.ToString("yyyy-MM-dd");
            pat.allergy = txtAllergy.Text;
            pat.disease = txtDisease.Text;
            pat.patientAddress = txtAddress.Text;
            pat.patientPhone = txtPhone.Text;
            pat.patientOther = txtOther.Text;
            pat.createdDate = dateTimePickerFirst.Value.ToString("yyyy-MM-dd");
            return pat;
        }
        private PatientReg getBindingReg()
        {

            PatientReg reg = new PatientReg();
            reg.patientId = txtPatID.Text;
            Int32.TryParse(txtRegId.Text, out int regId);
            reg.regId = regId;
            reg.regDate = DateTime.Now;
            reg.caseHistoryId = "";
            return reg;
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            clearTxt();
            status = "Create";
            checkStatus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            PatientController patientController = new PatientController();
            Patient pat = getBindingPat();
            if (status.Equals("Create"))
            {

                string result = patientController.insertPat(pat);
                if (result.Equals(""))
                {
                    MessageBox.Show("新增成功");
                    tabControlP.SelectedTab = tabPagePat;
                }
                else
                {
                    MessageBox.Show("新增失敗:" + result);
                    return;
                }
            }
            else if (status.Equals("Update"))
            {
                string result = patientController.updatePat(pat);
                if (result.Equals(""))
                {
                    MessageBox.Show("更新成功");
                }
                else
                {
                    MessageBox.Show("更新失敗:" + result);
                    return;
                }

            }

            status = "Default";
            checkStatus();
            searchAllPat();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtPatID.Text.Equals(""))
            {
                MessageBox.Show("請選擇一筆資料!");
                return;
            }
            status = "Update";
            checkStatus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            status = "Default";
            checkStatus();
        }

        private void btnListAllPat_Click(object sender, EventArgs e)
        {

            searchAllPat();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            upateRegNum();
            PatientController patientController = new PatientController();
            renderDgv(patientController.GetPatients(txtPatID.Text, txtName.Text, txtPhone.Text, txtAddress.Text));
            if (dgvPatient.RowCount == 0)
            {
                MessageBox.Show("查無此人!!");
            }
        }

        private void btnClearTxt_Click(object sender, EventArgs e)
        {
            clearTxt();
        }

        private void dgvReg_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex >= 0)
            {

                btnReg.Enabled = false;
                txtRegId.Text = dgvReg.Rows[e.RowIndex].Cells["RegId"].Value.ToString();
                txtPatID.Text = dgvReg.Rows[e.RowIndex].Cells["patientId"].Value.ToString();
                txtName.Text = dgvReg.Rows[e.RowIndex].Cells["patientName"].Value.ToString();

                if ((dgvReg.Rows[e.RowIndex].Cells["gender"].Value.ToString().Equals("男")))
                {
                    radioButtonB.Checked = true;
                }
                else
                {
                    radioButtonG.Checked = true;
                }
                dateTimePickerBirth.Text = dgvReg.Rows[e.RowIndex].Cells["patientBirth"].Value.ToString();

                txtAllergy.Text = dgvReg.Rows[e.RowIndex].Cells["allergy"].Value.ToString();
                txtDisease.Text = dgvReg.Rows[e.RowIndex].Cells["disease"].Value.ToString();
                txtAddress.Text = dgvReg.Rows[e.RowIndex].Cells["patientAddress"].Value.ToString();
                txtPhone.Text = dgvReg.Rows[e.RowIndex].Cells["patientPhone"].Value.ToString();
                txtOther.Text = dgvReg.Rows[e.RowIndex].Cells["patientOther"].Value.ToString();
                dateTimePickerFirst.Text = dgvReg.Rows[e.RowIndex].Cells["createdDate"].Value.ToString();

            }
        }

        private void btnCancelReg_Click(object sender, EventArgs e)
        {
            PatientController pc=new PatientController();
            PatientReg reg = getBindingReg();
            if (dgvReg.SelectedRows.Count > 0)
            {
                // 取得第一個選中的行
                DataGridViewRow selectedRow = dgvReg.SelectedRows[0];

                // 取得指定欄位的值
                string name = selectedRow.Cells["patientName"].Value.ToString();

                // 在這裡使用取得的值進行後續處理

                DialogResult result = MessageBox.Show($"確認取消{name}掛號?", "確認掛號", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                // 根據使用者的選擇執行相應的動作
                if (result == DialogResult.OK)
                {
                    if (reg != null)
                    {
                        if (reg.regId != 0 && reg.regDate != null)
                        {
                            string msg = pc.cancelReg(reg);
                            if (msg.Equals(""))
                            {
                                MessageBox.Show("取消掛號成功");
                                searchAllPat();
                            }
                            else
                            {
                                MessageBox.Show("取消掛號失敗:" + msg);
                            }


                        }
                    }

                    searchAllPat();
                }
                else
                {
                    // 使用者選擇了取消，不執行刪除動作
                }
            }
        }
    }
}

