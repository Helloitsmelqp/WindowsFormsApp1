namespace WindowsFormsApp1
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.بياناتالموظفينToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.إدخالالغياباتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تقريرغيابللموظفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.خروجمنالبرنامجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.بياناتالموظفينToolStripMenuItem,
            this.إدخالالغياباتToolStripMenuItem,
            this.تقريرغيابللموظفToolStripMenuItem,
            this.خروجمنالبرنامجToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(742, 29);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(321, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(409, 231);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 20);
            this.textBox1.TabIndex = 27;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "رقم الموطف";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(71, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 50);
            this.button1.TabIndex = 28;
            this.button1.Text = "عدد ايام غياب الموظف";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(31, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 231);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // بياناتالموظفينToolStripMenuItem
            // 
            this.بياناتالموظفينToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.بياناتالموظفينToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.IMG_20231208_WA02492;
            this.بياناتالموظفينToolStripMenuItem.Name = "بياناتالموظفينToolStripMenuItem";
            this.بياناتالموظفينToolStripMenuItem.Size = new System.Drawing.Size(143, 25);
            this.بياناتالموظفينToolStripMenuItem.Text = "بيانات الموظفين";
            this.بياناتالموظفينToolStripMenuItem.Click += new System.EventHandler(this.بياناتالموظفينToolStripMenuItem_Click);
            // 
            // إدخالالغياباتToolStripMenuItem
            // 
            this.إدخالالغياباتToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.إدخالالغياباتToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.IMG_20231208_WA02482;
            this.إدخالالغياباتToolStripMenuItem.Name = "إدخالالغياباتToolStripMenuItem";
            this.إدخالالغياباتToolStripMenuItem.Size = new System.Drawing.Size(129, 25);
            this.إدخالالغياباتToolStripMenuItem.Text = "إدخال الغيابات";
            this.إدخالالغياباتToolStripMenuItem.Click += new System.EventHandler(this.إدخالالغياباتToolStripMenuItem_Click);
            // 
            // تقريرغيابللموظفToolStripMenuItem
            // 
            this.تقريرغيابللموظفToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.تقريرغيابللموظفToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.IMG_20231208_WA02452;
            this.تقريرغيابللموظفToolStripMenuItem.Name = "تقريرغيابللموظفToolStripMenuItem";
            this.تقريرغيابللموظفToolStripMenuItem.Size = new System.Drawing.Size(168, 25);
            this.تقريرغيابللموظفToolStripMenuItem.Text = "تقرير غياب للموظف";
            // 
            // خروجمنالبرنامجToolStripMenuItem
            // 
            this.خروجمنالبرنامجToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.خروجمنالبرنامجToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources._39177592;
            this.خروجمنالبرنامجToolStripMenuItem.Name = "خروجمنالبرنامجToolStripMenuItem";
            this.خروجمنالبرنامجToolStripMenuItem.Size = new System.Drawing.Size(146, 25);
            this.خروجمنالبرنامجToolStripMenuItem.Text = "خروج من البرنامج";
            this.خروجمنالبرنامجToolStripMenuItem.Click += new System.EventHandler(this.خروجمنالبرنامجToolStripMenuItem_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(742, 362);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقرير غباب للموظف";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem بياناتالموظفينToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem إدخالالغياباتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تقريرغيابللموظفToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem خروجمنالبرنامجToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}