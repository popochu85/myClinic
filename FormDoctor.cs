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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace myClinic
{
    public partial class FormDoctor : Form
    {
        private PatientRegDTO selectPatient;
        private CaseHistory CaseHistory;

        private string patientId = "";
        private string patientId2 = "";
        private int MedIdint = 0;
        private string status = "Default";
        private void checkStatus()
        {
            switch (status)
            {
                case "Create":
                    btnAddMed.Enabled = true;
                    btnDeleteMed.Enabled = true;
                    btnSave.Enabled = true;
                    break;
                case "Cant":
                    btnAddMed.Enabled = false;
                    btnDeleteMed.Enabled = false;
                    btnSave.Enabled = false;
                    break;

                case "Default":
                    btnAddMed.Enabled = true;
                    btnDeleteMed.Enabled = true;
                    btnSave.Enabled = true;
                    break;
            }
            controlSetting();
        }
        private void controlSetting()
        {
            switch (status)
            {
                case "Create":
                    txtCc.Enabled = true;
                    txtDose.Enabled = true;
                    txtDx.Enabled = true;
                    txtMed.Enabled = true;
                    comboBoxFreq.Enabled = true;
                    break;
                case "Cant":
                    txtCc.Enabled = false;
                    txtDose.Enabled = false;
                    txtDx.Enabled = false;
                    txtMed.Enabled = false;
                    comboBoxFreq.Enabled = false;
                    break;
                case "Default":
                    txtCc.Enabled = true;
                    txtDose.Enabled = true;
                    txtDx.Enabled = true;
                    txtMed.Enabled = true;
                    comboBoxFreq.Enabled = true;
                    break;
            }
        }

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
                dgvMed.Rows.Add(med.MedId, med.MedName, med.MedEf, med.MedSe, med.MedNotice);

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

            //已看診病人
            dgvOkPt.Columns.Add("regId", "順序");
            dgvOkPt.Columns.Add("patientId", "病人編號");
            dgvOkPt.Columns.Add("patientName", "姓名");
            dgvOkPt.Columns.Add("gender", "性別");
            dgvOkPt.Columns.Add("patientBirth", "生日");
            dgvOkPt.Columns.Add("allergy", "過敏史");
            dgvOkPt.Columns.Add("disease", "疾病史");
            dgvOkPt.Columns.Add("patientOther", "備註");
            dgvOkPt.Columns.Add("createdDate", "初診日");
            dgvOkPt.Columns.Add("caseHistoryId", "病歷號碼");
            dgvOkPt.Columns.Add("dx", "診斷");
            dgvOkPt.Columns.Add("cc", "主訴");

            List<PatientRegDTO> regs = new List<PatientRegDTO>();
            PatientRegDTO patientRegDTO = new PatientRegDTO();
            string keyDate = DateTime.Now.ToString("yyyy-MM-dd");
            regs = patientRegDTO.getPatientsReg(keyDate);
            foreach (PatientRegDTO reg in regs)
            {
                dgvReg.Rows.Add(reg.patientReg.regId, reg.patient.patientId, reg.patient.patientName, reg.patient.getGender(), reg.patient.patientBirth, reg.patient.allergy, reg.patient.disease, reg.patient.patientOther, reg.patient.createdDate);
            }
            dgvOkPt.Columns["patientId"].Visible = false;
            dgvOkPt.Columns["allergy"].Visible = false;
            dgvOkPt.Columns["disease"].Visible = false;
            dgvOkPt.Columns["patientBirth"].Visible = false;
            dgvOkPt.Columns["patientOther"].Visible = false;
            dgvOkPt.Columns["createdDate"].Visible = false;
            dgvOkPt.Columns["caseHistoryId"].Visible = false;
            dgvOkPt.Columns["dx"].Visible = false;
            dgvOkPt.Columns["cc"].Visible = false;
            List<PatientRegDTO> regsOk = new List<PatientRegDTO>();
            PatientRegDTO patientRegDTOOk = new PatientRegDTO();
            regsOk = patientRegDTO.getPatientsOk(keyDate);
            foreach (PatientRegDTO regOk in regsOk)
            {
                dgvOkPt.Rows.Add(regOk.patientReg.regId, regOk.patient.patientId, regOk.patient.patientName, regOk.patient.getGender(), regOk.patient.patientBirth, regOk.patient.allergy, regOk.patient.disease, regOk.patient.patientOther, regOk.patient.createdDate, regOk.caseHistory.caseHistoryId, regOk.caseHistory.dx, regOk.caseHistory.cc);
            }

            //處方
            dgvMedsOfPat.Columns.Add("caseHistoryId", "病歷編號");
            dgvMedsOfPat.Columns.Add("MedSN", "藥品序號");
            dgvMedsOfPat.Columns.Add("MedId", "藥品編號");
            dgvMedsOfPat.Columns.Add("MedName", "藥品名稱");
            dgvMedsOfPat.Columns.Add("MedFreq", "頻率");
            dgvMedsOfPat.Columns.Add("MedDose", "劑量");
            dgvMedsOfPat.Columns["caseHistoryId"].Visible = false;
            dgvMedsOfPat.Columns["MedSN"].Visible = false;
            dgvMedsOfPat.Columns["MedId"].Visible = false;

            //選取病人歷史病歷
            dgvPastHx.Columns.Add("caseHistoryId", "病歷號");
            dgvPastHx.Columns.Add("cc", "主訴");
            dgvPastHx.Columns.Add("dx", "診斷");
        }
        private void searchOkPt()
        {
            dgvOkPt.Rows.Clear();
            PatientRegDTO patientRegDTO = new PatientRegDTO();
            List<PatientRegDTO> regsOk = new List<PatientRegDTO>();
            PatientRegDTO patientRegDTOOk = new PatientRegDTO();
            string keyDate = DateTime.Now.ToString("yyyy-MM-dd");
            regsOk = patientRegDTO.getPatientsOk(keyDate);
            foreach (PatientRegDTO regOk in regsOk)
            {
                dgvOkPt.Rows.Add(regOk.patientReg.regId, regOk.patient.patientId, regOk.patient.patientName, regOk.patient.getGender(), regOk.patient.patientBirth, regOk.patient.allergy, regOk.patient.disease, regOk.patient.patientOther, regOk.patient.createdDate, regOk.caseHistory.caseHistoryId, regOk.caseHistory.dx, regOk.caseHistory.cc);
            }
        }
        private void searchRegPt()
        {
            dgvReg.Rows.Clear();
            List<PatientRegDTO> regs = new List<PatientRegDTO>();
            PatientRegDTO patientRegDTO = new PatientRegDTO();
            string keyDate = DateTime.Now.ToString("yyyy-MM-dd");
            regs = patientRegDTO.getPatientsReg(keyDate);
            foreach (PatientRegDTO reg in regs)
            {
                dgvReg.Rows.Add(reg.patientReg.regId, reg.patient.patientId, reg.patient.patientName, reg.patient.getGender(), reg.patient.patientBirth, reg.patient.allergy, reg.patient.disease, reg.patient.patientOther, reg.patient.createdDate);
            }
        }
        private void renderDgvOldHx(string patientId)
        {
            List<CaseHistory> listHx = new List<CaseHistory>();
            CaseHistoryController caseHistoryController = new CaseHistoryController();
            dgvPastHx.Rows.Clear();
            listHx = caseHistoryController.searchOldCaseHistory(patientId);
            foreach (CaseHistory hx in listHx)
            {
               

                DateTime a;
                DateTime.TryParse(hx.dxDate, out a);
                string date = a.ToString("yyyyMMdd");
                dgvPastHx.Rows.Add(date, hx.dx, hx.caseHistoryId, hx.cc, hx.dx);
            }
        }

        private void renderDgvPtMeds(List<MedOfPtDTO> caseHistoryMeds)
        {
            List<MedOfPtDTO> medOfPtDTOs = new List<MedOfPtDTO>();
            CaseHistoryController caseHistoryController = new CaseHistoryController();

            string id = txtCaseHxId.Text;
            medOfPtDTOs = caseHistoryController.getPtMeds(id);
            dgvMedsOfPat.Rows.Clear();

            foreach (MedOfPtDTO caseHistoryMed in caseHistoryMeds)
            {
                dgvMedsOfPat.Rows.Add(caseHistoryMed.caseHistory.patientId, caseHistoryMed.caseHistory.MedSN, caseHistoryMed.caseHistory.MedId, caseHistoryMed.medicine.MedName, caseHistoryMed.caseHistory.MedFreq, caseHistoryMed.caseHistory.MedDose);

            }
        }
        private void renderDgvMed(List<Medicine> meds)
        {
            dgvMed.Rows.Clear();

            foreach (Medicine med in meds)
            {
                dgvMed.Rows.Add(med.MedId, med.MedName, med.MedEf, med.MedSe, med.MedNotice);

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
            CaseHistoryController HxC = new CaseHistoryController();
            int count = 0;
            foreach (DataGridViewRow row in dgvMedsOfPat.Rows)
            {

                count += 1;
                string HxId = row.Cells["caseHistoryId"].Value.ToString();
                string MedSN = count.ToString();
                string MedId = MedIdint.ToString();
                string MedFreq = row.Cells["MedFreq"].Value.ToString();
                float medDose = 0.0f;
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
        private void cleartxt()
        {
            txtCc.Clear();
            txtDx.Clear();
            dgvMedsOfPat.Rows.Clear();
            dgvPastHx.Rows.Clear();
        }
        public void dgvReg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                cleartxt();
                PatientRegDTO patientRegDTO = GetPatientRegDTO(dgvReg, e.RowIndex);
                if (patientRegDTO != null)
                {
                    status = "Create";
                    checkStatus();
                    patientId = patientRegDTO.patient.patientId;

                    //病人編號
                    txtCaseHxId.Text = patientRegDTO.patient.patientId + DateTime.Now.ToString("yyyyMMdd");
                    lblPatId.Text = $"病人編號：{patientRegDTO.patient.patientId}";
                    lblName.Text = $"姓名：{patientRegDTO.patient.patientName}";
                    lblGender.Text = $"性別：{patientRegDTO.patient.gender}";

                    if (DateTime.TryParse(patientRegDTO.patient.patientBirth, out DateTime birth))
                    {
                        lblBirth.Text = $"生日：{birth.ToString("yyyy-MM-dd")}";
                    }
                    else
                    {
                        lblBirth.Text = $"生日：{patientRegDTO.patient.patientBirth}";
                    }

                    lblAllergy.Text = $"過敏史：{patientRegDTO.patient.allergy}";
                    lblDisease.Text = $"疾病史：{patientRegDTO.patient.disease}";
                    lblOther.Text = $"備註：{patientRegDTO.patient.patientOther}";

                    patientId2 = patientRegDTO.patient.patientId;
                    renderDgvOldHx(patientId2);
                }
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
                    dgvMedsOfPat.Rows.Add(txtCaseHxId.Text, "", MedId, MedName, comboBoxFreq.SelectedItem.ToString(), txtDose.Text);
                    txtDose.Clear();
                    comboBoxFreq.SelectedItem = null;
                }
                // 從 dgv1 中取得選中行的資料

            }
        }

        private void btnBackToOption_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"確認退出看診系統?", "確認退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            // 根據使用者的選擇執行相應的動作
            if (result == DialogResult.OK)
            {
                Close();

            }
            else
            {
                return;
            }
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
                            searchRegPt();
                            searchOkPt();
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

        private void btnDeleteMed_Click(object sender, EventArgs e)
        {
            DataGridView dgv = this.Controls["dgvMedsOfPat"] as DataGridView;
            if (dgv != null && dgv.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgv.SelectedRows)
                {
                    dgv.Rows.Remove(row);
                }
            }
            else
            {
                MessageBox.Show("請選擇要刪除的行。");
            }


        }

        private void dgvOkPt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                PatientRegDTO patientRegDTO = GetPatientRegDTO(dgvOkPt, e.RowIndex);
                if (patientRegDTO != null)
                {
                    patientId2 = patientRegDTO.patient.patientId;
                    status = "Cant";
                    checkStatus();
                    patientId = patientRegDTO.patient.patientId;
                    txtCaseHxId.Text = patientRegDTO.caseHistory.caseHistoryId;
                    lblPatId.Text = $"病人編號：{patientRegDTO.patient.patientId}";
                    lblName.Text = $"姓名：{patientRegDTO.patient.patientName}";
                    lblGender.Text = $"性別：{patientRegDTO.patient.gender}";

                    if (DateTime.TryParse(patientRegDTO.patient.patientBirth, out DateTime birth))
                    {
                        lblBirth.Text = $"生日：{birth.ToString("yyyy-MM-dd")}";
                    }
                    else
                    {
                        lblBirth.Text = $"生日：{patientRegDTO.patient.patientBirth}";
                    }

                    lblAllergy.Text = $"過敏史：{patientRegDTO.patient.allergy}";
                    lblDisease.Text = $"疾病史：{patientRegDTO.patient.disease}";
                    lblOther.Text = $"備註：{patientRegDTO.patient.patientOther}";
                    txtCc.Text = patientRegDTO.caseHistory.cc;
                    txtDx.Text = patientRegDTO.caseHistory.dx;

                    CaseHistoryController cc = new CaseHistoryController();
                    renderDgvPtMeds(cc.getPtMeds(txtCaseHxId.Text));
                    renderDgvOldHx(patientId2);
                }
            }


            //if (e.RowIndex >= 0)
            //{
            //    patientId2 = dgvOkPt.Rows[e.RowIndex].Cells["patientId"].Value.ToString();
            //    status = "Cant";
            //    checkStatus();
            //    patientId = dgvOkPt.Rows[e.RowIndex].Cells["patientId"].Value.ToString();
            //    txtCaseHxId.Text = dgvOkPt.Rows[e.RowIndex].Cells["caseHistoryId"].Value.ToString();
            //    lblPatId.Text = $"病人編號：{dgvOkPt.Rows[e.RowIndex].Cells["patientId"].Value.ToString()}";
            //    lblName.Text = $"姓名：{dgvOkPt.Rows[e.RowIndex].Cells["patientName"].Value.ToString()}";
            //    lblGender.Text = $"性別：{dgvOkPt.Rows[e.RowIndex].Cells["gender"].Value.ToString()}";
            //    string s = dgvOkPt.Rows[e.RowIndex].Cells["patientBirth"].Value.ToString();
            //    DateTime.TryParse(s, out DateTime birth);
            //    lblBirth.Text = $"生日：{birth.ToString("yyyy-MM-dd")}";
            //    lblAllergy.Text = $"過敏史：{dgvOkPt.Rows[e.RowIndex].Cells["allergy"].Value.ToString()}";
            //    lblDisease.Text = $"疾病史：{dgvOkPt.Rows[e.RowIndex].Cells["disease"].Value.ToString()}";
            //    lblOther.Text = $"備註：{dgvOkPt.Rows[e.RowIndex].Cells["patientOther"].Value.ToString()}";
            //    txtCc.Text = dgvOkPt.Rows[e.RowIndex].Cells["cc"].Value.ToString();
            //    txtDx.Text = dgvOkPt.Rows[e.RowIndex].Cells["dx"].Value.ToString();
            //    CaseHistoryController cc = new CaseHistoryController();
            //    renderDgvPtMeds(cc.getPtMeds(txtCaseHxId.Text));
            //    renderDgvOldHx(patientId2);
            //}
        }
        private CaseHistory GetCaseHistory(DataGridView dgv, int rowIndex)
        {
            CaseHistory caseHx = new CaseHistory();

            if (rowIndex >= 0 && rowIndex < dgv.Rows.Count)
            {
                // Initialize the nested objects


                // Fill in Patient details
                if (dgv.Columns.Contains("caseHistoryId"))
                    caseHx.caseHistoryId = dgv.Rows[rowIndex].Cells["caseHistoryId"].Value?.ToString();
                if (dgv.Columns.Contains("cc"))
                    caseHx.cc = dgv.Rows[rowIndex].Cells["cc"].Value?.ToString();
                if (dgv.Columns.Contains("dx"))
                    caseHx.dx = dgv.Rows[rowIndex].Cells["dx"].Value?.ToString();
                if (dgv.Columns.Contains("dxDate"))
                    caseHx.dxDate = dgv.Rows[rowIndex].Cells["dxDate"].Value?.ToString();
                //date, hx.dx, hx.caseHistoryId, hx.cc, hx.dx

                CaseHistory = caseHx;// 更新已經點選的
            }

            return caseHx;

        }
        private PatientRegDTO GetPatientRegDTO(DataGridView dgv, int rowIndex)
        {
            PatientRegDTO patientRegDTO = new PatientRegDTO();

            if (rowIndex >= 0 && rowIndex < dgv.Rows.Count)
            {
                // Initialize the nested objects
                patientRegDTO.patient = new Patient();
                patientRegDTO.caseHistory = new CaseHistory();

                // Fill in Patient details
                if (dgv.Columns.Contains("patientId"))
                    patientRegDTO.patient.patientId = dgv.Rows[rowIndex].Cells["patientId"].Value?.ToString();
                if (dgv.Columns.Contains("patientName"))
                    patientRegDTO.patient.patientName = dgv.Rows[rowIndex].Cells["patientName"].Value?.ToString();
                if (dgv.Columns.Contains("gender"))
                    patientRegDTO.patient.gender = dgv.Rows[rowIndex].Cells["gender"].Value?.ToString();
                if (dgv.Columns.Contains("patientBirth"))
                    patientRegDTO.patient.patientBirth = dgv.Rows[rowIndex].Cells["patientBirth"].Value?.ToString();
                if (dgv.Columns.Contains("allergy"))
                    patientRegDTO.patient.allergy = dgv.Rows[rowIndex].Cells["allergy"].Value?.ToString();
                if (dgv.Columns.Contains("disease"))
                    patientRegDTO.patient.disease = dgv.Rows[rowIndex].Cells["disease"].Value?.ToString();
                if (dgv.Columns.Contains("patientOther"))
                    patientRegDTO.patient.patientOther = dgv.Rows[rowIndex].Cells["patientOther"].Value?.ToString();

                // Fill in CaseHistory details
                if (dgv.Columns.Contains("caseHistoryId"))
                    patientRegDTO.caseHistory.caseHistoryId = dgv.Rows[rowIndex].Cells["caseHistoryId"].Value?.ToString();
                if (dgv.Columns.Contains("cc"))
                    patientRegDTO.caseHistory.cc = dgv.Rows[rowIndex].Cells["cc"].Value?.ToString();
                if (dgv.Columns.Contains("dx"))
                    patientRegDTO.caseHistory.dx = dgv.Rows[rowIndex].Cells["dx"].Value?.ToString();

                selectPatient = patientRegDTO;// 更新已經點選的
            }

            return patientRegDTO;
        }




        private void dgvPastHx_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                CaseHistory caseHx = GetCaseHistory(dgvPastHx, e.RowIndex);
                if (caseHx != null)
                {
                    FormCaseHistory a = new FormCaseHistory(selectPatient, CaseHistory);
                    a.ShowDialog();

                }

            }
        }
    }
}
