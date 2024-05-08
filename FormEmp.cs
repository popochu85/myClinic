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
            }
        }

        private void btnSearchEmp_Click(object sender, EventArgs e)
        {
            EmployeeController empController = new EmployeeController();
            renderDgv(empController.GetEmployees(txtEmpNo.Text, txtEmpName.Text));
        }

        private void FormEmp_Load(object sender, EventArgs e)
        {
            searchAllEmp();
            txtEmp.Text = GlobalSettings.employee.empName;


            checkStatus();
            //dataGridViewEmp.Rows[0].Selected = true;
            //txtEmpName.Text = dataGridViewEmp.Rows[0].Cells["empName"].Value.ToString();
            //txtPwd.Text = dataGridViewEmp.Rows[0].Cells["pwd"].Value.ToString();
            //txtEmpNo.Text = dataGridViewEmp.Rows[0].Cells["empNo"].Value.ToString();
            //txtBirth.Text = dataGridViewEmp.Rows[0].Cells["birth"].Value.ToString();
            //txtPhone.Text = dataGridViewEmp.Rows[0].Cells["phone"].Value.ToString();
            //txtPosition.Text = dataGridViewEmp.Rows[0].Cells["position"].Value.ToString();
            //txtCreateDate.Text = dataGridViewEmp.Rows[0].Cells["createdDate"].Value.ToString();
            //int a = 0;
            //string g = dataGridViewEmp.Rows[0].Cells["groupId"].Value.ToString();
            //comboAuth.SelectedValue = g;

            //if ((dataGridViewEmp.Rows[0].Cells["gender"].Value.ToString().Equals("B")))
            //{
            //    rabBoy.Checked = true;
            //}
            //else
            //{
            //    rabGirl.Checked = true;
            //}
            //txtAddress.Text = dataGridViewEmp.Rows[0].Cells["address"].Value.ToString();
        }

        private void searchAllEmp()
        {
            // 清空DataGridView的資料
            dataGridViewEmp.Rows.Clear();
            List<Employee> employees = new List<Employee>();

            EmployeeController employeeController = new EmployeeController();
            // 取得員工資料
            employees = employeeController.GetEmployees();
            renderDgv(employees);
        }
        private void renderDgv(List<Employee> employees)
        {
            // 將員工資料加入到DataGridView
            foreach (Employee emp in employees)
            {
                dataGridViewEmp.Rows.Add(emp.empNo, emp.pwd, emp.empName, emp.groupId, emp.isActivate, emp.gender, emp.birth, emp.address, emp.phone, emp.createdDate, emp.position);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            
            status = "Create";
            txtAddress.Clear();
            txtEmpNo.Clear();
            txtEmpName.Clear();
            txtPosition.Clear();
            txtBirth.Value = new DateTime(1990, 1, 1);
            txtPhone.Clear();
            txtCreateDate.Value= DateTime.Now;
            txtPwd.Clear();
            comboAuth.SelectedIndex = 0;


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
            Employee emp = getBindingEmp();
            if (status.Equals("Create"))
            {
                string result = employeeController.insertEmp(emp);
                if (result.Equals(""))
                {
                    MessageBox.Show("新增成功");
                }
                else
                {
                    MessageBox.Show("新增失敗:"+result);
                    return;
                }
            }
            else if(status.Equals("Update"))
            {
                string result = employeeController.updateEmp(emp);
                if (result.Equals(""))
                {
                    MessageBox.Show("更新成功");
                }
                else
                {
                    MessageBox.Show("更新失敗:" + result);
                    return;
                }
                
            }

            status = "Default";
            checkStatus();
            searchAllEmp();
        }
        /// <summary>
        /// 把畫面元件蒐集匯聚成新的Emp
        /// </summary>
        /// <returns></returns>
        private Employee getBindingEmp() {

            Employee emp = new Employee();
            emp.empName = txtEmpName.Text;
            emp.empNo = txtEmpNo.Text;
            emp.groupId = (comboAuth.SelectedValue!=null)?comboAuth.SelectedValue.ToString():"";
            emp.gender = (rabBoy.Checked) ? "B" : "G";
            emp.phone = txtPhone.Text;
            emp.pwd = txtPwd.Text;
            emp.createdDate = txtCreateDate.Value.ToString("yyyy-MM-dd");
            emp.birth = txtBirth.Value.ToString("yyyy-MM-dd");
            emp.position = txtPosition.Text;
            emp.address = txtAddress.Text;
            return emp;
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
                    txtBirth.Enabled = true;
                    txtCreateDate.Enabled = true;
                    txtPhone.Enabled = true;
                    txtPwd.Enabled = true;
                    txtPosition.Enabled = true;
                    txtAddress.Enabled = true;
                    rabBoy.Enabled = true;
                    rabGirl.Enabled = true;
                    break;
                case "Update":
                    txtEmpNo.ReadOnly = true;
                    txtCreateDate.Enabled = true;
                    txtBirth.Enabled = true;
                    txtCreateDate.Enabled = true;
                    txtPhone.Enabled = true;
                    txtPwd.Enabled = true;
                    txtPosition.Enabled = true;
                    txtAddress.Enabled = true;
                    rabBoy.Enabled = true;
                    rabGirl.Enabled = true;
                    break;
                case "Default":
                    txtEmpNo.ReadOnly = false;
                    txtEmpName.ReadOnly = false;
                    txtBirth.Enabled = false;
                    txtCreateDate.Enabled = false;
                    txtPhone.Enabled = false;
                    txtPwd.Enabled = false;
                    txtPosition.Enabled = false;
                    txtAddress.Enabled = false;
                    rabBoy.Enabled = false;
                    rabGirl.Enabled = false;
                    break;
            }
        }

        
    private bool checkNotNull()
        {
            
            if ((txtEmpNo.Text != "")&&(txtEmpName.Text != ""))
            {
                return  true;
            }
            else
            {
                return false;
            }

        }
        



        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            EmployeeController employeeController = new EmployeeController();
            if (txtEmpNo.Text.Equals(""))
            {
                MessageBox.Show("請選擇一筆資料!");
                return;
            }
            else
            {
                Employee emp = getBindingEmp();
                DialogResult result = MessageBox.Show("是否確定要刪除["+emp.empName+"]？", "刪除確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                // 根據使用者的選擇執行相應的動作
                if (result == DialogResult.OK)
                {
                    if (employeeController.deleteEmp(emp))
                    {
                        MessageBox.Show("已刪除資料。");
                    }
                    else
                    {
                        MessageBox.Show("刪除失敗。");
                    }
                }
                else
                {
                    // 使用者選擇了取消，不執行刪除動作
                    MessageBox.Show("取消刪除。");
                }
                bool isDelete = false;

                searchAllEmp();

            }
        }

        private void btnBackOption_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}