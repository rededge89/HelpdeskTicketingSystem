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
    public partial class UserDashboard : Form
    {
        public UserDashboard()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.Red, ButtonBorderStyle.Solid);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panelCurrentSelection.Height = btnHome.Height;
            panelCurrentSelection.Top = btnHome.Top;
        }

        private void btnCreateTicket_Click(object sender, EventArgs e)
        {
            panelCurrentSelection.Height = btnCreateTicket.Height;
            panelCurrentSelection.Top = btnCreateTicket.Top;
            //Hide all other panels
            panelViewTicketStatus.Visible = false;
            //show selected panel
            panelCreateNewTicket.Visible = true;
            
        }

        private void btnTicketStatus_Click(object sender, EventArgs e)
        {
            panelCurrentSelection.Height = btnTicketStatus.Height;
            panelCurrentSelection.Top = btnTicketStatus.Top;
            //Hide all other panels
            panelCreateNewTicket.Visible = false;
            //show selected panel
            panelViewTicketStatus.Visible = true;
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            panelCurrentSelection.Height = btnAccount.Height;
            panelCurrentSelection.Top = btnAccount.Top;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            panelCurrentSelection.Height = btnExit.Height;
            panelCurrentSelection.Top = btnExit.Top;
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
    }
}
