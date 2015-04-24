using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Debtors.Services;
using Debtors.Domain;

namespace Debtors.Forms
{
	public partial class CollectionOfDebt : Form
	{
		private readonly DebtorService _debtorService;
		private Debtor _currentDebtor;
		private List<Record> _records;
		private BindingSource bs;

		/// <summary>
		/// Форма для работ с претензиями
		/// </summary>
		public CollectionOfDebt(Debtor debtor)
		{
			InitializeComponent();
			_debtorService = new DebtorService();
			_currentDebtor = debtor;
			SetDebtorProperties(debtor);
			SetHeaderTextTable();
			HideColumnWithId();
		}

		private void SetDebtorProperties(Debtor debtor)
		{
			ShowAddress(debtor.Address);
			ShowNumContract(debtor.NumContract);
			ShowDateContract(debtor.DateContract);
			ShowDebt(debtor.Debt);
			ShowName(debtor.Name);
			ShowTypeContragent(debtor.TypeId);
			ShowDurationOfDebt(debtor.StartDateDebt);
			ShowStartDateDebt(debtor.StartDateDebt);
			ShowRecordsCollectionOfDebt(debtor);
			SetCheckBox(debtor);
		}

		private int CalculateDurationOfDebt(DateTime startDate, DateTime endDate)
		{
			return Math.Abs((startDate.Month - endDate.Month) + 12 * (startDate.Year - endDate.Year));
		}

		private void ShowRecordsCollectionOfDebt(Debtor debtor)
		{
			bs = new BindingSource();
			_records = LoadJournal(debtor.Id);
			bs.DataSource = _records;
			bindingNavigator.BindingSource = bs;
			dgvHistory.DataSource = bs;
		}

		private List<Record> LoadJournal(int idDebtor)
		{
			return _debtorService.GetRecordJournal(idDebtor);
		}

		private void btnChangeCopyContract_Click(object sender, EventArgs e)
		{
			OpenFileDialog file = new OpenFileDialog();
			if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				txbCopyContract.Text = file.FileName;
			}
		}

		private void btnLoadScanContract_Click(object sender, EventArgs e)
		{
			if (_debtorService.HandleUpload(_currentDebtor, txbCopyContract.Text))
			{
				MessageBox.Show("Документ загружен.");
			}

			else
			{
				MessageBox.Show("Ошибка во время выполнения. Попробуйте еще раз.", "Ошибка");
			}
		}

		private void SetCheckBox(Debtor debtor)
		{
			bool isScan = _debtorService.IsScan(debtor.Id);
			if (isScan)
			{
				cbScanContract.Checked = true;
			}

			else
			{
				cbScanContract.Checked = false;
			}
		}

		private void btnLoadScan_Click(object sender, EventArgs e)
		{
			_debtorService.OpenFile(_currentDebtor.Id);
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			_debtorService.SaveCurrentDebtor(_currentDebtor);
			_debtorService.SaveColletionDebt(_records, _currentDebtor.Id);
		}

		private void txbName_TextChanged(object sender, EventArgs e)
		{
			_currentDebtor.Name = txbName.Text;
		}

		private void txbAddress_TextChanged(object sender, EventArgs e)
		{
			_currentDebtor.Address = txbAddress.Text;
		}

		private void cmbCounteragent_TextChanged(object sender, EventArgs e)
		{
			_currentDebtor.TypeId = cmbCounteragent.SelectedIndex;
		}

		private void txbDebt_TextChanged(object sender, EventArgs e)
		{
			_currentDebtor.Debt = Convert.ToDecimal(txbDebt.Text);
		}

		private void dtpStartDebt_ValueChanged(object sender, EventArgs e)
		{
			_currentDebtor.StartDateDebt = dtpStartDebt.Value;
			ShowDurationOfDebt(_currentDebtor.StartDateDebt);
		}

		private void txbDebt_KeyPress(object sender, KeyPressEventArgs e)
		{
			double value = 0;
			if (!double.TryParse(txbDebt.Text + e.KeyChar.ToString(), out value) && !char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#region Show debtor properties
		private void ShowAddress(string address)
		{
			txbAddress.Text = address;
		}
		private void ShowNumContract(string numContract)
		{
			txbContractInfo.Text = numContract;
		}
		private void ShowDebt(decimal debt)
		{
			txbDebt.Text = debt.ToString();
		}
		private void ShowName(string name)
		{
			txbName.Text = name;
		}
		private void ShowTypeContragent(int typeId)
		{
			cmbCounteragent.SelectedIndex = typeId;
		}
		private void ShowDateContract(DateTime dateContract)
		{
			dtpDateContract.Value = dateContract;
		}
		private void ShowStartDateDebt(DateTime date)
		{
			dtpStartDebt.Value = date;
		}
		private void ShowDurationOfDebt(DateTime startDate)
		{
			mtbTermDebt.Text = CalculateDurationOfDebt(startDate, DateTime.Now).ToString();
		}
		#endregion

		private void SetHeaderTextTable()
		{
			dgvHistory.Columns[1].HeaderText = "Дата";
			dgvHistory.Columns[2].HeaderText = "Описание";
		}
		private void HideColumnWithId()
		{
			dgvHistory.Columns[0].Visible = false;
		}

		private void txbContractInfo_TextChanged(object sender, EventArgs e)
		{
			_currentDebtor.NumContract = txbContractInfo.Text;
		}

		private void dtpDateContract_ValueChanged(object sender, EventArgs e)
		{
			_currentDebtor.DateContract = dtpDateContract.Value;
		}

		private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
		{

		}

		private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
		{
		}
	}
}
