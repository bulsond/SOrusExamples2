namespace WinFormsApp
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
            this._textBoxUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._textBoxPath = new System.Windows.Forms.TextBox();
            this._buttonSelectFolder = new System.Windows.Forms.Button();
            this._buttonCancel = new System.Windows.Forms.Button();
            this._buttonStart = new System.Windows.Forms.Button();
            this._labelReport = new System.Windows.Forms.Label();
            this._saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this._labelSize = new System.Windows.Forms.Label();
            this._progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Адрес URL";
            // 
            // _textBoxUrl
            // 
            this._textBoxUrl.Location = new System.Drawing.Point(118, 26);
            this._textBoxUrl.Name = "_textBoxUrl";
            this._textBoxUrl.Size = new System.Drawing.Size(592, 20);
            this._textBoxUrl.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Путь сохранения";
            // 
            // _textBoxPath
            // 
            this._textBoxPath.Location = new System.Drawing.Point(118, 63);
            this._textBoxPath.Name = "_textBoxPath";
            this._textBoxPath.Size = new System.Drawing.Size(496, 20);
            this._textBoxPath.TabIndex = 1;
            // 
            // _buttonSelectFolder
            // 
            this._buttonSelectFolder.Location = new System.Drawing.Point(635, 61);
            this._buttonSelectFolder.Name = "_buttonSelectFolder";
            this._buttonSelectFolder.Size = new System.Drawing.Size(75, 23);
            this._buttonSelectFolder.TabIndex = 2;
            this._buttonSelectFolder.Text = "Выбрать";
            this._buttonSelectFolder.UseVisualStyleBackColor = true;
            // 
            // _buttonCancel
            // 
            this._buttonCancel.Enabled = false;
            this._buttonCancel.Location = new System.Drawing.Point(539, 122);
            this._buttonCancel.Name = "_buttonCancel";
            this._buttonCancel.Size = new System.Drawing.Size(75, 23);
            this._buttonCancel.TabIndex = 4;
            this._buttonCancel.Text = "Отменить";
            this._buttonCancel.UseVisualStyleBackColor = true;
            // 
            // _buttonStart
            // 
            this._buttonStart.Location = new System.Drawing.Point(635, 122);
            this._buttonStart.Name = "_buttonStart";
            this._buttonStart.Size = new System.Drawing.Size(75, 23);
            this._buttonStart.TabIndex = 3;
            this._buttonStart.Text = "Скачать";
            this._buttonStart.UseVisualStyleBackColor = true;
            // 
            // _labelReport
            // 
            this._labelReport.AutoSize = true;
            this._labelReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._labelReport.Location = new System.Drawing.Point(471, 122);
            this._labelReport.Name = "_labelReport";
            this._labelReport.Size = new System.Drawing.Size(50, 20);
            this._labelReport.TabIndex = 5;
            this._labelReport.Text = "100%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Размер файла";
            // 
            // _labelSize
            // 
            this._labelSize.AutoSize = true;
            this._labelSize.Location = new System.Drawing.Point(115, 127);
            this._labelSize.Name = "_labelSize";
            this._labelSize.Size = new System.Drawing.Size(13, 13);
            this._labelSize.TabIndex = 6;
            this._labelSize.Text = "0";
            // 
            // _progressBar
            // 
            this._progressBar.Location = new System.Drawing.Point(333, 122);
            this._progressBar.Name = "_progressBar";
            this._progressBar.Size = new System.Drawing.Size(132, 23);
            this._progressBar.TabIndex = 7;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 175);
            this.Controls.Add(this._progressBar);
            this.Controls.Add(this._labelSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._labelReport);
            this.Controls.Add(this._buttonCancel);
            this.Controls.Add(this._buttonStart);
            this.Controls.Add(this._buttonSelectFolder);
            this.Controls.Add(this._textBoxPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._textBoxUrl);
            this.Controls.Add(this.label1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пример на скачивание файла";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _textBoxUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _textBoxPath;
        private System.Windows.Forms.Button _buttonSelectFolder;
        private System.Windows.Forms.Button _buttonCancel;
        private System.Windows.Forms.Button _buttonStart;
        private System.Windows.Forms.Label _labelReport;
        private System.Windows.Forms.SaveFileDialog _saveFileDialog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label _labelSize;
        private System.Windows.Forms.ProgressBar _progressBar;
    }
}

