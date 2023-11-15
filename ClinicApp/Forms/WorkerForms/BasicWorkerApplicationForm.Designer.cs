namespace ClinicApp.Forms
{
    partial class BasicWorkerApplicationForm
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
            BasicWorkerTabControl = new TabControl();
            BasicWorkerSendRequest_TP = new TabPage();
            SendRequest_BTN = new Button();
            label2 = new Label();
            BasicWorkerDayoffType_CB = new ComboBox();
            label1 = new Label();
            RequestContent_RTB = new RichTextBox();
            BasicWorkerNotifications_TP = new TabPage();
            WorkerNotificatin_DGV = new DataGridView();
            RequestNumber = new DataGridViewTextBoxColumn();
            DayoffType = new DataGridViewTextBoxColumn();
            RequestStatus = new DataGridViewTextBoxColumn();
            BasicWorkerTabControl.SuspendLayout();
            BasicWorkerSendRequest_TP.SuspendLayout();
            BasicWorkerNotifications_TP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)WorkerNotificatin_DGV).BeginInit();
            SuspendLayout();
            // 
            // BasicWorkerTabControl
            // 
            BasicWorkerTabControl.Controls.Add(BasicWorkerSendRequest_TP);
            BasicWorkerTabControl.Controls.Add(BasicWorkerNotifications_TP);
            BasicWorkerTabControl.Dock = DockStyle.Fill;
            BasicWorkerTabControl.Location = new Point(0, 0);
            BasicWorkerTabControl.Name = "BasicWorkerTabControl";
            BasicWorkerTabControl.SelectedIndex = 0;
            BasicWorkerTabControl.Size = new Size(762, 433);
            BasicWorkerTabControl.TabIndex = 0;
            // 
            // BasicWorkerSendRequest_TP
            // 
            BasicWorkerSendRequest_TP.Controls.Add(SendRequest_BTN);
            BasicWorkerSendRequest_TP.Controls.Add(label2);
            BasicWorkerSendRequest_TP.Controls.Add(BasicWorkerDayoffType_CB);
            BasicWorkerSendRequest_TP.Controls.Add(label1);
            BasicWorkerSendRequest_TP.Controls.Add(RequestContent_RTB);
            BasicWorkerSendRequest_TP.Location = new Point(4, 24);
            BasicWorkerSendRequest_TP.Name = "BasicWorkerSendRequest_TP";
            BasicWorkerSendRequest_TP.Padding = new Padding(3);
            BasicWorkerSendRequest_TP.Size = new Size(754, 405);
            BasicWorkerSendRequest_TP.TabIndex = 0;
            BasicWorkerSendRequest_TP.Text = "Wyślij wniosek";
            BasicWorkerSendRequest_TP.UseVisualStyleBackColor = true;
            // 
            // SendRequest_BTN
            // 
            SendRequest_BTN.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SendRequest_BTN.Location = new Point(608, 350);
            SendRequest_BTN.Name = "SendRequest_BTN";
            SendRequest_BTN.Size = new Size(109, 35);
            SendRequest_BTN.TabIndex = 4;
            SendRequest_BTN.Text = "Wyslij";
            SendRequest_BTN.UseVisualStyleBackColor = true;
            SendRequest_BTN.Click += SendRequest_BTN_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(596, 15);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 3;
            label2.Text = "Typ zwolnienia";
            // 
            // BasicWorkerDayoffType_CB
            // 
            BasicWorkerDayoffType_CB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BasicWorkerDayoffType_CB.DropDownStyle = ComboBoxStyle.DropDownList;
            BasicWorkerDayoffType_CB.FormattingEnabled = true;
            BasicWorkerDayoffType_CB.Location = new Point(596, 36);
            BasicWorkerDayoffType_CB.Name = "BasicWorkerDayoffType_CB";
            BasicWorkerDayoffType_CB.Size = new Size(121, 23);
            BasicWorkerDayoffType_CB.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 15);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 1;
            label1.Text = "Wniosek";
            // 
            // RequestContent_RTB
            // 
            RequestContent_RTB.AccessibleDescription = "";
            RequestContent_RTB.Location = new Point(21, 36);
            RequestContent_RTB.Name = "RequestContent_RTB";
            RequestContent_RTB.Size = new Size(561, 305);
            RequestContent_RTB.TabIndex = 0;
            RequestContent_RTB.Text = "";
            // 
            // BasicWorkerNotifications_TP
            // 
            BasicWorkerNotifications_TP.Controls.Add(WorkerNotificatin_DGV);
            BasicWorkerNotifications_TP.Location = new Point(4, 24);
            BasicWorkerNotifications_TP.Name = "BasicWorkerNotifications_TP";
            BasicWorkerNotifications_TP.Padding = new Padding(3);
            BasicWorkerNotifications_TP.Size = new Size(754, 405);
            BasicWorkerNotifications_TP.TabIndex = 1;
            BasicWorkerNotifications_TP.Text = "Powiadomienia";
            BasicWorkerNotifications_TP.UseVisualStyleBackColor = true;
            // 
            // WorkerNotificatin_DGV
            // 
            WorkerNotificatin_DGV.AllowUserToAddRows = false;
            WorkerNotificatin_DGV.AllowUserToDeleteRows = false;
            WorkerNotificatin_DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            WorkerNotificatin_DGV.Columns.AddRange(new DataGridViewColumn[] { RequestNumber, DayoffType, RequestStatus });
            WorkerNotificatin_DGV.Dock = DockStyle.Fill;
            WorkerNotificatin_DGV.Location = new Point(3, 3);
            WorkerNotificatin_DGV.Name = "WorkerNotificatin_DGV";
            WorkerNotificatin_DGV.ReadOnly = true;
            WorkerNotificatin_DGV.RowTemplate.Height = 25;
            WorkerNotificatin_DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            WorkerNotificatin_DGV.Size = new Size(748, 399);
            WorkerNotificatin_DGV.TabIndex = 0;
            WorkerNotificatin_DGV.CellDoubleClick += PreviewRejectionMessage_CellMouseDoubleClick;
            // 
            // RequestNumber
            // 
            RequestNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RequestNumber.FillWeight = 30F;
            RequestNumber.HeaderText = "Nr wniosku";
            RequestNumber.Name = "RequestNumber";
            RequestNumber.ReadOnly = true;
            // 
            // DayoffType
            // 
            DayoffType.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DayoffType.FillWeight = 35F;
            DayoffType.HeaderText = "Typ zwolnienia";
            DayoffType.Name = "DayoffType";
            DayoffType.ReadOnly = true;
            // 
            // RequestStatus
            // 
            RequestStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RequestStatus.FillWeight = 35F;
            RequestStatus.HeaderText = "Status wniosku";
            RequestStatus.Name = "RequestStatus";
            RequestStatus.ReadOnly = true;
            // 
            // BasicWorkerApplicationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 433);
            Controls.Add(BasicWorkerTabControl);
            MaximumSize = new Size(991, 624);
            MinimumSize = new Size(778, 472);
            Name = "BasicWorkerApplicationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Panel pracownika";
            BasicWorkerTabControl.ResumeLayout(false);
            BasicWorkerSendRequest_TP.ResumeLayout(false);
            BasicWorkerSendRequest_TP.PerformLayout();
            BasicWorkerNotifications_TP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)WorkerNotificatin_DGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl BasicWorkerTabControl;
        private TabPage BasicWorkerSendRequest_TP;
        private TabPage BasicWorkerNotifications_TP;
        private Label label1;
        private RichTextBox RequestContent_RTB;
        private ComboBox BasicWorkerDayoffType_CB;
        private Button SendRequest_BTN;
        private Label label2;
        private DataGridView WorkerNotificatin_DGV;
        private DataGridViewTextBoxColumn RequestNumber;
        private DataGridViewTextBoxColumn DayoffType;
        private DataGridViewTextBoxColumn RequestStatus;
    }
}