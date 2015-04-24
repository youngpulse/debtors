using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Debtors.Services;
using Debtors.Domain;

namespace Debtors.Forms
{
	enum SearchedField {Null=0, Name=1, Address=2 }
	public partial class DebtsForm : Form
	{
		private readonly DebtorService _debtorService;
		private decimal _debt;
		private decimal _durationDebt;
		private string _type;
		private string _keyWord;
		private SearchedField _searchedField;

		/// <summary>
		/// Форма работы с дебиторами.
		/// </summary>
		public DebtsForm()
		{
			InitializeComponent();
			_debtorService = new DebtorService();
		}

		private void btnLoadDebtrors_Click(object sender, EventArgs e)
		{

		}

		private void LoadDebtors()
		{
			dgvDebtors.DataSource = _debtorService.GetDebtors();
			HideNavigateFields();
			SetNameForTable();
		}

		private void HideNavigateFields()
		{
			dgvDebtors.Columns[0].Visible = false;
		}

		private void SetNameForTable()
		{
			dgvDebtors.Columns[1].HeaderText = "Тип";
			dgvDebtors.Columns[2].HeaderText = "Наименование";
			dgvDebtors.Columns[3].HeaderText = "Адрес";
			dgvDebtors.Columns[4].HeaderText = "Сумма задолженности";
			
		}

		private void GetSearchedField()
		{
			if (rdbtnAddress.Checked)
			{
				_searchedField = SearchedField.Address;
			}

			if (rdbtnName.Checked)
			{
				_searchedField = SearchedField.Name;
			}
		}


		private string CreateSearchQuery()
		{
			string query = null;

			query = string.Format("Name LIKE '%'"+ _keyWord+"'%");
			//string field = ReturnSearchField();
			//if (_type != null)
			//{
			//	string par = ""
			//}

			
			

			return query;
		}

		private SearchedField ReturnSearchField()
		{
			SearchedField field = SearchedField.Null;
			if (_searchedField == SearchedField.Name)
			{
				field = SearchedField.Name;
			}

			if (_searchedField == SearchedField.Address)
			{
				field = SearchedField.Address;
			}

			return field;
		}

		private List<DebtorShortInfo> Search()
		{
			//string query = CreateSearchQuery();
			List<DebtorShortInfo> debtors = new List<DebtorShortInfo>();
			_searchedField = ReturnSearchField();
			if (_searchedField == SearchedField.Name)
			{
				debtors = (dgvDebtors.DataSource as List<DebtorShortInfo>).FindAll(x => x.Name == _keyWord);
			}

			if (_searchedField == SearchedField.Address)
			{
				debtors = (dgvDebtors.DataSource as List<DebtorShortInfo>).FindAll(x => x.Address == _keyWord);
			}

			if (_type !=null)
			{
				debtors = (dgvDebtors.DataSource as List<DebtorShortInfo>).FindAll(x => x.Type == _type);
			}

			if (_debt > 0)
			{
				debtors = (dgvDebtors.DataSource as List<DebtorShortInfo>).FindAll(x => x.Debt >=_debt);
			}

			return debtors;
		}

		private void dgvDebtors_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			DebtorShortInfo d = (DebtorShortInfo)dgvDebtors.CurrentRow.DataBoundItem;
			Debtor debtor = _debtorService.GetCurrentDebtor(d.Id);
			CollectionOfDebt form = new CollectionOfDebt(debtor);
			form.Show();
		}

		private void miAddNewContragent_Click(object sender, EventArgs e)
		{

		}

		private void dgvDebtors_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			SortTable(e.ColumnIndex);
		}

		private void SortTable(int columnId)
		{
			dgvDebtors.Sort(dgvDebtors.Columns[columnId], ListSortDirection.Ascending);
		}

		private void gbAdvansedSearch_Enter(object sender, EventArgs e)
		{

		}

		private void lblAdvancedSearch_Click(object sender, EventArgs e)
		{
			if (gbAdvansedSearch.Visible)
			{
				gbAdvansedSearch.Visible = false;
			}

			else
			{
				gbAdvansedSearch.Visible = true;
			}
		}

		private void txbDebt_KeyPress(object sender, KeyPressEventArgs e)
		{
			double value = 0;
			if (!double.TryParse(txbDebt.Text + e.KeyChar.ToString(), out value) && !char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void txbDurationDebt_KeyPress(object sender, KeyPressEventArgs e)
		{
			double value = 0;
			if (!double.TryParse(txbDurationDebt.Text + e.KeyChar.ToString(), out value) && !char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void txbKeyWord_TextChanged(object sender, EventArgs e)
		{
			_keyWord = txbKeyWord.Text;
		}

		private void cmbType_TextChanged(object sender, EventArgs e)
		{
			_type = cmbType.SelectedText;
		}

		private void txbDebt_TextChanged(object sender, EventArgs e)
		{
			_debt = Convert.ToDecimal(txbDebt.Text);
		}

		private void txbDurationDebt_TextChanged(object sender, EventArgs e)
		{
			_durationDebt = Convert.ToDecimal(txbDurationDebt.Text);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			dgvDebtors.DataSource = Search();
		}

		private void tbSearch_TextChanged(object sender, EventArgs e)
		{

		}

		private void cmbType_SelectedValueChanged(object sender, EventArgs e)
		{
			_type = cmbType.SelectedItem.ToString();
		}

		private void DebtsForm_Load(object sender, EventArgs e)
		{
			LoadDebtors();
		}
	}
}
