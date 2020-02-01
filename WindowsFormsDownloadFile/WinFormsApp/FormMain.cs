using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using WinFormsApp.Services;

namespace WinFormsApp
{
    public partial class FormMain : Form
    {
        private enum FormState { Initial, Downloading }
        private CancellationTokenSource _tokenSource;

        public FormMain()
        {
            InitializeComponent();

            this.Load += FormMain_Load;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            _buttonSelectFolder.Click += ButtonSelectFolder_Click;
            _buttonCancel.Click += ButtonCancel_Click;
            _buttonStart.Click += ButtonStart_Click;

            SetFormState(FormState.Initial);
        }

        /// <summary>
        /// Вкл/Выкл. кнопок и текстбоксов
        /// </summary>
        /// <param name="start"></param>
        private void SetFormState(FormState start)
        {
            switch (start)
            {
                case FormState.Initial:
                    _labelReport.Text = "0%";
                    _labelSize.Text = "0";
                    _progressBar.Value = 0;
                    _buttonStart.Enabled = true;
                    _buttonSelectFolder.Enabled = true;
                    _buttonCancel.Enabled = false;
                    _textBoxUrl.ReadOnly = false;
                    _textBoxPath.ReadOnly = false;
                    break;
                case FormState.Downloading:
                    _buttonStart.Enabled = false;
                    _buttonSelectFolder.Enabled = false;
                    _buttonCancel.Enabled = true;
                    _textBoxUrl.ReadOnly = true;
                    _textBoxPath.ReadOnly = true;
                    break;
            }
        }

        /// <summary>
        /// Кнопка Выбрать
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSelectFolder_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(_textBoxUrl.Text))
            {
                if (Uri.TryCreate(_textBoxUrl.Text, UriKind.Absolute, out Uri uri))
                {
                    //присваиваем наименование файла
                    _saveFileDialog.FileName = System.IO.Path.GetFileName(uri.Segments.Last());
                }
            }

            if (_saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                _textBoxPath.Text = _saveFileDialog.FileName;
            }
        }

        /// <summary>
        /// Кнопка Скачать
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ButtonStart_Click(object sender, EventArgs e)
        {
            //проверяем и получаем введенные адрес и путь
            if (!TryGetDownloadPathes(out (Uri uri, string path) downloadPathes))
                return;
            //создаем экз.сервиса скачивания
            var service = new DownloadService(downloadPathes.uri, downloadPathes.path);
            //выключаем кнопки
            SetFormState(FormState.Downloading);
            //готовим токен отмены и отображение процесса скачивания
            _tokenSource = new CancellationTokenSource();
            var token = _tokenSource.Token;
            //размер скачиваемого файла
            var sizeFile = 0L;
            //колбек отображения процесса скачки
            var progress = new Progress<int>(readed =>
            {
                _progressBar.Value = readed;
                _labelReport.Text = $"{_progressBar.Value}%";
            });

            try
            {
                //размер
                sizeFile = await service.GetFileSize(token);
                _labelSize.Text = sizeFile.ToString() + " байт";
                //файл
                await service.DownloadFileAsync(token, progress);
            }
            catch (Exception ex)
            {
                var message = $"Oшибка: \n'{ex.Message}'";
                var caption = "Ошибка загрузки файла";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _tokenSource.Dispose();
                SetFormState(FormState.Initial);
            }
        }

        /// <summary>
        /// Проверка введения нужных данных для скачивания
        /// Возвращение кортежа из введенных данных
        /// </summary>
        /// <param name="downloadPathes"></param>
        /// <returns></returns>
        private bool TryGetDownloadPathes(out (Uri, string) downloadPathes)
        {
            Uri uri = null;
            downloadPathes = (uri, string.Empty);

            if (String.IsNullOrWhiteSpace(_textBoxPath.Text)
                || String.IsNullOrWhiteSpace(_textBoxUrl.Text))
            {
                var message = "Для запуска скачивания необходимо ввести\nадрес URL и путь сохранения.";
                var caption = "Предупреждение";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (Uri.TryCreate(_textBoxUrl.Text, UriKind.Absolute, out uri))
            {
                downloadPathes = (uri, _textBoxPath.Text);
                return true;
            }
            else
            {
                var message = "Для запуска скачивания необходимо ввести адрес URL.";
                var caption = "Предупреждение";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        /// <summary>
        /// Кнопка Отменить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            _tokenSource?.Cancel();
        }
    }
}
