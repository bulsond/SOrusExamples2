namespace WindowsFormsDGVDisconnected
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
            this._buttonSave = new System.Windows.Forms.Button();
            this._dataGridView = new System.Windows.Forms.DataGridView();
            this._columnCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._columnStreet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._columnBuilding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._columnApartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _buttonSave
            // 
            this._buttonSave.Location = new System.Drawing.Point(487, 262);
            this._buttonSave.Name = "_buttonSave";
            this._buttonSave.Size = new System.Drawing.Size(75, 23);
            this._buttonSave.TabIndex = 0;
            this._buttonSave.Text = "Сохранить";
            this._buttonSave.UseVisualStyleBackColor = true;
            // 
            // _dataGridView
            // 
            this._dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._columnCity,
            this._columnStreet,
            this._columnBuilding,
            this._columnApartment});
            this._dataGridView.Location = new System.Drawing.Point(12, 12);
            this._dataGridView.Name = "_dataGridView";
            this._dataGridView.Size = new System.Drawing.Size(550, 224);
            this._dataGridView.TabIndex = 1;
            // 
            // _columnCity
            // 
            this._columnCity.HeaderText = "Город";
            this._columnCity.Name = "_columnCity";
            // 
            // _columnStreet
            // 
            this._columnStreet.HeaderText = "Улица";
            this._columnStreet.Name = "_columnStreet";
            // 
            // _columnBuilding
            // 
            this._columnBuilding.HeaderText = "Дом";
            this._columnBuilding.Name = "_columnBuilding";
            // 
            // _columnApartment
            // 
            this._columnApartment.HeaderText = "Квартира";
            this._columnApartment.Name = "_columnApartment";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 309);
            this.Controls.Add(this._dataGridView);
            this.Controls.Add(this._buttonSave);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пример на DGV disconnected";
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _buttonSave;
        private System.Windows.Forms.DataGridView _dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn _columnCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn _columnStreet;
        private System.Windows.Forms.DataGridViewTextBoxColumn _columnBuilding;
        private System.Windows.Forms.DataGridViewTextBoxColumn _columnApartment;
    }
}

