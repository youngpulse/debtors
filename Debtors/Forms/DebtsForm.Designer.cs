namespace Debtors.Forms
{
	partial class DebtsForm
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
			this.components = new System.ComponentModel.Container();
			this.dgvDebtors = new System.Windows.Forms.DataGridView();
			this.lblSearch = new System.Windows.Forms.Label();
			this.tbSearch = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.miAddNewContragent = new System.Windows.Forms.ToolStripMenuItem();
			this.miEditContragent = new System.Windows.Forms.ToolStripMenuItem();
			this.miRemoveContragent = new System.Windows.Forms.ToolStripMenuItem();
			this.lblAdvancedSearch = new System.Windows.Forms.LinkLabel();
			this.txbKeyWord = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.txbDebt = new System.Windows.Forms.TextBox();
			this.lblDebt = new System.Windows.Forms.Label();
			this.cmbType = new System.Windows.Forms.ComboBox();
			this.lblTypeId = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.rdbtnName = new System.Windows.Forms.RadioButton();
			this.rdbtnAddress = new System.Windows.Forms.RadioButton();
			this.txbDurationDebt = new System.Windows.Forms.TextBox();
			this.lblDurationDebt = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.gbAdvansedSearch = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvDebtors)).BeginInit();
			this.contextMenuStrip.SuspendLayout();
			this.gbAdvansedSearch.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvDebtors
			// 
			this.dgvDebtors.AllowUserToAddRows = false;
			this.dgvDebtors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvDebtors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDebtors.Location = new System.Drawing.Point(340, 39);
			this.dgvDebtors.Name = "dgvDebtors";
			this.dgvDebtors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDebtors.Size = new System.Drawing.Size(667, 485);
			this.dgvDebtors.TabIndex = 0;
			this.dgvDebtors.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDebtors_CellDoubleClick);
			this.dgvDebtors.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDebtors_ColumnHeaderMouseClick);
			// 
			// lblSearch
			// 
			this.lblSearch.AutoSize = true;
			this.lblSearch.Location = new System.Drawing.Point(12, 39);
			this.lblSearch.Name = "lblSearch";
			this.lblSearch.Size = new System.Drawing.Size(39, 13);
			this.lblSearch.TabIndex = 2;
			this.lblSearch.Text = "Поиск";
			// 
			// tbSearch
			// 
			this.tbSearch.Location = new System.Drawing.Point(68, 36);
			this.tbSearch.Name = "tbSearch";
			this.tbSearch.Size = new System.Drawing.Size(175, 20);
			this.tbSearch.TabIndex = 3;
			this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(249, 34);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 23);
			this.btnSearch.TabIndex = 4;
			this.btnSearch.Text = "Найти";
			this.btnSearch.UseVisualStyleBackColor = true;
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAddNewContragent,
            this.miEditContragent,
            this.miRemoveContragent});
			this.contextMenuStrip.Name = "contextMenuStrip";
			this.contextMenuStrip.Size = new System.Drawing.Size(155, 70);
			// 
			// miAddNewContragent
			// 
			this.miAddNewContragent.Name = "miAddNewContragent";
			this.miAddNewContragent.Size = new System.Drawing.Size(154, 22);
			this.miAddNewContragent.Text = "Добавить";
			this.miAddNewContragent.Click += new System.EventHandler(this.miAddNewContragent_Click);
			// 
			// miEditContragent
			// 
			this.miEditContragent.Name = "miEditContragent";
			this.miEditContragent.Size = new System.Drawing.Size(154, 22);
			this.miEditContragent.Text = "Редактировать";
			// 
			// miRemoveContragent
			// 
			this.miRemoveContragent.Name = "miRemoveContragent";
			this.miRemoveContragent.Size = new System.Drawing.Size(154, 22);
			this.miRemoveContragent.Text = "Удалить";
			// 
			// lblAdvancedSearch
			// 
			this.lblAdvancedSearch.AutoSize = true;
			this.lblAdvancedSearch.Location = new System.Drawing.Point(12, 59);
			this.lblAdvancedSearch.Name = "lblAdvancedSearch";
			this.lblAdvancedSearch.Size = new System.Drawing.Size(111, 13);
			this.lblAdvancedSearch.TabIndex = 5;
			this.lblAdvancedSearch.TabStop = true;
			this.lblAdvancedSearch.Text = "Расширенный поиск";
			this.lblAdvancedSearch.Click += new System.EventHandler(this.lblAdvancedSearch_Click);
			// 
			// txbKeyWord
			// 
			this.txbKeyWord.Location = new System.Drawing.Point(12, 19);
			this.txbKeyWord.Name = "txbKeyWord";
			this.txbKeyWord.Size = new System.Drawing.Size(216, 20);
			this.txbKeyWord.TabIndex = 6;
			this.txbKeyWord.Text = "Ключевое слово";
			this.txbKeyWord.TextChanged += new System.EventHandler(this.txbKeyWord_TextChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(234, 16);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 7;
			this.button1.Text = "Найти";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// txbDebt
			// 
			this.txbDebt.Location = new System.Drawing.Point(124, 108);
			this.txbDebt.Name = "txbDebt";
			this.txbDebt.Size = new System.Drawing.Size(104, 20);
			this.txbDebt.TabIndex = 8;
			this.txbDebt.TextChanged += new System.EventHandler(this.txbDebt_TextChanged);
			this.txbDebt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbDebt_KeyPress);
			// 
			// lblDebt
			// 
			this.lblDebt.AutoSize = true;
			this.lblDebt.Location = new System.Drawing.Point(9, 111);
			this.lblDebt.Name = "lblDebt";
			this.lblDebt.Size = new System.Drawing.Size(101, 13);
			this.lblDebt.TabIndex = 9;
			this.lblDebt.Text = "Задолженность от";
			// 
			// cmbType
			// 
			this.cmbType.FormattingEnabled = true;
			this.cmbType.Items.AddRange(new object[] {
            "Физическое лицо",
            "Юридическое лицо"});
			this.cmbType.Location = new System.Drawing.Point(53, 76);
			this.cmbType.Name = "cmbType";
			this.cmbType.Size = new System.Drawing.Size(175, 21);
			this.cmbType.TabIndex = 10;
			this.cmbType.SelectedValueChanged += new System.EventHandler(this.cmbType_SelectedValueChanged);
			this.cmbType.TextChanged += new System.EventHandler(this.cmbType_TextChanged);
			// 
			// lblTypeId
			// 
			this.lblTypeId.AutoSize = true;
			this.lblTypeId.Location = new System.Drawing.Point(8, 79);
			this.lblTypeId.Name = "lblTypeId";
			this.lblTypeId.Size = new System.Drawing.Size(26, 13);
			this.lblTypeId.TabIndex = 11;
			this.lblTypeId.Text = "Тип";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 55);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 13);
			this.label3.TabIndex = 13;
			this.label3.Text = "Искать в";
			// 
			// rdbtnName
			// 
			this.rdbtnName.AutoSize = true;
			this.rdbtnName.Location = new System.Drawing.Point(73, 53);
			this.rdbtnName.Name = "rdbtnName";
			this.rdbtnName.Size = new System.Drawing.Size(101, 17);
			this.rdbtnName.TabIndex = 14;
			this.rdbtnName.TabStop = true;
			this.rdbtnName.Text = "Наименование";
			this.rdbtnName.UseVisualStyleBackColor = true;
			// 
			// rdbtnAddress
			// 
			this.rdbtnAddress.AutoSize = true;
			this.rdbtnAddress.Location = new System.Drawing.Point(180, 51);
			this.rdbtnAddress.Name = "rdbtnAddress";
			this.rdbtnAddress.Size = new System.Drawing.Size(56, 17);
			this.rdbtnAddress.TabIndex = 15;
			this.rdbtnAddress.TabStop = true;
			this.rdbtnAddress.Text = "Адрес";
			this.rdbtnAddress.UseVisualStyleBackColor = true;
			// 
			// txbDurationDebt
			// 
			this.txbDurationDebt.Location = new System.Drawing.Point(124, 134);
			this.txbDurationDebt.Name = "txbDurationDebt";
			this.txbDurationDebt.Size = new System.Drawing.Size(104, 20);
			this.txbDurationDebt.TabIndex = 16;
			this.txbDurationDebt.TextChanged += new System.EventHandler(this.txbDurationDebt_TextChanged);
			this.txbDurationDebt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbDurationDebt_KeyPress);
			// 
			// lblDurationDebt
			// 
			this.lblDurationDebt.AutoSize = true;
			this.lblDurationDebt.Location = new System.Drawing.Point(9, 137);
			this.lblDurationDebt.Name = "lblDurationDebt";
			this.lblDurationDebt.Size = new System.Drawing.Size(114, 13);
			this.lblDurationDebt.TabIndex = 17;
			this.lblDurationDebt.Text = "Срок задолженности";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(231, 115);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(30, 13);
			this.label5.TabIndex = 18;
			this.label5.Text = "(руб)";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(231, 137);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(33, 13);
			this.label6.TabIndex = 19;
			this.label6.Text = "(мес)";
			// 
			// gbAdvansedSearch
			// 
			this.gbAdvansedSearch.Controls.Add(this.label6);
			this.gbAdvansedSearch.Controls.Add(this.label5);
			this.gbAdvansedSearch.Controls.Add(this.lblDurationDebt);
			this.gbAdvansedSearch.Controls.Add(this.txbDurationDebt);
			this.gbAdvansedSearch.Controls.Add(this.rdbtnAddress);
			this.gbAdvansedSearch.Controls.Add(this.rdbtnName);
			this.gbAdvansedSearch.Controls.Add(this.label3);
			this.gbAdvansedSearch.Controls.Add(this.lblTypeId);
			this.gbAdvansedSearch.Controls.Add(this.cmbType);
			this.gbAdvansedSearch.Controls.Add(this.lblDebt);
			this.gbAdvansedSearch.Controls.Add(this.txbDebt);
			this.gbAdvansedSearch.Controls.Add(this.button1);
			this.gbAdvansedSearch.Controls.Add(this.txbKeyWord);
			this.gbAdvansedSearch.Location = new System.Drawing.Point(15, 75);
			this.gbAdvansedSearch.Name = "gbAdvansedSearch";
			this.gbAdvansedSearch.Size = new System.Drawing.Size(321, 177);
			this.gbAdvansedSearch.TabIndex = 6;
			this.gbAdvansedSearch.TabStop = false;
			this.gbAdvansedSearch.Text = "Расширенный поиск";
			this.gbAdvansedSearch.Visible = false;
			this.gbAdvansedSearch.Enter += new System.EventHandler(this.gbAdvansedSearch_Enter);
			// 
			// DebtsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1019, 542);
			this.Controls.Add(this.gbAdvansedSearch);
			this.Controls.Add(this.lblAdvancedSearch);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.tbSearch);
			this.Controls.Add(this.lblSearch);
			this.Controls.Add(this.dgvDebtors);
			this.Name = "DebtsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Дебиторская задолженность";
			this.Load += new System.EventHandler(this.DebtsForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvDebtors)).EndInit();
			this.contextMenuStrip.ResumeLayout(false);
			this.gbAdvansedSearch.ResumeLayout(false);
			this.gbAdvansedSearch.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvDebtors;
		private System.Windows.Forms.Label lblSearch;
		private System.Windows.Forms.TextBox tbSearch;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem miAddNewContragent;
		private System.Windows.Forms.ToolStripMenuItem miEditContragent;
		private System.Windows.Forms.ToolStripMenuItem miRemoveContragent;
		private System.Windows.Forms.LinkLabel lblAdvancedSearch;
		private System.Windows.Forms.TextBox txbKeyWord;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txbDebt;
		private System.Windows.Forms.Label lblDebt;
		private System.Windows.Forms.ComboBox cmbType;
		private System.Windows.Forms.Label lblTypeId;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RadioButton rdbtnName;
		private System.Windows.Forms.RadioButton rdbtnAddress;
		private System.Windows.Forms.TextBox txbDurationDebt;
		private System.Windows.Forms.Label lblDurationDebt;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox gbAdvansedSearch;
	}
}