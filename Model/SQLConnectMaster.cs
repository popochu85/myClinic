using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myClinic.Model
{
    public class SQLConnectMaster
    {
        private string connectionString;
        /// <summary>
        /// 連接器
        /// </summary>
        /// <param name="connectionString">連線字串傳入</param>
        public SQLConnectMaster(string connectionString)
        {
            this.connectionString = connectionString;
        }

        /// <summary>
        /// 連接器
        /// </summary>
        public SQLConnectMaster()
        {
            this.connectionString = GlobalSettings.DatabaseConnectionString;
        }

        /// <summary>
        /// 執行語法 (通常是新增、修改、刪除會呼叫), True代表有異動
        /// </summary>
        /// <param name="query">SQLScript</param>
        public bool ExecuteQuery(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0; // 如果受影響的行數大於 0，則返回 true，否則返回 false
            }
        }

        /// <summary>
        /// 執行查詢並且回傳 DataTable
        /// </summary>
        /// <param name="query">SQLScript</param>
        /// <returns></returns>
        public DataTable ExecuteDataTable(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                // 創建 DataTable 來存儲查詢結果
                DataTable dataTable = new DataTable();

                // 使用 SqlDataAdapter 來填充 DataTable
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }

                return dataTable;
            }
        }
        public bool ExecuteQuery(string query, List<SqlParameter> parameter)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddRange(parameter.ToArray());
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0; // 如果受影響的行數大於 0，則返回 true，否則返回 false
            }
        }

    }
}
