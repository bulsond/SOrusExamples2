namespace WindowsFormsListBox
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
            this._listBoxProducts = new System.Windows.Forms.ListBox();
            this._textBoxPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._textBoxCity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._buttonAddProduct = new System.Windows.Forms.Button();
            this._buttonRemoveProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _listBoxProducts
            // 
            this._listBoxProducts.FormattingEnabled = true;
            this._listBoxProducts.Location = new System.Drawing.Point(326, 25);
            this._listBoxProducts.Name = "_listBoxProducts";
            this._listBoxProducts.Size = new System.Drawing.Size(281, 186);
            this._listBoxProducts.TabIndex = 0;
            // 
            // _textBoxPrice
            // 
            this._textBoxPrice.Location = new System.Drawing.Point(81, 77);
            this._textBoxPrice.Name = "_textBoxPrice";
            this._textBoxPrice.Size = new System.Drawing.Size(218, 20);
            this._textBoxPrice.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Цена";
            // 
            // _textBoxCity
            // 
            this._textBoxCity.Location = new System.Drawing.Point(81, 51);
            this._textBoxCity.Name = "_textBoxCity";
            this._textBoxCity.Size = new System.Drawing.Size(218, 20);
            this._textBoxCity.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Город";
            // 
            // _textBoxName
            // 
            this._textBoxName.Location = new System.Drawing.Point(81, 25);
            this._textBoxName.Name = "_textBoxName";
            this._textBoxName.Size = new System.Drawing.Size(218, 20);
            this._textBoxName.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Название";
            // 
            // _buttonAddProduct
            // 
            this._buttonAddProduct.Location = new System.Drawing.Point(628, 28);
            this._buttonAddProduct.Name = "_buttonAddProduct";
            this._buttonAddProduct.Size = new System.Drawing.Size(75, 23);
            this._buttonAddProduct.TabIndex = 10;
            this._buttonAddProduct.Text = "Добавить";
            this._buttonAddProduct.UseVisualStyleBackColor = true;
            // 
            // _buttonRemoveProduct
            // 
            this._buttonRemoveProduct.Location = new System.Drawing.Point(628, 57);
            this._buttonRemoveProduct.Name = "_buttonRemoveProduct";
            this._buttonRemoveProduct.Size = new System.Drawing.Size(75, 23);
            this._buttonRemoveProduct.TabIndex = 10;
            this._buttonRemoveProduct.Text = "Удалить";
            this._buttonRemoveProduct.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 250);
            this.Controls.Add(this._buttonRemoveProduct);
            this.Controls.Add(this._buttonAddProduct);
            this.Controls.Add(this._textBoxPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._textBoxCity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._textBoxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._listBoxProducts);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox _listBoxProducts;
        private System.Windows.Forms.TextBox _textBoxPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _textBoxCity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _buttonAddProduct;
        private System.Windows.Forms.Button _buttonRemoveProduct;
    }
}

