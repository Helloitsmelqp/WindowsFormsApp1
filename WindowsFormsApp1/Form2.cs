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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        void filldgv()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-T9JTCQ3;Initial Catalog=employee;Integrated Security=True;");
            string sql = "Select ID,Name,Management,Job FROM employees";
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
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            filldgv();
            Clear();
        }
        private void بياناتالموظفينToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void إدخالالغياباتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 fa = new Form3();
            fa.Show();
        }
        private void تقريرغيابللموظفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 ff = new Form4();
            ff.Show();
        }
        private void خروجمنالبرنامجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
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
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                textBox4.Focus();
            }
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex % 2 == 0)
            {
                e.CellStyle.BackColor = Color.RosyBrown;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-T9JTCQ3;Initial Catalog=employee;Integrated Security=True;");
                string sql = "INSERT INTO employees  (ID,Name,Management,Job) Values(@1,@2,@3,@4)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@1", Convert.ToInt32(textBox1.Text));
                cmd.Parameters.AddWithValue("@2", textBox2.Text);
                cmd.Parameters.AddWithValue("@3", textBox3.Text);
                cmd.Parameters.AddWithValue("@4", textBox4.Text);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("تم التسجيل بنجاح ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                    filldgv();
                    Clear();
                }
            }
            else
            { 
                   MessageBox.Show("ارجاء ادخال بيانات", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }  
    }
        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "")
            {
                String conString = @"Data Source = DESKTOP-T9JTCQ3;  Initial Catalog =employee; Integrated Security = True";
                SqlConnection con = new SqlConnection(conString);
                String sql = "UPDATE employees SET Name = @2,Management = @3,Job = @4  WHERE ID = @1";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@1", Convert.ToInt32(textBox1.Text));
                cmd.Parameters.AddWithValue("@2", textBox2.Text);
                cmd.Parameters.AddWithValue("@3", textBox3.Text);
                cmd.Parameters.AddWithValue("@4", textBox4.Text);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("تم التعديل بنجاح", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                    filldgv();
                    Clear();
                }
            }
            else
            {
                MessageBox.Show("لاتوجد بيانات لتعديلها", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
}
             private void button3_Click(object sender, EventArgs e)
             { 
                if (textBox1.Text != "")
                {
                String conString = @"Data Source = DESKTOP-T9JTCQ3;  Initial Catalog =employee; Integrated Security = True";
                SqlConnection con = new SqlConnection(conString);
                String sql = "DELETE FROM employees WHERE ID = @1 ";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@1", Convert.ToInt32(textBox1.Text));
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("تم الحذف بنجاح", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                finally
                {
                    con.Close();
                    filldgv();
                }
             }
                else
                {
                   MessageBox.Show("لاتوجد بيانات لحذفها", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
    }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-T9JTCQ3;Initial Catalog=employee;Integrated Security=True;");
            string sql = "Select ID,Name,Management,Job FROM employees WHERE Name  LIKE '%" + textBox5.Text + "%'";
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
        private void dataGridView1_Click(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
        private void button4_Click(object sender, EventArgs e)
        {
        }
        private void label5_Click(object sender, EventArgs e)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {  
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
        private void label5_Click_1(object sender, EventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void label4_Click(object sender, EventArgs e)
        {
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
    }
}
