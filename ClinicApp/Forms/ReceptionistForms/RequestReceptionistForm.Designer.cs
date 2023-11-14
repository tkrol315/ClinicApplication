namespace ClinicApp.Forms.ReceptionistForms
{
    partial class RequestReceptionistForm
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
            RequestContent_RTB = new RichTextBox();
            RequestReply_RTB = new RichTextBox();
            label1 = new Label();
            AcceptRequest_RB = new RadioButton();
            RejectRequest_RB = new RadioButton();
            RequestDateFrom_CB = new ComboBox();
            RequestDateTo_CB = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            ReceptionistSendRequest_BTN = new Button();
            Schedule_BTN = new Button();
            SuspendLayout();
            // 
            // RequestContent_RTB
            // 
            RequestContent_RTB.BackColor = Color.White;
            RequestContent_RTB.Location = new Point(19, 36);
            RequestContent_RTB.Name = "RequestContent_RTB";
            RequestContent_RTB.ReadOnly = true;
            RequestContent_RTB.Size = new Size(583, 265);
            RequestContent_RTB.TabIndex = 0;
            RequestContent_RTB.Text = "";
            // 
            // RequestReply_RTB
            // 
            RequestReply_RTB.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RequestReply_RTB.Enabled = false;
            RequestReply_RTB.Location = new Point(19, 320);
            RequestReply_RTB.Name = "RequestReply_RTB";
            RequestReply_RTB.Size = new Size(583, 80);
            RequestReply_RTB.TabIndex = 1;
            RequestReply_RTB.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 13);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 2;
            label1.Text = "Treść wniosku";
            // 
            // AcceptRequest_RB
            // 
            AcceptRequest_RB.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AcceptRequest_RB.AutoSize = true;
            AcceptRequest_RB.Location = new Point(19, 418);
            AcceptRequest_RB.Name = "AcceptRequest_RB";
            AcceptRequest_RB.Size = new Size(72, 19);
            AcceptRequest_RB.TabIndex = 3;
            AcceptRequest_RB.TabStop = true;
            AcceptRequest_RB.Text = "Akceptuj";
            AcceptRequest_RB.UseVisualStyleBackColor = true;
            // 
            // RejectRequest_RB
            // 
            RejectRequest_RB.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RejectRequest_RB.AutoSize = true;
            RejectRequest_RB.Location = new Point(19, 443);
            RejectRequest_RB.Name = "RejectRequest_RB";
            RejectRequest_RB.Size = new Size(63, 19);
            RejectRequest_RB.TabIndex = 4;
            RejectRequest_RB.TabStop = true;
            RejectRequest_RB.Text = "Odrzuć";
            RejectRequest_RB.UseVisualStyleBackColor = true;
            // 
            // RequestDateFrom_CB
            // 
            RequestDateFrom_CB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RequestDateFrom_CB.DropDownStyle = ComboBoxStyle.DropDownList;
            RequestDateFrom_CB.FormattingEnabled = true;
            RequestDateFrom_CB.Location = new Point(671, 36);
            RequestDateFrom_CB.Name = "RequestDateFrom_CB";
            RequestDateFrom_CB.Size = new Size(148, 23);
            RequestDateFrom_CB.TabIndex = 5;
            RequestDateFrom_CB.SelectedIndexChanged += DateFrom_SelectedIndexChanged;
            // 
            // RequestDateTo_CB
            // 
            RequestDateTo_CB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RequestDateTo_CB.DropDownStyle = ComboBoxStyle.DropDownList;
            RequestDateTo_CB.FormattingEnabled = true;
            RequestDateTo_CB.Location = new Point(671, 72);
            RequestDateTo_CB.Name = "RequestDateTo_CB";
            RequestDateTo_CB.Size = new Size(149, 23);
            RequestDateTo_CB.TabIndex = 6;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(641, 36);
            label2.Name = "label2";
            label2.Size = new Size(23, 15);
            label2.TabIndex = 7;
            label2.Text = "Od";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(642, 72);
            label3.Name = "label3";
            label3.Size = new Size(22, 15);
            label3.TabIndex = 8;
            label3.Text = "Do";
            // 
            // ReceptionistSendRequest_BTN
            // 
            ReceptionistSendRequest_BTN.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ReceptionistSendRequest_BTN.Location = new Point(614, 436);
            ReceptionistSendRequest_BTN.Name = "ReceptionistSendRequest_BTN";
            ReceptionistSendRequest_BTN.Size = new Size(96, 33);
            ReceptionistSendRequest_BTN.TabIndex = 9;
            ReceptionistSendRequest_BTN.Text = "Wyślij";
            ReceptionistSendRequest_BTN.UseVisualStyleBackColor = true;
            // 
            // Schedule_BTN
            // 
            Schedule_BTN.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Schedule_BTN.Location = new Point(723, 436);
            Schedule_BTN.Name = "Schedule_BTN";
            Schedule_BTN.Size = new Size(96, 33);
            Schedule_BTN.TabIndex = 10;
            Schedule_BTN.Text = "Grafik";
            Schedule_BTN.UseVisualStyleBackColor = true;
            // 
            // RequestReceptionistForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 486);
            Controls.Add(Schedule_BTN);
            Controls.Add(ReceptionistSendRequest_BTN);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(RequestDateTo_CB);
            Controls.Add(RequestDateFrom_CB);
            Controls.Add(RejectRequest_RB);
            Controls.Add(AcceptRequest_RB);
            Controls.Add(label1);
            Controls.Add(RequestReply_RTB);
            Controls.Add(RequestContent_RTB);
            MaximumSize = new Size(1122, 641);
            MinimumSize = new Size(847, 525);
            Name = "RequestReceptionistForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Wniosek";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox RequestContent_RTB;
        private RichTextBox RequestReply_RTB;
        private Label label1;
        private RadioButton AcceptRequest_RB;
        private RadioButton RejectRequest_RB;
        private ComboBox RequestDateFrom_CB;
        private ComboBox RequestDateTo_CB;
        private Label label2;
        private Label label3;
        private Button ReceptionistSendRequest_BTN;
        private Button Schedule_BTN;
    }
}