namespace formLatihan15menit
{
    partial class Form12
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
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            label2 = new Label();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 61);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(651, 11);
            button2.Name = "button2";
            button2.Size = new Size(127, 39);
            button2.TabIndex = 2;
            button2.Text = "Kategori Angsuran";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(506, 11);
            button1.Name = "button1";
            button1.Size = new Size(127, 39);
            button1.TabIndex = 1;
            button1.Text = "Tambah Angsuran";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(185, 32);
            label1.TabIndex = 3;
            label1.Text = "Data Angsuran";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column3, Column4, Column5, Column6, Column7, Column2 });
            dataGridView1.Location = new Point(12, 144);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(766, 239);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "No";
            Column1.Name = "Column1";
            // 
            // Column3
            // 
            Column3.HeaderText = "Nama Siswa";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Cicilan Ke ";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Besar Cicilan";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Sisa Cicilan";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Sisa Banyaknya Cicilan";
            Column7.Name = "Column7";
            // 
            // Column2
            // 
            Column2.HeaderText = "Lunas?";
            Column2.Name = "Column2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(564, 85);
            label2.Name = "label2";
            label2.Size = new Size(31, 17);
            label2.TabIndex = 2;
            label2.Text = "Cari";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(612, 84);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(166, 23);
            textBox1.TabIndex = 3;
            // 
            // Form12
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "Form12";
            Text = "Form12";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label2;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column2;
    }
}