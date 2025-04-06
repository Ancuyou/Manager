using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager
{
    public partial class frmManager : Form
    {
        public frmManager()
        {
            InitializeComponent();
        }
        void Select_btn(Button btn)
        {
            switch (btn.Name)
            {
                case "btnProduct": btn.ImageIndex = 1; break;
                case "btnIncome": btn.ImageIndex = 3; break;
                case "btnStaff": btn.ImageIndex = 5; break;
                case "btnFacility": btn.ImageIndex = 7; break;
                default: break;
            }
            btn.BackColor = Color.FromArgb(17, 147, 255);
        }
        void Reset_btn()
        {
            foreach (var btn in TLB_menu.Controls.OfType<Button>())
            {
                btn.BackColor = Color.FromArgb(17, 153, 248);
            }
            btnProduct.ImageIndex = 0;
            btnIncome.ImageIndex = 2;
            btnStaff.ImageIndex = 4;
            btnFacility.ImageIndex = 6;
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            Reset_btn();
            Select_btn(btnProduct);
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            Reset_btn();
            Select_btn(btnIncome);
            ucIncome uc_ic = new ucIncome();
            pnlPage.Controls.Clear();
            pnlPage.Controls.Add(uc_ic);
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            Reset_btn();
            Select_btn(btnStaff);
            ucIncome uc_p = new ucStaff();
            pnlPage.Controls.Clear();
            pnlPage.Controls.Add(uc_p);
        }

        private void btnFacility_Click(object sender, EventArgs e)
        {
            Reset_btn();
            Select_btn(btnFacility);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            lblLineSearch.Visible = false;
            txtSearch.BackColor = Color.FromArgb(99, 180, 255);
            pnlSearch.BackColor = Color.FromArgb(99, 180, 255);
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            lblLineSearch.Visible = true;
            txtSearch.BackColor = Color.FromArgb(139, 99, 255);
            pnlSearch.BackColor = Color.FromArgb(139, 99, 255);
        }
    }
}
