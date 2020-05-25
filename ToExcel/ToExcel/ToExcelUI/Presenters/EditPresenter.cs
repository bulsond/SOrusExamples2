using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using ToExcelUI.Models;
using ToExcelUI.Views;
using ToExcelUI.Views.EventHandlers;

namespace ToExcelUI.Presenters
{
    public class EditPresenter
    {
        private readonly IEditView _editView;
        private List<Func<string, bool>> _personPropertyRules;

        //ctor
        public EditPresenter(IEditView editView, Person person)
        {
            _editView = editView ?? throw new ArgumentNullException(nameof(editView));

            //редактируемый
            _editView.CurrentPerson = person ?? throw new ArgumentNullException(nameof(person));

            //кнопка
            _editView.OkPerson = new SimpleButtonEventHandler(OnOk, CanOk);
            _editView.OkPerson.CheckEnabled();

            //событие изменений свойств у редактируемого
            _editView.PropertyChanged = new SimpleEventHandler(OnPropertyChanged);

            //правила для проверки
            SetCheckRules();
        }

        /// <summary>
        /// Создание правил для проверки свойств редактируемого
        /// </summary>
        private void SetCheckRules()
        {
            _personPropertyRules = new List<Func<string, bool>>
            {
                new Func<string, bool>(p => String.IsNullOrEmpty(p)),
                new Func<string, bool>(p => p.Equals("<?>"))
            };
        }

        private void OnPropertyChanged()
        {
            //запускаем CanOK();
            _editView.OkPerson.CheckEnabled();
        }

        /// <summary>
        /// Кнопка ОК
        /// </summary>
        /// <returns></returns>
        private bool CanOk()
        {
            List<bool> results = new List<bool>();

            BindingFlags flags = BindingFlags.Instance | BindingFlags.Public;
            var person = _editView.CurrentPerson;
            foreach (var prop in person.GetType().GetProperties(flags))
            {
                if (prop.Name.Equals("Id")) continue;
                if (prop.Name.Equals("ForList")) continue;

                var value = prop.GetValue(person).ToString();
                results.Add(!(String.IsNullOrEmpty(value) || value.Contains("<?>")));
            }

            return results.All(r => r == true);
        }
        private void OnOk()
        {
            Debug.WriteLine("Нажали ОК");
        }
    }
}
