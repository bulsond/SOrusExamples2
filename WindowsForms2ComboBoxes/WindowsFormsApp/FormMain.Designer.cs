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
            this._comboBoxTypes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this._comboBoxNumbers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _comboBoxTypes
            // 
            this._comboBoxTypes.FormattingEnabled = true;
            this._comboBoxTypes.Location = new System.Drawing.Point(155, 60);
            this._comboBoxTypes.Name = "_comboBoxTypes";
            this._comboBoxTypes.Size = new System.Drawing.Size(173, 21);
            this._comboBoxTypes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Тип комнаты";
            // 
            // _comboBoxNumbers
            // 
            this._comboBoxNumbers.FormattingEnabled = true;
            this._comboBoxNumbers.Location = new System.Drawing.Point(155, 98);
            this._comboBoxNumbers.Name = "_comboBoxNumbers";
            this._comboBoxNumbers.Size = new System.Drawing.Size(173, 21);
            this._comboBoxNumbers.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Номера комнат";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 198);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._comboBoxNumbers);
            this.Controls.Add(this._comboBoxTypes);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пример на 2 ComboBoxа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox _comboBoxTypes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _comboBoxNumbers;
        private System.Windows.Forms.Label label2;
    }
}

