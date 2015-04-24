using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Debtors.Forms
{
	public partial class DebtorForm : Form
	{
		public DebtorForm()
		{
			InitializeComponent();
		}

		private void dtpStartDebt_ValueChanged(object sender, EventArgs e)
		{
			TimeSpan days = DateTime.Now - dtpStartDebt.Value;
			double months = days.Days / 30.0;
			mtbTermDebt.Text = string.Format("{0}", Math.Floor(months));
		}

		private void DebtorForm_Load(object sender, EventArgs e)
		{
			cmbCounteragent.SelectedIndex = 0;
		}

		private void btnChangeCopyContract_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			if (DialogResult.OK == dialog.ShowDialog())
			{
				txbCopyContract.Text = dialog.FileName;
			}
		}

		private void txbDebt_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsDigit(e.KeyChar) | (e.KeyChar == ',' && !txbDebt.Text.Contains(',')) | char.IsControl(e.KeyChar)))
			{
				e.Handled = true;
			}
		}
	}
}
