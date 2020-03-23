using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsUI
{
    public partial class FormMain : Form
    {
        private const string _conString = @"Data Source=(localdb)\MSSQLLocalDB;" +
            "Initial Catalog=AdventureWorks2016;Integrated Security=True;" +
            "Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;" +
            "ApplicationIntent=ReadWrite;MultiSubnetFailover=False"; 

        public FormMain()
        {
            InitializeComponent();

            _buttonSelectFile.Click += ButtonSelectFile_Click;
            _buttonSave.Click += ButtonSave_Click;
        }

        private void ButtonSelectFile_Click(object sender, EventArgs e)
        {
            if (_saveFileDialog.ShowDialog() != DialogResult.OK)
                return;

            _textBoxFile.Text = _saveFileDialog.FileName;
        }

        private async void ButtonSave_Click(object sender, EventArgs e)
        {
            var file = _textBoxFile.Text;
            if (String.IsNullOrEmpty(file))
                return;

            //кнопки
            _buttonSave.Enabled = false;
            _buttonSelectFile.Enabled = false;

            //колбек отображения процесса записи в файл
            IProgress<int> progress = new Progress<int>(value =>
            {
                _progressBar.Value = value;
                _labelProc.Text = $"{value}%";
                _labelProc.Update();
            });
            
            try
            {
                await SaveTableAsync(progress, file);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //кнопки
                _buttonSave.Enabled = true;
                _buttonSelectFile.Enabled = true;
            }
        }

        private async Task SaveTableAsync(IProgress<int> progress, string file)
        {
            //двусоставный запрос к БД
            var request = @"SELECT COUNT(AddressID)
                           FROM[AdventureWorks2016].[Person].[Address];
                           SELECT AddressLine1
		                   FROM[AdventureWorks2016].[Person].[Address]";

            using (var con = new SqlConnection(_conString))
            using (var cmd = con.CreateCommand())
            {
                cmd.CommandText = request;
                await con.OpenAsync();
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    //получаем количество записей в таблице
                    int countRecords = 0;
                    if (reader.HasRows)
                    {
                        await reader.ReadAsync();
                        countRecords = reader.GetInt32(0);
                    }
                    //записываем данные из таблицы в файл
                    if (await reader.NextResultAsync())
                    {
                        //открываем файл на запись
                        using (var fs = File.OpenWrite(file))
                        {
                            //текущая запись (строка) в таблице
                            int currentRecord = 0;
                            //пока есть записи в таблице
                            while (await reader.ReadAsync())
                            {
                                //получаем второй столбец
                                var column = reader.GetString(0);
                                var bytes = Encoding.UTF8.GetBytes(column);
                                //пишем в файл
                                await fs.WriteAsync(bytes, 0, bytes.Length);

                                //вычисляем процент записанных записей
                                var percent = ++currentRecord * 100 / countRecords;
                                //обновляем прогрессбар и лейбл
                                progress?.Report(percent);
                            }
                        }
                    }
                }
            }
        }

    }
}
