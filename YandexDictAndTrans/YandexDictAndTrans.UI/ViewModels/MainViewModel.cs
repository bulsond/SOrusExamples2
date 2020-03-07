using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using YandexDictAndTrans.UI.Services;

namespace YandexDictAndTrans.UI.ViewModels
{
    public class MainViewModel
    {
        private YandexServices _yandexServices;

        public MainViewModel(YandexServices yandexServices)
        {
            _yandexServices = yandexServices ??
                throw new ArgumentNullException(nameof(yandexServices));

            Langs = new List<string>() { "с русского на английский", "с английского на русский" };
        }

        public event EventHandler OutputChanged;

        private string _Output;
        public string Output
        {
            get { return _Output; }
            set
            { 
                _Output = value;
                OutputChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public string Input { get; set; }

        public List<string> Langs { get; }

        public int SelectedLang { get; set; }

        public async Task GetTransationAsync()
        {
            var direction = GetDirection();
            var result = await _yandexServices
                .GetTranslateAnswerAsync(Input, direction);

            Output = result.Text;
        }

        public async Task GetDictionaryAsync()
        {
            var direction = GetDirection();
            var result = await _yandexServices
                .GetDictionaryAnswerAsync(Input, direction);

            Output = result.Text;
        }

        private YandexServices.TranslationDirection GetDirection()
        {
            if (SelectedLang == 0)
            {
                return YandexServices.TranslationDirection.RuEng;
            }
            else
            {
                return YandexServices.TranslationDirection.EngRu;
            }
        }
    }
}
