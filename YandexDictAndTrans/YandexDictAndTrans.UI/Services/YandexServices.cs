using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace YandexDictAndTrans.UI.Services
{
    public class YandexServices
    {
        private const string _addressTranslator = "https://translate.yandex.net/api/v1.5/tr.json/translate?" +
            "key=trnsl.1.1.20200226T182352Z.f50284e5823499f7.dafb6352b04e04f4d4f6d95e7d4d076fa972c2ed";
        private const string _addressDictionary = "https://dictionary.yandex.net/api/v1/dicservice.json/lookup?" +
            "key=dict.1.1.20200226T180945Z.3dff57d76cbaf934.a871b8b923f38ae1cd61bd5139c51ab39f217f83";

        private readonly HttpClient _httpClient;

        public enum TranslationDirection { RuEng, EngRu }

        public YandexServices()
        {
            _httpClient = new HttpClient();
            _httpClient.Timeout = new TimeSpan(0, 0, 30);
        }

        public async Task<YandexAnswer> GetTranslateAnswerAsync(string text, TranslationDirection direction)
        {
            var answer = new YandexAnswer
            {
                Lang = GetLang(direction),
                TranslatorAnswer = new Translator()
            };

            if (String.IsNullOrWhiteSpace(text))
            {
                answer.Text = "Нет текста для перевода";
                return answer;
            }

            var address = String.Concat(_addressTranslator,
                "&lang=", answer.Lang, "&text=", text);

            answer = await GetAnswerAsync(address, answer);
            return answer;
        }

        public async Task<YandexAnswer> GetDictionaryAnswerAsync(string text, TranslationDirection direction)
        {
            var answer = new YandexAnswer
            {
                Lang = GetLang(direction),
                DictionaryAnswer = new Dictionary()
            };
            if (String.IsNullOrWhiteSpace(text))
            {
                answer.Text = "Нет слова(ов) для перевода";
                return answer;
            }

            var address = String.Concat(_addressDictionary,
                "&lang=", answer.Lang, "&text=", text);

            answer = await GetAnswerAsync(address, answer);
            return answer;
        }

        private string GetLang(TranslationDirection direction)
        {
            switch (direction)
            {
                case TranslationDirection.RuEng:
                    return "ru-en";
                case TranslationDirection.EngRu:
                    return "en-ru";
                default:
                    throw new ArgumentException(nameof(direction));
            }
        }

        private async Task<YandexAnswer> GetAnswerAsync(string address, YandexAnswer answer)
        {
            var response = await _httpClient.GetAsync(address);
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                if (answer.DictionaryAnswer != null)
                {
                    answer.DictionaryAnswer = JsonConvert.DeserializeObject<Dictionary>(json);
                }
                else
                {
                    answer.TranslatorAnswer = JsonConvert.DeserializeObject<Translator>(json);
                }
            }
            else
            {
                answer.Text = "Ошибка доступа к сервису Яндекса";
            }
            answer.Code = response.StatusCode.ToString();
            return answer;
        }
    }
}
