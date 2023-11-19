namespace ClinicApp.Forms.ManagerForms
{
    partial class ManagerMainForm
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
            components = new System.ComponentModel.Container();
            Logout_BTN = new ContextMenuStrip(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            ManagerTabControl = new TabControl();
            RequestManager_TP = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            RequestManager_DGV = new DataGridView();
            RequestIdManager = new DataGridViewTextBoxColumn();
            From = new DataGridViewTextBoxColumn();
            To = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            WorkerScheduleManager_BTN = new Button();
            AcceptRequestManager_BTN = new Button();
            C = new Button();
            ManagerHistory_TP = new TabPage();
            RequestHistory_DGV = new DataGridView();
            ManagerSubstitutions_TP = new TabPage();
            Substitutions_DGV = new DataGridView();
            SubstitutionId = new DataGridViewTextBoxColumn();
            SubstitutionCol = new DataGridViewTextBoxColumn();
            DateSubstitution = new DataGridViewTextBoxColumn();
            WorkerNameSubstitutions = new DataGridViewTextBoxColumn();
            WorkerSurnameSubstitutions = new DataGridViewTextBoxColumn();
            menuStrip1 = new MenuStrip();
            ManagerLogout_BTN = new ToolStripMenuItem();
            WorkerName = new DataGridViewTextBoxColumn();
            WorkerSurname = new DataGridViewTextBoxColumn();
            FromDateHistory = new DataGridViewTextBoxColumn();
            ToDateHistory = new DataGridViewTextBoxColumn();
            DayOffType = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            ManagerTabControl.SuspendLayout();
            RequestManager_TP.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RequestManager_DGV).BeginInit();
            panel2.SuspendLayout();
            ManagerHistory_TP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RequestHistory_DGV).BeginInit();
            ManagerSubstitutions_TP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Substitutions_DGV).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Logout_BTN
            // 
            Logout_BTN.Name = "Logout_BTN";
            Logout_BTN.Size = new Size(61, 4);
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(ManagerTabControl, 0, 1);
            tableLayoutPanel1.Controls.Add(menuStrip1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // ManagerTabControl
            // 
            ManagerTabControl.Controls.Add(RequestManager_TP);
            ManagerTabControl.Controls.Add(ManagerHistory_TP);
            ManagerTabControl.Controls.Add(ManagerSubstitutions_TP);
            ManagerTabControl.Dock = DockStyle.Fill;
            ManagerTabControl.Location = new Point(3, 28);
            ManagerTabControl.Name = "ManagerTabControl";
            ManagerTabControl.SelectedIndex = 0;
            ManagerTabControl.Size = new Size(794, 419);
            ManagerTabControl.TabIndex = 4;
            ManagerTabControl.SelectedIndexChanged += ManagerTabControl_SelectedIndexChanged;
            // 
            // RequestManager_TP
            // 
            RequestManager_TP.Controls.Add(tableLayoutPanel2);
            RequestManager_TP.Location = new Point(4, 24);
            RequestManager_TP.Name = "RequestManager_TP";
            RequestManager_TP.Padding = new Padding(3);
            RequestManager_TP.Size = new Size(786, 391);
            RequestManager_TP.TabIndex = 0;
            RequestManager_TP.Text = "Wnisoki";
            RequestManager_TP.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(RequestManager_DGV, 0, 0);
            tableLayoutPanel2.Controls.Add(panel2, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel2.Size = new Size(780, 385);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // RequestManager_DGV
            // 
            RequestManager_DGV.AllowUserToAddRows = false;
            RequestManager_DGV.AllowUserToDeleteRows = false;
            RequestManager_DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RequestManager_DGV.Columns.AddRange(new DataGridViewColumn[] { RequestIdManager, From, To });
            RequestManager_DGV.Dock = DockStyle.Fill;
            RequestManager_DGV.Location = new Point(3, 3);
            RequestManager_DGV.Name = "RequestManager_DGV";
            RequestManager_DGV.ReadOnly = true;
            RequestManager_DGV.RowTemplate.Height = 25;
            RequestManager_DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            RequestManager_DGV.Size = new Size(774, 309);
            RequestManager_DGV.TabIndex = 1;
            // 
            // RequestIdManager
            // 
            RequestIdManager.HeaderText = "Column1";
            RequestIdManager.Name = "RequestIdManager";
            RequestIdManager.ReadOnly = true;
            RequestIdManager.Visible = false;
            // 
            // From
            // 
            From.HeaderText = "Od";
            From.Name = "From";
            From.ReadOnly = true;
            From.Resizable = DataGridViewTriState.False;
            // 
            // To
            // 
            To.HeaderText = "Do";
            To.Name = "To";
            To.ReadOnly = true;
            To.Resizable = DataGridViewTriState.False;
            // 
            // panel2
            // 
            panel2.Controls.Add(WorkerScheduleManager_BTN);
            panel2.Controls.Add(AcceptRequestManager_BTN);
            panel2.Controls.Add(C);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 318);
            panel2.Name = "panel2";
            panel2.Size = new Size(774, 64);
            panel2.TabIndex = 2;
            // 
            // WorkerScheduleManager_BTN
            // 
            WorkerScheduleManager_BTN.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            WorkerScheduleManager_BTN.Location = new Point(667, 12);
            WorkerScheduleManager_BTN.Name = "WorkerScheduleManager_BTN";
            WorkerScheduleManager_BTN.Size = new Size(91, 39);
            WorkerScheduleManager_BTN.TabIndex = 3;
            WorkerScheduleManager_BTN.Text = "Grafik";
            WorkerScheduleManager_BTN.UseVisualStyleBackColor = true;
            WorkerScheduleManager_BTN.Click += ShowSchedule_BTN_Click;
            // 
            // AcceptRequestManager_BTN
            // 
            AcceptRequestManager_BTN.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AcceptRequestManager_BTN.Location = new Point(473, 12);
            AcceptRequestManager_BTN.Name = "AcceptRequestManager_BTN";
            AcceptRequestManager_BTN.Size = new Size(91, 39);
            AcceptRequestManager_BTN.TabIndex = 1;
            AcceptRequestManager_BTN.Text = "Zatwierdź";
            AcceptRequestManager_BTN.UseVisualStyleBackColor = true;
            AcceptRequestManager_BTN.Click += AcceptRejectRequestManager_BTN_Click;
            // 
            // C
            // 
            C.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            C.Location = new Point(570, 12);
            C.Name = "C";
            C.Size = new Size(91, 39);
            C.TabIndex = 2;
            C.Text = "Odrzuć";
            C.UseVisualStyleBackColor = true;
            C.Click += AcceptRejectRequestManager_BTN_Click;
            // 
            // ManagerHistory_TP
            // 
            ManagerHistory_TP.Controls.Add(RequestHistory_DGV);
            ManagerHistory_TP.Location = new Point(4, 24);
            ManagerHistory_TP.Name = "ManagerHistory_TP";
            ManagerHistory_TP.Padding = new Padding(3);
            ManagerHistory_TP.Size = new Size(786, 391);
            ManagerHistory_TP.TabIndex = 1;
            ManagerHistory_TP.Text = "Historia";
            ManagerHistory_TP.UseVisualStyleBackColor = true;
            // 
            // RequestHistory_DGV
            // 
            RequestHistory_DGV.AllowUserToAddRows = false;
            RequestHistory_DGV.AllowUserToDeleteRows = false;
            RequestHistory_DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RequestHistory_DGV.Columns.AddRange(new DataGridViewColumn[] { WorkerName, WorkerSurname, FromDateHistory, ToDateHistory, DayOffType });
            RequestHistory_DGV.Dock = DockStyle.Fill;
            RequestHistory_DGV.Location = new Point(3, 3);
            RequestHistory_DGV.Name = "RequestHistory_DGV";
            RequestHistory_DGV.ReadOnly = true;
            RequestHistory_DGV.RowTemplate.Height = 25;
            RequestHistory_DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            RequestHistory_DGV.Size = new Size(780, 385);
            RequestHistory_DGV.TabIndex = 0;
            // 
            // ManagerSubstitutions_TP
            // 
            ManagerSubstitutions_TP.Controls.Add(Substitutions_DGV);
            ManagerSubstitutions_TP.Location = new Point(4, 24);
            ManagerSubstitutions_TP.Name = "ManagerSubstitutions_TP";
            ManagerSubstitutions_TP.Padding = new Padding(3);
            ManagerSubstitutions_TP.Size = new Size(786, 391);
            ManagerSubstitutions_TP.TabIndex = 2;
            ManagerSubstitutions_TP.Text = "Zastepstwa";
            ManagerSubstitutions_TP.UseVisualStyleBackColor = true;
            // 
            // Substitutions_DGV
            // 
            Substitutions_DGV.AllowUserToAddRows = false;
            Substitutions_DGV.AllowUserToDeleteRows = false;
            Substitutions_DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Substitutions_DGV.Columns.AddRange(new DataGridViewColumn[] { SubstitutionId, SubstitutionCol, DateSubstitution, WorkerNameSubstitutions, WorkerSurnameSubstitutions });
            Substitutions_DGV.Dock = DockStyle.Fill;
            Substitutions_DGV.Location = new Point(3, 3);
            Substitutions_DGV.Name = "Substitutions_DGV";
            Substitutions_DGV.ReadOnly = true;
            Substitutions_DGV.RowTemplate.Height = 25;
            Substitutions_DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Substitutions_DGV.Size = new Size(780, 385);
            Substitutions_DGV.TabIndex = 1;
            Substitutions_DGV.CellDoubleClick += Substitutions_DGV_CellDoubleClick;
            // 
            // SubstitutionId
            // 
            SubstitutionId.HeaderText = "Id";
            SubstitutionId.Name = "SubstitutionId";
            SubstitutionId.ReadOnly = true;
            SubstitutionId.Visible = false;
            // 
            // SubstitutionCol
            // 
            SubstitutionCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SubstitutionCol.FillWeight = 15F;
            SubstitutionCol.HeaderText = "Wypełnione";
            SubstitutionCol.Name = "SubstitutionCol";
            SubstitutionCol.ReadOnly = true;
            // 
            // DateSubstitution
            // 
            DateSubstitution.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DateSubstitution.FillWeight = 15F;
            DateSubstitution.HeaderText = "Data";
            DateSubstitution.Name = "DateSubstitution";
            DateSubstitution.ReadOnly = true;
            // 
            // WorkerNameSubstitutions
            // 
            WorkerNameSubstitutions.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            WorkerNameSubstitutions.FillWeight = 35F;
            WorkerNameSubstitutions.HeaderText = "Imię";
            WorkerNameSubstitutions.Name = "WorkerNameSubstitutions";
            WorkerNameSubstitutions.ReadOnly = true;
            // 
            // WorkerSurnameSubstitutions
            // 
            WorkerSurnameSubstitutions.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            WorkerSurnameSubstitutions.FillWeight = 35F;
            WorkerSurnameSubstitutions.HeaderText = "Nazwisko";
            WorkerSurnameSubstitutions.Name = "WorkerSurnameSubstitutions";
            WorkerSurnameSubstitutions.ReadOnly = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ManagerLogout_BTN });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ManagerLogout_BTN
            // 
            ManagerLogout_BTN.Name = "ManagerLogout_BTN";
            ManagerLogout_BTN.Size = new Size(63, 20);
            ManagerLogout_BTN.Text = "Wyloguj";
            ManagerLogout_BTN.Click += ManagerLogout_BTN_Click;
            // 
            // WorkerName
            // 
            WorkerName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            WorkerName.FillWeight = 35F;
            WorkerName.HeaderText = "Imię";
            WorkerName.Name = "WorkerName";
            WorkerName.ReadOnly = true;
            // 
            // WorkerSurname
            // 
            WorkerSurname.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            WorkerSurname.FillWeight = 35F;
            WorkerSurname.HeaderText = "Nazwisko";
            WorkerSurname.Name = "WorkerSurname";
            WorkerSurname.ReadOnly = true;
            // 
            // FromDateHistory
            // 
            FromDateHistory.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FromDateHistory.FillWeight = 15F;
            FromDateHistory.HeaderText = "Od";
            FromDateHistory.Name = "FromDateHistory";
            FromDateHistory.ReadOnly = true;
            // 
            // ToDateHistory
            // 
            ToDateHistory.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ToDateHistory.FillWeight = 15F;
            ToDateHistory.HeaderText = "Do";
            ToDateHistory.Name = "ToDateHistory";
            ToDateHistory.ReadOnly = true;
            // 
            // DayOffType
            // 
            DayOffType.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DayOffType.FillWeight = 25F;
            DayOffType.HeaderText = "Typ wniosku";
            DayOffType.Name = "DayOffType";
            DayOffType.ReadOnly = true;
            // 
            // ManagerMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            MainMenuStrip = menuStrip1;
            Name = "ManagerMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Panel kierownika";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ManagerTabControl.ResumeLayout(false);
            RequestManager_TP.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)RequestManager_DGV).EndInit();
            panel2.ResumeLayout(false);
            ManagerHistory_TP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)RequestHistory_DGV).EndInit();
            ManagerSubstitutions_TP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Substitutions_DGV).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ContextMenuStrip Logout_BTN;
        private TableLayoutPanel tableLayoutPanel1;
        private TabControl ManagerTabControl;
        private TabPage RequestManager_TP;
        private Button WorkerScheduleManager_BTN;
        private Button C;
        private Button AcceptRequestManager_BTN;
        private TabPage ManagerHistory_TP;
        private DataGridView RequestHistory_DGV;
        private TabPage ManagerSubstitutions_TP;
        private DataGridView Substitutions_DGV;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ManagerLogout_BTN;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView RequestManager_DGV;
        private DataGridViewTextBoxColumn RequestIdManager;
        private DataGridViewTextBoxColumn From;
        private DataGridViewTextBoxColumn To;
        private Panel panel2;
        private DataGridViewTextBoxColumn SubstitutionId;
        private DataGridViewTextBoxColumn SubstitutionCol;
        private DataGridViewTextBoxColumn DateSubstitution;
        private DataGridViewTextBoxColumn WorkerNameSubstitutions;
        private DataGridViewTextBoxColumn WorkerSurnameSubstitutions;
        private DataGridViewTextBoxColumn WorkerName;
        private DataGridViewTextBoxColumn WorkerSurname;
        private DataGridViewTextBoxColumn FromDateHistory;
        private DataGridViewTextBoxColumn ToDateHistory;
        private DataGridViewTextBoxColumn DayOffType;
    }
}