using System;
using System.Collections.Generic;
using System.Linq;
using WpfApp.Models;

namespace WpfApp.Services
{
    public class WordsService
    {
        private string _currentText = String.Empty;
        private List<Word> _words;

        /// <summary>
        /// Получение коллекции слов из текста
        /// </summary>
        /// <param name="text">текст для разбора</param>
        /// <returns>коллекция слов</returns>
        public List<Word> GetWords(string text)
        {
            if (string.IsNullOrEmpty(text))
                throw new ArgumentException(nameof(text));

            //готовим результат
            var words = new List<Word>();

            //нумерация слов в тексте
            int wordOrderNumber = 0;
            //позиция первой буквы слова
            int wordStartPosition = 0;
            //для посимвольного набора слова
            List<char> wordChars = new List<char>();

            var chars = text.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                //извлекаем текущий символ
                var current = chars[i];

                if (Char.IsLetter(current))
                {
                    //если это первая буква слова
                    if (wordChars.Count == 0)
                    {
                        wordStartPosition = i;
                    }

                    //вносим букву в массив слова
                    wordChars.Add(current);

                    //если это последний символ в тексте, т.е. текст заканчивается на слове
                    //нужно добавить слово
                    if (i + 1 == chars.Length)
                    {
                        AddWord(words, ++wordOrderNumber, wordChars, wordStartPosition);
                    }
                }
                else
                {
                    //т.е. текущий символ не относится к слову
                    //и до этого у нас возможно собиралось слово
                    //и его нужно закрывать и создавать слово
                    if (wordChars.Count > 0)
                    {
                        AddWord(words, ++wordOrderNumber, wordChars, wordStartPosition);
                        //очищаем для следующего слова
                        wordChars.Clear();
                    }
                }
            }

            return words;
        }

        /// <summary>
        /// Получить слово по позиции в тексте
        /// </summary>
        /// <param name="text">текст содержащий искомое слово</param>
        /// <param name="position">позиция искомого слова</param>
        /// <returns>слово</returns>
        public Word GetWordByPosition(string text, int position)
        {
            if (string.IsNullOrWhiteSpace(text))
                throw new ArgumentException(nameof(text));

            if (String.IsNullOrEmpty(_currentText)
                || _currentText.Equals(text) == false)
            {
                _currentText = text;
                _words = GetWords(text);
            }

            var word = _words.First(w => w.IsThisItByPosition(position));
            return word;
        }

        private void AddWord(List<Word> words, int orderNumber,
            List<char> wordChars, int startPosition)
        {
            var value = new String(wordChars.ToArray());
            words.Add(new Word(orderNumber, startPosition, value));
        }
    }
}
