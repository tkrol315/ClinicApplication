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
            contextMenuStrip1 = new ContextMenuStrip(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            ManagerTabControl = new TabControl();
            RequestManager_TP = new TabPage();
            WorkerScheduleManager_BTN = new Button();
            RejectRequestManager_BTN = new Button();
            AcceptRequestManager_BTN = new Button();
            RequestManager_DGV = new DataGridView();
            RequestIdManager = new DataGridViewTextBoxColumn();
            From = new DataGridViewTextBoxColumn();
            To = new DataGridViewTextBoxColumn();
            ManagerHistory_TP = new TabPage();
            RequestHistory_DGV = new DataGridView();
            WorkerName = new DataGridViewTextBoxColumn();
            WorkerSurname = new DataGridViewTextBoxColumn();
            FromDateHistory = new DataGridViewTextBoxColumn();
            ToDateHistory = new DataGridViewTextBoxColumn();
            ManagerSubstitutions_TP = new TabPage();
            Substitutions_DGV = new DataGridView();
            WorkerNameSubstitutions = new DataGridViewTextBoxColumn();
            WorkerSurnameSubstitutions = new DataGridViewTextBoxColumn();
            FromDateSubstitutions = new DataGridViewTextBoxColumn();
            ToDateSubstitutions = new DataGridViewTextBoxColumn();
            menuStrip1 = new MenuStrip();
            ManagerLogout_BTN = new ToolStripMenuItem();
            tableLayoutPanel1.SuspendLayout();
            ManagerTabControl.SuspendLayout();
            RequestManager_TP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RequestManager_DGV).BeginInit();
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
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
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
            // 
            // RequestManager_TP
            // 
            RequestManager_TP.Controls.Add(WorkerScheduleManager_BTN);
            RequestManager_TP.Controls.Add(RejectRequestManager_BTN);
            RequestManager_TP.Controls.Add(AcceptRequestManager_BTN);
            RequestManager_TP.Controls.Add(RequestManager_DGV);
            RequestManager_TP.Location = new Point(4, 24);
            RequestManager_TP.Name = "RequestManager_TP";
            RequestManager_TP.Padding = new Padding(3);
            RequestManager_TP.Size = new Size(786, 391);
            RequestManager_TP.TabIndex = 0;
            RequestManager_TP.Text = "Wnisoki";
            RequestManager_TP.UseVisualStyleBackColor = true;
            // 
            // WorkerScheduleManager_BTN
            // 
            WorkerScheduleManager_BTN.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            WorkerScheduleManager_BTN.Location = new Point(2448, 1265);
            WorkerScheduleManager_BTN.Name = "WorkerScheduleManager_BTN";
            WorkerScheduleManager_BTN.Size = new Size(91, 39);
            WorkerScheduleManager_BTN.TabIndex = 3;
            WorkerScheduleManager_BTN.Text = "Grafik";
            WorkerScheduleManager_BTN.UseVisualStyleBackColor = true;
            // 
            // RejectRequestManager_BTN
            // 
            RejectRequestManager_BTN.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RejectRequestManager_BTN.Location = new Point(2351, 1265);
            RejectRequestManager_BTN.Name = "RejectRequestManager_BTN";
            RejectRequestManager_BTN.Size = new Size(91, 39);
            RejectRequestManager_BTN.TabIndex = 2;
            RejectRequestManager_BTN.Text = "Odrzuć";
            RejectRequestManager_BTN.UseVisualStyleBackColor = true;
            // 
            // AcceptRequestManager_BTN
            // 
            AcceptRequestManager_BTN.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AcceptRequestManager_BTN.Location = new Point(2254, 1265);
            AcceptRequestManager_BTN.Name = "AcceptRequestManager_BTN";
            AcceptRequestManager_BTN.Size = new Size(91, 39);
            AcceptRequestManager_BTN.TabIndex = 1;
            AcceptRequestManager_BTN.Text = "Zatwierdź";
            AcceptRequestManager_BTN.UseVisualStyleBackColor = true;
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
            RequestManager_DGV.Size = new Size(780, 385);
            RequestManager_DGV.TabIndex = 0;
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
            RequestHistory_DGV.Columns.AddRange(new DataGridViewColumn[] { WorkerName, WorkerSurname, FromDateHistory, ToDateHistory });
            RequestHistory_DGV.Dock = DockStyle.Fill;
            RequestHistory_DGV.Location = new Point(3, 3);
            RequestHistory_DGV.Name = "RequestHistory_DGV";
            RequestHistory_DGV.ReadOnly = true;
            RequestHistory_DGV.RowTemplate.Height = 25;
            RequestHistory_DGV.Size = new Size(780, 385);
            RequestHistory_DGV.TabIndex = 0;
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
            Substitutions_DGV.Columns.AddRange(new DataGridViewColumn[] { WorkerNameSubstitutions, WorkerSurnameSubstitutions, FromDateSubstitutions, ToDateSubstitutions });
            Substitutions_DGV.Dock = DockStyle.Fill;
            Substitutions_DGV.Location = new Point(3, 3);
            Substitutions_DGV.Name = "Substitutions_DGV";
            Substitutions_DGV.ReadOnly = true;
            Substitutions_DGV.RowTemplate.Height = 25;
            Substitutions_DGV.Size = new Size(780, 385);
            Substitutions_DGV.TabIndex = 1;
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
            // FromDateSubstitutions
            // 
            FromDateSubstitutions.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FromDateSubstitutions.FillWeight = 15F;
            FromDateSubstitutions.HeaderText = "Od";
            FromDateSubstitutions.Name = "FromDateSubstitutions";
            FromDateSubstitutions.ReadOnly = true;
            // 
            // ToDateSubstitutions
            // 
            ToDateSubstitutions.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ToDateSubstitutions.FillWeight = 15F;
            ToDateSubstitutions.HeaderText = "Do";
            ToDateSubstitutions.Name = "ToDateSubstitutions";
            ToDateSubstitutions.ReadOnly = true;
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
            ((System.ComponentModel.ISupportInitialize)RequestManager_DGV).EndInit();
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
        private ContextMenuStrip contextMenuStrip1;
        private TableLayoutPanel tableLayoutPanel1;
        private TabControl ManagerTabControl;
        private TabPage RequestManager_TP;
        private Button WorkerScheduleManager_BTN;
        private Button RejectRequestManager_BTN;
        private Button AcceptRequestManager_BTN;
        private DataGridView RequestManager_DGV;
        private DataGridViewTextBoxColumn RequestIdManager;
        private DataGridViewTextBoxColumn From;
        private DataGridViewTextBoxColumn To;
        private TabPage ManagerHistory_TP;
        private DataGridView RequestHistory_DGV;
        private DataGridViewTextBoxColumn WorkerName;
        private DataGridViewTextBoxColumn WorkerSurname;
        private DataGridViewTextBoxColumn FromDateHistory;
        private DataGridViewTextBoxColumn ToDateHistory;
        private TabPage ManagerSubstitutions_TP;
        private DataGridView Substitutions_DGV;
        private DataGridViewTextBoxColumn WorkerNameSubstitutions;
        private DataGridViewTextBoxColumn WorkerSurnameSubstitutions;
        private DataGridViewTextBoxColumn FromDateSubstitutions;
        private DataGridViewTextBoxColumn ToDateSubstitutions;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ManagerLogout_BTN;
    }
}