namespace WindowsFormsListBox
{
    partial class FormInputProduct
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
            this._buttonOk = new System.Windows.Forms.Button();
            this._buttonCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._textBoxCity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._textBoxPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _buttonOk
            // 
            this._buttonOk.Location = new System.Drawing.Point(246, 118);
            this._buttonOk.Name = "_buttonOk";
            this._buttonOk.Size = new System.Drawing.Size(75, 23);
            this._buttonOk.TabIndex = 0;
            this._buttonOk.Text = "ОК";
            this._buttonOk.UseVisualStyleBackColor = true;
            // 
            // _buttonCancel
            // 
            this._buttonCancel.Location = new System.Drawing.Point(165, 118);
            this._buttonCancel.Name = "_buttonCancel";
            this._buttonCancel.Size = new System.Drawing.Size(75, 23);
            this._buttonCancel.TabIndex = 1;
            this._buttonCancel.Text = "Отмена";
            this._buttonCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название";
            // 
            // _textBoxName
            // 
            this._textBoxName.Location = new System.Drawing.Point(103, 23);
            this._textBoxName.Name = "_textBoxName";
            this._textBoxName.Size = new System.Drawing.Size(218, 20);
            this._textBoxName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Город";
            // 
            // _textBoxCity
            // 
            this._textBoxCity.Location = new System.Drawing.Point(103, 49);
            this._textBoxCity.Name = "_textBoxCity";
            this._textBoxCity.Size = new System.Drawing.Size(218, 20);
            this._textBoxCity.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Цена";
            // 
            // _textBoxPrice
            // 
            this._textBoxPrice.Location = new System.Drawing.Point(103, 75);
            this._textBoxPrice.Name = "_textBoxPrice";
            this._textBoxPrice.Size = new System.Drawing.Size(218, 20);
            this._textBoxPrice.TabIndex = 3;
            // 
            // FormInputProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 183);
            this.Controls.Add(this._textBoxPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._textBoxCity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._textBoxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._buttonCancel);
            this.Controls.Add(this._buttonOk);
            this.Name = "FormInputProduct";
            this.Text = "FormInputProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _buttonOk;
        private System.Windows.Forms.Button _buttonCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _textBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _textBoxCity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _textBoxPrice;
    }
}