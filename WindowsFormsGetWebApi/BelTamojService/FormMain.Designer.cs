namespace BelTamojService
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
            this._buttonPage = new System.Windows.Forms.Button();
            this._textBoxPageNumber = new System.Windows.Forms.TextBox();
            this._labelCounter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _dataGridView
            // 
            this._dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridView.Location = new System.Drawing.Point(12, 12);
            this._dataGridView.Name = "_dataGridView";
            this._dataGridView.Size = new System.Drawing.Size(776, 353);
            this._dataGridView.TabIndex = 0;
            // 
            // _buttonPage
            // 
            this._buttonPage.Location = new System.Drawing.Point(632, 397);
            this._buttonPage.Name = "_buttonPage";
            this._buttonPage.Size = new System.Drawing.Size(156, 23);
            this._buttonPage.TabIndex = 1;
            this._buttonPage.Text = "Загрузить страницу";
            this._buttonPage.UseVisualStyleBackColor = true;
            // 
            // _textBoxPageNumber
            // 
            this._textBoxPageNumber.Location = new System.Drawing.Point(562, 399);
            this._textBoxPageNumber.Name = "_textBoxPageNumber";
            this._textBoxPageNumber.Size = new System.Drawing.Size(52, 20);
            this._textBoxPageNumber.TabIndex = 2;
            // 
            // _labelCounter
            // 
            this._labelCounter.AutoSize = true;
            this._labelCounter.Location = new System.Drawing.Point(292, 402);
            this._labelCounter.Name = "_labelCounter";
            this._labelCounter.Size = new System.Drawing.Size(43, 13);
            this._labelCounter.TabIndex = 3;
            this._labelCounter.Text = "counter";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._labelCounter);
            this.Controls.Add(this._textBoxPageNumber);
            this.Controls.Add(this._buttonPage);
            this.Controls.Add(this._dataGridView);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Белтаможсервис";
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView _dataGridView;
        private System.Windows.Forms.Button _buttonPage;
        private System.Windows.Forms.TextBox _textBoxPageNumber;
        private System.Windows.Forms.Label _labelCounter;
    }
}

