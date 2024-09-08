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
namespace Fashion_shop
{
    public partial class Form1 : Form
    {
        SqlConnection connec = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\84839\Documents\fashionshop.mdf;Integrated Security=True;Connect Timeout=30");
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public bool emptyFieds()
        {
            if(Username.Text == ""|| password.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (emptyFieds())
            {
                MessageBox.Show("yeu cau  khong duoc de trong", "Error Message", MessageBoxButtons.OK);
            }
            else
            {
                if(connec.State == ConnectionState.Closed){
                    try
                    {
                        connec.Open();
                        string slect = "SELECT * From users WHERE username_user = @usern AND password_user = @pass AND status_user = @status";
                        using(SqlCommand cmd = new SqlCommand(slect, connec))
                        {
                            cmd.Parameters.AddWithValue("@usern",Username.Text.Trim());
                            cmd.Parameters.AddWithValue("@pass", password.Text.Trim());
                            cmd.Parameters.AddWithValue("@status", "Active");
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show("ket noi thanh cong", "thong tin message", MessageBoxButtons.OK);

                            }
                            else
                            {
                                MessageBox.Show(" pass va ten khong chinh sac","loi he thong",MessageBoxButtons.OK);
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("ket noi loi" + ex, "loi tin nhaw", MessageBoxButtons.OK);
                    }
                    
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void show_password(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                password.PasswordChar = (char)0;
               
            }
            else
            {
                password.PasswordChar = '*';
              
            }

        }

       
    }
}
