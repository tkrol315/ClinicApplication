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
            tableLayoutPanel1 = new TableLayoutPanel();
            AdministratorPanel_DGV = new DataGridView();
            menuStrip1 = new MenuStrip();
            LogoutAdmin_BTN = new ToolStripMenuItem();
            Id = new DataGridViewTextBoxColumn();
            WorkerLogin = new DataGridViewTextBoxColumn();
            WorkerName = new DataGridViewTextBoxColumn();
            WorkerSurname = new DataGridViewTextBoxColumn();
            DaysoffAmount = new DataGridViewTextBoxColumn();
            WorkerRole = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AdministratorPanel_DGV).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(AdministratorPanel_DGV, 0, 1);
            tableLayoutPanel1.Controls.Add(menuStrip1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // AdministratorPanel_DGV
            // 
            AdministratorPanel_DGV.AllowUserToAddRows = false;
            AdministratorPanel_DGV.AllowUserToDeleteRows = false;
            AdministratorPanel_DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AdministratorPanel_DGV.Columns.AddRange(new DataGridViewColumn[] { Id, WorkerLogin, WorkerName, WorkerSurname, DaysoffAmount, WorkerRole });
            AdministratorPanel_DGV.Dock = DockStyle.Fill;
            AdministratorPanel_DGV.Location = new Point(3, 28);
            AdministratorPanel_DGV.MultiSelect = false;
            AdministratorPanel_DGV.Name = "AdministratorPanel_DGV";
            AdministratorPanel_DGV.ReadOnly = true;
            AdministratorPanel_DGV.RowTemplate.Height = 25;
            AdministratorPanel_DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AdministratorPanel_DGV.Size = new Size(794, 419);
            AdministratorPanel_DGV.TabIndex = 1;
            AdministratorPanel_DGV.CellDoubleClick += AdministratorPanel_DGV_CellDoubleClick;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { LogoutAdmin_BTN });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // LogoutAdmin_BTN
            // 
            LogoutAdmin_BTN.Name = "LogoutAdmin_BTN";
            LogoutAdmin_BTN.Size = new Size(63, 20);
            LogoutAdmin_BTN.Text = "Wyloguj";
            LogoutAdmin_BTN.Click += AdminLogout_BTN_Click;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Id.FillWeight = 5F;
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Resizable = DataGridViewTriState.False;
            // 
            // WorkerLogin
            // 
            WorkerLogin.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            WorkerLogin.FillWeight = 15F;
            WorkerLogin.HeaderText = "Login";
            WorkerLogin.Name = "WorkerLogin";
            WorkerLogin.ReadOnly = true;
            // 
            // WorkerName
            // 
            WorkerName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            WorkerName.FillWeight = 25F;
            WorkerName.HeaderText = "Imię";
            WorkerName.Name = "WorkerName";
            WorkerName.ReadOnly = true;
            WorkerName.Resizable = DataGridViewTriState.False;
            // 
            // WorkerSurname
            // 
            WorkerSurname.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            WorkerSurname.FillWeight = 25F;
            WorkerSurname.HeaderText = "Nazwisko";
            WorkerSurname.Name = "WorkerSurname";
            WorkerSurname.ReadOnly = true;
            WorkerSurname.Resizable = DataGridViewTriState.False;
            // 
            // DaysoffAmount
            // 
            DaysoffAmount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DaysoffAmount.FillWeight = 20F;
            DaysoffAmount.HeaderText = "Ilość urlopu";
            DaysoffAmount.Name = "DaysoffAmount";
            DaysoffAmount.ReadOnly = true;
            DaysoffAmount.Resizable = DataGridViewTriState.False;
            // 
            // WorkerRole
            // 
            WorkerRole.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            WorkerRole.FillWeight = 20F;
            WorkerRole.HeaderText = "Stanowisko";
            WorkerRole.Name = "WorkerRole";
            WorkerRole.ReadOnly = true;
            WorkerRole.Resizable = DataGridViewTriState.False;
            // 
            // MainAdministratorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            MainMenuStrip = menuStrip1;
            Name = "MainAdministratorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Panel administratora";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AdministratorPanel_DGV).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView AdministratorPanel_DGV;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem LogoutAdmin_BTN;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn WorkerLogin;
        private DataGridViewTextBoxColumn WorkerName;
        private DataGridViewTextBoxColumn WorkerSurname;
        private DataGridViewTextBoxColumn DaysoffAmount;
        private DataGridViewTextBoxColumn WorkerRole;
    }
}