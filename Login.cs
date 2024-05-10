using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using myClinic.Controller;
using myClinic.Model;

namespace myClinic
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            EmployeeController employeeController = new EmployeeController();
            Employee emp = employeeController.Login(txtAccount.Text, txtPwd.Text);

            if (emp != null)
            {
                MessageBox.Show($"成功了, 你是[{emp.empName}], 性別[{emp.getGender()}] " +
                    $"職級[{emp.position}], 權限代碼[{emp.groupId}]");
                // 登入成功
                GlobalSettings.employee = emp;
                FormOption option = new FormOption();
                option.Show();
                option.FormClosed += Option_FormClosed;// 委派
            }
            else
            {
                MessageBox.Show("登入失敗! 垃圾!");
                // 登入失敗
                GlobalSettings.employee = null;
            }


            CheckLoginStatus();
        }

        private void Option_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalSettings.employee = null;
            CheckLoginStatus();
        }


        /// <summary>
        /// 登入狀態檢查
        /// </summary>
        private void CheckLoginStatus()
        {
            if (GlobalSettings.employee == null)
            {
                // 如果全域變數employee登入失敗, 要繼續顯示
                // 所以是true
                this.Visible = true;
                txtAccount.Clear();
                txtPwd.Clear();
            }
            else
            {
                this.Visible = false;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            AcceptButton = btnLogin;
        }
    }
}
