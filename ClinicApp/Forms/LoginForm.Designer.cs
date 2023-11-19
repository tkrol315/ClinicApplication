namespace ClinicApp
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            Password_TB = new TextBox();
            label2 = new Label();
            label1 = new Label();
            Login_TB = new TextBox();
            Login_BTN = new Button();
            label3 = new Label();
            ShowPasswordCB = new CheckBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(Password_TB, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(Login_TB, 1, 0);
            tableLayoutPanel1.Location = new Point(41, 42);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(249, 78);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // Password_TB
            // 
            Password_TB.Anchor = AnchorStyles.Left;
            Password_TB.Location = new Point(73, 47);
            Password_TB.Name = "Password_TB";
            Password_TB.PlaceholderText = "Hasło";
            Password_TB.Size = new Size(173, 23);
            Password_TB.TabIndex = 3;
            Password_TB.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(15, 50);
            label2.Name = "label2";
            label2.Size = new Size(40, 17);
            label2.TabIndex = 2;
            label2.Text = "Hasło";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(14, 11);
            label1.Name = "label1";
            label1.Size = new Size(42, 17);
            label1.TabIndex = 0;
            label1.Text = "Login ";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Login_TB
            // 
            Login_TB.Anchor = AnchorStyles.Left;
            Login_TB.Location = new Point(73, 8);
            Login_TB.Name = "Login_TB";
            Login_TB.PlaceholderText = "Login";
            Login_TB.Size = new Size(173, 23);
            Login_TB.TabIndex = 1;
            // 
            // Login_BTN
            // 
            Login_BTN.BackColor = Color.FromArgb(192, 255, 192);
            Login_BTN.Cursor = Cursors.Hand;
            Login_BTN.FlatStyle = FlatStyle.Flat;
            Login_BTN.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Login_BTN.Location = new Point(41, 139);
            Login_BTN.Name = "Login_BTN";
            Login_BTN.Size = new Size(249, 32);
            Login_BTN.TabIndex = 1;
            Login_BTN.Text = "Zaloguj";
            Login_BTN.UseVisualStyleBackColor = false;
            Login_BTN.Click += Login_BTN_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(95, 9);
            label3.Name = "label3";
            label3.Size = new Size(134, 30);
            label3.TabIndex = 2;
            label3.Text = "LOGOWANIE";
            // 
            // ShowPasswordCB
            // 
            ShowPasswordCB.AutoSize = true;
            ShowPasswordCB.Location = new Point(202, 118);
            ShowPasswordCB.Name = "ShowPasswordCB";
            ShowPasswordCB.Size = new Size(88, 19);
            ShowPasswordCB.TabIndex = 3;
            ShowPasswordCB.Text = "Pokaż hasło";
            ShowPasswordCB.UseVisualStyleBackColor = true;
            ShowPasswordCB.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 183);
            Controls.Add(ShowPasswordCB);
            Controls.Add(label3);
            Controls.Add(Login_BTN);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(355, 222);
            MinimumSize = new Size(355, 222);
            Name = "LoginForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Logowanie";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox Password_TB;
        private Label label2;
        private Label label1;
        private TextBox Login_TB;
        private Button Login_BTN;
        private Label label3;
        private CheckBox ShowPasswordCB;
    }
}