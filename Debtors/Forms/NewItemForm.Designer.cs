namespace Debtors.Forms
{
	partial class NewItemForm
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
			this.txbName = new System.Windows.Forms.TextBox();
			this.dtpDate = new System.Windows.Forms.DateTimePicker();
			this.lblDate = new System.Windows.Forms.Label();
			this.txbDescription = new System.Windows.Forms.RichTextBox();
			this.lblDescripsion = new System.Windows.Forms.Label();
			this.flpanel = new System.Windows.Forms.FlowLayoutPanel();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.flpanel.SuspendLayout();
			this.SuspendLayout();
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
			// txbName
			// 
			this.txbName.Location = new System.Drawing.Point(3, 16);
			this.txbName.Name = "txbName";
			this.txbName.Size = new System.Drawing.Size(258, 20);
			this.txbName.TabIndex = 1;
			// 
			// dtpDate
			// 
			this.dtpDate.Location = new System.Drawing.Point(3, 55);
			this.dtpDate.Name = "dtpDate";
			this.dtpDate.Size = new System.Drawing.Size(200, 20);
			this.dtpDate.TabIndex = 2;
			// 
			// lblDate
			// 
			this.lblDate.AutoSize = true;
			this.lblDate.Location = new System.Drawing.Point(3, 39);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(33, 13);
			this.lblDate.TabIndex = 3;
			this.lblDate.Text = "Дата";
			// 
			// txbDescription
			// 
			this.txbDescription.Location = new System.Drawing.Point(3, 94);
			this.txbDescription.Name = "txbDescription";
			this.txbDescription.Size = new System.Drawing.Size(258, 103);
			this.txbDescription.TabIndex = 4;
			this.txbDescription.Text = "";
			// 
			// lblDescripsion
			// 
			this.lblDescripsion.AutoSize = true;
			this.lblDescripsion.Location = new System.Drawing.Point(3, 78);
			this.lblDescripsion.Name = "lblDescripsion";
			this.lblDescripsion.Size = new System.Drawing.Size(57, 13);
			this.lblDescripsion.TabIndex = 5;
			this.lblDescripsion.Text = "Описание";
			// 
			// flpanel
			// 
			this.flpanel.Controls.Add(this.lblName);
			this.flpanel.Controls.Add(this.txbName);
			this.flpanel.Controls.Add(this.lblDate);
			this.flpanel.Controls.Add(this.dtpDate);
			this.flpanel.Controls.Add(this.lblDescripsion);
			this.flpanel.Controls.Add(this.txbDescription);
			this.flpanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.flpanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flpanel.Location = new System.Drawing.Point(0, 0);
			this.flpanel.Name = "flpanel";
			this.flpanel.Size = new System.Drawing.Size(265, 209);
			this.flpanel.TabIndex = 6;
			// 
			// btnOK
			// 
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Location = new System.Drawing.Point(186, 215);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 7;
			this.btnOK.Text = "ОК";
			this.btnOK.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(105, 215);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 8;
			this.btnCancel.Text = "Отмена";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// ItemForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(265, 240);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.flpanel);
			this.Name = "ItemForm";
			this.Text = "Новая запись";
			this.flpanel.ResumeLayout(false);
			this.flpanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.TextBox txbName;
		private System.Windows.Forms.DateTimePicker dtpDate;
		private System.Windows.Forms.Label lblDate;
		private System.Windows.Forms.RichTextBox txbDescription;
		private System.Windows.Forms.Label lblDescripsion;
		private System.Windows.Forms.FlowLayoutPanel flpanel;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
	}
}