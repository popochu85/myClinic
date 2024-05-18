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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace myClinic
{
    public partial class FormMed : Form
    {
        private string status = "default";
        public FormMed()
        {
            InitializeComponent();


            // 設定DataGridView的屬性
            dataGridViewMeds.AutoGenerateColumns = false;



            // 添加DataGridView的欄位
            dataGridViewMeds.Columns.Add("MedId", "編號");
            dataGridViewMeds.Columns.Add("MedName", "藥品名稱");
            dataGridViewMeds.Columns.Add("MedEf", "作用");
            dataGridViewMeds.Columns.Add("MedSe", "副作用");
            dataGridViewMeds.Columns.Add("MedNotice", "注意事項");

            EmployeeController employeeController = new EmployeeController();


        }
        private void searchAllMeds()
        {
            // 清空DataGridView的資料
            dataGridViewMeds.Rows.Clear();
            List<Medicine> meds = new List<Medicine>();

            MedicineController medController = new MedicineController();
            // 取得員工資料
            meds = medController.GetMeds();

            // 將員工資料加入到DataGridView
            foreach (Medicine med in meds)
            {
                dataGridViewMeds.Rows.Add(med.MedId, med.MedName, med.MedEf, med.MedSe, med.MedNotice);
            }
        }

        private void FormMed_Load(object sender, EventArgs e)
        {

            checkStatus();
            searchAllMeds();
            lblEmp.Text = $"操作人員：{GlobalSettings.employee.empName}";
        }
        /// <summary>
        /// 確認狀態(按鈕)
        /// </summary>
        private void checkStatus()
        {
            switch (status)
            {
                case "Create":
                    lblTitle.Text = "藥品資料-新增";
                    btnCreate.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnSearch.Enabled = false;
                    dataGridViewMeds.Enabled = false;
                    panelSave.Visible = true;
                    break;
                case "Update":
                    lblTitle.Text = "藥品資料-修改";
                    btnCreate.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnSearch.Enabled = false;
                    dataGridViewMeds.Enabled = false;
                    panelSave.Visible = true;
                    break;
                case "Default":
                    lblTitle.Text = "藥品資料";
                    btnCreate.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnSearch.Enabled = true;
                    dataGridViewMeds.Enabled = true;
                    panelSave.Visible = false;
                    break;
            }
            controlSetting();
        }
        /// <summary>
        /// 確認狀態(txt可否更動)
        /// </summary>
        private void controlSetting()
        {
            switch (status)
            {
                case "Create":

                    txtMedId.Enabled = true;
                    txtMedEf.Enabled = true;
                    txtMedName.Enabled = true;
                    txtMedNotice.Enabled = true;
                    txtMedSe.Enabled = true;
                    break;
                case "Update":
                    txtMedId.Enabled = false;
                    txtMedEf.Enabled = true;
                    txtMedName.Enabled = true;
                    txtMedNotice.Enabled = true;
                    txtMedSe.Enabled = true;
                    break;
                case "Default":
                    txtMedId.Enabled = true;
                    txtMedEf.Enabled = true;
                    txtMedName.Enabled = true;
                    txtMedNotice.Enabled = false;
                    txtMedSe.Enabled = true;
                    break;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            status = "Create";

            checkStatus();



        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            status = "Update";

            MedicineController medController = new MedicineController();
            if (txtMedId.Text.Equals(""))
            {
                MessageBox.Show("請選擇一筆資料!");
                return;
            }
            checkStatus();

        }

        private void btnBackOption_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {

            status = "Default";
            checkStatus();
        }

        private void dataGridViewMeds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMedId.Text = dataGridViewMeds.Rows[e.RowIndex].Cells["MedId"].Value.ToString().Trim();
                txtMedName.Text = dataGridViewMeds.Rows[e.RowIndex].Cells["MedName"].Value.ToString().Trim();
                txtMedEf.Text = dataGridViewMeds.Rows[e.RowIndex].Cells["MedEf"].Value.ToString().Trim();
                txtMedSe.Text = dataGridViewMeds.Rows[e.RowIndex].Cells["MedSe"].Value.ToString().Trim();
                txtMedNotice.Text = dataGridViewMeds.Rows[e.RowIndex].Cells["MedNotice"].Value.ToString().Trim();
            }
        }
        private void clearTxt()
        {
            txtMedId.Clear();
            txtMedEf.Clear();
            txtMedName.Clear();
            txtMedNotice.Clear();
            txtMedSe.Clear();

        }
        private Medicine getBindingMed()
        {
            Medicine med = new Medicine();
            med.MedId = txtMedId.Text;
            med.MedName = txtMedName.Text;
            med.MedEf = txtMedEf.Text;
            med.MedSe = txtMedSe.Text;
            med.MedNotice = txtMedNotice.Text;
            return med;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MedicineController MedController = new MedicineController();
            if (txtMedId.Text.Equals(""))
            {
                MessageBox.Show("請選擇一筆資料!");
                return;
            }
            else
            {
                Medicine med = getBindingMed();
                DialogResult result = MessageBox.Show($"是否確定要刪除{med.MedName}？", "刪除確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                // 根據使用者的選擇執行相應的動作
                if (result == DialogResult.OK)
                {
                    if (MedController.deleteMed(med))
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

                searchAllMeds();
                clearTxt();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            MedicineController medCon = new MedicineController();
            Medicine med = getBindingMed();
            if (status.Equals("Create"))
            {
                string result = medCon.InsertMed(med);
                if (result.Equals(""))
                {
                    MessageBox.Show("新增成功");
                }
                else
                {
                    MessageBox.Show("新增失敗:" + result);
                    return;
                }
            }
            else if (status.Equals("Update"))
            {
                string result = medCon.updateMed(med);
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
            searchAllMeds();
            clearTxt();
        }

        /// <summary>
        /// 搜尋後DGV呈現資料
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            status = "Default";
            dataGridViewMeds.Rows.Clear();
            MedicineController medController = new MedicineController();
            renderDgv(medController.GetMedicines(txtMedId.Text, txtMedName.Text,txtMedEf.Text, txtMedSe.Text));
            if (dataGridViewMeds.RowCount == 0)
            {
                MessageBox.Show("查無此藥品!!");
            }
            checkStatus();
        }
        /// <summary>
        /// 填充搜尋到的資料 填入DGV
        /// </summary>
        /// <param name="employees"></param>
        private void renderDgv(List<Medicine> meds)
        {
            // 清空DataGridView的資料
            dataGridViewMeds.Rows.Clear();
            // 將藥物資料加入到DataGridView
            foreach (Medicine med in meds)
            {
                dataGridViewMeds.Rows.Add(med.MedId, med.MedName,med.MedEf,med.MedSe,med.MedNotice);
            }
        }

        private void btnClearTxt_Click(object sender, EventArgs e)
        {
            clearTxt();
        }

        private void btnListAllMed_Click(object sender, EventArgs e)
        {
            dataGridViewMeds.Rows.Clear();
            clearTxt();
            searchAllMeds();
        }
    }
}
