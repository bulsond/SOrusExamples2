namespace WindowsFormsApp
{
    partial class FormMain
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
            this.label1 = new System.Windows.Forms.Label();
            this._comboBoxType = new System.Windows.Forms.ComboBox();
            this._dataGridView = new System.Windows.Forms.DataGridView();
            this._columnTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._columnYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._columnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._columnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "кузов";
            // 
            // _comboBoxType
            // 
            this._comboBoxType.FormattingEnabled = true;
            this._comboBoxType.Location = new System.Drawing.Point(68, 43);
            this._comboBoxType.Name = "_comboBoxType";
            this._comboBoxType.Size = new System.Drawing.Size(148, 21);
            this._comboBoxType.TabIndex = 1;
            // 
            // _dataGridView
            // 
            this._dataGridView.AllowUserToAddRows = false;
            this._dataGridView.AllowUserToDeleteRows = false;
            this._dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._columnTitle,
            this._columnYear,
            this._columnType,
            this._columnPrice});
            this._dataGridView.Location = new System.Drawing.Point(236, 43);
            this._dataGridView.Name = "_dataGridView";
            this._dataGridView.ReadOnly = true;
            this._dataGridView.Size = new System.Drawing.Size(452, 150);
            this._dataGridView.TabIndex = 2;
            // 
            // _columnTitle
            // 
            this._columnTitle.HeaderText = "Название";
            this._columnTitle.Name = "_columnTitle";
            this._columnTitle.ReadOnly = true;
            // 
            // _columnYear
            // 
            this._columnYear.HeaderText = "Год";
            this._columnYear.Name = "_columnYear";
            this._columnYear.ReadOnly = true;
            // 
            // _columnType
            // 
            this._columnType.HeaderText = "Кузов";
            this._columnType.Name = "_columnType";
            this._columnType.ReadOnly = true;
            // 
            // _columnPrice
            // 
            this._columnPrice.HeaderText = "Цена";
            this._columnPrice.Name = "_columnPrice";
            this._columnPrice.ReadOnly = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 242);
            this.Controls.Add(this._dataGridView);
            this.Controls.Add(this._comboBoxType);
            this.Controls.Add(this.label1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пример";
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _comboBoxType;
        private System.Windows.Forms.DataGridView _dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn _columnTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn _columnYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn _columnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn _columnPrice;
    }
}

