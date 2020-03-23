namespace WindowsFormsUI
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
            this._textBoxFile = new System.Windows.Forms.TextBox();
            this._buttonSelectFile = new System.Windows.Forms.Button();
            this._progressBar = new System.Windows.Forms.ProgressBar();
            this._labelProc = new System.Windows.Forms.Label();
            this._buttonSave = new System.Windows.Forms.Button();
            this._saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // _textBoxFile
            // 
            this._textBoxFile.Location = new System.Drawing.Point(23, 21);
            this._textBoxFile.Name = "_textBoxFile";
            this._textBoxFile.ReadOnly = true;
            this._textBoxFile.Size = new System.Drawing.Size(364, 20);
            this._textBoxFile.TabIndex = 0;
            // 
            // _buttonSelectFile
            // 
            this._buttonSelectFile.Location = new System.Drawing.Point(409, 19);
            this._buttonSelectFile.Name = "_buttonSelectFile";
            this._buttonSelectFile.Size = new System.Drawing.Size(75, 23);
            this._buttonSelectFile.TabIndex = 1;
            this._buttonSelectFile.Text = "Выбрать";
            this._buttonSelectFile.UseVisualStyleBackColor = true;
            // 
            // _progressBar
            // 
            this._progressBar.Location = new System.Drawing.Point(23, 119);
            this._progressBar.Name = "_progressBar";
            this._progressBar.Size = new System.Drawing.Size(312, 23);
            this._progressBar.TabIndex = 2;
            // 
            // _labelProc
            // 
            this._labelProc.AutoSize = true;
            this._labelProc.Location = new System.Drawing.Point(341, 124);
            this._labelProc.Name = "_labelProc";
            this._labelProc.Size = new System.Drawing.Size(21, 13);
            this._labelProc.TabIndex = 3;
            this._labelProc.Text = "0%";
            // 
            // _buttonSave
            // 
            this._buttonSave.Location = new System.Drawing.Point(409, 119);
            this._buttonSave.Name = "_buttonSave";
            this._buttonSave.Size = new System.Drawing.Size(75, 23);
            this._buttonSave.TabIndex = 4;
            this._buttonSave.Text = "Сохранить";
            this._buttonSave.UseVisualStyleBackColor = true;
            // 
            // _saveFileDialog
            // 
            this._saveFileDialog.Filter = "Текстовые файлы|*.txt|Все файлы|*.*";
            this._saveFileDialog.InitialDirectory = "D:\\";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 278);
            this.Controls.Add(this._buttonSave);
            this.Controls.Add(this._labelProc);
            this.Controls.Add(this._progressBar);
            this.Controls.Add(this._buttonSelectFile);
            this.Controls.Add(this._textBoxFile);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пример с ProgressBar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _textBoxFile;
        private System.Windows.Forms.Button _buttonSelectFile;
        private System.Windows.Forms.ProgressBar _progressBar;
        private System.Windows.Forms.Label _labelProc;
        private System.Windows.Forms.Button _buttonSave;
        private System.Windows.Forms.SaveFileDialog _saveFileDialog;
    }
}

