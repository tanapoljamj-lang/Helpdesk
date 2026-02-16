namespace Helpdesk
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            dateTimePicker2 = new DateTimePicker();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Leelawadee UI", 15F);
            label1.Location = new Point(11, 17);
            label1.Name = "label1";
            label1.Size = new Size(42, 28);
            label1.TabIndex = 0;
            label1.Text = "จาก";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Leelawadee UI", 15F);
            dateTimePicker1.Location = new Point(50, 17);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 34);
            dateTimePicker1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Leelawadee UI", 15F);
            label2.Location = new Point(256, 17);
            label2.Name = "label2";
            label2.Size = new Size(31, 28);
            label2.TabIndex = 2;
            label2.Text = "ถึง";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Leelawadee UI", 15F);
            dateTimePicker2.Location = new Point(293, 17);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 34);
            dateTimePicker2.TabIndex = 3;
            // 
            // button4
            // 
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(511, 12);
            button4.Name = "button4";
            button4.Size = new Size(136, 44);
            button4.TabIndex = 17;
            button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 76);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(635, 344);
            dataGridView1.TabIndex = 18;
            // 
            // button5
            // 
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(12, 438);
            button5.Name = "button5";
            button5.Size = new Size(136, 44);
            button5.TabIndex = 19;
            button5.UseVisualStyleBackColor = true;
            // 
            // Report
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 494);
            Controls.Add(button5);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(dateTimePicker2);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Name = "Report";
            Text = "Report";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private DateTimePicker dateTimePicker2;
        private Button button4;
        private DataGridView dataGridView1;
        private Button button5;
    }
}