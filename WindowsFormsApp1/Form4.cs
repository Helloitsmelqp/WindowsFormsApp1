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

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        void filldgv()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-T9JTCQ3;Initial Catalog=employee;Integrated Security=True;");
            string sql = "Select * FROM Hooky";
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);

            DataSet sd = new DataSet();
            try
            {
                con.Open();
                sda.Fill(sd);
                dataGridView1.DataSource = sd.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        void Clear()
        {
            textBox1.Clear();
            textBox1.Focus();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            filldgv();
            Clear();
        }
        private void خروجمنالبرنامجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void بياناتالموظفينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 ff = new Form2();
            ff.Show();
        }
        private void إدخالالغياباتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 ff = new Form3();
            ff.Show();
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex % 2 == 0)
            {
                e.CellStyle.BackColor = Color.RosyBrown;
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("الرجاء ادخال ارقام فقط", "تنبية", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "")
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-T9JTCQ3;Initial Catalog=employee;Integrated Security=True;");
                string sql = "Select Date FROM Hooky WHERE ID  LIKE '%" + Convert.ToInt32(textBox1.Text) + "%'";
                SqlDataAdapter sda = new SqlDataAdapter(sql, con);

                DataSet sd = new DataSet();
                try
                {
                    con.Open();
                    sda.Fill(sd);
                    dataGridView1.DataSource = sd.Tables[0];


                    MessageBox.Show(" رقم الموظف  " + textBox1.Text + "غاب في");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                    Clear();
                }
            }
            else
            {
                MessageBox.Show("ارجاء ادخال بيانات", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void dateTimePicker1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
