namespace ClinicApp.Forms.ManagerForms
{
    partial class AssignSubstitutionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignSubstitutionForm));
            AssignWorker_CB = new ComboBox();
            AssignWorker_BTN = new Button();
            SuspendLayout();
            // 
            // AssignWorker_CB
            // 
            AssignWorker_CB.DropDownStyle = ComboBoxStyle.DropDownList;
            AssignWorker_CB.FormattingEnabled = true;
            AssignWorker_CB.Location = new Point(35, 27);
            AssignWorker_CB.Name = "AssignWorker_CB";
            AssignWorker_CB.Size = new Size(130, 23);
            AssignWorker_CB.TabIndex = 0;
            // 
            // AssignWorker_BTN
            // 
            AssignWorker_BTN.Location = new Point(35, 74);
            AssignWorker_BTN.Name = "AssignWorker_BTN";
            AssignWorker_BTN.Size = new Size(130, 33);
            AssignWorker_BTN.TabIndex = 1;
            AssignWorker_BTN.Text = "Przypisz";
            AssignWorker_BTN.UseVisualStyleBackColor = true;
            AssignWorker_BTN.Click += AssignWorker_BTN_Click;
            // 
            // AssignSubstitutionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(192, 129);
            Controls.Add(AssignWorker_BTN);
            Controls.Add(AssignWorker_CB);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(208, 168);
            MinimumSize = new Size(208, 168);
            Name = "AssignSubstitutionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Przypisz pracownika";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox AssignWorker_CB;
        private Button AssignWorker_BTN;
    }
}