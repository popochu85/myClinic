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
    public class Employee
    {
        #region 屬性

        /// <summary>
        /// 工號
        /// </summary>
        public string empNo { get; set; }
        /// <summary>
        /// 密碼
        /// </summary>
        public string pwd { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string empName { get; set; }
        /// <summary>
        /// 群組ID
        /// </summary>
        public string groupId { get; set; }
        /// <summary>
        /// 激活狀態
        /// </summary>
        public string isActivate { get; set; }

        /// <summary>
        /// 性別
        /// </summary>
        public string gender { get; set; }

        /// <summary>
        /// 生日
        /// </summary>
        public string birth { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        public string address { get; set; }
        /// <summary>
        /// 電話
        /// </summary>
        public string phone { get; set; }
        /// <summary>
        /// 到職日
        /// </summary>
        public string createdDate { get; set; }
        /// <summary>
        /// 職位
        /// </summary>
        public string position { get; set; }

        #endregion

        #region 方法
        /// <summary>
        /// 取得性別
        /// </summary>
        /// <returns></returns>
        public string getGender() {
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
        /// 查詢全部的員工
        /// </summary>
        /// <returns></returns>
        public List<Employee> GetEmployees()
        {
            SQLConnectMaster sqlConnect = new SQLConnectMaster();// 不傳遞, 使用預設全域變數的連線字串
            List<Employee> employees = new List<Employee>();
            string query = "SELECT empM.*, empD.* FROM Employee as empM LEFT JOIN " +
                " EmployeeDetail as empD ON empD.empNo = empM.empNo ";

            // 使用 SQLConnect 來執行查詢並且取得結果
            using (DataTable DT = sqlConnect.ExecuteDataTable(query))
            {
                foreach(DataRow row in DT.Rows)
                {
                    Employee employee = new Employee
                    {
                        empNo = row["empNo"].ToString(),
                        pwd = row["pwd"].ToString(),
                        empName = row["empName"].ToString(),
                        groupId = row["groupId"].ToString(),
                        gender = row["gender"].ToString(),
                        birth = row["birth"].ToString(),
                        address = row["address"].ToString(),
                        phone = row["phone"].ToString(),
                        createdDate = row["createdDate"].ToString(),
                        position = row["position"].ToString()
                    };
                    employees.Add(employee);
                }
            }

            return employees;
        }
        /// <summary>
        /// 搜尋員工(關鍵字)
        /// </summary>
        /// <param name="pairs"></param>
        /// <returns></returns>
        public List<Employee> GetEmployees(Dictionary<string, string> pairs) {

            SQLConnectMaster sqlConnect = new SQLConnectMaster();// 不傳遞, 使用預設全域變數的連線字串
            List<Employee> employees = new List<Employee>();
            string query = "SELECT empM.*, empD.* FROM Employee as empM LEFT JOIN " +
                " EmployeeDetail as empD ON empD.empNo = empM.empNo ";
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
                    Employee employee = new Employee
                    {
                        empNo = row["empNo"].ToString(),
                        pwd = row["pwd"].ToString(),
                        empName = row["empName"].ToString(),
                        groupId = row["groupId"].ToString(),
                        gender = row["gender"].ToString(),
                        birth = row["birth"].ToString(),
                        address = row["address"].ToString(),
                        phone = row["phone"].ToString(),
                        createdDate = row["createdDate"].ToString(),
                        position = row["position"].ToString()
                    };
                    employees.Add(employee);
                }
            }

            return employees;
        }
        /// <summary>
         /// 取得員工資訊，根據工號及密碼
         /// </summary>
         /// <param name="empNo">工號</param>
         /// <param name="pwd">密碼</param>
         /// <returns>員工資訊，若不存在則返回 null</returns>
        public Employee GetEmployee(string empNo, string pwd)
        {
            SQLConnectMaster sqlConnect = new SQLConnectMaster();// 不傳遞, 使用預設全域變數的連線
            // 創建一個 Employee 物件來存儲查詢結果
            Employee employee = null;

            // SQL 查詢語句
            string query = "SELECT empM.*, empD.* FROM Employee as empM LEFT JOIN " +
                           " EmployeeDetail as empD ON empD.empNo = empM.empNo " +
                           $"WHERE empM.empNo = '{empNo}' AND empM.pwd = '{pwd}'";
            // 使用 SQLConnect 來執行查詢並且取得結果
            using (DataTable dataTable = sqlConnect.ExecuteDataTable(query))
            {
                // 如果查詢結果中有資料，則將第一筆資料轉換為 Employee 物件
                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    employee = new Employee
                    {
                       
                        empNo = row["empNo"].ToString(),
                        pwd = row["pwd"].ToString(),
                        empName = row["empName"].ToString(),
                        groupId = row["groupId"].ToString(),
                        gender = row["gender"].ToString(),
                        birth = row["birth"].ToString(),
                        address = row["address"].ToString(),
                        phone = row["phone"].ToString(),
                        createdDate = row["createdDate"].ToString(),
                        position = row["position"].ToString()
                    };
                    
                }
            }


            return employee;
        }

        /// <summary>
        /// 新增員工
        /// </summary>
        /// <param name="emp">員工實體</param>
        /// <returns></returns>
        public bool insertEmp(Employee emp)
        {
            bool result = false; // 預設回傳
            SQLConnectMaster sqlConnect = new SQLConnectMaster();// 不傳遞, 使用預設全域變數的連線


            // SQL 新增的語法 (EMP_M)
            string query1 = $"INSERT INTO [myClinic].[dbo].[Employee] ([empNo], [pwd], [groupId],[isActivate]) VALUES (@empNo, @pwd, @groupId,'Y')";

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@empNo", emp.empNo));
            parameters.Add(new SqlParameter("@pwd", emp.pwd));
            parameters.Add(new SqlParameter("@groupId", emp.groupId));



            // SQL 新增的語法 (EMP_D)
            string query2 = $"INSERT INTO [myClinic].[dbo].[EmployeeDetail] ([empNo], [position], [empName], [gender], [birth], [address], [phone], [createdDate]) VALUES (@empNo, @position, @empName,@gender, @birth, @address, @phone, @createdDate)";
            List<SqlParameter> parameters2 = new List<SqlParameter>();
            parameters2.Add(new SqlParameter("@empName", emp.empName));
            parameters2.Add(new SqlParameter("@empNo", emp.empNo));
            parameters2.Add(new SqlParameter("@position", emp.position));
            parameters2.Add(new SqlParameter("@gender", emp.gender));
            parameters2.Add(new SqlParameter("@birth", emp.birth));
            parameters2.Add(new SqlParameter("@address", emp.address));
            parameters2.Add(new SqlParameter("@phone", emp.phone));
            parameters2.Add(new SqlParameter("@createdDate", emp.createdDate));
            // 使用 SQLConnect 來執行查詢並且取得結果
            if (sqlConnect.ExecuteQuery(query1, parameters) && sqlConnect.ExecuteQuery(query2, parameters2))
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
        public bool updateEmp(Employee emp)
        {
            bool result = false;
            SQLConnectMaster sqlConnect = new SQLConnectMaster();// 不傳遞, 使用預設全域變數的連線
            

            string query =$"update EmployeeDetail set empName=@empName,empNo=@empNo,position=@position,gender=@gender,birth=@birth,address=@address,phone=@phone,createdDate=@createdDate where empNo=@empNo";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@empName", emp.empName));
            parameters.Add(new SqlParameter("@empNo", emp.empNo));
            parameters.Add(new SqlParameter("@position", emp.position));
            parameters.Add(new SqlParameter("@gender",emp.gender));
            parameters.Add(new SqlParameter("@birth",emp.birth));
            parameters.Add(new SqlParameter("@address",emp.address));
            parameters.Add(new SqlParameter("@phone",emp.phone));
            parameters.Add(new SqlParameter("@createdDate", emp.createdDate));

            List<SqlParameter> parameters2 = new List<SqlParameter>();
            string query2 = "update Employee set pwd=@pwd,groupId=@groupId where empNo=@empNo";
            parameters2.Add(new SqlParameter("@empNo", emp.empNo));
            parameters2.Add(new SqlParameter("@pwd", emp.pwd));
            parameters2.Add(new SqlParameter("@groupId", emp.groupId));
            // 使用 SQLConnect 來執行查詢並且取得結果
            if (sqlConnect.ExecuteQuery(query, parameters)&& sqlConnect.ExecuteQuery(query2, parameters2))
            {
                result = true;
            }

            return result;
        }

        

        public bool deleteEmp(Employee emp)
        {
            SQLConnectMaster sqlConnect = new SQLConnectMaster();// 不傳遞, 使用預設全域變數的連線

            // SQL 新增的語法 (EMP_Detail)
            string query = $"delete EmployeeDetail where empNo=@empNo";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@empNo", emp.empNo));
            bool sqlDelete = sqlConnect.ExecuteQuery(query, parameters);

            string query2 = "delete Employee where empNo=@empNo";
            List<SqlParameter> parameters2 = new List<SqlParameter>();
            parameters2.Add(new SqlParameter("@empNo", emp.empNo));
            bool sqlDelete2 = sqlConnect.ExecuteQuery(query2, parameters2);

            return sqlDelete && sqlDelete2;
        }

        #endregion 

    }
}
