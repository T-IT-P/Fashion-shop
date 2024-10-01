using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Fashion_shop
{
    public partial class FormDanhMucSanPham : Form
    {
        SqlConnection connec = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\VF_IT_06\Documents\DESKTOP-AUDBA01.mdf;Integrated Security=True;Connect Timeout=30");
        public FormDanhMucSanPham()
        {
            InitializeComponent();
        }

        private void FormDanhMucSanPham_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

            Text  = textBox1.Text;
            Text = textBox2.Text;
        
            

            
            connec.Open();
           
            string slect = "INSERT INTO category  (id_chatlieu_category,name_chatlieu_category) VALUES ('Text','' );";
            using (SqlCommand cmd = new SqlCommand(slect, connec))
            { 
              

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
            }

        }
           

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
