namespace WindowsFormsApp
{
    partial class FormInput
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
            this._textBoxMiddleName = new System.Windows.Forms.TextBox();
            this._textBoxLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._textBoxFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._textBoxLogin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this._textBoxPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this._textBoxPassword2 = new System.Windows.Forms.TextBox();
            this._buttonCancel = new System.Windows.Forms.Button();
            this._buttonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _textBoxMiddleName
            // 
            this._textBoxMiddleName.Location = new System.Drawing.Point(87, 78);
            this._textBoxMiddleName.Name = "_textBoxMiddleName";
            this._textBoxMiddleName.Size = new System.Drawing.Size(160, 20);
            this._textBoxMiddleName.TabIndex = 2;
            // 
            // _textBoxLastName
            // 
            this._textBoxLastName.Location = new System.Drawing.Point(87, 23);
            this._textBoxLastName.Name = "_textBoxLastName";
            this._textBoxLastName.Size = new System.Drawing.Size(160, 20);
            this._textBoxLastName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Фамилия";
            // 
            // _textBoxFirstName
            // 
            this._textBoxFirstName.Location = new System.Drawing.Point(87, 51);
            this._textBoxFirstName.Name = "_textBoxFirstName";
            this._textBoxFirstName.Size = new System.Drawing.Size(160, 20);
            this._textBoxFirstName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Имя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Логин";
            // 
            // _textBoxLogin
            // 
            this._textBoxLogin.Location = new System.Drawing.Point(87, 107);
            this._textBoxLogin.Name = "_textBoxLogin";
            this._textBoxLogin.Size = new System.Drawing.Size(160, 20);
            this._textBoxLogin.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Пароль";
            // 
            // _textBoxPassword
            // 
            this._textBoxPassword.Location = new System.Drawing.Point(87, 133);
            this._textBoxPassword.Name = "_textBoxPassword";
            this._textBoxPassword.PasswordChar = '*';
            this._textBoxPassword.Size = new System.Drawing.Size(160, 20);
            this._textBoxPassword.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Пароль";
            // 
            // _textBoxPassword2
            // 
            this._textBoxPassword2.Location = new System.Drawing.Point(87, 159);
            this._textBoxPassword2.Name = "_textBoxPassword2";
            this._textBoxPassword2.PasswordChar = '*';
            this._textBoxPassword2.Size = new System.Drawing.Size(160, 20);
            this._textBoxPassword2.TabIndex = 5;
            // 
            // _buttonCancel
            // 
            this._buttonCancel.Location = new System.Drawing.Point(87, 205);
            this._buttonCancel.Name = "_buttonCancel";
            this._buttonCancel.Size = new System.Drawing.Size(75, 23);
            this._buttonCancel.TabIndex = 6;
            this._buttonCancel.Text = "Отмена";
            this._buttonCancel.UseVisualStyleBackColor = true;
            // 
            // _buttonOk
            // 
            this._buttonOk.Location = new System.Drawing.Point(172, 205);
            this._buttonOk.Name = "_buttonOk";
            this._buttonOk.Size = new System.Drawing.Size(75, 23);
            this._buttonOk.TabIndex = 7;
            this._buttonOk.Text = "OK";
            this._buttonOk.UseVisualStyleBackColor = true;
            // 
            // FormInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 240);
            this.Controls.Add(this._buttonOk);
            this.Controls.Add(this._buttonCancel);
            this.Controls.Add(this._textBoxPassword2);
            this.Controls.Add(this._textBoxPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._textBoxLogin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._textBoxMiddleName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._textBoxLastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._textBoxFirstName);
            this.Controls.Add(this.label1);
            this.Name = "FormInput";
            this.Text = "FormInput";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _textBoxMiddleName;
        private System.Windows.Forms.TextBox _textBoxLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _textBoxFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _textBoxLogin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _textBoxPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _textBoxPassword2;
        private System.Windows.Forms.Button _buttonCancel;
        private System.Windows.Forms.Button _buttonOk;
    }
}