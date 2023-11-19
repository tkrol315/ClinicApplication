namespace ClinicApp.Forms.AdministratorForms
{
    partial class EditWorkerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditWorkerForm));
            label1 = new Label();
            Name_TB = new TextBox();
            Surname_TB = new TextBox();
            label2 = new Label();
            DaysOff_TB = new TextBox();
            label3 = new Label();
            Login_TB = new TextBox();
            label4 = new Label();
            EditWorker_BTN = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 61);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "Imię";
            // 
            // Name_TB
            // 
            Name_TB.Location = new Point(130, 61);
            Name_TB.Name = "Name_TB";
            Name_TB.Size = new Size(133, 23);
            Name_TB.TabIndex = 2;
            // 
            // Surname_TB
            // 
            Surname_TB.Location = new Point(130, 99);
            Surname_TB.Name = "Surname_TB";
            Surname_TB.Size = new Size(133, 23);
            Surname_TB.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 99);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Nazwisko";
            // 
            // DaysOff_TB
            // 
            DaysOff_TB.Location = new Point(130, 138);
            DaysOff_TB.Name = "DaysOff_TB";
            DaysOff_TB.Size = new Size(133, 23);
            DaysOff_TB.TabIndex = 4;
            DaysOff_TB.KeyPress += DaysOff_TB_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 138);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 4;
            label3.Text = "Ilość urlopu";
            // 
            // Login_TB
            // 
            Login_TB.Location = new Point(130, 24);
            Login_TB.Name = "Login_TB";
            Login_TB.Size = new Size(133, 23);
            Login_TB.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(76, 32);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 6;
            label4.Text = "Login";
            // 
            // EditWorker_BTN
            // 
            EditWorker_BTN.Location = new Point(107, 186);
            EditWorker_BTN.MaximumSize = new Size(131, 37);
            EditWorker_BTN.MinimumSize = new Size(131, 37);
            EditWorker_BTN.Name = "EditWorker_BTN";
            EditWorker_BTN.Size = new Size(131, 37);
            EditWorker_BTN.TabIndex = 5;
            EditWorker_BTN.Text = "Zapisz";
            EditWorker_BTN.UseVisualStyleBackColor = true;
            EditWorker_BTN.Click += EditWorker_BTN_Click;
            // 
            // EditWorkerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 235);
            Controls.Add(EditWorker_BTN);
            Controls.Add(Login_TB);
            Controls.Add(label4);
            Controls.Add(DaysOff_TB);
            Controls.Add(label3);
            Controls.Add(Surname_TB);
            Controls.Add(label2);
            Controls.Add(Name_TB);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(353, 321);
            Name = "EditWorkerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edycja pracownika";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Name_TB;
        private TextBox Surname_TB;
        private Label label2;
        private TextBox DaysOff_TB;
        private Label label3;
        private TextBox Login_TB;
        private Label label4;
        private Button EditWorker_BTN;
    }
}