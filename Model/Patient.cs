﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myClinic.Model
{
    public class Patient
    {

        #region 屬性
        //病人資料

        /// <summary>
        /// 病歷號碼
        /// </summary>
        public string patientId { get; set; }
        /// <summary>
        /// 病人姓名
        /// </summary>
        public string patientName { get; set; }
        /// <summary>
        /// 病人性別
        /// </summary>
        public string gender { get; set; }
        /// <summary>
        /// 病人生日
        /// </summary>
        public string patientBirth { get; set; }
        /// <summary>
        /// 過敏史
        /// </summary>
        public string allergy { get; set; }
        /// <summary>
        /// 疾病史
        /// </summary>
        public string disease { get; set; }
        /// <summary>
        /// 病人地址
        /// </summary>
        public string patientAddress { get; set; }
        /// <summary>
        /// 病人電話
        /// </summary>
        public string patientPhone { get; set; }
        /// <summary>
        /// 初診日期
        /// </summary>
        public string createdDate { get; set; }




        #endregion


        #region 方法
        /// <summary>
        /// 取性別轉字串
        /// </summary>
        /// <returns></returns>
        public string getGender()
        {
            if (this.gender.Equals("G"))
            {
                return "女";
            }
            else
            {
                return "男";
            }
        }
        /// <summary>
        /// 取得所有病人資料
        /// </summary>
        /// <returns></returns>
        public List<Patient> getPatients()
        {
            SQLConnectMaster sqlConnect = new SQLConnectMaster();// 不傳遞, 使用預設全域變數的連線字串
            List<Patient> patients = new List<Patient>();
            string query = "SELECT * from [myClinic].[dbo].[Patients]";

            // 使用 SQLConnect 來執行查詢並且取得結果
            using (DataTable DT = sqlConnect.ExecuteDataTable(query))
            {
                foreach (DataRow row in DT.Rows)
                {
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
                        createdDate = row["createdDate"].ToString(),
                    };
                    patients.Add(patient);
                }
            }

            return patients;
        }
        
        public bool insertPat(Patient pat)
        {
            bool result = false;
            SQLConnectMaster sqlConnect = new SQLConnectMaster();
            string query = "insert into [myClinic].[dbo].[Patients] ([patientId],[patientName],[gender],[patientBirth],[allergy],[disease],[patientAddress],[patientPhone] ,[createdDate]) values(@patientId,@patientName,@gender,@patientBirth,@allergy,@disease,@patientAddress,@patientPhone,@createdDate)";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("patientId", pat.patientId));
            parameters.Add(new SqlParameter("patientName", pat.patientName));
            parameters.Add(new SqlParameter("gender", pat.gender));
            parameters.Add(new SqlParameter("patientBirth", pat.patientBirth));
            parameters.Add(new SqlParameter("allergy", pat.allergy));
            parameters.Add(new SqlParameter("disease", pat.disease));
            parameters.Add(new SqlParameter("patientAddress", pat.patientAddress));
            parameters.Add(new SqlParameter("patientPhone", pat.patientPhone));
            parameters.Add(new SqlParameter("createdDate", pat.createdDate));
            if(sqlConnect.ExecuteQuery(query, parameters))
            {
                result = true;
            }

            return result;
        }

        
        #endregion
    }
}
