using System;

/// <summary>
/// Простейший обработчки события
/// 
///     View
///         private SimpleEventHandler _EventButton;
///         public SimpleEventHandler EventButton
///         {
///            get => _EventButton;
///            set
///            {
///                if (_EventButton != null) return;
///
///                _EventButton = value;
///                _buttonEventSimple.Click += value.Handler;
///            }
///        }
/// 
/// 
///     Presenter
///         _mainView.EventButton = new SimpleEventHandler(OnEvent);
/// 
/// </summary>

namespace ToExcelUI.Views.EventHandlers
{
    public class SimpleEventHandler
    {
        private Action _handlerExecutor;

        //ctor
        public SimpleEventHandler(Action handlerExecutor)
        {
            _handlerExecutor = handlerExecutor ??
                throw new ArgumentNullException(nameof(handlerExecutor));

            Handler = new EventHandler(OnEvent);
        }

        /// <summary>
        /// Ссылка на метод,
        /// который буден вызван при возникновении события у целевого контрола 
        /// </summary>
        public EventHandler Handler { get; private set; }

        /// <summary>
        /// Вызов по событию исполняемого метода
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnEvent(object sender, EventArgs e)
        {
            _handlerExecutor();
        }
    }
}
