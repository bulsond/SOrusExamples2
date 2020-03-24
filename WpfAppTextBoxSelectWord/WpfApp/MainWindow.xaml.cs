using System;
using System.Windows;
using System.Windows.Input;
using WpfApp.Services;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly WordsService _wordsService;
        private readonly YandexServices _yandexServices;

        public MainWindow()
        {
            InitializeComponent();

            _wordsService = new WordsService();
            _yandexServices = new YandexServices();

            _textBox.PreviewMouseDoubleClick += TextBox_PreviewMouseDoubleClick;
        }

        private async void TextBox_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(_textBox.Text))
                return;

            //находим слово по которому был двойной клик
            var word = _wordsService.GetWordByPosition(_textBox.Text, _textBox.SelectionStart);

            //находим перевод слова
            var result = await _yandexServices.GetDictionaryAnswerAsync(word.Value,
                YandexServices.TranslationDirection.RuEng);
            word.Translation = result.Text;

            //показываем слово и его перевод
            var message = $"Слово: {word.Value}"
                + Environment.NewLine
                + $"Перевод: {word.Translation}";
            MessageBox.Show(message);
        }
    }
}
