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

namespace myClinic
{
    public partial class FormNurse : Form
    {
        public FormNurse()
        {

            PatientController patientController = new PatientController();
            InitializeComponent();

            lblEmp.Text = $"操作人員：{GlobalSettings.employee.empName}";
            // 設定DataGridView的屬性
            dgvPatient.AutoGenerateColumns = false;
            dgvRes.AutoGenerateColumns = false;

            // 添加DataGridView的欄位
            dgvPatient.Columns.Add("patientId", "病歷號碼");
            dgvPatient.Columns.Add("patientName", "姓名");
            dgvPatient.Columns.Add("patientBirth", "生日");
            dgvPatient.Columns.Add("gender", "性別");
            dgvPatient.Columns.Add("patientPhone", "電話");
            dgvPatient.Columns.Add("patientAddress", "地址");
            dgvPatient.Columns.Add("allergy", "過敏史");
            dgvPatient.Columns.Add("disease", "疾病史");
            dgvPatient.Columns.Add("createdDate", "初診日");
            dgvPatient.Columns["disease"].Visible = false;
            dgvPatient.Columns["disease"].Visible = false;
            dgvPatient.Columns["patientAddress"].Visible = false;
            dgvPatient.Columns["disease"].Visible = false;
            dgvPatient.Columns["allergy"].Visible = false;
            dgvPatient.Columns["createdDate"].Visible = false;


            dgvRes.Columns.Add("patientId", "病歷號碼");
            dgvRes.Columns.Add("patientName", "姓名");
            dgvRes.Columns.Add("patientBirth", "生日");
            dgvRes.Columns.Add("gender", "性別");
            dgvRes.Columns.Add("patientPhone", "電話");
            dgvRes.Columns.Add("patientAddress", "地址");
            dgvRes.Columns.Add("allergy", "過敏史");
            dgvRes.Columns.Add("disease", "疾病史");
            dgvRes.Columns.Add("createdDate", "初診日");
            dgvRes.Columns["disease"].Visible = false;
            dgvRes.Columns["disease"].Visible = false;
            dgvRes.Columns["patientAddress"].Visible = false;
            dgvRes.Columns["disease"].Visible = false;
            dgvRes.Columns["allergy"].Visible = false;
            dgvRes.Columns["createdDate"].Visible = false;

            searchAllPat();
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
                
                dgvPatient.Rows.Add(pat.patientId,pat.patientName, pat.patientBirth, pat.getGender(),pat.patientPhone,pat.allergy,pat.createdDate,pat.disease,pat.patientAddress);
            }
        }
        private void btnBackToOption_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// 綁SELECT項目跟TXT
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void dataGridViewEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0)
        //    {
        //        txtEmpName.Text = dataGridViewEmp.Rows[e.RowIndex].Cells["empName"].Value.ToString();
        //        txtPwd.Text = dataGridViewEmp.Rows[e.RowIndex].Cells["pwd"].Value.ToString();
        //        txtEmpNo.Text = dataGridViewEmp.Rows[e.RowIndex].Cells["empNo"].Value.ToString();
        //        txtBirth.Text = dataGridViewEmp.Rows[e.RowIndex].Cells["birth"].Value.ToString();
        //        txtPhone.Text = dataGridViewEmp.Rows[e.RowIndex].Cells["phone"].Value.ToString();
        //        txtPosition.Text = dataGridViewEmp.Rows[e.RowIndex].Cells["position"].Value.ToString();
        //        txtCreateDate.Text = dataGridViewEmp.Rows[e.RowIndex].Cells["createdDate"].Value.ToString();
        //        string g = dataGridViewEmp.Rows[e.RowIndex].Cells["groupId"].Value.ToString();
        //        comboAuth.SelectedValue = g;

        //        if ((dataGridViewEmp.Rows[e.RowIndex].Cells["gender"].Value.ToString().Equals("B")))
        //        {
        //            rabBoy.Checked = true;
        //        }
        //        else
        //        {
        //            rabGirl.Checked = true;
        //        }
        //        txtAddress.Text = dataGridViewEmp.Rows[e.RowIndex].Cells["address"].Value.ToString();
        //    }
        }
    }


