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
    public partial class FormEmp : Form
    {
        private string status = "Default";
        public FormEmp()
        {
            InitializeComponent();

            // 設定DataGridView的屬性
            dataGridViewEmp.AutoGenerateColumns = false;

            // 添加DataGridView的欄位
            dataGridViewEmp.Columns.Add("empNo", "員工編號");
            dataGridViewEmp.Columns.Add("pwd", "密碼");
            dataGridViewEmp.Columns.Add("empName", "姓名");
            dataGridViewEmp.Columns.Add("groupId", "群組ID");
            dataGridViewEmp.Columns.Add("isActivate", "激活狀態");
            dataGridViewEmp.Columns.Add("gender", "性別");
            dataGridViewEmp.Columns.Add("birth", "生日");
            dataGridViewEmp.Columns.Add("address", "地址");
            dataGridViewEmp.Columns.Add("phone", "電話");
            dataGridViewEmp.Columns.Add("createdDate", "到職日");
            dataGridViewEmp.Columns.Add("position", "職位");
            dataGridViewEmp.Columns["pwd"].Visible = false;

            EmployeeController employeeController = new EmployeeController();

            // 設定ComboBox的DataSource
            comboAuth.DataSource = employeeController.GetAuthGroups(); ;

            // 指定ComboBox顯示的文本屬性
            comboAuth.DisplayMember = "groupDesc"; 

            // 指定ComboBox的值屬性
            comboAuth.ValueMember = "groupId"; 
        }



        private void dataGridViewEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtEmpName.Text = dataGridViewEmp.Rows[e.RowIndex].Cells["empName"].Value.ToString();
                txtPwd.Text = dataGridViewEmp.Rows[e.RowIndex].Cells["pwd"].Value.ToString();
                txtEmpNo.Text = dataGridViewEmp.Rows[e.RowIndex].Cells["empNo"].Value.ToString();
                txtBirth.Text = dataGridViewEmp.Rows[e.RowIndex].Cells["birth"].Value.ToString();
                txtPhone.Text= dataGridViewEmp.Rows[e.RowIndex].Cells["phone"].Value.ToString();
                txtPosition.Text = dataGridViewEmp.Rows[e.RowIndex].Cells["position"].Value.ToString();
                txtCreateDate.Text= dataGridViewEmp.Rows[e.RowIndex].Cells["createdDate"].Value.ToString();
                int a = 0;
                string g = dataGridViewEmp.Rows[e.RowIndex].Cells["groupId"].Value.ToString();
                comboAuth.SelectedValue = g;
     
                if ((dataGridViewEmp.Rows[e.RowIndex].Cells["gender"].Value.ToString().Equals("B"))){
                    rabBoy.Checked = true;
                }
                else
                {
                    rabGirl.Checked = true;
                }
                txtAddress.Text = dataGridViewEmp.Rows[e.RowIndex].Cells["address"].Value.ToString() ;
                //txtPosition.Text=
                //txtPhone.Text=
                //txtCreateDate.Text=

            }
        }

        private void btnSearchEmp_Click(object sender, EventArgs e)
        {
            
        }

        private void FormEmp_Load(object sender, EventArgs e)
        {
            searchAllEmp();
        }

        private void searchAllEmp()
        {
            // 清空DataGridView的資料
            dataGridViewEmp.Rows.Clear();
            List<Employee> employees = new List<Employee>();

            EmployeeController employeeController = new EmployeeController();
            // 取得員工資料
            employees = employeeController.GetEmployees();

            // 將員工資料加入到DataGridView
            foreach (Employee emp in employees)
            {
                dataGridViewEmp.Rows.Add(emp.empNo, emp.pwd, emp.empName, emp.groupId, emp.isActivate, emp.gender, emp.birth, emp.address, emp.phone, emp.createdDate, emp.position);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            status = "Create";
            checkStatus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtEmpNo.Text.Equals("")) {
                MessageBox.Show("請選擇一筆資料!");
                return;
            }
            status = "Update";
            checkStatus();
        }

        private void Save() {

            EmployeeController employeeController = new EmployeeController();
            if (status.Equals("Create"))
            {
                Employee emp = new Employee();
                emp.empName = txtEmpName.Text;
                emp.empNo = txtEmpNo.Text;
                emp.groupId = comboAuth.SelectedValue.ToString();
                employeeController.insertEmp(emp);
            }
            else if(status.Equals("Update"))
            {

                Employee emp = new Employee();
                emp.empName = txtEmpName.Text;
                emp.empNo = txtEmpNo.Text;
                employeeController.updateEmp(emp);
            }


            status = "Default";
            checkStatus();
            searchAllEmp();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            status = "Default";
            checkStatus();
        }

        private void checkStatus()
        {
            switch (status)
            {
                case "Create":
                    lblTitle.Text = "員工資料-新增";
                    btnCreate.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnSearchEmp.Enabled = false;
                    dataGridViewEmp.Enabled = false;
                    panelSave.Visible = true;
                    break;
                case "Update":
                    lblTitle.Text = "員工資料-修改";
                    btnCreate.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnSearchEmp.Enabled = false;
                    dataGridViewEmp.Enabled = false;
                    panelSave.Visible = true;
                    break;
                case "Default":
                    lblTitle.Text = "員工資料";
                    btnCreate.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnSearchEmp.Enabled = true;
                    dataGridViewEmp.Enabled = true;
                    panelSave.Visible = false;
                    break;
            }
            controlSetting();
        }
        private void controlSetting()
        {
            switch (status)
            {
                case "Create":
                    txtEmpNo.ReadOnly = false;
                    txtCreateDate.Enabled = true;
                    break;
                case "Update":
                    txtEmpNo.ReadOnly = true;
                    txtCreateDate.Enabled = false;
                    break;
                case "Default":
                    txtEmpNo.ReadOnly = false;
                    txtCreateDate.Enabled = true;
                    break;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
            checkStatus();
            searchAllEmp();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtEmpNo.Text.Equals(""))
            {
                MessageBox.Show("請選擇一筆資料!");
                return;
            }
        }
    }
}