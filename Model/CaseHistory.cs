﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myClinic.Model.DTO;

namespace myClinic.Model
{
    public class CaseHistory
    {
        #region 屬性
        //病歷


        /// <summary>
        /// 病歷號碼
        /// </summary>
        public string patientId { get; set; }
        /// <summary>
        /// 病歷編號
        /// </summary>
        public string caseHistoryId { get; set; }
        /// <summary>
        /// 診斷
        /// </summary>
        public string dx { get; set; }
        /// <summary>
        /// 主訴
        /// </summary>
        public string cc { get; set; }
        /// <summary>
        /// 看診醫師
        /// </summary>
        public string empNo { get; set; }
        /// <summary>
        /// 看診日期
        /// </summary>
        public string dxDate { get; set; }

        //藥單

        /// <summary>
        /// 藥品順序(在藥單上)
        /// </summary>
        public string MedSN { get; set; }
        /// <summary>
        /// 藥品編號
        /// </summary>
        public string MedId { get; set; }
        /// <summary>
        /// 藥品劑量
        /// </summary>
        public float MedDose { get; set; }
        /// <summary>
        /// 藥品使用頻次
        /// </summary>
        public string MedFreq { get; set; }
        #endregion




        #region 方法
        public bool addMed(CaseHistory caseHx)
        {
            bool result = false; // 預設回傳
            SQLConnectMaster sqlConnect = new SQLConnectMaster();// 不傳遞, 使用預設全域變數的連線


            // SQL 新增的語法 (MedOfPT)
            string query1 = $"insert MedOfPT(caseHistoryId,MedSN,MedId,MedDose,MedFreq)values(@caseHistoryId,@MedSN,@MedId,@MedDose,@MedFreq)";

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@caseHistoryId", caseHx.caseHistoryId));
            parameters.Add(new SqlParameter("@MedSN", caseHx.MedSN));
            parameters.Add(new SqlParameter("@MedId", caseHx.MedId));
            parameters.Add(new SqlParameter("@MedDose", caseHx.MedDose));
            parameters.Add(new SqlParameter("@MedFreq", caseHx.MedFreq));

            // 使用 SQLConnect 來執行查詢並且取得結果
            if (sqlConnect.ExecuteQuery(query1, parameters))
            {
                result = true;
            }

            return result;
        }
        public bool addNewHx(CaseHistory caseHx)
        {
            bool result = false; // 預設回傳
            SQLConnectMaster sqlConnect = new SQLConnectMaster();// 不傳遞, 使用預設全域變數的連線


            // SQL 新增的語法 (caseHistory)
            string query1 = $"insert caseHistory(caseHistoryId,patientId,dx,cc,empNo,dxDate)values(@caseHistoryId,@patientId,@dx,@cc,@empNo,@dxDate)";

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@caseHistoryId", caseHx.caseHistoryId));
            parameters.Add(new SqlParameter("@patientId", caseHx.patientId));
            parameters.Add(new SqlParameter("@dx", caseHx.dx));
            parameters.Add(new SqlParameter("@cc", caseHx.cc));
            parameters.Add(new SqlParameter("@empNo", caseHx.empNo));
            parameters.Add(new SqlParameter("@dxDate", caseHx.dxDate));

            //更新REG 病歷號碼
            string query2 = $"update PatientReg set caseHistoryId = @caseHistoryId where regDate =@regDate and patientId = @patientId";
            List<SqlParameter> parameters2 = new List<SqlParameter>();
            parameters2.Add(new SqlParameter("caseHistoryId", caseHx.caseHistoryId));
            parameters2.Add(new SqlParameter("regDate", caseHx.dxDate));
            parameters2.Add(new SqlParameter("patientId", caseHx.patientId));

            // 使用 SQLConnect 來執行查詢並且取得結果
            if (sqlConnect.ExecuteQuery(query1, parameters) && sqlConnect.ExecuteQuery(query2, parameters2))
            {
                result = true;
            }

            return result;
        }
        public List<CaseHistory> searchOldCaseHistory(string ptId)
        {

            SQLConnectMaster sqlConnect = new SQLConnectMaster();// 不傳遞, 使用預設全域變數的連線字串
            List<CaseHistory> oldCaseHx = new List<CaseHistory>();
            string query = $"select * from CaseHistory　where patientId='{ptId}' and dxDate!='{DateTime.Now.ToString("yyyy-MM-dd")}'";
            // 使用 SQLConnect 來執行查詢並且取得結果
            using (DataTable DT = sqlConnect.ExecuteDataTable(query))
            {
                foreach (DataRow row in DT.Rows)
                {

                    CaseHistory caseHistory = new CaseHistory
                    {
                        caseHistoryId = row["caseHistoryId"].ToString(),
                        patientId = row["patientId"].ToString(),
                        dxDate = row["dxDate"].ToString(),
                        dx = row["dx"].ToString(),
                        cc = row["cc"].ToString(),
                    };

                    oldCaseHx.Add(caseHistory);
                }
            }

            return oldCaseHx;
        }


        #endregion
    }
}
