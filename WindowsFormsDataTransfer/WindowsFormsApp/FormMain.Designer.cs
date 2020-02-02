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
            this._dataGridView = new System.Windows.Forms.DataGridView();
            this._buttonOpenInput = new System.Windows.Forms.Button();
            this._columnOrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._columnLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._columnFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _dataGridView
            // 
            this._dataGridView.AllowUserToAddRows = false;
            this._dataGridView.AllowUserToDeleteRows = false;
            this._dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._columnOrderNumber,
            this._columnLastName,
            this._columnFirstName});
            this._dataGridView.Location = new System.Drawing.Point(12, 12);
            this._dataGridView.Name = "_dataGridView";
            this._dataGridView.ReadOnly = true;
            this._dataGridView.Size = new System.Drawing.Size(444, 150);
            this._dataGridView.TabIndex = 0;
            // 
            // _buttonOpenInput
            // 
            this._buttonOpenInput.Location = new System.Drawing.Point(200, 181);
            this._buttonOpenInput.Name = "_buttonOpenInput";
            this._buttonOpenInput.Size = new System.Drawing.Size(75, 23);
            this._buttonOpenInput.TabIndex = 1;
            this._buttonOpenInput.Text = "Добавить";
            this._buttonOpenInput.UseVisualStyleBackColor = true;
            // 
            // _columnOrderNumber
            // 
            this._columnOrderNumber.HeaderText = "Порядк.номер";
            this._columnOrderNumber.Name = "_columnOrderNumber";
            this._columnOrderNumber.ReadOnly = true;
            // 
            // _columnLastName
            // 
            this._columnLastName.HeaderText = "Фамилия";
            this._columnLastName.Name = "_columnLastName";
            this._columnLastName.ReadOnly = true;
            this._columnLastName.Width = 150;
            // 
            // _columnFirstName
            // 
            this._columnFirstName.HeaderText = "Имя";
            this._columnFirstName.Name = "_columnFirstName";
            this._columnFirstName.ReadOnly = true;
            this._columnFirstName.Width = 150;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 227);
            this.Controls.Add(this._buttonOpenInput);
            this.Controls.Add(this._dataGridView);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пример передачи данных между формами";
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView _dataGridView;
        private System.Windows.Forms.Button _buttonOpenInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn _columnOrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn _columnLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn _columnFirstName;
    }
}

