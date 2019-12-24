namespace WinFormsUI
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
            this._textBoxAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._textBoxParam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._textBoxFrom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._textBoxTo = new System.Windows.Forms.TextBox();
            this._buttonStart = new System.Windows.Forms.Button();
            this._progressBar = new System.Windows.Forms.ProgressBar();
            this._buttonCancel = new System.Windows.Forms.Button();
            this._dataGridView = new System.Windows.Forms.DataGridView();
            this._columnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._columnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._columnResponse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _textBoxAddress
            // 
            this._textBoxAddress.Location = new System.Drawing.Point(74, 12);
            this._textBoxAddress.Name = "_textBoxAddress";
            this._textBoxAddress.Size = new System.Drawing.Size(288, 20);
            this._textBoxAddress.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Адрес:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Параметр:";
            // 
            // _textBoxParam
            // 
            this._textBoxParam.Location = new System.Drawing.Point(437, 12);
            this._textBoxParam.Name = "_textBoxParam";
            this._textBoxParam.Size = new System.Drawing.Size(100, 20);
            this._textBoxParam.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(549, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "с:";
            // 
            // _textBoxFrom
            // 
            this._textBoxFrom.Location = new System.Drawing.Point(571, 12);
            this._textBoxFrom.Name = "_textBoxFrom";
            this._textBoxFrom.Size = new System.Drawing.Size(56, 20);
            this._textBoxFrom.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(635, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "по:";
            // 
            // _textBoxTo
            // 
            this._textBoxTo.Location = new System.Drawing.Point(657, 12);
            this._textBoxTo.Name = "_textBoxTo";
            this._textBoxTo.Size = new System.Drawing.Size(56, 20);
            this._textBoxTo.TabIndex = 5;
            // 
            // _buttonStart
            // 
            this._buttonStart.Location = new System.Drawing.Point(741, 10);
            this._buttonStart.Name = "_buttonStart";
            this._buttonStart.Size = new System.Drawing.Size(75, 23);
            this._buttonStart.TabIndex = 6;
            this._buttonStart.Text = "Запуск";
            this._buttonStart.UseVisualStyleBackColor = true;
            // 
            // _progressBar
            // 
            this._progressBar.Location = new System.Drawing.Point(741, 48);
            this._progressBar.Name = "_progressBar";
            this._progressBar.Size = new System.Drawing.Size(75, 23);
            this._progressBar.TabIndex = 8;
            // 
            // _buttonCancel
            // 
            this._buttonCancel.Enabled = false;
            this._buttonCancel.Location = new System.Drawing.Point(741, 94);
            this._buttonCancel.Name = "_buttonCancel";
            this._buttonCancel.Size = new System.Drawing.Size(75, 23);
            this._buttonCancel.TabIndex = 9;
            this._buttonCancel.Text = "Отмена";
            this._buttonCancel.UseVisualStyleBackColor = true;
            // 
            // _dataGridView
            // 
            this._dataGridView.AllowUserToAddRows = false;
            this._dataGridView.AllowUserToDeleteRows = false;
            this._dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._columnNumber,
            this._columnAddress,
            this._columnResponse});
            this._dataGridView.Location = new System.Drawing.Point(30, 94);
            this._dataGridView.Name = "_dataGridView";
            this._dataGridView.ReadOnly = true;
            this._dataGridView.Size = new System.Drawing.Size(683, 244);
            this._dataGridView.TabIndex = 10;
            // 
            // _columnNumber
            // 
            this._columnNumber.HeaderText = "Н/П";
            this._columnNumber.Name = "_columnNumber";
            this._columnNumber.ReadOnly = true;
            this._columnNumber.Width = 50;
            // 
            // _columnAddress
            // 
            this._columnAddress.HeaderText = "Адрес";
            this._columnAddress.Name = "_columnAddress";
            this._columnAddress.ReadOnly = true;
            this._columnAddress.Width = 300;
            // 
            // _columnResponse
            // 
            this._columnResponse.HeaderText = "Ответ";
            this._columnResponse.Name = "_columnResponse";
            this._columnResponse.ReadOnly = true;
            this._columnResponse.Width = 300;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 367);
            this.Controls.Add(this._dataGridView);
            this.Controls.Add(this._buttonCancel);
            this.Controls.Add(this._progressBar);
            this.Controls.Add(this._buttonStart);
            this.Controls.Add(this._textBoxTo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._textBoxFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._textBoxParam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._textBoxAddress);
            this.Name = "FormMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _textBoxAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _textBoxParam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _textBoxFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _textBoxTo;
        private System.Windows.Forms.Button _buttonStart;
        private System.Windows.Forms.ProgressBar _progressBar;
        private System.Windows.Forms.Button _buttonCancel;
        private System.Windows.Forms.DataGridView _dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn _columnNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn _columnAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn _columnResponse;
    }
}

