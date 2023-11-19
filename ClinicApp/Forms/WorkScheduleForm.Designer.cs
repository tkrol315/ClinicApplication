namespace ClinicApp.Forms
{
    partial class WorkScheduleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkScheduleForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            WorkSchedule_DGV = new DataGridView();
            Date = new DataGridViewTextBoxColumn();
            Shift = new DataGridViewTextBoxColumn();
            Dayoff = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)WorkSchedule_DGV).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel1.Controls.Add(WorkSchedule_DGV, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // WorkSchedule_DGV
            // 
            WorkSchedule_DGV.AllowUserToAddRows = false;
            WorkSchedule_DGV.AllowUserToDeleteRows = false;
            WorkSchedule_DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            WorkSchedule_DGV.Columns.AddRange(new DataGridViewColumn[] { Date, Shift, Dayoff });
            WorkSchedule_DGV.Dock = DockStyle.Fill;
            WorkSchedule_DGV.Location = new Point(3, 3);
            WorkSchedule_DGV.Name = "WorkSchedule_DGV";
            WorkSchedule_DGV.ReadOnly = true;
            WorkSchedule_DGV.RowTemplate.Height = 25;
            WorkSchedule_DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            WorkSchedule_DGV.Size = new Size(674, 444);
            WorkSchedule_DGV.TabIndex = 1;
            // 
            // Date
            // 
            Date.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Date.HeaderText = "Data";
            Date.Name = "Date";
            Date.ReadOnly = true;
            // 
            // Shift
            // 
            Shift.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Shift.HeaderText = "Zmiana";
            Shift.Name = "Shift";
            Shift.ReadOnly = true;
            // 
            // Dayoff
            // 
            Dayoff.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Dayoff.HeaderText = "Zwolnienie";
            Dayoff.Name = "Dayoff";
            Dayoff.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(683, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(114, 444);
            panel1.TabIndex = 2;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Yellow;
            pictureBox4.Location = new Point(3, 102);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(21, 16);
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.OrangeRed;
            pictureBox3.Location = new Point(3, 78);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(21, 16);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.YellowGreen;
            pictureBox2.Location = new Point(3, 51);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(21, 16);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.SpringGreen;
            pictureBox1.Location = new Point(3, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(21, 16);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 102);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 3;
            label4.Text = "Zastępstwo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 78);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 2;
            label3.Text = "Dzień roboczy";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 51);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 1;
            label2.Text = "Zwolnienie";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 25);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 0;
            label1.Text = "Dzień wolny";
            // 
            // WorkScheduleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "WorkScheduleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Grafik";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)WorkSchedule_DGV).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView WorkSchedule_DGV;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Shift;
        private DataGridViewTextBoxColumn Dayoff;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
    }
}