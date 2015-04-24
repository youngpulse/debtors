namespace Debtors.Forms
{
	partial class OutboundClaims
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
			this.dgvClaimsJournal = new System.Windows.Forms.DataGridView();
			this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateClaim = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.inputNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameOrganization = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.addressOrg = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sumClaim = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.core = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateToAnswer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateFactAnswer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.disposeClaim = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.claimAccept = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateDocPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.numDocPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvClaimsJournal)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvClaimsJournal
			// 
			this.dgvClaimsJournal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvClaimsJournal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvClaimsJournal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.dateClaim,
            this.inputNumber,
            this.nameOrganization,
            this.addressOrg,
            this.sumClaim,
            this.core,
            this.dateToAnswer,
            this.nameDepartment,
            this.dateFactAnswer,
            this.disposeClaim,
            this.claimAccept,
            this.dateDocPayment,
            this.numDocPayment});
			this.dgvClaimsJournal.Location = new System.Drawing.Point(12, 12);
			this.dgvClaimsJournal.Name = "dgvClaimsJournal";
			this.dgvClaimsJournal.Size = new System.Drawing.Size(1054, 367);
			this.dgvClaimsJournal.TabIndex = 8;
			// 
			// num
			// 
			this.num.HeaderText = "№";
			this.num.Name = "num";
			this.num.ReadOnly = true;
			// 
			// dateClaim
			// 
			this.dateClaim.HeaderText = "Дата";
			this.dateClaim.Name = "dateClaim";
			// 
			// inputNumber
			// 
			this.inputNumber.HeaderText = "Номер претензии";
			this.inputNumber.Name = "inputNumber";
			// 
			// nameOrganization
			// 
			this.nameOrganization.HeaderText = "Организация";
			this.nameOrganization.Name = "nameOrganization";
			// 
			// addressOrg
			// 
			this.addressOrg.HeaderText = "Адрес";
			this.addressOrg.Name = "addressOrg";
			// 
			// sumClaim
			// 
			this.sumClaim.HeaderText = "Сумма";
			this.sumClaim.Name = "sumClaim";
			// 
			// core
			// 
			this.core.HeaderText = "Описание";
			this.core.Name = "core";
			// 
			// dateToAnswer
			// 
			this.dateToAnswer.HeaderText = "Ответить до";
			this.dateToAnswer.Name = "dateToAnswer";
			// 
			// nameDepartment
			// 
			this.nameDepartment.HeaderText = "Ответственное подразделение";
			this.nameDepartment.Name = "nameDepartment";
			// 
			// dateFactAnswer
			// 
			this.dateFactAnswer.HeaderText = "Дата ответа";
			this.dateFactAnswer.Name = "dateFactAnswer";
			// 
			// disposeClaim
			// 
			this.disposeClaim.HeaderText = "Отклонена в размере (сумма)";
			this.disposeClaim.Name = "disposeClaim";
			// 
			// claimAccept
			// 
			this.claimAccept.HeaderText = "Принята в размере (сумма)";
			this.claimAccept.Name = "claimAccept";
			// 
			// dateDocPayment
			// 
			this.dateDocPayment.HeaderText = "Дата оплаты";
			this.dateDocPayment.Name = "dateDocPayment";
			// 
			// numDocPayment
			// 
			this.numDocPayment.HeaderText = "Номер платежного документа";
			this.numDocPayment.Name = "numDocPayment";
			// 
			// OutboundClaims
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1113, 483);
			this.Controls.Add(this.dgvClaimsJournal);
			this.Name = "OutboundClaims";
			this.Text = "OutboundClaims";
			((System.ComponentModel.ISupportInitialize)(this.dgvClaimsJournal)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvClaimsJournal;
		private System.Windows.Forms.DataGridViewTextBoxColumn num;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateClaim;
		private System.Windows.Forms.DataGridViewTextBoxColumn inputNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameOrganization;
		private System.Windows.Forms.DataGridViewTextBoxColumn addressOrg;
		private System.Windows.Forms.DataGridViewTextBoxColumn sumClaim;
		private System.Windows.Forms.DataGridViewTextBoxColumn core;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateToAnswer;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDepartment;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateFactAnswer;
		private System.Windows.Forms.DataGridViewTextBoxColumn disposeClaim;
		private System.Windows.Forms.DataGridViewTextBoxColumn claimAccept;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateDocPayment;
		private System.Windows.Forms.DataGridViewTextBoxColumn numDocPayment;
	}
}