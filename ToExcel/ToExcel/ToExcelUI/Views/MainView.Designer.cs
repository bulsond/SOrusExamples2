namespace ToExcelUI.Views
{
    partial class MainView
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this._listBoxPeople = new System.Windows.Forms.ListBox();
            this._buttonRemove = new System.Windows.Forms.Button();
            this._buttonUpdate = new System.Windows.Forms.Button();
            this._buttonAdd = new System.Windows.Forms.Button();
            this._textBoxAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._textBoxPhone = new System.Windows.Forms.TextBox();
            this._textBoxLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._textBoxFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this._listBoxPeople);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this._buttonRemove);
            this.splitContainer1.Panel2.Controls.Add(this._buttonUpdate);
            this.splitContainer1.Panel2.Controls.Add(this._buttonAdd);
            this.splitContainer1.Panel2.Controls.Add(this._textBoxAddress);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this._textBoxPhone);
            this.splitContainer1.Panel2.Controls.Add(this._textBoxLastName);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this._textBoxFirstName);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(622, 398);
            this.splitContainer1.SplitterDistance = 216;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.TabStop = false;
            // 
            // _listBoxPeople
            // 
            this._listBoxPeople.Dock = System.Windows.Forms.DockStyle.Fill;
            this._listBoxPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._listBoxPeople.FormattingEnabled = true;
            this._listBoxPeople.ItemHeight = 18;
            this._listBoxPeople.Location = new System.Drawing.Point(0, 0);
            this._listBoxPeople.Name = "_listBoxPeople";
            this._listBoxPeople.Size = new System.Drawing.Size(216, 398);
            this._listBoxPeople.TabIndex = 0;
            // 
            // _buttonRemove
            // 
            this._buttonRemove.Location = new System.Drawing.Point(279, 341);
            this._buttonRemove.Name = "_buttonRemove";
            this._buttonRemove.Size = new System.Drawing.Size(75, 23);
            this._buttonRemove.TabIndex = 2;
            this._buttonRemove.Text = "Удалить";
            this._buttonRemove.UseVisualStyleBackColor = true;
            // 
            // _buttonUpdate
            // 
            this._buttonUpdate.Location = new System.Drawing.Point(190, 341);
            this._buttonUpdate.Name = "_buttonUpdate";
            this._buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this._buttonUpdate.TabIndex = 2;
            this._buttonUpdate.Text = "Изменить";
            this._buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // _buttonAdd
            // 
            this._buttonAdd.Location = new System.Drawing.Point(104, 341);
            this._buttonAdd.Name = "_buttonAdd";
            this._buttonAdd.Size = new System.Drawing.Size(75, 23);
            this._buttonAdd.TabIndex = 2;
            this._buttonAdd.Text = "Добавить";
            this._buttonAdd.UseVisualStyleBackColor = true;
            // 
            // _textBoxAddress
            // 
            this._textBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._textBoxAddress.Location = new System.Drawing.Point(104, 91);
            this._textBoxAddress.Multiline = true;
            this._textBoxAddress.Name = "_textBoxAddress";
            this._textBoxAddress.ReadOnly = true;
            this._textBoxAddress.Size = new System.Drawing.Size(250, 166);
            this._textBoxAddress.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Телефон";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Адрес";
            // 
            // _textBoxPhone
            // 
            this._textBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._textBoxPhone.Location = new System.Drawing.Point(104, 271);
            this._textBoxPhone.Name = "_textBoxPhone";
            this._textBoxPhone.ReadOnly = true;
            this._textBoxPhone.Size = new System.Drawing.Size(250, 24);
            this._textBoxPhone.TabIndex = 1;
            // 
            // _textBoxLastName
            // 
            this._textBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._textBoxLastName.Location = new System.Drawing.Point(104, 56);
            this._textBoxLastName.Name = "_textBoxLastName";
            this._textBoxLastName.ReadOnly = true;
            this._textBoxLastName.Size = new System.Drawing.Size(250, 24);
            this._textBoxLastName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Фамилия";
            // 
            // _textBoxFirstName
            // 
            this._textBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._textBoxFirstName.Location = new System.Drawing.Point(104, 21);
            this._textBoxFirstName.Name = "_textBoxFirstName";
            this._textBoxFirstName.ReadOnly = true;
            this._textBoxFirstName.Size = new System.Drawing.Size(250, 24);
            this._textBoxFirstName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 398);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.Name = "MainView";
            this.Text = "MainView";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox _listBoxPeople;
        private System.Windows.Forms.TextBox _textBoxAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _textBoxLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _textBoxFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _textBoxPhone;
        private System.Windows.Forms.Button _buttonRemove;
        private System.Windows.Forms.Button _buttonUpdate;
        private System.Windows.Forms.Button _buttonAdd;
    }
}