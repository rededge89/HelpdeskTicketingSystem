using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelpdeskTicketingSystem.Pages
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.Red, ButtonBorderStyle.Solid);
        }

        

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTopExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            txtUsername.TextAlign = HorizontalAlignment.Left;
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
            }

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.TextAlign = HorizontalAlignment.Left;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
            }
        }
    }
}
