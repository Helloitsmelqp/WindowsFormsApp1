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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        void Clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }
        void fill_dgv()
        {
            String conString = @"Data Source = DESKTOP-T9JTCQ3;  Initial Catalog = employee ; Integrated Security = True";
            SqlConnection con = new SqlConnection(conString);
            String sql = "select * from Hooky";
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);

            DataSet sd = new DataSet();
            DataTable dt = new DataTable();
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
        private void Form3_Load(object sender, EventArgs e)
        {
            fill_dgv();
            Clear();
        }
        private void خروجمنالبرنامجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void تقريرغيابللموظفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 ff = new Form4();
            ff.Show();
        }
        private void بياناتالموظفينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 ff = new Form2();
            ff.Show();
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
            if (e.KeyChar == (char)Keys.Enter)
            {
                textBox2.Focus();
            }
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                dateTimePicker1.Focus();
            }
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex % 2 == 0)
            {
                e.CellStyle.BackColor = Color.RosyBrown;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-T9JTCQ3;Initial Catalog = employee;Integrated Security=True;");
                string sql = "INSERT INTO Hooky  (ID,Name,Date) Values(@1,@2,@3)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@1", Convert.ToInt32(textBox1.Text));
                cmd.Parameters.AddWithValue("@2", textBox2.Text);
                cmd.Parameters.AddWithValue("@3", dateTimePicker1.Value.Date);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("تم التسجيل غياب " + textBox2.Text + " بتاريخ يوم" + dateTimePicker1.Value.Date);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                    fill_dgv();
                    Clear();
                }
            }
            else
            {
                MessageBox.Show("ارجاء ادخال بيانات", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-T9JTCQ3;Initial Catalog=employee;Integrated Security=True;");
            string sql = "Select ID,Name,Date FROM Hooky WHERE Name LIKE '%" + textBox3.Text + "%'";
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);
            DataSet sd = new DataSet();
            DataTable dt = new DataTable();
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
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                String conString = @"Data Source = DESKTOP-T9JTCQ3;  Initial Catalog =employee; Integrated Security = True";
                SqlConnection con = new SqlConnection(conString);
                String sql = "SELECT  Name  FROM employees WHERE ID = @1 ";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@1", Convert.ToInt32(textBox1.Text));
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                finally
                {
                    con.Close();
                    fill_dgv();
                }
            }
            else
            {
                MessageBox.Show("ارجاء ادخال بيانات", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
