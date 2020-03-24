using System.Collections.Generic;
using System.Text;

namespace WpfApp.Services
{
    public class YandexAnswer
    {
        private Dictionary _dictionaryAnswer;
        private Translator _translatorAnswer;

        public string Code { get; set; }
        public string Lang { get; set; }
        public string Text { get; set; }
        public Dictionary DictionaryAnswer
        {
            get => _dictionaryAnswer;
            set
            {
                _dictionaryAnswer = value;
                if (_dictionaryAnswer != null)
                {
                    SetTextFromDictionaryAnswer();
                }
            }
        }

        public Translator TranslatorAnswer
        {
            get => _translatorAnswer;
            set
            {
                _translatorAnswer = value;
                if (_translatorAnswer != null)
                {
                    SetTextFromTranslatorAnswer();
                }
            }
        }

        private void SetTextFromTranslatorAnswer()
        {
            var sb = new StringBuilder();
            _translatorAnswer.text?.ForEach(t => sb.AppendLine(t));
            Text = sb.ToString();
        }

        private void SetTextFromDictionaryAnswer()
        {
            if (_dictionaryAnswer.def == null)
            {
                return;
            }

            var sb = new StringBuilder();
            foreach (var def in _dictionaryAnswer.def)
            {
                int counter = 0;
                foreach (var tr in def.tr)
                {
                    sb.AppendLine($"{++counter}) {tr.text}");
                }
            }
            Text = sb.ToString();
        }
    }

    public class Translator
    {
        public int code { get; set; }
        public string lang { get; set; }
        public List<string> text { get; set; }
    }

    public class Dictionary
    {
        public Head head { get; set; }
        public Def[] def { get; set; }
    }

    public class Head
    {
    }

    public class Def
    {
        public string text { get; set; }
        public string pos { get; set; }
        public string gen { get; set; }
        public string anm { get; set; }
        public Tr[] tr { get; set; }
    }

    public class Tr
    {
        public string text { get; set; }
        public string pos { get; set; }
        public Syn[] syn { get; set; }
        public Mean[] mean { get; set; }
        public Ex[] ex { get; set; }
    }

    public class Syn
    {
        public string text { get; set; }
        public string pos { get; set; }
    }

    public class Mean
    {
        public string text { get; set; }
    }

    public class Ex
    {
        public string text { get; set; }
        public Tr1[] tr { get; set; }
    }

    public class Tr1
    {
        public string text { get; set; }
    }
}
