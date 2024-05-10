using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using myClinic.Controller;
using myClinic.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            dgvPatient.Columns.Add("patientId", "病歷號碼");
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
            dgvReg.Columns["disease"].Visible = false;
            dgvReg.Columns["disease"].Visible = false;
            dgvReg.Columns["patientAddress"].Visible = false;
            dgvReg.Columns["disease"].Visible = false;
            dgvReg.Columns["allergy"].Visible = false;
            dgvReg.Columns["patientOther"].Visible = false;
            dgvReg.Columns["createdDate"].Visible = false;

            searchAllPat();
        }
        private void FormNurse_Load(object sender, EventArgs e)
        {
        }
        private void searchAllPat()
        {
            // 清空DataGridView的資料
            dgvPatient.Rows.Clear();
            List<Patient> patients = new List<Patient>();
            PatientController patientController = new PatientController();
            // 取得員工資料
            patients = patientController.getPatients();
            renderDgv(patients);
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

                dgvPatient.Rows.Add(pat.patientId, pat.patientName, pat.getGender(), pat.patientBirth, pat.allergy, pat.disease, pat.patientAddress, pat.patientPhone, pat.patientOther, pat.createdDate);
            }
        }
        private void clearTxt()
        {
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

            if (txtPatID.Text.Equals(""))
            {
                MessageBox.Show("請選擇一筆資料!");
                return;
            }

            //要把資料存到[myClinic].[dbo].[PatientReg]


            PatientController patientController = new PatientController();
            if (txtPatID.Text.Equals(""))
            {
                MessageBox.Show("請選擇一筆資料!");
                return;
            }
            else
            {
                Patient pat = getBindingPat();
                DialogResult result = MessageBox.Show($"確認病人{pat.patientName}掛號?", "確認掛號", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                // 根據使用者的選擇執行相應的動作
                if (result == DialogResult.OK)
                {
                    if (patientController.regPat(pat))
                    {
                        MessageBox.Show("掛號成功!");
                    }
                    else
                    {
                        MessageBox.Show("掛號失敗。");
                    }
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

            Patient pat=new Patient();
            pat.patientId = txtPatID.Text;
            pat.patientName= txtName.Text;
            pat.gender = (radioButtonB.Checked) ? "B" : "G";
            pat.patientBirth = dateTimePickerBirth.Value.ToString("yyyy-MM-dd");
            pat.allergy=txtAllergy.Text;
            pat.disease=txtDisease.Text;
            pat.patientAddress=txtAddress.Text;
            pat.patientPhone=txtPhone.Text;
            pat.patientOther=txtOther.Text;
            pat.createdDate=dateTimePickerFirst.Value.ToString("yyyy-MM-dd");
            return pat;
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
            PatientController patientController = new PatientController();
            renderDgv(patientController.GetPatients(txtPatID.Text, txtName.Text,txtPhone.Text,txtAddress.Text));
            if (dgvPatient.RowCount == 0)
            {
                MessageBox.Show("查無此人!!");
            }
        }

        private void btnClearTxt_Click(object sender, EventArgs e)
        {
            clearTxt();
        }
    }
}

