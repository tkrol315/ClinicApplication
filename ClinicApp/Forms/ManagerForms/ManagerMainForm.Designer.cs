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
            ManagerTabControl = new TabControl();
            RequestManager_TP = new TabPage();
            ManagerHistory_TP = new TabPage();
            ManagerSubstitutions_TP = new TabPage();
            RequestManager_DGV = new DataGridView();
            From = new DataGridViewTextBoxColumn();
            To = new DataGridViewTextBoxColumn();
            AcceptRequestManager_BTN = new Button();
            RejectRequestManager_BTN = new Button();
            WorkerScheduleManager_BTN = new Button();
            RequestHistory_DGV = new DataGridView();
            WorkerName = new DataGridViewTextBoxColumn();
            WorkerSurname = new DataGridViewTextBoxColumn();
            FromDateHistory = new DataGridViewTextBoxColumn();
            ToDateHistory = new DataGridViewTextBoxColumn();
            Substitutions_DGV = new DataGridView();
            WorkerNameSubstitutions = new DataGridViewTextBoxColumn();
            WorkerSurnameSubstitutions = new DataGridViewTextBoxColumn();
            FromDateSubstitutions = new DataGridViewTextBoxColumn();
            ToDateSubstitutions = new DataGridViewTextBoxColumn();
            ManagerTabControl.SuspendLayout();
            RequestManager_TP.SuspendLayout();
            ManagerHistory_TP.SuspendLayout();
            ManagerSubstitutions_TP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RequestManager_DGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RequestHistory_DGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Substitutions_DGV).BeginInit();
            SuspendLayout();
            // 
            // ManagerTabControl
            // 
            ManagerTabControl.Controls.Add(RequestManager_TP);
            ManagerTabControl.Controls.Add(ManagerHistory_TP);
            ManagerTabControl.Controls.Add(ManagerSubstitutions_TP);
            ManagerTabControl.Dock = DockStyle.Fill;
            ManagerTabControl.Location = new Point(0, 0);
            ManagerTabControl.Name = "ManagerTabControl";
            ManagerTabControl.SelectedIndex = 0;
            ManagerTabControl.Size = new Size(800, 450);
            ManagerTabControl.TabIndex = 0;
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
            RequestManager_TP.Size = new Size(792, 422);
            RequestManager_TP.TabIndex = 0;
            RequestManager_TP.Text = "Wnisoki";
            RequestManager_TP.UseVisualStyleBackColor = true;
            // 
            // ManagerHistory_TP
            // 
            ManagerHistory_TP.Controls.Add(RequestHistory_DGV);
            ManagerHistory_TP.Location = new Point(4, 24);
            ManagerHistory_TP.Name = "ManagerHistory_TP";
            ManagerHistory_TP.Padding = new Padding(3);
            ManagerHistory_TP.Size = new Size(792, 422);
            ManagerHistory_TP.TabIndex = 1;
            ManagerHistory_TP.Text = "Historia";
            ManagerHistory_TP.UseVisualStyleBackColor = true;
            // 
            // ManagerSubstitutions_TP
            // 
            ManagerSubstitutions_TP.Controls.Add(Substitutions_DGV);
            ManagerSubstitutions_TP.Location = new Point(4, 24);
            ManagerSubstitutions_TP.Name = "ManagerSubstitutions_TP";
            ManagerSubstitutions_TP.Padding = new Padding(3);
            ManagerSubstitutions_TP.Size = new Size(792, 422);
            ManagerSubstitutions_TP.TabIndex = 2;
            ManagerSubstitutions_TP.Text = "Zastepstwa";
            ManagerSubstitutions_TP.UseVisualStyleBackColor = true;
            // 
            // RequestManager_DGV
            // 
            RequestManager_DGV.AllowUserToAddRows = false;
            RequestManager_DGV.AllowUserToDeleteRows = false;
            RequestManager_DGV.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            RequestManager_DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RequestManager_DGV.Columns.AddRange(new DataGridViewColumn[] { From, To });
            RequestManager_DGV.Location = new Point(10, 15);
            RequestManager_DGV.Name = "RequestManager_DGV";
            RequestManager_DGV.ReadOnly = true;
            RequestManager_DGV.RowTemplate.Height = 25;
            RequestManager_DGV.Size = new Size(774, 354);
            RequestManager_DGV.TabIndex = 0;
            // 
            // From
            // 
            From.HeaderText = "Od";
            From.Name = "From";
            From.ReadOnly = true;
            // 
            // To
            // 
            To.HeaderText = "Do";
            To.Name = "To";
            To.ReadOnly = true;
            // 
            // AcceptRequestManager_BTN
            // 
            AcceptRequestManager_BTN.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AcceptRequestManager_BTN.Location = new Point(499, 375);
            AcceptRequestManager_BTN.Name = "AcceptRequestManager_BTN";
            AcceptRequestManager_BTN.Size = new Size(91, 39);
            AcceptRequestManager_BTN.TabIndex = 1;
            AcceptRequestManager_BTN.Text = "Zatwierdź";
            AcceptRequestManager_BTN.UseVisualStyleBackColor = true;
            // 
            // RejectRequestManager_BTN
            // 
            RejectRequestManager_BTN.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RejectRequestManager_BTN.Location = new Point(596, 375);
            RejectRequestManager_BTN.Name = "RejectRequestManager_BTN";
            RejectRequestManager_BTN.Size = new Size(91, 39);
            RejectRequestManager_BTN.TabIndex = 2;
            RejectRequestManager_BTN.Text = "Odrzuć";
            RejectRequestManager_BTN.UseVisualStyleBackColor = true;
            // 
            // WorkerScheduleManager_BTN
            // 
            WorkerScheduleManager_BTN.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            WorkerScheduleManager_BTN.Location = new Point(693, 375);
            WorkerScheduleManager_BTN.Name = "WorkerScheduleManager_BTN";
            WorkerScheduleManager_BTN.Size = new Size(91, 39);
            WorkerScheduleManager_BTN.TabIndex = 3;
            WorkerScheduleManager_BTN.Text = "Grafik";
            WorkerScheduleManager_BTN.UseVisualStyleBackColor = true;
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
            RequestHistory_DGV.Size = new Size(786, 416);
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
            Substitutions_DGV.Size = new Size(786, 416);
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
            // ManagerMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ManagerTabControl);
            Name = "ManagerMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Panel kierownika";
            ManagerTabControl.ResumeLayout(false);
            RequestManager_TP.ResumeLayout(false);
            ManagerHistory_TP.ResumeLayout(false);
            ManagerSubstitutions_TP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)RequestManager_DGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)RequestHistory_DGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)Substitutions_DGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl ManagerTabControl;
        private TabPage RequestManager_TP;
        private TabPage ManagerHistory_TP;
        private TabPage ManagerSubstitutions_TP;
        private Button RejectRequestManager_BTN;
        private Button AcceptRequestManager_BTN;
        private DataGridView RequestManager_DGV;
        private DataGridViewTextBoxColumn From;
        private DataGridViewTextBoxColumn To;
        private Button WorkerScheduleManager_BTN;
        private DataGridView RequestHistory_DGV;
        private DataGridViewTextBoxColumn WorkerName;
        private DataGridViewTextBoxColumn WorkerSurname;
        private DataGridViewTextBoxColumn FromDateHistory;
        private DataGridViewTextBoxColumn ToDateHistory;
        private DataGridView Substitutions_DGV;
        private DataGridViewTextBoxColumn WorkerNameSubstitutions;
        private DataGridViewTextBoxColumn WorkerSurnameSubstitutions;
        private DataGridViewTextBoxColumn FromDateSubstitutions;
        private DataGridViewTextBoxColumn ToDateSubstitutions;
    }
}