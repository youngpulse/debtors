using System;
using System.Windows.Forms;
using Debtors.Services;
using Debtors.Forms;

namespace Debtors.Forms
{
	public partial class LoginForm : Form
	{
		private readonly UserService _userServices;
		private string _login;
		private string _password;

		public LoginForm()
		{
			InitializeComponent();
			_userServices = new UserService();
			SetTextBoxMaxLength(txbLogin, _userServices.LoginMaxLength);
			SetTextBoxMaxLength(txbPassword, _userServices.PasswordMaxLength);
			Autorun();
		}

		private void Autorun()
		
		{
			_login = "Ivanova";
			_password = "Ivanova";
			btnEnter_Click(this, new EventArgs());
		}

		private void btnEnter_Click(object sender, EventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
				if (_userServices.Authorizate(_login, _password))
				{
					MainForm form = new MainForm();
					this.Hide();
					form.ShowDialog();
				}
			}

			catch (UserException ex)
			{
				MessageBox.Show(ex.Message, "Ошибка!");
			}

			catch (InvalidOperationException ex)
			{
				MessageBox.Show(ex.Message, "Ошибка!");
			}

			finally
			{
				this.Cursor = Cursors.Default;
			}
		}


		private bool IsCreatedServices()
		{
			if (_userServices == null)
			{
				return false;
			}

			return true;
		}

		private void SetTextBoxMaxLength(TextBox control, int maxLength)
		{
			control.MaxLength = maxLength;
		}

		private void txbLogin_TextChanged(object sender, EventArgs e)
		{
			_login = txbLogin.Text;
		}

		private void txbPassword_TextChanged(object sender, EventArgs e)
		{
			_password = txbPassword.Text;
		}

		private void LoginForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btnEnter_Click(this, new EventArgs());
			}
		}
	}
}
