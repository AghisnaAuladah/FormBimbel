namespace formLatihan15menit
{
    partial class Form11
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            textBox6 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(851, 55);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(199, 32);
            label1.TabIndex = 2;
            label1.Text = "Anggota Bimbel";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(546, 72);
            label2.Name = "label2";
            label2.Size = new Size(31, 17);
            label2.TabIndex = 1;
            label2.Text = "Cari";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(606, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(218, 23);
            textBox1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8 });
            dataGridView1.Location = new Point(26, 112);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(798, 150);
            dataGridView1.TabIndex = 3;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nama Siswa";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Jenis Paket";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Kelas";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Tgl. Registrasi";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Tipe Bayar";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Pilihan Hari";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Diskon";
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.HeaderText = "Total Bayar";
            Column8.Name = "Column8";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 281);
            label3.Name = "label3";
            label3.Size = new Size(67, 17);
            label3.TabIndex = 4;
            label3.Text = "Pilih Siswa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(27, 313);
            label4.Name = "label4";
            label4.Size = new Size(66, 17);
            label4.TabIndex = 5;
            label4.Text = "Pilih Paket";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(26, 347);
            label5.Name = "label5";
            label5.Size = new Size(69, 17);
            label5.TabIndex = 6;
            label5.Text = "Tipe Bayar";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(26, 377);
            label6.Name = "label6";
            label6.Size = new Size(107, 17);
            label6.TabIndex = 7;
            label6.Text = "Jumlah Angsuran";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(376, 281);
            label7.Name = "label7";
            label7.Size = new Size(66, 17);
            label7.TabIndex = 8;
            label7.Text = "Pilih Kelas";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(376, 313);
            label8.Name = "label8";
            label8.Size = new Size(95, 17);
            label8.TabIndex = 9;
            label8.Text = "Pilih Hari / Sesi";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(376, 347);
            label9.Name = "label9";
            label9.Size = new Size(115, 17);
            label9.TabIndex = 10;
            label9.Text = "Tanggal Registrasi";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(376, 377);
            label10.Name = "label10";
            label10.Size = new Size(47, 17);
            label10.TabIndex = 11;
            label10.Text = "Diskon";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(606, 377);
            label11.Name = "label11";
            label11.Size = new Size(77, 17);
            label11.TabIndex = 12;
            label11.Text = "Total Bayar";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(156, 280);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(140, 23);
            textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(156, 312);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(140, 23);
            textBox3.TabIndex = 14;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(519, 280);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(138, 23);
            textBox4.TabIndex = 15;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(689, 376);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(135, 23);
            textBox5.TabIndex = 16;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(156, 346);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(183, 23);
            comboBox1.TabIndex = 17;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(156, 376);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(183, 23);
            comboBox2.TabIndex = 18;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(519, 312);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(183, 23);
            comboBox3.TabIndex = 19;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(466, 377);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(111, 23);
            textBox6.TabIndex = 20;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(519, 343);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 21;
            // 
            // button1
            // 
            button1.Location = new Point(27, 432);
            button1.Name = "button1";
            button1.Size = new Size(106, 34);
            button1.TabIndex = 22;
            button1.Text = "Simpan";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(170, 432);
            button2.Name = "button2";
            button2.Size = new Size(106, 34);
            button2.TabIndex = 23;
            button2.Text = "Hapus";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(317, 432);
            button3.Name = "button3";
            button3.Size = new Size(106, 34);
            button3.TabIndex = 24;
            button3.Text = "Tambah";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form11
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 487);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox6);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Form11";
            Text = "Form11";
            Load += Form11_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private TextBox textBox6;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}