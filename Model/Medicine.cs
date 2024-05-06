using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myClinic.Model
{
    public class Medicine
    {
       
        #region 屬性

        /// <summary>
        /// 藥品編號
        /// </summary>
        public string MedId { get; set; }
        /// <summary>
        /// 藥品名稱
        /// </summary>
        public string MedName { get; set; }
        /// <summary>
        /// 藥品作用
        /// </summary>
        public string MedEf { get; set; }
        /// <summary>
        /// 藥品副作用
        /// </summary>
        public string MedSe { get; set; }
        /// <summary>
        /// 藥物注意事項
        /// </summary>
        public string MedNotice { get; set; }

        /// <summary>
        /// 藥品圖片(位址)
        /// </summary>
        public string MedPic { get; set; }


        #endregion

        #region 方法
       
        /// <summary>
        /// 查詢全部的藥物
        /// </summary>
        /// <returns></returns>
        public List<Medicine> GetMeds()
        {
            SQLConnectMaster sqlConnect = new SQLConnectMaster();// 不傳遞, 使用預設全域變數的連線字串
            List<Medicine> Meds = new List<Medicine>();
            string query = "SELECT * FROM Medicine";

            // 使用 SQLConnect 來執行查詢並且取得結果
            using (DataTable DT = sqlConnect.ExecuteDataTable(query))
            {
                foreach (DataRow row in DT.Rows)
                {
                    Medicine Med = new Medicine
                    {
                        MedId = row["MedId"].ToString(),
                        MedName = row["MedName"].ToString(),
                        MedEf = row["MedEf"].ToString(),
                        MedSe = row["MedSe"].ToString(),
                        MedNotice = row["MedNotice"].ToString(),
                        MedPic = row["MedPic"].ToString(),
                        
                    };
                    Meds.Add(Med);
                }
            }

            return Meds;
        }
        /// <summary>
        /// 取得員工資訊，根據工號及密碼
        /// </summary>
        /// <param name="empNo">工號</param>
        /// <param name="pwd">密碼</param>
        /// <returns>員工資訊，若不存在則返回 null</returns>
        public Medicine GetMeds(string medecine)
        {
            SQLConnectMaster sqlConnect = new SQLConnectMaster();// 不傳遞, 使用預設全域變數的連線
            // 創建一個 Medecine 物件來存儲查詢結果
            Medicine med = null;

            // SQL 查詢語句
            string query = $"SELECT * FROM Medecine WHERE MedName like '%{medecine}%'";
            // 使用 SQLConnect 來執行查詢並且取得結果
            using (DataTable dataTable = sqlConnect.ExecuteDataTable(query))
            {
                // 如果查詢結果中有資料，則將第一筆資料轉換為 Employee 物件
                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    med = new Medicine
                    {
                        MedId = row["MedId"].ToString(),
                        MedName = row["MedName"].ToString(),
                        MedEf = row["MedEf"].ToString(),
                        MedSe = row["MedSe"].ToString(),
                        MedNotice = row["MedNotice"].ToString(),
                        MedPic = row["MedPic"].ToString(),

                    };
                }
            }


            return med;
        }

        /// <summary>
        /// 新增員工
        /// </summary>
        /// <param name="emp">員工實體</param>
        /// <returns></returns>
        public bool insertMed(Medicine med)
        {
            bool result = false; // 預設回傳
            SQLConnectMaster sqlConnect = new SQLConnectMaster();// 不傳遞, 使用預設全域變數的連線


            // SQL 新增的語法 (EMP_M)
            string query1 = $"INSERT INTO [caseHistoryId],[MedSN],[MedId],[MedDose],[empNo]) VALUES ('{med.MedId}', '{med.MedName}', '{med.MedEf}', '{med.MedSe},{med.MedNotice}')";

            // 使用 SQLConnect 來執行查詢並且取得結果
            if (sqlConnect.ExecuteQuery(query1) )
            {
                result = true;
            }

            return result;
        }


        /// <summary>
        /// 更新員工
        /// </summary>
        /// <param name="emp">員工實體</param>
        /// <returns></returns>
        //public bool updateMed(Medecine med)
        //{
        //    bool result = false;
        //    SQLConnectMaster sqlConnect = new SQLConnectMaster();// 不傳遞, 使用預設全域變數的連線
        //    // 創建一個 Employee 物件來存儲查詢結果
        //    Medecine med = null;

        //    // SQL 新增的語法 (EMP_M)
        //    string query = "update Medecine where ";
        //    // 使用 SQLConnect 來執行查詢並且取得結果
        //    if (sqlConnect.ExecuteQuery(query) )
        //    {
        //        result = true;
        //    }

        //    return result;
        //}
        #endregion 

    }
}
