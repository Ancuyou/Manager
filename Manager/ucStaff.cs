using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Manager
{
    public partial class ucStaff : UserControl
    {
        public ucStaff()
        {
            InitializeComponent();
        }
        void SelectTxt(Guna2TextBox txt)
        {
            txt.BackColor = Color.FromArgb(139, 199, 255);
        }
        void LeaveTxt(Guna2TextBox txt)
        {
            txt.BackColor = Color.White;
        }
        private void txtFirstName_MouseClick(object sender, MouseEventArgs e)
        {
            SelectTxt(txtFirstName);
        }
        private void txtLastName_MouseClick(object sender, MouseEventArgs e)
        {
            SelectTxt(txtLastName);
        }

        private void txtEmail_MouseClick(object sender, MouseEventArgs e)
        {
            SelectTxt(txtEmail);
        }
        private void txtPhone_MouseClick(object sender, MouseEventArgs e)
        {
            SelectTxt(txtPhone);
        }

        private void txtAddress_MouseClick(object sender, MouseEventArgs e)
        {
            SelectTxt(txtAddress);
        }

        private void txtSalary_MouseClick(object sender, MouseEventArgs e)
        {
            SelectTxt(txtSalary);
        }

        private void txtDescription_MouseClick(object sender, MouseEventArgs e)
        {
            SelectTxt(txtDescription);
        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            LeaveTxt(txtFirstName);
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            LeaveTxt(txtLastName);
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            LeaveTxt(txtEmail);
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            LeaveTxt(txtPhone);
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            LeaveTxt(txtAddress);
        }

        private void txtSalary_Leave(object sender, EventArgs e)
        {
            LeaveTxt(txtSalary);
        }

        private void txtDescription_Leave(object sender, EventArgs e)
        {
            LeaveTxt(txtDescription);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            timer.Start();
            tbpnlTop.Enabled = false;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            timer.Start();
            tbpnlTop.Enabled = true;
        }
        private void timer_Tick_1(object sender, EventArgs e)
        {
            if (pnlEditProduct.Width == 470)
            {
                tblEditProduct.Visible = false;
                for (int i = 0; i < 10; i++)
                {
                    pnlEditProduct.Width = pnlEditProduct.Width - 47;
                }
            }
            else
            {
                for (int i = 0; i < 10; i++)
                {
                    pnlEditProduct.Width = pnlEditProduct.Width + 47;
                }
                tblEditProduct.Visible = true;
            }
            timer.Stop();
        }

        private void ucStaff_Load(object sender, EventArgs e)
        {
            pnlEditProduct.Width = 0;
            dgvStaff.Rows.Add(new object[] { "100", "James", "Adams", "09/20/1980", "12345678" });
            dgvStaff.Rows.Add(new object[] { "101", "Mary", "Baker", "02/19/1974", "12345678" });
            dgvStaff.Rows.Add(new object[] { "102", "John", "Snyder", "04/21/1983", "12345678" });
            dgvStaff.Rows.Add(new object[] { "103", "Patricia", "Young", "12/10/1990", "12345678" });
            dgvStaff.Rows.Add(new object[] { "104", "Robert", "Miller", "07/07/1982", "12345678" });
            dgvStaff.Rows.Add(new object[] { "105", "Jennifer", "Campbell", "03/03/1986", "12345678" });
            dgvStaff.Rows.Add(new object[] { "100", "James", "Adams", "09/20/1980", "12345678" });
            dgvStaff.Rows.Add(new object[] { "101", "Mary", "Baker", "02/19/1974", "12345678" });
            dgvStaff.Rows.Add(new object[] { "102", "John", "Snyder", "04/21/1983", "12345678" });
            dgvStaff.Rows.Add(new object[] { "103", "Patricia", "Young", "12/10/1990", "12345678" });
            dgvStaff.Rows.Add(new object[] { "104", "Robert", "Miller", "07/07/1982", "12345678" });
            dgvStaff.Rows.Add(new object[] { "105", "Jennifer", "Campbell", "03/03/1986", "12345678" });
            dgvStaff.Rows.Add(new object[] { "100", "James", "Adams", "09/20/1980", "12345678" });
            dgvStaff.Rows.Add(new object[] { "101", "Mary", "Baker", "02/19/1974", "12345678" });
            dgvStaff.Rows.Add(new object[] { "102", "John", "Snyder", "04/21/1983", "12345678" });
            dgvStaff.Rows.Add(new object[] { "103", "Patricia", "Young", "12/10/1990", "12345678" });
            dgvStaff.Rows.Add(new object[] { "104", "Robert", "Miller", "07/07/1982", "12345678" });
            dgvStaff.Rows.Add(new object[] { "105", "Jennifer", "Campbell", "03/03/1986", "12345678" });

        }
    }
}
