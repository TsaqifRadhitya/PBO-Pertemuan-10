namespace PBO_Pertemuan_9
{
    partial class Tambah_Edit_Tugas
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
            label1 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            errName = new Label();
            label3 = new Label();
            errMatkul = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            errDeadline = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(350, 52);
            label1.Name = "label1";
            label1.Size = new Size(91, 38);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(208, 133);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(367, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "PBO", "BASDA", "JARKOM", "ALGO 2", "SISDIG" });
            comboBox1.Location = new Point(208, 226);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(367, 28);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(208, 313);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(367, 27);
            dateTimePicker1.TabIndex = 3;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(208, 110);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 4;
            label2.Text = "Nama Tugas";
            // 
            // errName
            // 
            errName.AutoSize = true;
            errName.Font = new Font("Segoe UI", 9F);
            errName.ForeColor = Color.Red;
            errName.Location = new Point(208, 179);
            errName.Name = "errName";
            errName.Size = new Size(0, 20);
            errName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(208, 203);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 6;
            label3.Text = "Mata Kuliah";
            // 
            // errMatkul
            // 
            errMatkul.AutoSize = true;
            errMatkul.Font = new Font("Segoe UI", 9F);
            errMatkul.ForeColor = Color.Red;
            errMatkul.Location = new Point(208, 273);
            errMatkul.Name = "errMatkul";
            errMatkul.Size = new Size(0, 20);
            errMatkul.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(208, 360);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(208, 290);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 10;
            label5.Text = "Deadline";
            // 
            // button1
            // 
            button1.Location = new Point(208, 372);
            button1.Name = "button1";
            button1.Size = new Size(367, 41);
            button1.TabIndex = 11;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // errDeadline
            // 
            errDeadline.AutoSize = true;
            errDeadline.ForeColor = Color.Red;
            errDeadline.Location = new Point(208, 359);
            errDeadline.Name = "errDeadline";
            errDeadline.Size = new Size(0, 20);
            errDeadline.TabIndex = 12;
            // 
            // Tambah_Edit_Tugas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(errDeadline);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(errMatkul);
            Controls.Add(label3);
            Controls.Add(errName);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Tambah_Edit_Tugas";
            Text = " ";
            Load += Tambah_Edit_Tugas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label errName;
        private Label label3;
        private Label errMatkul;
        private Label label4;
        private Label label5;
        private Button button1;
        private Label errDeadline;
    }
}