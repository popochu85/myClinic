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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace myClinic
{
    public partial class FormCaseHistory : Form
    {
        //private Patient _patient;
        private PatientRegDTO _dto;
        private CaseHistory _caseHistory;
        FormDoctor FormDoctor=new FormDoctor();
        //public FormCaseHistory(Patient patient)
        public FormCaseHistory(PatientRegDTO dto,CaseHistory caseHistory)
        {
            CaseHistoryController cc = new CaseHistoryController();
            InitializeComponent();
            dgvMedsOfPat.Columns.Add("MedSN", "藥品序號");
            dgvMedsOfPat.Columns.Add("MedName", "藥品名稱");
            dgvMedsOfPat.Columns.Add("MedFreq", "頻率");
            dgvMedsOfPat.Columns.Add("MedDose", "劑量");
            
            _dto = dto;
            _caseHistory= caseHistory;
            string caseId = _caseHistory.caseHistoryId; 
            renderDgvPtMeds(cc.getPtMeds(caseId));
        }
        private void renderDgvPtMeds(List<MedOfPtDTO> caseHistoryMeds)
        {
            List<MedOfPtDTO> medOfPtDTOs = new List<MedOfPtDTO>();
            CaseHistoryController caseHistoryController = new CaseHistoryController();
            string caseId = _caseHistory.caseHistoryId;
            medOfPtDTOs = caseHistoryController.getPtMeds(caseId);
            dgvMedsOfPat.Rows.Clear();

            foreach (MedOfPtDTO caseHistoryMed in caseHistoryMeds)
            {
                dgvMedsOfPat.Rows.Add(caseHistoryMed.caseHistory.MedSN, caseHistoryMed.medicine.MedName, caseHistoryMed.caseHistory.MedFreq, caseHistoryMed.caseHistory.MedDose);

            }
        }
        private void FormCaseHistory_Load(object sender, EventArgs e)
        {
           
            lblName.Text = $"姓名:{_dto.patient.patientName}";
            DateTime s;
            DateTime.TryParse(_dto.patient.patientBirth, out s);
            
            lblBirth.Text = $"生日:{s.ToString("yyyy-MM-dd")}";
            lblAllergy.Text=$"過敏史:{_dto.patient.allergy}";
            lblPatId.Text=$"病人編號:{_dto.patient.patientId}";
            lblGender.Text= $"性別:{_dto.patient.getGender()}";
            lblDisease.Text= $"疾病史:{_dto.patient.disease}";
            txtCc.Text = _caseHistory.cc;
            txtDx.Text = _caseHistory.dx;   

        }


    }
}
