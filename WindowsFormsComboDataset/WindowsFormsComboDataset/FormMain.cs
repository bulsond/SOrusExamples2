using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsComboDataset
{
    public partial class FormMain : Form
    {
        private string _name;
        private int _weight;
        private int _age;
        private int _cost;

        public FormMain()
        {
            InitializeComponent();

            this.Load += FormMain_Load;
            textBoxNewName.Validating += TextBoxNewName_Validating;
            textBoxNewWeight.Validating += TextBoxNewWeight_Validating;
            textBoxNewAge.Validating += TextBoxNewAge_Validating;
            textBoxNewCost.Validating += TextBoxNewCost_Validating;
            buttonAdd.Click += ButtonAdd_Click;
            buttonRemove.Click += ButtonRemove_Click;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //заполняем данными
            var row1 = animalsData.Tables["Animals"].NewRow();
            row1["Name"] = "dog";
            row1["Weight"] = 3;
            row1["Age"] = 2;
            row1["Cost"] = 45;

            var row2 = animalsData.Tables["Animals"].NewRow();
            row2["Name"] = "fox";
            row2["Weight"] = 7;
            row2["Age"] = 3;
            row2["Cost"] = 68;

            animalsData.Tables["Animals"].Rows.Add(row1);
            animalsData.Tables["Animals"].Rows.Add(row2);
        }

        /// <summary>
        /// Кнопка удаления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            var drv = animalsBindingSource.Current as DataRowView;
            var name = drv.Row.Field<string>("Name");

            var result = MessageBox.Show($"Do you want to delete the {name}?", "Question",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                animalsBindingSource.RemoveCurrent();
            }
        }

        /// <summary>
        /// Проверка значения Name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxNewName_Validating(object sender, CancelEventArgs e)
        {
            _name = textBoxNewName.Text.Trim();
            if (String.IsNullOrEmpty(_name))
            {
                e.Cancel = true;
                errorProvider.SetError(textBoxNewName, "Please enter a name of animal");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textBoxNewName, null);
            }
        }

        /// <summary>
        /// Проверка значеня Weight
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxNewWeight_Validating(object sender, CancelEventArgs e)
        {
            var str = textBoxNewWeight.Text.Trim();
            if (int.TryParse(str, out _weight))
            {
                e.Cancel = false;
                errorProvider.SetError(textBoxNewWeight, null);
            }
            else
            {
                e.Cancel = true;
                errorProvider.SetError(textBoxNewWeight, "Please enter a weight of animal");
            }
        }
        
        /// <summary>
        /// Проверка значения Age
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxNewAge_Validating(object sender, CancelEventArgs e)
        {
            var str = textBoxNewAge.Text.Trim();
            if (int.TryParse(str, out _age))
            {
                e.Cancel = false;
                errorProvider.SetError(textBoxNewAge, null);
            }
            else
            {
                e.Cancel = true;
                errorProvider.SetError(textBoxNewAge, "Please enter a age of animal");
            }
        }
        /// <summary>
        /// Проверка значения Cost
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxNewCost_Validating(object sender, CancelEventArgs e)
        {
            var str = textBoxNewCost.Text.Trim();
            if (int.TryParse(str, out _cost))
            {
                e.Cancel = false;
                errorProvider.SetError(textBoxNewCost, null);
            }
            else
            {
                e.Cancel = true;
                errorProvider.SetError(textBoxNewCost, "Please enter a cost in day");
            }
        }

        /// <summary>
        /// Кнопка добавления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren(ValidationConstraints.Enabled))
                return;

            var row = animalsData.Tables["Animals"].NewRow();
            row["Name"] = _name;
            row["Weight"] = _weight;
            row["Age"] = _age;
            row["Cost"] = _cost;
            animalsData.Tables["Animals"].Rows.Add(row);

            textBoxNewName.Text = String.Empty;
            textBoxNewWeight.Text = "0";
            textBoxNewAge.Text = "0";
            textBoxNewCost.Text = "0";
        }
    }
}
