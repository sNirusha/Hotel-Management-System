namespace WindowsFormsApp1
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Setting = new Guna.UI2.WinForms.Guna2Button();
            this.Bill = new Guna.UI2.WinForms.Guna2Button();
            this.Room = new Guna.UI2.WinForms.Guna2Button();
            this.Food = new Guna.UI2.WinForms.Guna2Button();
            this.Customer = new Guna.UI2.WinForms.Guna2Button();
            this.User = new Guna.UI2.WinForms.Guna2Button();
            this.Home = new Guna.UI2.WinForms.Guna2Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(149)))), ((int)(((byte)(212)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1334, 63);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(1295, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = " Dashboard";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.Setting);
            this.panel2.Controls.Add(this.Bill);
            this.panel2.Controls.Add(this.Room);
            this.panel2.Controls.Add(this.Food);
            this.panel2.Controls.Add(this.Customer);
            this.panel2.Controls.Add(this.User);
            this.panel2.Controls.Add(this.Home);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1334, 57);
            this.panel2.TabIndex = 0;
            // 
            // Setting
            // 
            this.Setting.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Setting.CheckedState.CustomBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.Setting.CustomBorderColor = System.Drawing.Color.White;
            this.Setting.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.Setting.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Setting.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Setting.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Setting.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Setting.FillColor = System.Drawing.Color.White;
            this.Setting.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Setting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(149)))), ((int)(((byte)(212)))));
            this.Setting.HoverState.CustomBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.Setting.Location = new System.Drawing.Point(1139, 0);
            this.Setting.Name = "Setting";
            this.Setting.Size = new System.Drawing.Size(232, 58);
            this.Setting.TabIndex = 6;
            this.Setting.Text = "Setting";
            this.Setting.Click += new System.EventHandler(this.Setting_Click);
            // 
            // Bill
            // 
            this.Bill.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Bill.CheckedState.CustomBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.Bill.CustomBorderColor = System.Drawing.Color.White;
            this.Bill.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.Bill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Bill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Bill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Bill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Bill.FillColor = System.Drawing.Color.White;
            this.Bill.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(149)))), ((int)(((byte)(212)))));
            this.Bill.HoverState.CustomBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.Bill.Location = new System.Drawing.Point(948, 0);
            this.Bill.Name = "Bill";
            this.Bill.Size = new System.Drawing.Size(192, 58);
            this.Bill.TabIndex = 5;
            this.Bill.Text = "Bill";
            this.Bill.Click += new System.EventHandler(this.Bill_Click);
            // 
            // Room
            // 
            this.Room.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Room.CheckedState.CustomBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.Room.CustomBorderColor = System.Drawing.Color.White;
            this.Room.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.Room.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Room.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Room.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Room.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Room.FillColor = System.Drawing.Color.White;
            this.Room.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Room.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(149)))), ((int)(((byte)(212)))));
            this.Room.HoverState.CustomBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.Room.Location = new System.Drawing.Point(759, -1);
            this.Room.Name = "Room";
            this.Room.Size = new System.Drawing.Size(192, 58);
            this.Room.TabIndex = 4;
            this.Room.Text = "Room";
            this.Room.Click += new System.EventHandler(this.Room_Click);
            // 
            // Food
            // 
            this.Food.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Food.CheckedState.CustomBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.Food.CustomBorderColor = System.Drawing.Color.White;
            this.Food.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.Food.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Food.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Food.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Food.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Food.FillColor = System.Drawing.Color.White;
            this.Food.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Food.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(149)))), ((int)(((byte)(212)))));
            this.Food.HoverState.CustomBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.Food.Location = new System.Drawing.Point(560, -1);
            this.Food.Name = "Food";
            this.Food.Size = new System.Drawing.Size(203, 58);
            this.Food.TabIndex = 3;
            this.Food.Text = "Food";
            this.Food.Click += new System.EventHandler(this.Food_Click);
            // 
            // Customer
            // 
            this.Customer.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Customer.CheckedState.CustomBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.Customer.CustomBorderColor = System.Drawing.Color.White;
            this.Customer.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.Customer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Customer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Customer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Customer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Customer.FillColor = System.Drawing.Color.White;
            this.Customer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(149)))), ((int)(((byte)(212)))));
            this.Customer.HoverState.CustomBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.Customer.Location = new System.Drawing.Point(376, -1);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(192, 58);
            this.Customer.TabIndex = 2;
            this.Customer.Text = "Customer";
            this.Customer.Click += new System.EventHandler(this.Customer_Click);
            // 
            // User
            // 
            this.User.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.User.CheckedState.CustomBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.User.CustomBorderColor = System.Drawing.Color.White;
            this.User.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.User.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.User.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.User.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.User.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.User.FillColor = System.Drawing.Color.White;
            this.User.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(149)))), ((int)(((byte)(212)))));
            this.User.HoverState.CustomBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.User.Location = new System.Drawing.Point(188, 0);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(192, 58);
            this.User.TabIndex = 1;
            this.User.Text = "User";
            this.User.Click += new System.EventHandler(this.User_Click);
            // 
            // Home
            // 
            this.Home.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Home.CheckedState.CustomBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.Home.CustomBorderColor = System.Drawing.Color.White;
            this.Home.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.Home.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Home.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Home.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Home.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Home.FillColor = System.Drawing.Color.White;
            this.Home.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(149)))), ((int)(((byte)(212)))));
            this.Home.HoverState.CustomBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.Home.Location = new System.Drawing.Point(-1, -1);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(192, 58);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            this.Home.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.Snow;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 120);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1334, 570);
            this.panelContainer.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(1097, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 37);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(149)))), ((int)(((byte)(212)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(1146, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 38);
            this.button1.TabIndex = 11;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1334, 690);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelContainer;
        private Guna.UI2.WinForms.Guna2Button Home;
        private Guna.UI2.WinForms.Guna2Button Setting;
        private Guna.UI2.WinForms.Guna2Button Bill;
        private Guna.UI2.WinForms.Guna2Button Room;
        private Guna.UI2.WinForms.Guna2Button Food;
        private Guna.UI2.WinForms.Guna2Button Customer;
        private Guna.UI2.WinForms.Guna2Button User;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

