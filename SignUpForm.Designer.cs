namespace LoginFormSQL
{
    partial class SignUpForm
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
            this.LblPwd = new System.Windows.Forms.Label();
            this.LblUserName = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.txtPwdSign = new System.Windows.Forms.TextBox();
            this.txtUserSign = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPwd2Sign = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblPwd
            // 
            this.LblPwd.AutoSize = true;
            this.LblPwd.Location = new System.Drawing.Point(34, 88);
            this.LblPwd.Name = "LblPwd";
            this.LblPwd.Size = new System.Drawing.Size(73, 17);
            this.LblPwd.TabIndex = 11;
            this.LblPwd.Text = "Password:";
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Location = new System.Drawing.Point(34, 40);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(77, 17);
            this.LblUserName.TabIndex = 10;
            this.LblUserName.Text = "Username:";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.PaleGreen;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Location = new System.Drawing.Point(176, 182);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(95, 32);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "Submit";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.Tomato;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSignUp.Location = new System.Drawing.Point(303, 182);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(95, 32);
            this.btnSignUp.TabIndex = 8;
            this.btnSignUp.Text = "Cancel";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // txtPwdSign
            // 
            this.txtPwdSign.Location = new System.Drawing.Point(176, 85);
            this.txtPwdSign.Multiline = true;
            this.txtPwdSign.Name = "txtPwdSign";
            this.txtPwdSign.PasswordChar = '*';
            this.txtPwdSign.Size = new System.Drawing.Size(222, 22);
            this.txtPwdSign.TabIndex = 7;
            // 
            // txtUserSign
            // 
            this.txtUserSign.Location = new System.Drawing.Point(176, 37);
            this.txtUserSign.Multiline = true;
            this.txtUserSign.Name = "txtUserSign";
            this.txtUserSign.Size = new System.Drawing.Size(222, 22);
            this.txtUserSign.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Re-Type Password: ";
            // 
            // txtPwd2Sign
            // 
            this.txtPwd2Sign.Location = new System.Drawing.Point(176, 131);
            this.txtPwd2Sign.Multiline = true;
            this.txtPwd2Sign.Name = "txtPwd2Sign";
            this.txtPwd2Sign.PasswordChar = '*';
            this.txtPwd2Sign.Size = new System.Drawing.Size(222, 22);
            this.txtPwd2Sign.TabIndex = 12;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 253);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPwd2Sign);
            this.Controls.Add(this.LblPwd);
            this.Controls.Add(this.LblUserName);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.txtPwdSign);
            this.Controls.Add(this.txtUserSign);
            this.MaximizeBox = false;
            this.Name = "SignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SignUpForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblPwd;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.TextBox txtPwdSign;
        private System.Windows.Forms.TextBox txtUserSign;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPwd2Sign;
    }
}