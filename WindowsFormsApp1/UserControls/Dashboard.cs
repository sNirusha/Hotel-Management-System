using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;
using System.Windows.Forms;
using WindowsFormsApp1.UserControls;

namespace WindowsFormsApp1
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            UC_Home uc = new UC_Home();
            addUserControl(uc);
        }
  
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront(); 
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UC_Home uc = new UC_Home();
            addUserControl(uc);
        }

        private void User_Click(object sender, EventArgs e)
        {
            UC_User uc = new UC_User();
            addUserControl(uc);
        }

        private void Customer_Click(object sender, EventArgs e)
        {
            UC_Customer uc = new UC_Customer();
            addUserControl(uc);
        }

        private void Food_Click(object sender, EventArgs e)
        {
            UC_Food uc = new UC_Food(); 
            addUserControl(uc);
        }

        private void Room_Click(object sender, EventArgs e)
        {
            UC_Room uc = new UC_Room(); 
            addUserControl(uc);
        }

        private void Bill_Click(object sender, EventArgs e)
        {
            UC_Bill uc = new UC_Bill();
            addUserControl(uc);
        }

        private void Setting_Click(object sender, EventArgs e)
        {
            UC_Setting uc = new UC_Setting();
            addUserControl(uc);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Close();
        }
    }
}
