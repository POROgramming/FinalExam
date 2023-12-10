namespace lab
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            lblLogIn = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            lblUserName = new Label();
            lblPassword = new Label();
            btnSubmit = new Button();
            chbShowPass = new CheckBox();
            SuspendLayout();
            // 
            // lblLogIn
            // 
            lblLogIn.AutoSize = true;
            lblLogIn.BackColor = Color.Transparent;
            lblLogIn.Font = new Font("Verdana", 26F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogIn.ForeColor = Color.WhiteSmoke;
            lblLogIn.Location = new Point(426, 82);
            lblLogIn.Margin = new Padding(4, 0, 4, 0);
            lblLogIn.Name = "lblLogIn";
            lblLogIn.Size = new Size(218, 62);
            lblLogIn.TabIndex = 0;
            lblLogIn.Text = "LOGIN";
            lblLogIn.Click += lblLogIn_Click;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Location = new Point(330, 258);
            txtUserName.Margin = new Padding(4, 5, 4, 5);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(443, 29);
            txtUserName.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(330, 370);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(443, 29);
            txtPassword.TabIndex = 2;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.BackColor = Color.Transparent;
            lblUserName.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserName.ForeColor = Color.White;
            lblUserName.Location = new Point(330, 231);
            lblUserName.Margin = new Padding(4, 0, 4, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(129, 22);
            lblUserName.TabIndex = 3;
            lblUserName.Text = "USERNAME:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.ForeColor = Color.White;
            lblPassword.Location = new Point(330, 343);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(140, 22);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "PASSWORD: ";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.CornflowerBlue;
            btnSubmit.FlatStyle = FlatStyle.Popup;
            btnSubmit.Font = new Font("Verdana", 7F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(666, 535);
            btnSubmit.Margin = new Padding(4, 5, 4, 5);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.RightToLeft = RightToLeft.No;
            btnSubmit.Size = new Size(107, 38);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "SUBMIT";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // chbShowPass
            // 
            chbShowPass.AutoSize = true;
            chbShowPass.BackColor = Color.Transparent;
            chbShowPass.ForeColor = SystemColors.HighlightText;
            chbShowPass.Location = new Point(330, 418);
            chbShowPass.Margin = new Padding(4, 5, 4, 5);
            chbShowPass.Name = "chbShowPass";
            chbShowPass.Size = new Size(162, 29);
            chbShowPass.TabIndex = 6;
            chbShowPass.Text = "Show Password";
            chbShowPass.UseVisualStyleBackColor = false;
            chbShowPass.CheckedChanged += chbShowPass_CheckedChanged;
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1071, 750);
            Controls.Add(chbShowPass);
            Controls.Add(btnSubmit);
            Controls.Add(lblPassword);
            Controls.Add(lblUserName);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(lblLogIn);
            Margin = new Padding(4, 5, 4, 5);
            Name = "LogInForm";
            Text = "Log In Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogIn;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Label lblUserName;
        private Label lblPassword;
        private Button btnSubmit;
        private CheckBox chbShowPass;
    }
}