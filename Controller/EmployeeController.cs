using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myClinic.Model;

namespace myClinic.Controller
{

    public class EmployeeController
    {
        public Employee employee { get; set; }
        public AuthGroup auth { get; set; }
        public EmployeeController()
        {
            this.employee = new Employee(); // 實例化
            this.auth = new AuthGroup(); // 實例化
        }

        /// <summary>
        /// 取得全部的權限群組
        /// </summary>
        /// <returns></returns>
        public List<AuthGroup> GetAuthGroups() {
            return auth.GetGroups();
        }

        /// <summary>
        /// 登入功能
        /// </summary>
        /// <param name="empNo">員工工號碼</param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public Employee Login(string empNo, string pwd)
        {
            return employee.GetEmployee(empNo, pwd);

            //// 使用 Employee Model 中的 GetEmployees 方法來獲取全部員工資料
            ////List<Employee> employees = new Employee().GetEmployees();
            //// 遍歷員工列表，檢查是否有匹配的員工
            //foreach (Employee employee in employees)
            //{
            //    // 如果找到了工號和密碼都匹配的員工，則登入成功
            //    if (employee.empNo == empNo && employee.pwd == pwd)
            //    {
            //        // 登入成功
            //        return true;
            //    }
            //}

            //// 如果沒有找到匹配的員工，或者密碼不正確，則登入失敗
            //return false;
        }

        /// <summary>
        /// 查詢全部員工, 無條件!!
        /// </summary>
        /// <returns></returns>
        public List<Employee> GetEmployees()
        {
            return employee.GetEmployees();
        }
        /// <summary>
        /// 新增員工
        /// </summary>
        /// <param name="emp">定義好的員工傳進來</param>
        /// <returns></returns>
        public string insertEmp(Employee emp)
        {
            string msg = "";
            try {
                if (emp.empNo.Equals("")) {
                    return "員工編號請勿為空!!";
                }

                if (emp.empName.Equals(""))
                {
                    return "員工姓名請勿為空!!";
                }

                if (emp.gender.Equals(""))
                {
                    return "性別請勿為空!!";
                }

                if (emp.gender.Equals(""))
                {
                    return "性別請勿為空!!";
                }
                if (emp.gender.Equals(""))
                {
                    return "性別請勿為空!!";
                }
                if (emp.gender.Equals(""))
                {
                    return "性別請勿為空!!";
                }
                if (emp.gender.Equals(""))
                {
                    return "性別請勿為空!!";
                }
                if (emp.gender.Equals(""))
                {
                    return "性別請勿為空!!";
                }

                employee.insertEmp(emp);
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return msg;
        }

        public bool updateEmp(Employee emp)
        {
            return emp.updateEmp(emp);// 修改成功
        }

        public bool deleteEmp(Employee emp)
        {
            return true;// 刪除成功
        }
    }

}
