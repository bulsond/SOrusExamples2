namespace YandexDictAndTrans.UI
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
            this._buttonTrans = new System.Windows.Forms.Button();
            this._buttonDict = new System.Windows.Forms.Button();
            this._textBoxInput = new System.Windows.Forms.TextBox();
            this._textBoxOutput = new System.Windows.Forms.TextBox();
            this._comboBoxLang = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // _buttonTrans
            // 
            this._buttonTrans.Location = new System.Drawing.Point(457, 51);
            this._buttonTrans.Name = "_buttonTrans";
            this._buttonTrans.Size = new System.Drawing.Size(83, 23);
            this._buttonTrans.TabIndex = 0;
            this._buttonTrans.Text = "Переводчик";
            this._buttonTrans.UseVisualStyleBackColor = true;
            // 
            // _buttonDict
            // 
            this._buttonDict.Location = new System.Drawing.Point(563, 51);
            this._buttonDict.Name = "_buttonDict";
            this._buttonDict.Size = new System.Drawing.Size(75, 23);
            this._buttonDict.TabIndex = 1;
            this._buttonDict.Text = "Словарь";
            this._buttonDict.UseVisualStyleBackColor = true;
            // 
            // _textBoxInput
            // 
            this._textBoxInput.Location = new System.Drawing.Point(50, 53);
            this._textBoxInput.Name = "_textBoxInput";
            this._textBoxInput.Size = new System.Drawing.Size(387, 20);
            this._textBoxInput.TabIndex = 2;
            // 
            // _textBoxOutput
            // 
            this._textBoxOutput.Location = new System.Drawing.Point(50, 95);
            this._textBoxOutput.Multiline = true;
            this._textBoxOutput.Name = "_textBoxOutput";
            this._textBoxOutput.Size = new System.Drawing.Size(387, 185);
            this._textBoxOutput.TabIndex = 3;
            // 
            // _comboBoxLang
            // 
            this._comboBoxLang.FormattingEnabled = true;
            this._comboBoxLang.Location = new System.Drawing.Point(457, 95);
            this._comboBoxLang.Name = "_comboBoxLang";
            this._comboBoxLang.Size = new System.Drawing.Size(181, 21);
            this._comboBoxLang.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 318);
            this.Controls.Add(this._comboBoxLang);
            this.Controls.Add(this._textBoxOutput);
            this.Controls.Add(this._textBoxInput);
            this.Controls.Add(this._buttonDict);
            this.Controls.Add(this._buttonTrans);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пример работы с Яндексом";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _buttonTrans;
        private System.Windows.Forms.Button _buttonDict;
        private System.Windows.Forms.TextBox _textBoxInput;
        private System.Windows.Forms.TextBox _textBoxOutput;
        private System.Windows.Forms.ComboBox _comboBoxLang;
    }
}

