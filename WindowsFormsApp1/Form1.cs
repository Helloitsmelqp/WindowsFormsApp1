using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "admin" && textBox2.Text == "123456")
            {
                Form5 f = new Form5();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("اسم المستخدم او كلمة المرور خاطئة ", "تنبية", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                textBox2.Focus();
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
        }
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
    }
}
