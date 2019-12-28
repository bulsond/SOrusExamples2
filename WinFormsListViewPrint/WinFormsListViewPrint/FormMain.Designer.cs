namespace WinFormsListViewPrint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this._buttonPrint = new System.Windows.Forms.Button();
            this._buttonAdd = new System.Windows.Forms.Button();
            this._listView = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._textBoxMiddleName = new System.Windows.Forms.TextBox();
            this._textBoxFirstName = new System.Windows.Forms.TextBox();
            this._textBoxLastName = new System.Windows.Forms.TextBox();
            this._printDocument = new System.Drawing.Printing.PrintDocument();
            this._printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // _buttonPrint
            // 
            this._buttonPrint.Location = new System.Drawing.Point(700, 91);
            this._buttonPrint.Name = "_buttonPrint";
            this._buttonPrint.Size = new System.Drawing.Size(75, 23);
            this._buttonPrint.TabIndex = 13;
            this._buttonPrint.Text = "Печать";
            this._buttonPrint.UseVisualStyleBackColor = true;
            // 
            // _buttonAdd
            // 
            this._buttonAdd.Location = new System.Drawing.Point(700, 16);
            this._buttonAdd.Name = "_buttonAdd";
            this._buttonAdd.Size = new System.Drawing.Size(75, 23);
            this._buttonAdd.TabIndex = 12;
            this._buttonAdd.Text = "Добавить";
            this._buttonAdd.UseVisualStyleBackColor = true;
            // 
            // _listView
            // 
            this._listView.HideSelection = false;
            this._listView.Location = new System.Drawing.Point(80, 91);
            this._listView.Name = "_listView";
            this._listView.Size = new System.Drawing.Size(587, 159);
            this._listView.TabIndex = 11;
            this._listView.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(469, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Фамилия";
            // 
            // _textBoxMiddleName
            // 
            this._textBoxMiddleName.Location = new System.Drawing.Point(529, 18);
            this._textBoxMiddleName.Name = "_textBoxMiddleName";
            this._textBoxMiddleName.Size = new System.Drawing.Size(138, 20);
            this._textBoxMiddleName.TabIndex = 5;
            // 
            // _textBoxFirstName
            // 
            this._textBoxFirstName.Location = new System.Drawing.Point(292, 18);
            this._textBoxFirstName.Name = "_textBoxFirstName";
            this._textBoxFirstName.Size = new System.Drawing.Size(138, 20);
            this._textBoxFirstName.TabIndex = 6;
            // 
            // _textBoxLastName
            // 
            this._textBoxLastName.Location = new System.Drawing.Point(80, 18);
            this._textBoxLastName.Name = "_textBoxLastName";
            this._textBoxLastName.Size = new System.Drawing.Size(138, 20);
            this._textBoxLastName.TabIndex = 7;
            // 
            // _printPreviewDialog
            // 
            this._printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this._printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this._printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this._printPreviewDialog.Document = this._printDocument;
            this._printPreviewDialog.Enabled = true;
            this._printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("_printPreviewDialog.Icon")));
            this._printPreviewDialog.Name = "_printPreviewDialog";
            this._printPreviewDialog.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 290);
            this.Controls.Add(this._buttonPrint);
            this.Controls.Add(this._buttonAdd);
            this.Controls.Add(this._listView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._textBoxMiddleName);
            this.Controls.Add(this._textBoxFirstName);
            this.Controls.Add(this._textBoxLastName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _buttonPrint;
        private System.Windows.Forms.Button _buttonAdd;
        private System.Windows.Forms.ListView _listView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _textBoxMiddleName;
        private System.Windows.Forms.TextBox _textBoxFirstName;
        private System.Windows.Forms.TextBox _textBoxLastName;
        private System.Drawing.Printing.PrintDocument _printDocument;
        private System.Windows.Forms.PrintPreviewDialog _printPreviewDialog;
    }
}

