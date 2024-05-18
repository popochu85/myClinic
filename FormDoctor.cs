using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using myClinic.Controller;
using myClinic.Model;
using myClinic.Model.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace myClinic
{
    public partial class FormDoctor : Form
    {
        private string patientId = "";
        private int MedIdint = 0;
        

        public FormDoctor()
        {
            InitializeComponent();
        }

        private void FormDoctor_Load(object sender, EventArgs e)
        {
            lblToday.Text = "看診日期：" + DateTime.Now.ToString("yyyy-MM-dd");
            lblDr.Text = $"看診醫師：{GlobalSettings.employee.empName}";
            dgvMed.Columns.Add("MedId", "藥品編號");
            dgvMed.Columns.Add("MedName", "藥品名稱");
            dgvMed.Columns.Add("MedEf", "作用");
            dgvMed.Columns.Add("MedSe", "副作用");
            dgvMed.Columns.Add("MedNotice", "注意事項");
            dgvMed.Columns["MedId"].Visible = false;

            // 清空DataGridView的資料
            dgvMedsOfPat.Rows.Clear();
            dgvPastHx.Rows.Clear();
            dgvReg.Rows.Clear();
            dgvMed.Rows.Clear();
            Medicine medicine = new Medicine();
            List<Medicine> meds = new List<Medicine>();
            MedicineController medicineController = new MedicineController();
            meds = medicineController.GetMeds();
            foreach (Medicine med in meds)
            {
                dgvMed.Rows.Add(med.MedId,med.MedName, med.MedEf, med.MedSe, med.MedNotice);

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
            foreach (PatientRegDTO reg in regs)
            {
                dgvReg.Rows.Add(reg.patientReg.regId, reg.patient.patientId, reg.patient.patientName, reg.patient.getGender(), reg.patient.patientBirth, reg.patient.allergy, reg.patient.disease, reg.patient.patientOther, reg.patient.createdDate);
            }
            dgvMedsOfPat.Columns.Add("caseHistoryId", "病歷編號");
            dgvMedsOfPat.Columns.Add("MedSN", "藥品序號");
            dgvMedsOfPat.Columns.Add("MedId", "藥品編號");
            dgvMedsOfPat.Columns.Add("MedName", "藥品名稱");
            dgvMedsOfPat.Columns.Add("MedFreq", "頻率");
            dgvMedsOfPat.Columns.Add("MedDose", "劑量");
            dgvMedsOfPat.Columns["caseHistoryId"].Visible = false;
            dgvMedsOfPat.Columns["MedSN"].Visible = false;
            dgvMedsOfPat.Columns["MedId"].Visible = false;
        }
        private void renderDgvMed(List<Medicine> meds)
        {
            dgvMed.Rows.Clear();

            foreach (Medicine med in meds)
            {
                dgvMed.Rows.Add(med.MedId,med.MedName, med.MedEf, med.MedSe, med.MedNotice);

            }
        }
        private CaseHistory getBindingHx()
        {
            CaseHistory caseHx = new CaseHistory();
            caseHx.caseHistoryId = txtCaseHxId.Text;
            caseHx.patientId = patientId;
            caseHx.dx = txtDx.Text;
            caseHx.cc = txtCc.Text;
            caseHx.empNo = GlobalSettings.employee.empNo;
            caseHx.dxDate = DateTime.Now.ToString("yyyyMMdd");
            return caseHx;

        }
        private CaseHistory getBindingMedOfPt()
        {
            CaseHistory caseMedOfPt = new CaseHistory();
            CaseHistoryController HxC=new CaseHistoryController();
            int count = 0;
            foreach (DataGridViewRow row in dgvMedsOfPat.Rows)
            {
                
                count += 1;
                string HxId = row.Cells["caseHistoryId"].Value.ToString();
                string MedSN = count.ToString();
                string MedId = MedIdint.ToString();
                string MedFreq = row.Cells["MedFreq"].Value.ToString();
                float medDose=0.0f;
                var value = row.Cells["MedDose"].Value;

                if (value != null && float.TryParse(value.ToString(), out medDose))
                {
                    // 轉換成功
                    Console.WriteLine($"MedDose: {medDose}");
                }
                else
                {
                    // 轉換失敗，處理錯誤
                    Console.WriteLine("無法轉換成浮點數");
                }
                caseMedOfPt.caseHistoryId = HxId;
                caseMedOfPt.MedSN = MedSN;
                caseMedOfPt.MedId = MedId;
                caseMedOfPt.MedDose = medDose;
                caseMedOfPt.MedFreq = MedFreq;

                HxC.addMed(caseMedOfPt);
            }
            return caseMedOfPt;

        }
        private void dgvReg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                patientId = dgvReg.Rows[e.RowIndex].Cells["patientId"].Value.ToString();
                //病人編號
                txtCaseHxId.Text = dgvReg.Rows[e.RowIndex].Cells["patientId"].Value.ToString() + DateTime.Now.ToString("yyyyMMdd");
                lblPatId.Text = $"病人編號：{dgvReg.Rows[e.RowIndex].Cells["patientId"].Value.ToString()}";
                lblName.Text = $"姓名：{dgvReg.Rows[e.RowIndex].Cells["patientName"].Value.ToString()}";
                lblGender.Text = $"性別：{dgvReg.Rows[e.RowIndex].Cells["gender"].Value.ToString()}";
                string s = dgvReg.Rows[e.RowIndex].Cells["patientBirth"].Value.ToString();
                DateTime.TryParse(s, out DateTime birth);
                lblBirth.Text = $"生日：{birth.ToString("yyyy-MM-dd")}";
                lblAllergy.Text = $"過敏史：{dgvReg.Rows[e.RowIndex].Cells["allergy"].Value.ToString()}";
                lblDisease.Text = $"疾病史：{dgvReg.Rows[e.RowIndex].Cells["disease"].Value.ToString()}";
                lblOther.Text = $"備註：{dgvReg.Rows[e.RowIndex].Cells["patientOther"].Value.ToString()}";

            }
        }

        private void btnAddMed_Click(object sender, EventArgs e)
        {
            if (dgvMed.SelectedRows.Count > 0)
            {
                if (comboBoxFreq.Text.Equals(""))
                {
                    MessageBox.Show("請選擇服藥頻率!!");

                }
                else if (txtDose.Text == "")
                {
                    MessageBox.Show("請輸入劑量!!");
                }

                else
                {
                    string MedId = dgvMed.SelectedRows[0].Cells[0].Value.ToString();
                    string MedName = dgvMed.SelectedRows[0].Cells[1].Value.ToString();

                    // 將選中行的資料加入 dgv2 中
                    dgvMedsOfPat.Rows.Add(txtCaseHxId.Text, "",MedId, MedName, comboBoxFreq.SelectedItem.ToString(), txtDose.Text);
                    txtDose.Clear();
                    comboBoxFreq.SelectedItem = null;
                }
                // 從 dgv1 中取得選中行的資料

            }
        }

        private void btnBackToOption_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSearchMed_Click(object sender, EventArgs e)
        {
            dgvMed.Rows.Clear();
            List<Medicine> meds = new List<Medicine>();
            MedicineController medController = new MedicineController();
            renderDgvMed(medController.GetMedicines(txtMed.Text));
            if (dgvMed.RowCount == 0)
            {
                MessageBox.Show("查無此藥!!");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CaseHistory Hx = getBindingHx();
            CaseHistoryController chc = new CaseHistoryController();
            DialogResult result = MessageBox.Show($"確認儲存病歷紀錄?", "確認儲存", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            // 根據使用者的選擇執行相應的動作
            if (result == DialogResult.OK)
            {
                if (Hx != null) 
                {
                    if (Hx.caseHistoryId != null)
                    {
                        string msg = chc.addNewHx(Hx);
                     
                        if (msg.Equals(""))
                        {

                            CaseHistory Med = getBindingMedOfPt();
                            MessageBox.Show("病歷紀錄儲存成功");
                            //刷新方式________!
                        }
                        else
                        {
                            MessageBox.Show("儲存失敗:" + msg);
                        }


                    }
                }
            }
        }

        private void dgvMed_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                MedIdint = Convert.ToInt32(dgvMed.Rows[e.RowIndex].Cells["MedId"].Value);
            }
        }
    }
}
