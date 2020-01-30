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
            this._listBoxPeople = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this._textBoxFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._textBoxLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._textBoxMiddleName = new System.Windows.Forms.TextBox();
            this._buttonAdd = new System.Windows.Forms.Button();
            this._buttonRemove = new System.Windows.Forms.Button();
            this._buttonUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _listBoxPeople
            // 
            this._listBoxPeople.FormattingEnabled = true;
            this._listBoxPeople.Location = new System.Drawing.Point(276, 29);
            this._listBoxPeople.Name = "_listBoxPeople";
            this._listBoxPeople.Size = new System.Drawing.Size(151, 95);
            this._listBoxPeople.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя";
            // 
            // _textBoxFirstName
            // 
            this._textBoxFirstName.Location = new System.Drawing.Point(89, 56);
            this._textBoxFirstName.Name = "_textBoxFirstName";
            this._textBoxFirstName.ReadOnly = true;
            this._textBoxFirstName.Size = new System.Drawing.Size(165, 20);
            this._textBoxFirstName.TabIndex = 2;
            this._textBoxFirstName.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фамилия";
            // 
            // _textBoxLastName
            // 
            this._textBoxLastName.Location = new System.Drawing.Point(89, 27);
            this._textBoxLastName.Name = "_textBoxLastName";
            this._textBoxLastName.ReadOnly = true;
            this._textBoxLastName.Size = new System.Drawing.Size(165, 20);
            this._textBoxLastName.TabIndex = 2;
            this._textBoxLastName.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Отчество";
            // 
            // _textBoxMiddleName
            // 
            this._textBoxMiddleName.Location = new System.Drawing.Point(89, 84);
            this._textBoxMiddleName.Name = "_textBoxMiddleName";
            this._textBoxMiddleName.ReadOnly = true;
            this._textBoxMiddleName.Size = new System.Drawing.Size(165, 20);
            this._textBoxMiddleName.TabIndex = 2;
            this._textBoxMiddleName.TabStop = false;
            // 
            // _buttonAdd
            // 
            this._buttonAdd.Location = new System.Drawing.Point(458, 27);
            this._buttonAdd.Name = "_buttonAdd";
            this._buttonAdd.Size = new System.Drawing.Size(75, 23);
            this._buttonAdd.TabIndex = 0;
            this._buttonAdd.Text = "Добавить";
            this._buttonAdd.UseVisualStyleBackColor = true;
            // 
            // _buttonRemove
            // 
            this._buttonRemove.Location = new System.Drawing.Point(458, 101);
            this._buttonRemove.Name = "_buttonRemove";
            this._buttonRemove.Size = new System.Drawing.Size(75, 23);
            this._buttonRemove.TabIndex = 1;
            this._buttonRemove.Text = "Удалить";
            this._buttonRemove.UseVisualStyleBackColor = true;
            // 
            // _buttonUpdate
            // 
            this._buttonUpdate.Location = new System.Drawing.Point(458, 57);
            this._buttonUpdate.Name = "_buttonUpdate";
            this._buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this._buttonUpdate.TabIndex = 1;
            this._buttonUpdate.Text = "Изменить";
            this._buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 160);
            this.Controls.Add(this._buttonUpdate);
            this.Controls.Add(this._buttonRemove);
            this.Controls.Add(this._buttonAdd);
            this.Controls.Add(this._textBoxMiddleName);
            this.Controls.Add(this._textBoxLastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._textBoxFirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._listBoxPeople);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox _listBoxPeople;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _textBoxFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _textBoxLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _textBoxMiddleName;
        private System.Windows.Forms.Button _buttonAdd;
        private System.Windows.Forms.Button _buttonRemove;
        private System.Windows.Forms.Button _buttonUpdate;
    }
}

