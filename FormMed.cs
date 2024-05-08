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
        public FormMed()
        {
            InitializeComponent();


            // 設定DataGridView的屬性
            dataGridViewMeds.AutoGenerateColumns = false;



            // 添加DataGridView的欄位
            dataGridViewMeds.Columns.Add("MedId", "藥品編號");
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
                dataGridViewMeds.Rows.Add(med.MedId,med.MedName, med.MedEf,med.MedSe,med.MedNotice);
            }
        }

        private void FormMed_Load(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            searchAllMeds();
            string emp = employee.empName;
            lblEmp.Text = $"操作人員：{emp}";
        }
    }
}
