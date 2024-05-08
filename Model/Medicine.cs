using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        /// 查詢藥物
        /// </summary>
        /// <param name="pairs"></param>
        /// <returns></returns>
        public List<Medicine> GetMedicines(Dictionary<string, string> pairs)
        {

            SQLConnectMaster sqlConnect = new SQLConnectMaster();// 不傳遞, 使用預設全域變數的連線字串
            List<Medicine> meds = new List<Medicine>();
            string query = "SELECT * from [myClinic].[dbo].[Medicine] ";
            if (pairs.Count > 0)
            {
                query += " WHERE ";

                // 遍歷字典中的鍵值對，將每個鍵值對組合成查詢條件
                foreach (var pair in pairs)
                {
                    query += $"{pair.Key} like '%{pair.Value}%' AND ";
                }

                // 刪除最後一個 "AND "
                query = query.Remove(query.Length - 5);
            }
            // 使用 SQLConnect 來執行查詢並且取得結果
            using (DataTable DT = sqlConnect.ExecuteDataTable(query))
            {
                foreach (DataRow row in DT.Rows)
                {
                    Medicine med = new Medicine
                    {
                        MedId = row["MedId"].ToString(),
                        MedEf = row["MedEf"].ToString(),
                        MedName = row["MedName"].ToString(),
                        MedNotice = row["MedNotice"].ToString(),
                        MedSe = row["MedSe"].ToString(),
                    };
                    meds.Add(med);
                }
            }

            return meds;
        }

        /// <summary>
        /// 新增藥物
        /// </summary>
        /// <param name="emp">員工實體</param>
        /// <returns></returns>
        public bool insertMed(Medicine med)
        {
            bool result = false; // 預設回傳
            SQLConnectMaster sqlConnect = new SQLConnectMaster();// 不傳遞, 使用預設全域變數的連線
            List<SqlParameter> sqlParameters = new List<SqlParameter>();

            // SQL 新增的語法 (EMP_M)
            string query1 = $"INSERT INTO [myClinic].[dbo].[Medicine]( [MedId] ,[MedName],[MedEf] ,[MedSe] ,[MedNotice] ,[MedPic]) VALUES (@MedId, @MedName, @MedEf, @MedSe,@MedNotice,' ')";
            sqlParameters.Add(new SqlParameter("@MedId", med.MedId));
            sqlParameters.Add(new SqlParameter("@MedName", med.MedName));
            sqlParameters.Add(new SqlParameter("@MedEf", med.MedEf));
            sqlParameters.Add(new SqlParameter("@MedSe", med.MedSe));
            sqlParameters.Add(new SqlParameter("@MedNotice", med.MedNotice));

            // 使用 SQLConnect 來執行查詢並且取得結果
            if (sqlConnect.ExecuteQuery(query1, sqlParameters) )
            {
                result = true;
            }

            return result;
        }
        /// <summary>
        /// 修改藥物
        /// </summary>
        /// <param name="med"></param>
        /// <returns></returns>

        public bool updateMed(Medicine med)
        {
            bool result = false; // 預設回傳
            SQLConnectMaster sqlConnect = new SQLConnectMaster();// 不傳遞, 使用預設全域變數的連線
            List<SqlParameter> sqlParameters = new List<SqlParameter>();

            // SQL 新增的語法 (EMP_M)
            string query1 = $"update [myClinic].[dbo].[Medicine] set [MedId]=@MedId ,[MedName]=@MedName,[MedEf]=@MedEf ,[MedSe] =@MedSe,[MedNotice]=@MedNotice where MedId=@MedId" ;
            sqlParameters.Add(new SqlParameter("@MedId", med.MedId));
            sqlParameters.Add(new SqlParameter("@MedName", med.MedName));
            sqlParameters.Add(new SqlParameter("@MedEf", med.MedEf));
            sqlParameters.Add(new SqlParameter("@MedSe", med.MedSe));
            sqlParameters.Add(new SqlParameter("@MedNotice", med.MedNotice));

            // 使用 SQLConnect 來執行查詢並且取得結果
            if (sqlConnect.ExecuteQuery(query1, sqlParameters))
            {
                result = true;
            }

            return result;
        }

        public bool deleteMed(Medicine med)
        {
            SQLConnectMaster sqlConnect = new SQLConnectMaster();// 不傳遞, 使用預設全域變數的連線

            // SQL 新增的語法 (EMP_Detail)
            string query = $"delete [myClinic].[dbo].[Medicine] where MedId=@MedId";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@MedId", med.MedId));
            bool sqlDelete = sqlConnect.ExecuteQuery(query, parameters);

            return sqlDelete;
        }


        #endregion 

    }
}
