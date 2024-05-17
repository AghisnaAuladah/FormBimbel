namespace formLatihan15menit
{
    partial class Form14
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
            label5 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
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
            panel1.Size = new Size(800, 56);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(221, 32);
            label1.TabIndex = 5;
            label1.Text = "Tambah Angsuran";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(23, 74);
            label5.Name = "label5";
            label5.Size = new Size(67, 17);
            label5.TabIndex = 7;
            label5.Text = "Pilih Siswa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 192);
            label2.Name = "label2";
            label2.Size = new Size(94, 17);
            label2.TabIndex = 8;
            label2.Text = "PEMBAYARAN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(361, 74);
            label3.Name = "label3";
            label3.Size = new Size(87, 17);
            label3.TabIndex = 9;
            label3.Text = "Histori Cicilan";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(23, 230);
            label4.Name = "label4";
            label4.Size = new Size(64, 17);
            label4.TabIndex = 10;
            label4.Text = "Cicilan Ke";
            label4.Click += label4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(23, 107);
            label6.Name = "label6";
            label6.Size = new Size(136, 17);
            label6.TabIndex = 11;
            label6.Text = "Sisa Banyaknya Cicilan";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(23, 270);
            label7.Name = "label7";
            label7.Size = new Size(81, 17);
            label7.TabIndex = 12;
            label7.Text = "Besar Cicilan";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(361, 106);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(415, 277);
            dataGridView1.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(113, 73);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(178, 23);
            textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(171, 106);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(62, 23);
            textBox2.TabIndex = 15;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(127, 229);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(62, 23);
            textBox3.TabIndex = 16;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(127, 269);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(164, 23);
            textBox4.TabIndex = 17;
            // 
            // button1
            // 
            button1.Location = new Point(23, 346);
            button1.Name = "button1";
            button1.Size = new Size(94, 38);
            button1.TabIndex = 18;
            button1.Text = "BAYAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "No";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Nama Siswa";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Cicilan Ke";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Besar Cicilan";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Sisa Banyaknya Cicilan";
            Column5.Name = "Column5";
            // 
            // Form14
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 437);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(panel1);
            Name = "Form14";
            Text = "Form14";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label5;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}