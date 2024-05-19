using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myClinic.Model.DTO
{
    public class MedOfPtDTO
    {
        public Medicine medicine;
        public CaseHistory caseHistory;
        public List<MedOfPtDTO> getPtMeds(string caseHxId)
        {
            SQLConnectMaster sqlConnect = new SQLConnectMaster();// 不傳遞, 使用預設全域變數的連線字串
            List<MedOfPtDTO> medOfPtDTOs = new List<MedOfPtDTO>();
            string query = $"SELECT *from MedOfPT join Medicine on MedOfPT.MedId=Medicine.MedId where caseHistoryId='{caseHxId}'"; 
            // 使用 SQLConnect 來執行查詢並且取得結果
            using (DataTable DT = sqlConnect.ExecuteDataTable(query))
            {
                foreach (DataRow row in DT.Rows)
                {
                    
                    CaseHistory caseHistory=new CaseHistory
                    {
                        caseHistoryId = row["caseHistoryId"].ToString(),
                        MedSN = row["MedSN"].ToString(),
                        MedId = row["MedSN"].ToString(),
                        MedDose = Convert.ToSingle(row["MedDose"]),
                        MedFreq = row["MedFreq"].ToString(),
                    };

                    Medicine medicine = new Medicine
                    {
                        MedName = row["MedName"].ToString(),
                        MedEf = row["MedName"].ToString(),
                        MedSe = row["MedName"].ToString(),
                    };
                    MedOfPtDTO medOfPtDTO = new MedOfPtDTO
                    {
                        caseHistory = caseHistory,
                        medicine = medicine

                    };

                    medOfPtDTOs.Add(medOfPtDTO);
                }
            }

            return medOfPtDTOs;
        }
    }
}
