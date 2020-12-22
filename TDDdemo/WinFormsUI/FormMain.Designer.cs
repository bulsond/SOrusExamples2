
namespace WinFormsUI
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._buttonDoCalc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._textBoxLength = new System.Windows.Forms.TextBox();
            this._textBoxWidth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._labelArea = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._labelPerimeter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _buttonDoCalc
            // 
            this._buttonDoCalc.Location = new System.Drawing.Point(371, 17);
            this._buttonDoCalc.Name = "_buttonDoCalc";
            this._buttonDoCalc.Size = new System.Drawing.Size(88, 23);
            this._buttonDoCalc.TabIndex = 0;
            this._buttonDoCalc.Text = "Вычислить";
            this._buttonDoCalc.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Высота";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Длина";
            // 
            // _textBoxLength
            // 
            this._textBoxLength.Location = new System.Drawing.Point(233, 17);
            this._textBoxLength.Name = "_textBoxLength";
            this._textBoxLength.Size = new System.Drawing.Size(100, 23);
            this._textBoxLength.TabIndex = 3;
            // 
            // _textBoxWidth
            // 
            this._textBoxWidth.Location = new System.Drawing.Point(61, 17);
            this._textBoxWidth.Name = "_textBoxWidth";
            this._textBoxWidth.Size = new System.Drawing.Size(100, 23);
            this._textBoxWidth.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Площадь:";
            // 
            // _labelArea
            // 
            this._labelArea.AutoSize = true;
            this._labelArea.Location = new System.Drawing.Point(91, 82);
            this._labelArea.Name = "_labelArea";
            this._labelArea.Size = new System.Drawing.Size(12, 15);
            this._labelArea.TabIndex = 6;
            this._labelArea.Text = "?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Периметр:";
            // 
            // _labelPerimeter
            // 
            this._labelPerimeter.AutoSize = true;
            this._labelPerimeter.Location = new System.Drawing.Point(233, 82);
            this._labelPerimeter.Name = "_labelPerimeter";
            this._labelPerimeter.Size = new System.Drawing.Size(12, 15);
            this._labelPerimeter.TabIndex = 6;
            this._labelPerimeter.Text = "?";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 147);
            this.Controls.Add(this._labelPerimeter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._labelArea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._textBoxWidth);
            this.Controls.Add(this._textBoxLength);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._buttonDoCalc);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вычисление данных прямоугольника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _buttonDoCalc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _textBoxLength;
        private System.Windows.Forms.TextBox _textBoxWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label _labelArea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label _labelPerimeter;
    }
}

