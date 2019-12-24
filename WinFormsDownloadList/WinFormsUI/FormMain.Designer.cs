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
            this._listView1Results = new System.Windows.Forms.ListView();
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
            // _listView1Results
            // 
            this._listView1Results.HideSelection = false;
            this._listView1Results.Location = new System.Drawing.Point(30, 79);
            this._listView1Results.Name = "_listView1Results";
            this._listView1Results.Size = new System.Drawing.Size(683, 261);
            this._listView1Results.TabIndex = 7;
            this._listView1Results.UseCompatibleStateImageBehavior = false;
            this._listView1Results.View = System.Windows.Forms.View.List;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 367);
            this.Controls.Add(this._listView1Results);
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
        private System.Windows.Forms.ListView _listView1Results;
    }
}

