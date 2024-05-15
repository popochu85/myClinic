using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myClinic.Model.DTO
{
    public class PatientRegDTO
    {
        public Patient patient;
        public PatientReg patientReg;

        public List<PatientRegDTO> getPatientsReg(string keyDate)
        {
            SQLConnectMaster sqlConnect = new SQLConnectMaster();// 不傳遞, 使用預設全域變數的連線字串
            List<PatientRegDTO> patientRegDTOs = new List<PatientRegDTO>();
            string query = "SELECT P.*, R.*  from [myClinic].[dbo].[Patients] as P join [myClinic].[dbo].[PatientReg] as R on p.patientId=r.patientId" +
                $" WHERE R.regDate ='{keyDate}'and caseHistoryId=''"; // 輸入日期查詢
            // 使用 SQLConnect 來執行查詢並且取得結果
            using (DataTable DT = sqlConnect.ExecuteDataTable(query))
            {
                foreach (DataRow row in DT.Rows)
                {
                    string patientId = row["patientId"].ToString();
                    int regId = Convert.ToInt32(row["regId"]);
                    PatientReg patientReg = new PatientReg
                    {
                        regId = Convert.ToInt32(row["regId"]),
                        regDate = DateTime.Parse(row["regDate"].ToString()),
                        patientId = row["patientId"].ToString(),
                        caseHistoryId = row["caseHistoryId"].ToString(),
                    };

                    Patient patient = new Patient
                    {
                        patientId = row["patientId"].ToString(),
                        patientBirth = row["patientBirth"].ToString(),
                        gender = row["gender"].ToString(),
                        patientName = row["patientName"].ToString(),
                        patientPhone = row["patientPhone"].ToString(),
                        patientAddress = row["patientAddress"].ToString(),
                        allergy = row["allergy"].ToString(),
                        disease = row["disease"].ToString(),
                        patientOther = row["patientOther"].ToString(),
                        createdDate = row["createdDate"].ToString()
                    };
                    PatientRegDTO patientRegDTO = new PatientRegDTO
                    {
                        patient = patient,
                        patientReg = patientReg,

                    };

                    patientRegDTOs.Add(patientRegDTO);
                }
            }

            return patientRegDTOs;
        }
    }
}
