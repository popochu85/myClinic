using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using myClinic.Model;
namespace myClinic.Model
{
    public class PatientReg
    {
        #region 屬性
        public int regId { get; set; }
        public DateTime regDate { get; set; }
        public string patientId { get; set; }
        //public string PatientName { get; set; }
        public string caseHistoryId { get; set; }



        #endregion
        #region 方法

        /// <summary>
        /// 掛號
        /// </summary>
        /// <param name="pat"></param>
        /// <returns></returns>
        public bool regPat(PatientReg reg)
        {
            bool result = false;

            SQLConnectMaster sqlConnect = new SQLConnectMaster();
            string query = "insert into [PatientReg](regId,regDate,patientId,caseHistoryId) values(@regId,@regDate,@patientId,@caseHistoryId)";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("regId", reg.regId));
            parameters.Add(new SqlParameter("regDate", DateTime.Now));
            parameters.Add(new SqlParameter("patientId", reg.patientId));
            parameters.Add(new SqlParameter("caseHistoryId", reg.caseHistoryId));
            if (sqlConnect.ExecuteQuery(query, parameters))
            {
                result = true;
            }
            return result;
        }
        public string cancelReg(PatientReg reg)
        {
            string result = "";
            try
            {

                SQLConnectMaster sqlConnect = new SQLConnectMaster();
                string query = "delete from PatientReg where regId=@regId and regDate=@regDate";
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter("regId", reg.regId));
                parameters.Add(new SqlParameter("regDate", reg.regDate.ToString("yyyy-MM-dd")));
                result = (sqlConnect.ExecuteQuery(query, parameters)) ? "" : "語法不明錯誤!!";
                

            }
            catch(Exception e)
            {
                result = e.ToString();
            }
            return result;
        }

        public int getMaxRegID(string today,out string msg) {

            // 寫查詢
            int result = 0;
            
            try
            {
                SQLConnectMaster s = new SQLConnectMaster();
                string qq = $"select COALESCE(max(RegId),0) as max from [PatientReg] where regDate='{today}'";
                List<SqlParameter> parameters = new List<SqlParameter>();
                List<PatientReg>regs= new List<PatientReg>();

                using (DataTable DT = s.ExecuteDataTable(qq))
                {
                    if(DT != null && DT.Rows.Count>0)
                    {
                        msg = "";
                        string rowResult = DT.Rows[0]["max"].ToString();
                        return Convert.ToInt32(rowResult);
                    }
                   
                }



            }
            catch (Exception e)
            {
               msg=e.ToString();
            }

            result = -1;
            msg = "";
            return result;
        }

        #endregion
    }

}
