namespace WindowsFormsAppCities
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
            this._textBoxInput = new System.Windows.Forms.TextBox();
            this._comboBoxInput = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // _textBoxInput
            // 
            this._textBoxInput.Location = new System.Drawing.Point(37, 26);
            this._textBoxInput.Name = "_textBoxInput";
            this._textBoxInput.Size = new System.Drawing.Size(224, 20);
            this._textBoxInput.TabIndex = 0;
            // 
            // _comboBoxInput
            // 
            this._comboBoxInput.FormattingEnabled = true;
            this._comboBoxInput.Location = new System.Drawing.Point(37, 52);
            this._comboBoxInput.Name = "_comboBoxInput";
            this._comboBoxInput.Size = new System.Drawing.Size(224, 21);
            this._comboBoxInput.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 283);
            this.Controls.Add(this._comboBoxInput);
            this.Controls.Add(this._textBoxInput);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пример вывода подсказки в TextBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _textBoxInput;
        private System.Windows.Forms.ComboBox _comboBoxInput;
    }
}

