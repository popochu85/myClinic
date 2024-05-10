using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using myClinic.Model;

namespace myClinic
{
    public partial class FormOption : Form
    {
        public FormOption()
        {
            InitializeComponent();
        }

        private void FormOption_Load(object sender, EventArgs e)
        {
            lblEmp.Text = $"操作人員：{GlobalSettings.employee.empName}";
        }


        private void FormOption_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMed_Click(object sender, EventArgs e)
        {
            FormMed a = new FormMed();
            a.ShowDialog();
        }

        private void btnNurse_Click(object sender, EventArgs e)
        {
            FormNurse a= new FormNurse();
            a.ShowDialog();
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            FormDoctor a= new FormDoctor(); 
            a.ShowDialog();
        }

        private void btnEmp_Click(object sender, EventArgs e)
        {
            FormEmp a = new FormEmp();
            a.ShowDialog();
        }
    }
}
