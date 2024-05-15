using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using myClinic.Controller;
using myClinic.Model;
using myClinic.Model.DTO;

namespace myClinic
{
    public partial class FormDoctor : Form
    {
        public FormDoctor()
        {
            InitializeComponent();
        }

        private void FormDoctor_Load(object sender, EventArgs e)
        {
            lblToday.Text = "看診日期："+DateTime.Now.ToString("yyyy-MM-dd");
            lblDr.Text=$"看診醫師：{GlobalSettings.employee.empName}"; 
            dgvMed.Columns.Add("MedName", "藥品名稱");
            dgvMed.Columns.Add("MedEf", "作用");
            dgvMed.Columns.Add("MedSe", "副作用");
            dgvMed.Columns.Add("MedNotice", "注意事項");
            
            // 清空DataGridView的資料
            dgvMed.Rows.Clear();
            dgvMedsOfPat.Rows.Clear();
            dgvPastHx.Rows.Clear();
            dgvReg.Rows.Clear();
            List<Medicine> meds = new List<Medicine>();
            MedicineController medController = new MedicineController();
            // 取得資料
            meds = medController.GetMeds();

            // 將員工資料加入到DataGridView
            foreach (Medicine med in meds)
            {
                dgvMed.Rows.Add(med.MedName, med.MedEf, med.MedSe, med.MedNotice);

            }
            //未看診病人

            dgvReg.Columns.Add("regId", "順序");
            dgvReg.Columns.Add("patientId", "病人編號");
            dgvReg.Columns.Add("patientName", "姓名");
            dgvReg.Columns.Add("gender", "性別");
            dgvReg.Columns.Add("patientBirth", "生日");
            dgvReg.Columns.Add("allergy", "過敏史");
            dgvReg.Columns.Add("disease", "疾病史");
            dgvReg.Columns.Add("patientOther", "備註");
            dgvReg.Columns.Add("createdDate", "初診日");
            dgvReg.Columns["patientId"].Visible = false;
            dgvReg.Columns["allergy"].Visible = false;
            dgvReg.Columns["disease"].Visible = false;
            dgvReg.Columns["patientBirth"].Visible = false;
            dgvReg.Columns["patientOther"].Visible = false;
            dgvReg.Columns["createdDate"].Visible = false;
            List<PatientRegDTO> regs = new List<PatientRegDTO>();
            PatientRegDTO patientRegDTO = new PatientRegDTO();
            string keyDate = DateTime.Now.ToString("yyyy-MM-dd");
            regs = patientRegDTO.getPatientsReg(keyDate);
            foreach(PatientRegDTO reg in regs)
            {
                dgvReg.Rows.Add(reg.patientReg.regId,reg.patient.patientId,reg.patient.patientName,reg.patient.getGender(),reg.patient.patientBirth,reg.patient.allergy,reg.patient.disease,reg.patient.patientOther,reg.patient.createdDate);
            }
            List<CaseHistory> caseHx = new List<CaseHistory>();//病歷、藥單
        }

        private void dgvReg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                lblPatId.Text = $"病人編號：{dgvReg.Rows[e.RowIndex].Cells["patientId"].Value.ToString()}";
                lblName.Text = $"姓名：{dgvReg.Rows[e.RowIndex].Cells["patientName"].Value.ToString()}";
                lblGender.Text= $"性別：{dgvReg.Rows[e.RowIndex].Cells["gender"].Value.ToString()}";
                lblBirth.Text= $"生日：{dgvReg.Rows[e.RowIndex].Cells["patientBirth"].Value.ToString()}"; 
                lblAllergy.Text = $"過敏史：{dgvReg.Rows[e.RowIndex].Cells["allergy"].Value.ToString()}";
                lblDisease.Text= $"疾病史：{dgvReg.Rows[e.RowIndex].Cells["disease"].Value.ToString()}";
                lblOther.Text= $"備註：{dgvReg.Rows[e.RowIndex].Cells["patientOther"].Value.ToString()}";
                
            }
        }

        private void btnAddMed_Click(object sender, EventArgs e)
        {
            if (dgvMed.SelectedRows.Count > 0)
            {
                // 從 dgv1 中取得選中行的資料
                string dataToAdd = dgvMed.SelectedRows[0].Cells[0].Value.ToString();

                // 將選中行的資料加入 dgv2 中
                dgvMed.Rows.Add(dataToAdd,comboBoxFreq.SelectedIndex.ToString(),txtDose.Text);
            }
        }
    }
}
