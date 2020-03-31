namespace WindowsFormsApp
{
    partial class FormCars
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
            this._columnModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._columnYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._columnTrans = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._columnDrive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._columnHp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._columnEngine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._columnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this._textBoxPriceFrom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._textBoxPriceTo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _dataGridView
            // 
            this._dataGridView.AllowUserToAddRows = false;
            this._dataGridView.AllowUserToDeleteRows = false;
            this._dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._columnModel,
            this._columnYear,
            this._columnTrans,
            this._columnDrive,
            this._columnHp,
            this._columnEngine,
            this._columnPrice});
            this._dataGridView.Location = new System.Drawing.Point(12, 87);
            this._dataGridView.Name = "_dataGridView";
            this._dataGridView.ReadOnly = true;
            this._dataGridView.Size = new System.Drawing.Size(749, 181);
            this._dataGridView.TabIndex = 0;
            // 
            // _columnModel
            // 
            this._columnModel.HeaderText = "Модель";
            this._columnModel.Name = "_columnModel";
            this._columnModel.ReadOnly = true;
            // 
            // _columnYear
            // 
            this._columnYear.HeaderText = "Год";
            this._columnYear.Name = "_columnYear";
            this._columnYear.ReadOnly = true;
            // 
            // _columnTrans
            // 
            this._columnTrans.HeaderText = "Трансмиссия";
            this._columnTrans.Name = "_columnTrans";
            this._columnTrans.ReadOnly = true;
            // 
            // _columnDrive
            // 
            this._columnDrive.HeaderText = "Привод";
            this._columnDrive.Name = "_columnDrive";
            this._columnDrive.ReadOnly = true;
            // 
            // _columnHp
            // 
            this._columnHp.HeaderText = "Лошад. силы";
            this._columnHp.Name = "_columnHp";
            this._columnHp.ReadOnly = true;
            // 
            // _columnEngine
            // 
            this._columnEngine.HeaderText = "Двигатель";
            this._columnEngine.Name = "_columnEngine";
            this._columnEngine.ReadOnly = true;
            // 
            // _columnPrice
            // 
            this._columnPrice.HeaderText = "Цена";
            this._columnPrice.Name = "_columnPrice";
            this._columnPrice.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "цена с";
            // 
            // _textBoxPriceFrom
            // 
            this._textBoxPriceFrom.Location = new System.Drawing.Point(296, 32);
            this._textBoxPriceFrom.Name = "_textBoxPriceFrom";
            this._textBoxPriceFrom.Size = new System.Drawing.Size(100, 20);
            this._textBoxPriceFrom.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(412, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "до";
            // 
            // _textBoxPriceTo
            // 
            this._textBoxPriceTo.Location = new System.Drawing.Point(453, 32);
            this._textBoxPriceTo.Name = "_textBoxPriceTo";
            this._textBoxPriceTo.Size = new System.Drawing.Size(100, 20);
            this._textBoxPriceTo.TabIndex = 4;
            // 
            // FormCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 310);
            this.Controls.Add(this._textBoxPriceTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._textBoxPriceFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._dataGridView);
            this.Name = "FormCars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormCars";
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView _dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn _columnModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn _columnYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn _columnTrans;
        private System.Windows.Forms.DataGridViewTextBoxColumn _columnDrive;
        private System.Windows.Forms.DataGridViewTextBoxColumn _columnHp;
        private System.Windows.Forms.DataGridViewTextBoxColumn _columnEngine;
        private System.Windows.Forms.DataGridViewTextBoxColumn _columnPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _textBoxPriceFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _textBoxPriceTo;
    }
}