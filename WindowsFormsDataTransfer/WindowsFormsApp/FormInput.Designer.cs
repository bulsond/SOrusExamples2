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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this._textBoxFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._textBoxLastName = new System.Windows.Forms.TextBox();
            this._buttonSave = new System.Windows.Forms.Button();
            this._errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // _textBoxFirstName
            // 
            this._textBoxFirstName.Location = new System.Drawing.Point(71, 12);
            this._textBoxFirstName.Name = "_textBoxFirstName";
            this._textBoxFirstName.Size = new System.Drawing.Size(126, 20);
            this._textBoxFirstName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Фамилия";
            // 
            // _textBoxLastName
            // 
            this._textBoxLastName.Location = new System.Drawing.Point(71, 47);
            this._textBoxLastName.Name = "_textBoxLastName";
            this._textBoxLastName.Size = new System.Drawing.Size(126, 20);
            this._textBoxLastName.TabIndex = 1;
            // 
            // _buttonSave
            // 
            this._buttonSave.Location = new System.Drawing.Point(92, 103);
            this._buttonSave.Name = "_buttonSave";
            this._buttonSave.Size = new System.Drawing.Size(75, 23);
            this._buttonSave.TabIndex = 2;
            this._buttonSave.Text = "Сохранить";
            this._buttonSave.UseVisualStyleBackColor = true;
            // 
            // _errorProvider
            // 
            this._errorProvider.ContainerControl = this;
            // 
            // FormInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 155);
            this.Controls.Add(this._buttonSave);
            this.Controls.Add(this._textBoxLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._textBoxFirstName);
            this.Controls.Add(this.label1);
            this.Name = "FormInput";
            this.Text = "Добавление";
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _textBoxFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _textBoxLastName;
        private System.Windows.Forms.Button _buttonSave;
        private System.Windows.Forms.ErrorProvider _errorProvider;
    }
}