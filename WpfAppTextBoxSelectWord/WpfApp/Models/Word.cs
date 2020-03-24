using System;

namespace WpfApp.Models
{
    public class Word
    {
        //порядковый номер в тексте
        public int OrderNumber { get; }
        //номер позиции первой буквы в тексте
        public int StartPosition { get; }
        //номер позиции последней буквы в тексте
        public int EndPosition => StartPosition + Value.Length - 1;
        //значение слова
        public string Value { get; }
        //перевод значения слова
        public string Translation { get; set; }

        public Word(int orderNumber, int startPosition, string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException(nameof(value));

            OrderNumber = orderNumber;
            StartPosition = startPosition;
            Value = value;
        }

        /// <summary>
        /// Относится ли данная позиция в тексте к этому слову
        /// </summary>
        /// <param name="position">позиция в тексте</param>
        /// <returns>true если позиция соответствует данному слову</returns>
        public bool IsThisItByPosition(int position)
        {
            return position >= StartPosition
                && position <= EndPosition;
        }
    }
}
