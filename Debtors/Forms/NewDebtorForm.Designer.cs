namespace Debtors.Forms
{
	partial class NewDebtorForm
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
			this.lblType = new System.Windows.Forms.Label();
			this.btnOK = new System.Windows.Forms.Button();
			this.gbAboutContract = new System.Windows.Forms.GroupBox();
			this.dtpDateContract = new System.Windows.Forms.DateTimePicker();
			this.btnChangeCopyContract = new System.Windows.Forms.Button();
			this.lblContractInfo = new System.Windows.Forms.Label();
			this.txbCopyContract = new System.Windows.Forms.TextBox();
			this.txbContractInfo = new System.Windows.Forms.TextBox();
			this.lblCopyContract = new System.Windows.Forms.Label();
			this.lblDateContract = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.gbAboutCounteragent = new System.Windows.Forms.GroupBox();
			this.flpAboutCounteragent = new System.Windows.Forms.FlowLayoutPanel();
			this.cmbCounteragent = new System.Windows.Forms.ComboBox();
			this.lblTypeCounteragent = new System.Windows.Forms.Label();
			this.txbAddress = new System.Windows.Forms.TextBox();
			this.lblAddress = new System.Windows.Forms.Label();
			this.txbName = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.gbAboutDebt = new System.Windows.Forms.GroupBox();
			this.flpAboutDebt = new System.Windows.Forms.FlowLayoutPanel();
			this.lblDebt = new System.Windows.Forms.Label();
			this.txbDebt = new System.Windows.Forms.TextBox();
			this.lblStartDateTimeDebt = new System.Windows.Forms.Label();
			this.dtpStartDebt = new System.Windows.Forms.DateTimePicker();
			this.lblTermDebt = new System.Windows.Forms.Label();
			this.mtbTermDebt = new System.Windows.Forms.MaskedTextBox();
			this.gbAboutContract.SuspendLayout();
			this.gbAboutCounteragent.SuspendLayout();
			this.flpAboutCounteragent.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.flowLayoutPanel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.gbAboutDebt.SuspendLayout();
			this.flpAboutDebt.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblType
			// 
			this.lblType.AutoSize = true;
			this.lblType.Location = new System.Drawing.Point(15, 46);
			this.lblType.Name = "lblType";
			this.lblType.Size = new System.Drawing.Size(0, 13);
			this.lblType.TabIndex = 1;
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Location = new System.Drawing.Point(400, 3);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 11;
			this.btnOK.Text = "ОК";
			this.btnOK.UseVisualStyleBackColor = true;
			// 
			// gbAboutContract
			// 
			this.gbAboutContract.AutoSize = true;
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
			this.gbAboutContract.Size = new System.Drawing.Size(472, 98);
			this.gbAboutContract.TabIndex = 3;
			this.gbAboutContract.TabStop = false;
			this.gbAboutContract.Text = "Информация по договору";
			// 
			// dtpDateContract
			// 
			this.dtpDateContract.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpDateContract.Location = new System.Drawing.Point(332, 32);
			this.dtpDateContract.Name = "dtpDateContract";
			this.dtpDateContract.Size = new System.Drawing.Size(126, 20);
			this.dtpDateContract.TabIndex = 8;
			// 
			// btnChangeCopyContract
			// 
			this.btnChangeCopyContract.Location = new System.Drawing.Point(432, 67);
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
			this.txbCopyContract.Size = new System.Drawing.Size(420, 20);
			this.txbCopyContract.TabIndex = 9;
			// 
			// txbContractInfo
			// 
			this.txbContractInfo.Location = new System.Drawing.Point(6, 32);
			this.txbContractInfo.Name = "txbContractInfo";
			this.txbContractInfo.Size = new System.Drawing.Size(302, 20);
			this.txbContractInfo.TabIndex = 7;
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
			this.lblDateContract.Location = new System.Drawing.Point(332, 16);
			this.lblDateContract.Name = "lblDateContract";
			this.lblDateContract.Size = new System.Drawing.Size(97, 13);
			this.lblDateContract.TabIndex = 0;
			this.lblDateContract.Text = "Дата заключения";
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(319, 3);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 20;
			this.btnCancel.Text = "Отмена";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// gbAboutCounteragent
			// 
			this.gbAboutCounteragent.Controls.Add(this.flpAboutCounteragent);
			this.gbAboutCounteragent.Location = new System.Drawing.Point(3, 3);
			this.gbAboutCounteragent.Name = "gbAboutCounteragent";
			this.gbAboutCounteragent.Size = new System.Drawing.Size(323, 146);
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
			this.flpAboutCounteragent.Size = new System.Drawing.Size(305, 118);
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
			this.cmbCounteragent.Size = new System.Drawing.Size(299, 21);
			this.cmbCounteragent.TabIndex = 3;
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
			this.txbAddress.Size = new System.Drawing.Size(299, 20);
			this.txbAddress.TabIndex = 2;
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
			this.txbName.Size = new System.Drawing.Size(299, 20);
			this.txbName.TabIndex = 1;
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
			// panel1
			// 
			this.panel1.Controls.Add(this.btnCancel);
			this.panel1.Controls.Add(this.btnOK);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 259);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(485, 35);
			this.panel1.TabIndex = 24;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.gbAboutContract);
			this.panel3.Location = new System.Drawing.Point(3, 155);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(472, 98);
			this.panel3.TabIndex = 25;
			// 
			// flowLayoutPanel3
			// 
			this.flowLayoutPanel3.Controls.Add(this.gbAboutCounteragent);
			this.flowLayoutPanel3.Controls.Add(this.panel2);
			this.flowLayoutPanel3.Controls.Add(this.panel3);
			this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel3.Name = "flowLayoutPanel3";
			this.flowLayoutPanel3.Size = new System.Drawing.Size(485, 261);
			this.flowLayoutPanel3.TabIndex = 26;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.gbAboutDebt);
			this.panel2.Location = new System.Drawing.Point(332, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(146, 146);
			this.panel2.TabIndex = 20;
			// 
			// gbAboutDebt
			// 
			this.gbAboutDebt.Controls.Add(this.flpAboutDebt);
			this.gbAboutDebt.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbAboutDebt.Location = new System.Drawing.Point(0, 0);
			this.gbAboutDebt.Name = "gbAboutDebt";
			this.gbAboutDebt.Size = new System.Drawing.Size(146, 146);
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
			this.flpAboutDebt.Size = new System.Drawing.Size(140, 127);
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
			this.lblDebt.Size = new System.Drawing.Size(123, 13);
			this.lblDebt.TabIndex = 0;
			this.lblDebt.Text = "Сумма (руб)";
			// 
			// txbDebt
			// 
			this.txbDebt.Location = new System.Drawing.Point(3, 16);
			this.txbDebt.Name = "txbDebt";
			this.txbDebt.Size = new System.Drawing.Size(123, 20);
			this.txbDebt.TabIndex = 4;
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
			this.dtpStartDebt.Size = new System.Drawing.Size(123, 20);
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
			this.mtbTermDebt.Location = new System.Drawing.Point(3, 94);
			this.mtbTermDebt.Mask = "00";
			this.mtbTermDebt.Name = "mtbTermDebt";
			this.mtbTermDebt.Size = new System.Drawing.Size(123, 20);
			this.mtbTermDebt.TabIndex = 6;
			// 
			// DebtorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(485, 294);
			this.Controls.Add(this.flowLayoutPanel3);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.lblType);
			this.MinimumSize = new System.Drawing.Size(501, 332);
			this.Name = "DebtorForm";
			this.Text = "Новый контрагент";
			this.Load += new System.EventHandler(this.DebtorForm_Load);
			this.gbAboutContract.ResumeLayout(false);
			this.gbAboutContract.PerformLayout();
			this.gbAboutCounteragent.ResumeLayout(false);
			this.gbAboutCounteragent.PerformLayout();
			this.flpAboutCounteragent.ResumeLayout(false);
			this.flpAboutCounteragent.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.flowLayoutPanel3.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.gbAboutDebt.ResumeLayout(false);
			this.gbAboutDebt.PerformLayout();
			this.flpAboutDebt.ResumeLayout(false);
			this.flpAboutDebt.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblType;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.GroupBox gbAboutContract;
		private System.Windows.Forms.DateTimePicker dtpDateContract;
		private System.Windows.Forms.Button btnChangeCopyContract;
		private System.Windows.Forms.Label lblContractInfo;
		private System.Windows.Forms.TextBox txbCopyContract;
		private System.Windows.Forms.TextBox txbContractInfo;
		private System.Windows.Forms.Label lblCopyContract;
		private System.Windows.Forms.Label lblDateContract;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.GroupBox gbAboutCounteragent;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
		private System.Windows.Forms.FlowLayoutPanel flpAboutCounteragent;
		private System.Windows.Forms.ComboBox cmbCounteragent;
		private System.Windows.Forms.Label lblTypeCounteragent;
		private System.Windows.Forms.TextBox txbAddress;
		private System.Windows.Forms.Label lblAddress;
		private System.Windows.Forms.TextBox txbName;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.GroupBox gbAboutDebt;
		private System.Windows.Forms.FlowLayoutPanel flpAboutDebt;
		private System.Windows.Forms.Label lblDebt;
		private System.Windows.Forms.TextBox txbDebt;
		private System.Windows.Forms.Label lblStartDateTimeDebt;
		private System.Windows.Forms.Label lblTermDebt;
		private System.Windows.Forms.DateTimePicker dtpStartDebt;
		private System.Windows.Forms.MaskedTextBox mtbTermDebt;
	}
}