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
            WorkSchedule_DGV = new DataGridView();
            Date = new DataGridViewTextBoxColumn();
            From = new DataGridViewTextBoxColumn();
            To = new DataGridViewTextBoxColumn();
            Dayoff = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)WorkSchedule_DGV).BeginInit();
            SuspendLayout();
            // 
            // WorkSchedule_DGV
            // 
            WorkSchedule_DGV.AllowUserToAddRows = false;
            WorkSchedule_DGV.AllowUserToDeleteRows = false;
            WorkSchedule_DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            WorkSchedule_DGV.Columns.AddRange(new DataGridViewColumn[] { Date, From, To, Dayoff });
            WorkSchedule_DGV.Dock = DockStyle.Fill;
            WorkSchedule_DGV.Location = new Point(0, 0);
            WorkSchedule_DGV.Name = "WorkSchedule_DGV";
            WorkSchedule_DGV.ReadOnly = true;
            WorkSchedule_DGV.RowTemplate.Height = 25;
            WorkSchedule_DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            WorkSchedule_DGV.Size = new Size(800, 450);
            WorkSchedule_DGV.TabIndex = 0;
            // 
            // Date
            // 
            Date.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Date.HeaderText = "Data";
            Date.Name = "Date";
            Date.ReadOnly = true;
            // 
            // From
            // 
            From.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            From.HeaderText = "Od";
            From.Name = "From";
            From.ReadOnly = true;
            // 
            // To
            // 
            To.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            To.HeaderText = "Do";
            To.Name = "To";
            To.ReadOnly = true;
            // 
            // Dayoff
            // 
            Dayoff.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Dayoff.HeaderText = "Zwolnienie";
            Dayoff.Name = "Dayoff";
            Dayoff.ReadOnly = true;
            // 
            // WorkScheduleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(WorkSchedule_DGV);
            Name = "WorkScheduleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Grafik";
            ((System.ComponentModel.ISupportInitialize)WorkSchedule_DGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView WorkSchedule_DGV;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn From;
        private DataGridViewTextBoxColumn To;
        private DataGridViewTextBoxColumn Dayoff;
    }
}