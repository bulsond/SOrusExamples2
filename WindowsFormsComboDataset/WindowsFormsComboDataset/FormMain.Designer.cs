namespace WindowsFormsComboDataset
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
            this.components = new System.ComponentModel.Container();
            this.comboBoxAnimals = new System.Windows.Forms.ComboBox();
            this.animalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalsData = new WindowsFormsComboDataset.AnimalsData();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNewName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNewWeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNewAge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNewCost = new System.Windows.Forms.TextBox();
            this._groupBoxNew = new System.Windows.Forms.GroupBox();
            this._groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.textBoxInfoCost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxInfoAge = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxInfoWeight = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxInfoName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.animalsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsData)).BeginInit();
            this._groupBoxNew.SuspendLayout();
            this._groupBoxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxAnimals
            // 
            this.comboBoxAnimals.DataSource = this.animalsBindingSource;
            this.comboBoxAnimals.DisplayMember = "Name";
            this.comboBoxAnimals.FormattingEnabled = true;
            this.comboBoxAnimals.Location = new System.Drawing.Point(292, 25);
            this.comboBoxAnimals.Name = "comboBoxAnimals";
            this.comboBoxAnimals.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAnimals.TabIndex = 0;
            // 
            // animalsBindingSource
            // 
            this.animalsBindingSource.DataMember = "Animals";
            this.animalsBindingSource.DataSource = this.animalsData;
            // 
            // animalsData
            // 
            this.animalsData.DataSetName = "AnimalsData";
            this.animalsData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(102, 244);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(192, 23);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // textBoxNewName
            // 
            this.textBoxNewName.Location = new System.Drawing.Point(95, 35);
            this.textBoxNewName.Name = "textBoxNewName";
            this.textBoxNewName.Size = new System.Drawing.Size(130, 20);
            this.textBoxNewName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Weight";
            // 
            // textBoxNewWeight
            // 
            this.textBoxNewWeight.Location = new System.Drawing.Point(95, 61);
            this.textBoxNewWeight.Name = "textBoxNewWeight";
            this.textBoxNewWeight.Size = new System.Drawing.Size(130, 20);
            this.textBoxNewWeight.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Age";
            // 
            // textBoxNewAge
            // 
            this.textBoxNewAge.Location = new System.Drawing.Point(95, 87);
            this.textBoxNewAge.Name = "textBoxNewAge";
            this.textBoxNewAge.Size = new System.Drawing.Size(130, 20);
            this.textBoxNewAge.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cost in day";
            // 
            // textBoxNewCost
            // 
            this.textBoxNewCost.Location = new System.Drawing.Point(95, 113);
            this.textBoxNewCost.Name = "textBoxNewCost";
            this.textBoxNewCost.Size = new System.Drawing.Size(130, 20);
            this.textBoxNewCost.TabIndex = 5;
            // 
            // _groupBoxNew
            // 
            this._groupBoxNew.Controls.Add(this.textBoxNewCost);
            this._groupBoxNew.Controls.Add(this.label4);
            this._groupBoxNew.Controls.Add(this.textBoxNewAge);
            this._groupBoxNew.Controls.Add(this.label3);
            this._groupBoxNew.Controls.Add(this.textBoxNewWeight);
            this._groupBoxNew.Controls.Add(this.label2);
            this._groupBoxNew.Controls.Add(this.textBoxNewName);
            this._groupBoxNew.Controls.Add(this.label1);
            this._groupBoxNew.Location = new System.Drawing.Point(69, 78);
            this._groupBoxNew.Name = "_groupBoxNew";
            this._groupBoxNew.Size = new System.Drawing.Size(245, 160);
            this._groupBoxNew.TabIndex = 4;
            this._groupBoxNew.TabStop = false;
            this._groupBoxNew.Text = "Add New Animal";
            // 
            // _groupBoxInfo
            // 
            this._groupBoxInfo.Controls.Add(this.textBoxInfoCost);
            this._groupBoxInfo.Controls.Add(this.label5);
            this._groupBoxInfo.Controls.Add(this.textBoxInfoAge);
            this._groupBoxInfo.Controls.Add(this.label6);
            this._groupBoxInfo.Controls.Add(this.textBoxInfoWeight);
            this._groupBoxInfo.Controls.Add(this.label7);
            this._groupBoxInfo.Controls.Add(this.textBoxInfoName);
            this._groupBoxInfo.Controls.Add(this.label8);
            this._groupBoxInfo.Location = new System.Drawing.Point(381, 78);
            this._groupBoxInfo.Name = "_groupBoxInfo";
            this._groupBoxInfo.Size = new System.Drawing.Size(245, 160);
            this._groupBoxInfo.TabIndex = 6;
            this._groupBoxInfo.TabStop = false;
            this._groupBoxInfo.Text = "Info About Animal";
            // 
            // textBoxInfoCost
            // 
            this.textBoxInfoCost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalsBindingSource, "Cost", true));
            this.textBoxInfoCost.Location = new System.Drawing.Point(95, 113);
            this.textBoxInfoCost.Name = "textBoxInfoCost";
            this.textBoxInfoCost.ReadOnly = true;
            this.textBoxInfoCost.Size = new System.Drawing.Size(130, 20);
            this.textBoxInfoCost.TabIndex = 1;
            this.textBoxInfoCost.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Cost in day";
            // 
            // textBoxInfoAge
            // 
            this.textBoxInfoAge.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalsBindingSource, "Age", true));
            this.textBoxInfoAge.Location = new System.Drawing.Point(95, 87);
            this.textBoxInfoAge.Name = "textBoxInfoAge";
            this.textBoxInfoAge.ReadOnly = true;
            this.textBoxInfoAge.Size = new System.Drawing.Size(130, 20);
            this.textBoxInfoAge.TabIndex = 1;
            this.textBoxInfoAge.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Age";
            // 
            // textBoxInfoWeight
            // 
            this.textBoxInfoWeight.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalsBindingSource, "Weight", true));
            this.textBoxInfoWeight.Location = new System.Drawing.Point(95, 61);
            this.textBoxInfoWeight.Name = "textBoxInfoWeight";
            this.textBoxInfoWeight.ReadOnly = true;
            this.textBoxInfoWeight.Size = new System.Drawing.Size(130, 20);
            this.textBoxInfoWeight.TabIndex = 1;
            this.textBoxInfoWeight.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Weight";
            // 
            // textBoxInfoName
            // 
            this.textBoxInfoName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalsBindingSource, "Name", true));
            this.textBoxInfoName.Location = new System.Drawing.Point(95, 35);
            this.textBoxInfoName.Name = "textBoxInfoName";
            this.textBoxInfoName.ReadOnly = true;
            this.textBoxInfoName.Size = new System.Drawing.Size(130, 20);
            this.textBoxInfoName.TabIndex = 1;
            this.textBoxInfoName.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Name";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(414, 244);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(192, 23);
            this.buttonRemove.TabIndex = 1;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 304);
            this.Controls.Add(this._groupBoxInfo);
            this.Controls.Add(this._groupBoxNew);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxAnimals);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Animals";
            ((System.ComponentModel.ISupportInitialize)(this.animalsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsData)).EndInit();
            this._groupBoxNew.ResumeLayout(false);
            this._groupBoxNew.PerformLayout();
            this._groupBoxInfo.ResumeLayout(false);
            this._groupBoxInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAnimals;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNewName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNewWeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNewAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNewCost;
        private System.Windows.Forms.GroupBox _groupBoxNew;
        private System.Windows.Forms.GroupBox _groupBoxInfo;
        private System.Windows.Forms.TextBox textBoxInfoCost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxInfoAge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxInfoWeight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxInfoName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource animalsBindingSource;
        private AnimalsData animalsData;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button buttonRemove;
    }
}

