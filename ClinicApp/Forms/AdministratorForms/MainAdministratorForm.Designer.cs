namespace ClinicApp.Forms.AdministratorForms
{
    partial class MainAdministratorForm
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
            AdministratorPanel_DGV = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            WorkerName = new DataGridViewTextBoxColumn();
            WorkerSurname = new DataGridViewTextBoxColumn();
            DaysoffAmount = new DataGridViewTextBoxColumn();
            WorkerRole = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)AdministratorPanel_DGV).BeginInit();
            SuspendLayout();
            // 
            // AdministratorPanel_DGV
            // 
            AdministratorPanel_DGV.AllowUserToAddRows = false;
            AdministratorPanel_DGV.AllowUserToDeleteRows = false;
            AdministratorPanel_DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AdministratorPanel_DGV.Columns.AddRange(new DataGridViewColumn[] { Id, WorkerName, WorkerSurname, DaysoffAmount, WorkerRole });
            AdministratorPanel_DGV.Dock = DockStyle.Fill;
            AdministratorPanel_DGV.Location = new Point(0, 0);
            AdministratorPanel_DGV.Name = "AdministratorPanel_DGV";
            AdministratorPanel_DGV.ReadOnly = true;
            AdministratorPanel_DGV.RowTemplate.Height = 25;
            AdministratorPanel_DGV.Size = new Size(800, 450);
            AdministratorPanel_DGV.TabIndex = 0;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Id.FillWeight = 30F;
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // WorkerName
            // 
            WorkerName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            WorkerName.HeaderText = "Imię";
            WorkerName.Name = "WorkerName";
            WorkerName.ReadOnly = true;
            // 
            // WorkerSurname
            // 
            WorkerSurname.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            WorkerSurname.HeaderText = "Nazwisko";
            WorkerSurname.Name = "WorkerSurname";
            WorkerSurname.ReadOnly = true;
            // 
            // DaysoffAmount
            // 
            DaysoffAmount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DaysoffAmount.HeaderText = "Ilość urlopu";
            DaysoffAmount.Name = "DaysoffAmount";
            DaysoffAmount.ReadOnly = true;
            // 
            // WorkerRole
            // 
            WorkerRole.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            WorkerRole.HeaderText = "Stanowisko";
            WorkerRole.Name = "WorkerRole";
            WorkerRole.ReadOnly = true;
            // 
            // MainAdministratorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AdministratorPanel_DGV);
            Name = "MainAdministratorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Panel administratora";
            ((System.ComponentModel.ISupportInitialize)AdministratorPanel_DGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView AdministratorPanel_DGV;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn WorkerName;
        private DataGridViewTextBoxColumn WorkerSurname;
        private DataGridViewTextBoxColumn DaysoffAmount;
        private DataGridViewTextBoxColumn WorkerRole;
    }
}