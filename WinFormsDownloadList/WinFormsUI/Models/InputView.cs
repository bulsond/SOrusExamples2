using System;
using System.Collections.Generic;

namespace WinFormsUI.Models
{
    class InputView
    {
        public string Address { get; set; }
        public string Parameter { get; set; }
        public int From { get; set; }
        public int To { get; set; }

        /// <summary>
        /// Получение списка загружаемых адресов
        /// !!! требует доработки !!!
        /// </summary>
        /// <returns>список загружаемых адресов</returns>
        public List<Item> GetItems()
        {
            List<Item> items = new List<Item>();

            if (NotCorrectedInputs())
                return items;

            var prefix = Parameter.Substring(0, Parameter.IndexOf("{"));
            var postfix = Parameter.Substring(Parameter.IndexOf("}") + 1);

            for (int i = From; i <= To; i++)
            {
                var address = String.Concat(Address, "/", prefix, i, postfix);
                var item = new Item(address);
                items.Add(item);
            }
            return items;
        }

        /// <summary>
        /// Проверка входных данных
        /// !!! требует доработки !!!
        /// </summary>
        /// <returns></returns>
        private bool NotCorrectedInputs()
        {
            return String.IsNullOrWhiteSpace(Address)
                && From == 0
                && To == 0;
        }

    }
}
