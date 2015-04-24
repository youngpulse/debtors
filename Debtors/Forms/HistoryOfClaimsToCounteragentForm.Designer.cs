namespace Debtors.Forms
{
	partial class HistoryOfClaimsToCounteragentForm
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
			this.lblName = new System.Windows.Forms.Label();
			this.lblDateDebt = new System.Windows.Forms.Label();
			this.lblsumDebt = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.point = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(12, 24);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(37, 13);
			this.lblName.TabIndex = 0;
			this.lblName.Text = "ФИО:";
			// 
			// lblDateDebt
			// 
			this.lblDateDebt.AutoSize = true;
			this.lblDateDebt.Location = new System.Drawing.Point(212, 63);
			this.lblDateDebt.Name = "lblDateDebt";
			this.lblDateDebt.Size = new System.Drawing.Size(67, 13);
			this.lblDateDebt.TabIndex = 1;
			this.lblDateDebt.Text = "Срок долга:";
			// 
			// lblsumDebt
			// 
			this.lblsumDebt.AutoSize = true;
			this.lblsumDebt.Location = new System.Drawing.Point(12, 63);
			this.lblsumDebt.Name = "lblsumDebt";
			this.lblsumDebt.Size = new System.Drawing.Size(76, 13);
			this.lblsumDebt.TabIndex = 2;
			this.lblsumDebt.Text = "Сумма долга:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(62, 21);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(363, 20);
			this.textBox1.TabIndex = 3;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(94, 60);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(112, 20);
			this.textBox2.TabIndex = 4;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(285, 60);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(140, 20);
			this.textBox3.TabIndex = 5;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.point,
            this.date,
            this.description});
			this.dataGridView1.Location = new System.Drawing.Point(3, 89);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(422, 198);
			this.dataGridView1.TabIndex = 6;
			// 
			// point
			// 
			this.point.HeaderText = "Этап";
			this.point.Name = "point";
			// 
			// date
			// 
			this.date.HeaderText = "Дата";
			this.date.Name = "date";
			// 
			// description
			// 
			this.description.HeaderText = "Описание";
			this.description.Name = "description";
			// 
			// ClaimsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(437, 299);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.lblsumDebt);
			this.Controls.Add(this.lblDateDebt);
			this.Controls.Add(this.lblName);
			this.Name = "ClaimsForm";
			this.Text = "Претензионная работа";
			this.TopMost = true;
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblDateDebt;
		private System.Windows.Forms.Label lblsumDebt;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn point;
		private System.Windows.Forms.DataGridViewTextBoxColumn date;
		private System.Windows.Forms.DataGridViewTextBoxColumn description;
	}
}