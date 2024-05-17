namespace formLatihan15menit
{
    partial class Form10
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 64);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(664, 14);
            button1.Name = "button1";
            button1.Size = new Size(113, 33);
            button1.TabIndex = 2;
            button1.Text = "GENERATE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(21, 15);
            label1.Name = "label1";
            label1.Size = new Size(204, 32);
            label1.TabIndex = 1;
            label1.Text = "Jadwal Pelajaran";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 82);
            label2.Name = "label2";
            label2.Size = new Size(139, 17);
            label2.TabIndex = 1;
            label2.Text = "Filter berdasarkan sesi";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(202, 81);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(283, 23);
            comboBox1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new Point(21, 128);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(756, 237);
            dataGridView1.TabIndex = 3;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nis";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Tanggal";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Hari";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Guru";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Kelas";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Mata Pelajaran";
            Column6.Name = "Column6";
            // 
            // button2
            // 
            button2.Location = new Point(21, 390);
            button2.Name = "button2";
            button2.Size = new Size(121, 32);
            button2.TabIndex = 4;
            button2.Text = "Print to excel / pdf";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form10
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Form10";
            Text = "Form10";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private Button button2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}