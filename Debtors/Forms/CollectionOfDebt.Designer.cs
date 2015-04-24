namespace Debtors.Forms
{
	partial class CollectionOfDebt
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CollectionOfDebt));
			this.dgvHistory = new System.Windows.Forms.DataGridView();
			this.lblType = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.gbAboutContract = new System.Windows.Forms.GroupBox();
			this.btnLoadScan = new System.Windows.Forms.Button();
			this.cbScanContract = new System.Windows.Forms.CheckBox();
			this.btnLoadScanContract = new System.Windows.Forms.Button();
			this.dtpDateContract = new System.Windows.Forms.DateTimePicker();
			this.btnChangeCopyContract = new System.Windows.Forms.Button();
			this.lblContractInfo = new System.Windows.Forms.Label();
			this.txbCopyContract = new System.Windows.Forms.TextBox();
			this.txbContractInfo = new System.Windows.Forms.TextBox();
			this.lblCopyContract = new System.Windows.Forms.Label();
			this.lblDateContract = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.gbAboutDebt = new System.Windows.Forms.GroupBox();
			this.flpAboutDebt = new System.Windows.Forms.FlowLayoutPanel();
			this.lblDebt = new System.Windows.Forms.Label();
			this.txbDebt = new System.Windows.Forms.TextBox();
			this.lblStartDateTimeDebt = new System.Windows.Forms.Label();
			this.dtpStartDebt = new System.Windows.Forms.DateTimePicker();
			this.lblTermDebt = new System.Windows.Forms.Label();
			this.mtbTermDebt = new System.Windows.Forms.MaskedTextBox();
			this.gbAboutCounteragent = new System.Windows.Forms.GroupBox();
			this.flpAboutCounteragent = new System.Windows.Forms.FlowLayoutPanel();
			this.cmbCounteragent = new System.Windows.Forms.ComboBox();
			this.lblTypeCounteragent = new System.Windows.Forms.Label();
			this.txbAddress = new System.Windows.Forms.TextBox();
			this.lblAddress = new System.Windows.Forms.Label();
			this.txbName = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.panel = new System.Windows.Forms.Panel();
			this.bindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
			this.panel3.SuspendLayout();
			this.gbAboutContract.SuspendLayout();
			this.panel2.SuspendLayout();
			this.gbAboutDebt.SuspendLayout();
			this.flpAboutDebt.SuspendLayout();
			this.gbAboutCounteragent.SuspendLayout();
			this.flpAboutCounteragent.SuspendLayout();
			this.flowLayoutPanel3.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).BeginInit();
			this.bindingNavigator.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvHistory
			// 
			this.dgvHistory.AllowUserToAddRows = false;
			this.dgvHistory.AllowUserToDeleteRows = false;
			this.dgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvHistory.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvHistory.Location = new System.Drawing.Point(0, 0);
			this.dgvHistory.Name = "dgvHistory";
			this.dgvHistory.Size = new System.Drawing.Size(561, 181);
			this.dgvHistory.TabIndex = 99;
			// 
			// lblType
			// 
			this.lblType.AutoSize = true;
			this.lblType.Location = new System.Drawing.Point(15, 46);
			this.lblType.Name = "lblType";
			this.lblType.Size = new System.Drawing.Size(0, 13);
			this.lblType.TabIndex = 27;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.gbAboutContract);
			this.panel3.Location = new System.Drawing.Point(3, 155);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(552, 98);
			this.panel3.TabIndex = 25;
			// 
			// gbAboutContract
			// 
			this.gbAboutContract.AutoSize = true;
			this.gbAboutContract.Controls.Add(this.btnLoadScan);
			this.gbAboutContract.Controls.Add(this.cbScanContract);
			this.gbAboutContract.Controls.Add(this.btnLoadScanContract);
			this.gbAboutContract.Controls.Add(this.dtpDateContract);
			this.gbAboutContract.Controls.Add(this.btnChangeCopyContract);
			this.gbAboutContract.Controls.Add(this.lblContractInfo);
			this.gbAboutContract.Controls.Add(this.txbCopyContract);
			this.gbAboutContract.Controls.Add(this.txbContractInfo);
			this.gbAboutContract.Controls.Add(this.lblCopyContract);
			this.gbAboutContract.Controls.Add(this.lblDateContract);
			this.gbAboutContract.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbAboutContract.Location = new System.Drawing.Point(0, 0);
			this.gbAboutContract.Name = "gbAboutContract";
			this.gbAboutContract.Size = new System.Drawing.Size(552, 98);
			this.gbAboutContract.TabIndex = 3;
			this.gbAboutContract.TabStop = false;
			this.gbAboutContract.Text = "Информация по договору";
			// 
			// btnLoadScan
			// 
			this.btnLoadScan.Location = new System.Drawing.Point(483, 68);
			this.btnLoadScan.Name = "btnLoadScan";
			this.btnLoadScan.Size = new System.Drawing.Size(66, 23);
			this.btnLoadScan.TabIndex = 13;
			this.btnLoadScan.Text = "Открыть";
			this.btnLoadScan.UseVisualStyleBackColor = true;
			this.btnLoadScan.Click += new System.EventHandler(this.btnLoadScan_Click);
			// 
			// cbScanContract
			// 
			this.cbScanContract.AutoSize = true;
			this.cbScanContract.Enabled = false;
			this.cbScanContract.Location = new System.Drawing.Point(372, 70);
			this.cbScanContract.Name = "cbScanContract";
			this.cbScanContract.Size = new System.Drawing.Size(114, 17);
			this.cbScanContract.TabIndex = 12;
			this.cbScanContract.Text = "Копия документа";
			this.cbScanContract.UseVisualStyleBackColor = true;
			// 
			// btnLoadScanContract
			// 
			this.btnLoadScanContract.Location = new System.Drawing.Point(269, 68);
			this.btnLoadScanContract.Name = "btnLoadScanContract";
			this.btnLoadScanContract.Size = new System.Drawing.Size(82, 23);
			this.btnLoadScanContract.TabIndex = 11;
			this.btnLoadScanContract.Text = "Прикрепить";
			this.btnLoadScanContract.UseVisualStyleBackColor = true;
			this.btnLoadScanContract.Click += new System.EventHandler(this.btnLoadScanContract_Click);
			// 
			// dtpDateContract
			// 
			this.dtpDateContract.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpDateContract.Location = new System.Drawing.Point(369, 32);
			this.dtpDateContract.Name = "dtpDateContract";
			this.dtpDateContract.Size = new System.Drawing.Size(162, 20);
			this.dtpDateContract.TabIndex = 8;
			this.dtpDateContract.ValueChanged += new System.EventHandler(this.dtpDateContract_ValueChanged);
			// 
			// btnChangeCopyContract
			// 
			this.btnChangeCopyContract.Location = new System.Drawing.Point(237, 68);
			this.btnChangeCopyContract.Name = "btnChangeCopyContract";
			this.btnChangeCopyContract.Size = new System.Drawing.Size(26, 23);
			this.btnChangeCopyContract.TabIndex = 10;
			this.btnChangeCopyContract.Text = "...";
			this.btnChangeCopyContract.UseVisualStyleBackColor = true;
			this.btnChangeCopyContract.Click += new System.EventHandler(this.btnChangeCopyContract_Click);
			// 
			// lblContractInfo
			// 
			this.lblContractInfo.AutoSize = true;
			this.lblContractInfo.Location = new System.Drawing.Point(6, 16);
			this.lblContractInfo.Name = "lblContractInfo";
			this.lblContractInfo.Size = new System.Drawing.Size(68, 13);
			this.lblContractInfo.TabIndex = 0;
			this.lblContractInfo.Text = "№ договора";
			// 
			// txbCopyContract
			// 
			this.txbCopyContract.Location = new System.Drawing.Point(6, 70);
			this.txbCopyContract.Name = "txbCopyContract";
			this.txbCopyContract.Size = new System.Drawing.Size(225, 20);
			this.txbCopyContract.TabIndex = 9;
			// 
			// txbContractInfo
			// 
			this.txbContractInfo.Location = new System.Drawing.Point(6, 32);
			this.txbContractInfo.Name = "txbContractInfo";
			this.txbContractInfo.Size = new System.Drawing.Size(345, 20);
			this.txbContractInfo.TabIndex = 7;
			this.txbContractInfo.TextChanged += new System.EventHandler(this.txbContractInfo_TextChanged);
			// 
			// lblCopyContract
			// 
			this.lblCopyContract.AutoSize = true;
			this.lblCopyContract.Location = new System.Drawing.Point(6, 55);
			this.lblCopyContract.Name = "lblCopyContract";
			this.lblCopyContract.Size = new System.Drawing.Size(95, 13);
			this.lblCopyContract.TabIndex = 0;
			this.lblCopyContract.Text = "Копия документа";
			// 
			// lblDateContract
			// 
			this.lblDateContract.AutoSize = true;
			this.lblDateContract.Location = new System.Drawing.Point(369, 16);
			this.lblDateContract.Name = "lblDateContract";
			this.lblDateContract.Size = new System.Drawing.Size(97, 13);
			this.lblDateContract.TabIndex = 0;
			this.lblDateContract.Text = "Дата заключения";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.gbAboutDebt);
			this.panel2.Location = new System.Drawing.Point(366, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(189, 146);
			this.panel2.TabIndex = 20;
			// 
			// gbAboutDebt
			// 
			this.gbAboutDebt.Controls.Add(this.flpAboutDebt);
			this.gbAboutDebt.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbAboutDebt.Location = new System.Drawing.Point(0, 0);
			this.gbAboutDebt.Name = "gbAboutDebt";
			this.gbAboutDebt.Size = new System.Drawing.Size(189, 146);
			this.gbAboutDebt.TabIndex = 2;
			this.gbAboutDebt.TabStop = false;
			this.gbAboutDebt.Text = "Задолженность";
			// 
			// flpAboutDebt
			// 
			this.flpAboutDebt.AutoSize = true;
			this.flpAboutDebt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flpAboutDebt.Controls.Add(this.lblDebt);
			this.flpAboutDebt.Controls.Add(this.txbDebt);
			this.flpAboutDebt.Controls.Add(this.lblStartDateTimeDebt);
			this.flpAboutDebt.Controls.Add(this.dtpStartDebt);
			this.flpAboutDebt.Controls.Add(this.lblTermDebt);
			this.flpAboutDebt.Controls.Add(this.mtbTermDebt);
			this.flpAboutDebt.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flpAboutDebt.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flpAboutDebt.Location = new System.Drawing.Point(3, 16);
			this.flpAboutDebt.Name = "flpAboutDebt";
			this.flpAboutDebt.Size = new System.Drawing.Size(183, 127);
			this.flpAboutDebt.TabIndex = 22;
			// 
			// lblDebt
			// 
			this.lblDebt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblDebt.AutoSize = true;
			this.lblDebt.Location = new System.Drawing.Point(3, 0);
			this.lblDebt.Name = "lblDebt";
			this.lblDebt.Size = new System.Drawing.Size(162, 13);
			this.lblDebt.TabIndex = 0;
			this.lblDebt.Text = "Сумма (руб)";
			// 
			// txbDebt
			// 
			this.txbDebt.Location = new System.Drawing.Point(3, 16);
			this.txbDebt.Name = "txbDebt";
			this.txbDebt.Size = new System.Drawing.Size(162, 20);
			this.txbDebt.TabIndex = 4;
			this.txbDebt.TextChanged += new System.EventHandler(this.txbDebt_TextChanged);
			this.txbDebt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbDebt_KeyPress);
			// 
			// lblStartDateTimeDebt
			// 
			this.lblStartDateTimeDebt.AutoSize = true;
			this.lblStartDateTimeDebt.Location = new System.Drawing.Point(3, 39);
			this.lblStartDateTimeDebt.Name = "lblStartDateTimeDebt";
			this.lblStartDateTimeDebt.Size = new System.Drawing.Size(44, 13);
			this.lblStartDateTimeDebt.TabIndex = 0;
			this.lblStartDateTimeDebt.Text = "Начало";
			// 
			// dtpStartDebt
			// 
			this.dtpStartDebt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpStartDebt.Location = new System.Drawing.Point(3, 55);
			this.dtpStartDebt.Name = "dtpStartDebt";
			this.dtpStartDebt.Size = new System.Drawing.Size(162, 20);
			this.dtpStartDebt.TabIndex = 5;
			this.dtpStartDebt.ValueChanged += new System.EventHandler(this.dtpStartDebt_ValueChanged);
			// 
			// lblTermDebt
			// 
			this.lblTermDebt.AutoSize = true;
			this.lblTermDebt.Location = new System.Drawing.Point(3, 78);
			this.lblTermDebt.Name = "lblTermDebt";
			this.lblTermDebt.Size = new System.Drawing.Size(61, 13);
			this.lblTermDebt.TabIndex = 0;
			this.lblTermDebt.Text = "Срок (мес)";
			// 
			// mtbTermDebt
			// 
			this.mtbTermDebt.Enabled = false;
			this.mtbTermDebt.Location = new System.Drawing.Point(3, 94);
			this.mtbTermDebt.Mask = "00";
			this.mtbTermDebt.Name = "mtbTermDebt";
			this.mtbTermDebt.Size = new System.Drawing.Size(162, 20);
			this.mtbTermDebt.TabIndex = 6;
			// 
			// gbAboutCounteragent
			// 
			this.gbAboutCounteragent.Controls.Add(this.flpAboutCounteragent);
			this.gbAboutCounteragent.Location = new System.Drawing.Point(3, 3);
			this.gbAboutCounteragent.Name = "gbAboutCounteragent";
			this.gbAboutCounteragent.Size = new System.Drawing.Size(357, 146);
			this.gbAboutCounteragent.TabIndex = 1;
			this.gbAboutCounteragent.TabStop = false;
			this.gbAboutCounteragent.Text = "Общие сведения";
			// 
			// flpAboutCounteragent
			// 
			this.flpAboutCounteragent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.flpAboutCounteragent.AutoSize = true;
			this.flpAboutCounteragent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flpAboutCounteragent.Controls.Add(this.cmbCounteragent);
			this.flpAboutCounteragent.Controls.Add(this.lblTypeCounteragent);
			this.flpAboutCounteragent.Controls.Add(this.txbAddress);
			this.flpAboutCounteragent.Controls.Add(this.lblAddress);
			this.flpAboutCounteragent.Controls.Add(this.txbName);
			this.flpAboutCounteragent.Controls.Add(this.lblName);
			this.flpAboutCounteragent.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
			this.flpAboutCounteragent.Location = new System.Drawing.Point(6, 16);
			this.flpAboutCounteragent.Name = "flpAboutCounteragent";
			this.flpAboutCounteragent.Size = new System.Drawing.Size(348, 118);
			this.flpAboutCounteragent.TabIndex = 19;
			// 
			// cmbCounteragent
			// 
			this.cmbCounteragent.FormattingEnabled = true;
			this.cmbCounteragent.Items.AddRange(new object[] {
            "Юридическое лицо",
            "Физическое лицо"});
			this.cmbCounteragent.Location = new System.Drawing.Point(3, 94);
			this.cmbCounteragent.Name = "cmbCounteragent";
			this.cmbCounteragent.Size = new System.Drawing.Size(342, 21);
			this.cmbCounteragent.TabIndex = 3;
			this.cmbCounteragent.TextChanged += new System.EventHandler(this.cmbCounteragent_TextChanged);
			// 
			// lblTypeCounteragent
			// 
			this.lblTypeCounteragent.AutoSize = true;
			this.lblTypeCounteragent.Location = new System.Drawing.Point(3, 78);
			this.lblTypeCounteragent.Name = "lblTypeCounteragent";
			this.lblTypeCounteragent.Size = new System.Drawing.Size(26, 13);
			this.lblTypeCounteragent.TabIndex = 0;
			this.lblTypeCounteragent.Text = "Тип";
			// 
			// txbAddress
			// 
			this.txbAddress.Location = new System.Drawing.Point(3, 55);
			this.txbAddress.Name = "txbAddress";
			this.txbAddress.Size = new System.Drawing.Size(342, 20);
			this.txbAddress.TabIndex = 2;
			this.txbAddress.TextChanged += new System.EventHandler(this.txbAddress_TextChanged);
			// 
			// lblAddress
			// 
			this.lblAddress.AutoSize = true;
			this.lblAddress.Location = new System.Drawing.Point(3, 39);
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Size = new System.Drawing.Size(38, 13);
			this.lblAddress.TabIndex = 0;
			this.lblAddress.Text = "Адрес";
			// 
			// txbName
			// 
			this.txbName.Location = new System.Drawing.Point(3, 16);
			this.txbName.Name = "txbName";
			this.txbName.Size = new System.Drawing.Size(342, 20);
			this.txbName.TabIndex = 1;
			this.txbName.TextChanged += new System.EventHandler(this.txbName_TextChanged);
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(3, 0);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(83, 13);
			this.lblName.TabIndex = 0;
			this.lblName.Text = "Наименование";
			// 
			// flowLayoutPanel3
			// 
			this.flowLayoutPanel3.Controls.Add(this.gbAboutCounteragent);
			this.flowLayoutPanel3.Controls.Add(this.panel2);
			this.flowLayoutPanel3.Controls.Add(this.panel3);
			this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel3.Name = "flowLayoutPanel3";
			this.flowLayoutPanel3.Size = new System.Drawing.Size(561, 261);
			this.flowLayoutPanel3.TabIndex = 29;
			// 
			// btnOK
			// 
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Location = new System.Drawing.Point(483, 3);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 0;
			this.btnOK.Text = "Сохранить";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(402, 3);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Отмена";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.btnOK);
			this.flowLayoutPanel1.Controls.Add(this.btnCancel);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 152);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.flowLayoutPanel1.Size = new System.Drawing.Size(561, 29);
			this.flowLayoutPanel1.TabIndex = 30;
			// 
			// panel
			// 
			this.panel.Controls.Add(this.flowLayoutPanel1);
			this.panel.Controls.Add(this.dgvHistory);
			this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel.Location = new System.Drawing.Point(0, 261);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(561, 181);
			this.panel.TabIndex = 2;
			// 
			// bindingNavigator
			// 
			this.bindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.bindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.bindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.bindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
			this.bindingNavigator.Location = new System.Drawing.Point(0, 261);
			this.bindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.bindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.bindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.bindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.bindingNavigator.Name = "bindingNavigator";
			this.bindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.bindingNavigator.Size = new System.Drawing.Size(561, 25);
			this.bindingNavigator.TabIndex = 30;
			this.bindingNavigator.Text = "bindingNavigator1";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveFirstItem.Text = "Move first";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMovePreviousItem.Text = "Move previous";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Position";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Current position";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
			this.bindingNavigatorCountItem.Text = "of {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveNextItem.Text = "Move next";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveLastItem.Text = "Move last";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorAddNewItem.Text = "Add new";
			this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorDeleteItem.Text = "Delete";
			this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
			// 
			// CollectionOfDebt
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(561, 442);
			this.Controls.Add(this.bindingNavigator);
			this.Controls.Add(this.panel);
			this.Controls.Add(this.flowLayoutPanel3);
			this.Controls.Add(this.lblType);
			this.Name = "CollectionOfDebt";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Взыскание задолженности";
			this.TopMost = true;
			((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.gbAboutContract.ResumeLayout(false);
			this.gbAboutContract.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.gbAboutDebt.ResumeLayout(false);
			this.gbAboutDebt.PerformLayout();
			this.flpAboutDebt.ResumeLayout(false);
			this.flpAboutDebt.PerformLayout();
			this.gbAboutCounteragent.ResumeLayout(false);
			this.gbAboutCounteragent.PerformLayout();
			this.flpAboutCounteragent.ResumeLayout(false);
			this.flpAboutCounteragent.PerformLayout();
			this.flowLayoutPanel3.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).EndInit();
			this.bindingNavigator.ResumeLayout(false);
			this.bindingNavigator.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvHistory;
		private System.Windows.Forms.Label lblType;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.GroupBox gbAboutContract;
		private System.Windows.Forms.DateTimePicker dtpDateContract;
		private System.Windows.Forms.Button btnChangeCopyContract;
		private System.Windows.Forms.Label lblContractInfo;
		private System.Windows.Forms.TextBox txbCopyContract;
		private System.Windows.Forms.TextBox txbContractInfo;
		private System.Windows.Forms.Label lblCopyContract;
		private System.Windows.Forms.Label lblDateContract;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.GroupBox gbAboutDebt;
		private System.Windows.Forms.FlowLayoutPanel flpAboutDebt;
		private System.Windows.Forms.Label lblDebt;
		private System.Windows.Forms.TextBox txbDebt;
		private System.Windows.Forms.Label lblStartDateTimeDebt;
		private System.Windows.Forms.DateTimePicker dtpStartDebt;
		private System.Windows.Forms.Label lblTermDebt;
		private System.Windows.Forms.MaskedTextBox mtbTermDebt;
		private System.Windows.Forms.GroupBox gbAboutCounteragent;
		private System.Windows.Forms.FlowLayoutPanel flpAboutCounteragent;
		private System.Windows.Forms.ComboBox cmbCounteragent;
		private System.Windows.Forms.Label lblTypeCounteragent;
		private System.Windows.Forms.TextBox txbAddress;
		private System.Windows.Forms.Label lblAddress;
		private System.Windows.Forms.TextBox txbName;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
		private System.Windows.Forms.Button btnLoadScanContract;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Panel panel;
		private System.Windows.Forms.CheckBox cbScanContract;
		private System.Windows.Forms.Button btnLoadScan;
		private System.Windows.Forms.BindingNavigator bindingNavigator;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
	}
}