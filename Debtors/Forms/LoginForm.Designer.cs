namespace Debtors.Forms
{
	partial class LoginForm
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
			this.lblLogin = new System.Windows.Forms.Label();
			this.lblPassword = new System.Windows.Forms.Label();
			this.txbLogin = new System.Windows.Forms.TextBox();
			this.txbPassword = new System.Windows.Forms.TextBox();
			this.btnEnter = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblLogin
			// 
			this.lblLogin.AutoSize = true;
			this.lblLogin.Location = new System.Drawing.Point(67, 83);
			this.lblLogin.Name = "lblLogin";
			this.lblLogin.Size = new System.Drawing.Size(41, 13);
			this.lblLogin.TabIndex = 0;
			this.lblLogin.Text = "Логин:";
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Location = new System.Drawing.Point(67, 112);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(48, 13);
			this.lblPassword.TabIndex = 1;
			this.lblPassword.Text = "Пароль:";
			// 
			// txbLogin
			// 
			this.txbLogin.Location = new System.Drawing.Point(118, 83);
			this.txbLogin.Name = "txbLogin";
			this.txbLogin.Size = new System.Drawing.Size(100, 20);
			this.txbLogin.TabIndex = 2;
			this.txbLogin.TextChanged += new System.EventHandler(this.txbLogin_TextChanged);
			// 
			// txbPassword
			// 
			this.txbPassword.Location = new System.Drawing.Point(118, 109);
			this.txbPassword.Name = "txbPassword";
			this.txbPassword.PasswordChar = '*';
			this.txbPassword.Size = new System.Drawing.Size(100, 20);
			this.txbPassword.TabIndex = 3;
			this.txbPassword.TextChanged += new System.EventHandler(this.txbPassword_TextChanged);
			// 
			// btnEnter
			// 
			this.btnEnter.Location = new System.Drawing.Point(97, 148);
			this.btnEnter.Name = "btnEnter";
			this.btnEnter.Size = new System.Drawing.Size(75, 23);
			this.btnEnter.TabIndex = 4;
			this.btnEnter.Text = "Вход";
			this.btnEnter.UseVisualStyleBackColor = true;
			this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.btnEnter);
			this.Controls.Add(this.txbPassword);
			this.Controls.Add(this.txbLogin);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.lblLogin);
			this.KeyPreview = true;
			this.Name = "LoginForm";
			this.Text = "Вход в систему";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginForm_KeyDown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblLogin;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.TextBox txbLogin;
		private System.Windows.Forms.TextBox txbPassword;
		private System.Windows.Forms.Button btnEnter;
	}
}

