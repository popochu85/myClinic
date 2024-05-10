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
    public partial class FormDoctor : Form
    {
        public FormDoctor()
        {
            InitializeComponent();
        }

        private void FormDoctor_Load(object sender, EventArgs e)
        {
            dgvMed.Columns.Add("MedName", "藥品名稱");
            dgvMed.Columns.Add("MedEf", "作用");
            dgvMed.Columns.Add("MedSe", "副作用");
            dgvMed.Columns.Add("MedNotice", "注意事項");
            
            // 清空DataGridView的資料
            dgvMed.Rows.Clear();
            List<Medicine> meds = new List<Medicine>();

            MedicineController medController = new MedicineController();
            // 取得員工資料
            meds = medController.GetMeds();

            // 將員工資料加入到DataGridView
            foreach (Medicine med in meds)
            {
                dgvMed.Rows.Add(med.MedName, med.MedEf, med.MedSe, med.MedNotice);
            }
        }
    }
}
