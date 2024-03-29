﻿namespace ClinicApp.Forms
{
    partial class ReceptionistApplicationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceptionistApplicationForm));
            Request_DGV = new DataGridView();
            RequestNumber = new DataGridViewTextBoxColumn();
            WorkerName = new DataGridViewTextBoxColumn();
            WorkerSurname = new DataGridViewTextBoxColumn();
            DayoffType = new DataGridViewTextBoxColumn();
            menuStrip1 = new MenuStrip();
            Logout_BTN = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)Request_DGV).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Request_DGV
            // 
            Request_DGV.AllowUserToAddRows = false;
            Request_DGV.AllowUserToDeleteRows = false;
            Request_DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            Request_DGV.Columns.AddRange(new DataGridViewColumn[] { RequestNumber, WorkerName, WorkerSurname, DayoffType });
            Request_DGV.Dock = DockStyle.Fill;
            Request_DGV.Location = new Point(0, 24);
            Request_DGV.Name = "Request_DGV";
            Request_DGV.ReadOnly = true;
            Request_DGV.RowTemplate.Height = 25;
            Request_DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Request_DGV.Size = new Size(800, 426);
            Request_DGV.TabIndex = 0;
            Request_DGV.CellDoubleClick += Rquest_Click;
            // 
            // RequestNumber
            // 
            RequestNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RequestNumber.FillWeight = 15F;
            RequestNumber.HeaderText = "Nr wniosku";
            RequestNumber.Name = "RequestNumber";
            RequestNumber.ReadOnly = true;
            RequestNumber.Resizable = DataGridViewTriState.False;
            // 
            // WorkerName
            // 
            WorkerName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            WorkerName.FillWeight = 35F;
            WorkerName.HeaderText = "Imię";
            WorkerName.Name = "WorkerName";
            WorkerName.ReadOnly = true;
            WorkerName.Resizable = DataGridViewTriState.False;
            // 
            // WorkerSurname
            // 
            WorkerSurname.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            WorkerSurname.FillWeight = 35F;
            WorkerSurname.HeaderText = "Nazwisko";
            WorkerSurname.Name = "WorkerSurname";
            WorkerSurname.ReadOnly = true;
            WorkerSurname.Resizable = DataGridViewTriState.False;
            // 
            // DayoffType
            // 
            DayoffType.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DayoffType.FillWeight = 15F;
            DayoffType.HeaderText = "Typ zwolnienia";
            DayoffType.Name = "DayoffType";
            DayoffType.ReadOnly = true;
            DayoffType.Resizable = DataGridViewTriState.False;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { Logout_BTN });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // Logout_BTN
            // 
            Logout_BTN.Name = "Logout_BTN";
            Logout_BTN.Size = new Size(63, 20);
            Logout_BTN.Text = "Wyloguj";
            Logout_BTN.Click += LogoutToolStripMenuItem_Click;
            // 
            // ReceptionistApplicationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Request_DGV);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "ReceptionistApplicationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Panel recepcjonistki";
            ((System.ComponentModel.ISupportInitialize)Request_DGV).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Request_DGV;
        private DataGridViewTextBoxColumn RequestNumber;
        private DataGridViewTextBoxColumn WorkerName;
        private DataGridViewTextBoxColumn WorkerSurname;
        private DataGridViewTextBoxColumn DayoffType;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem Logout_BTN;
    }
}