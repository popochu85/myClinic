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
            if (GlobalSettings.employee.groupId == "01")
            {//01系統管理員 02護理師 03醫師
                btnDoctor.Enabled = true;
                btnMed.Enabled = true;
                btnNurse.Enabled = true;
                btnEmp.Enabled = true;
            }
            else if (GlobalSettings.employee.groupId == "02")
                {//01系統管理員 02護理師 03醫師
                    btnDoctor.Enabled = false;
                    btnMed.Enabled = true;
                    btnNurse.Enabled = true;
                    btnEmp.Enabled = true;
                }
            else if (GlobalSettings.employee.groupId == "03")
            {//01系統管理員 02護理師 03醫師
                btnDoctor.Enabled = true;
                btnMed.Enabled = true;
                btnNurse.Enabled = false;
                btnEmp.Enabled = true;
            }
        }


        private void FormOption_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            GlobalSettings.employee = null;
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
