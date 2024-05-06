using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace myClinic.Model
{
    public class AuthGroup
    {
        #region 屬性
        /// <summary>
        /// 工號
        /// </summary>
        public string groupId { get; set; }
        /// <summary>
        /// 密碼
        /// </summary>
        public string groupDesc { get; set; }
        /// <summary>
        /// 密碼
        /// </summary>
        public string editDate { get; set; }
        /// <summary>
        /// 密碼
        /// </summary>
        public string editEmp { get; set; }

        #endregion

        #region 方法
        /// <summary>
        /// 查詢所有群組
        /// </summary>
        /// <returns></returns>
        public List<AuthGroup> GetGroups()
        {
            SQLConnectMaster sqlConnect = new SQLConnectMaster();// 不傳遞, 使用預設全域變數的連線字串
            List<AuthGroup> authGroups = new List<AuthGroup>();
            string query = "SELECT * from AuthGroup";

            // 使用 SQLConnect 來執行查詢並且取得結果
            using (DataTable DT = sqlConnect.ExecuteDataTable(query))
            {
                foreach(DataRow row in DT.Rows)
                {
                    AuthGroup employee = new AuthGroup
                    {
                        groupId = row["groupId"].ToString(),
                        groupDesc = row["groupDesc"].ToString(),
                        editDate = row["editDate"].ToString(),
                        editEmp = row["editEmp"].ToString(),
                    };
                    authGroups.Add(employee);
                }
            }

            return authGroups;
        }
        #endregion 

    }
}
