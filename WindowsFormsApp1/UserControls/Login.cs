using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1.UserControls
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        //data base conection
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-7S7QJOB\SQLEXPRESS;Initial Catalog=Hotel_M;Integrated Security=True;");

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            String username, password;
            username = guna2TextBox1.Text;
            password = guna2TextBox2.Text;

            try
            {
                string querry = "SELECT * FROM login_user WHERE user_name ='" + username + "' AND password = '" + password + "'";


                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);


                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = guna2TextBox1.Text;
                    password = guna2TextBox2.Text;

                    Dashboard db = new Dashboard();
                    db.Show();
                    this.Hide();



                }
                else
                {
                    MessageBox.Show("Inavalid details");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
          this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
