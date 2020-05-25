using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

/// <summary>
/// Обработчик нажатия на кнопку, с возможность вкл./выкл. доступности кнопки
/// 
///     View
///        private BindingSource _bsSimple = new BindingSource();
///        
///         устанавливаем привязки
///         _bsSimple.DataSource = typeof(SimpleButtonEventHandler);
///         _buttonSimple.DataBindings.Add(nameof(_buttonSimple.Enabled), _bsSimple, nameof(SimpleButtonEventHandler.Enabled));
/// 
///         создаем свойство
///         public SimpleButtonEventHandler SimpleButton
///        {
///            get => _bsSimple.Current as SimpleButtonEventHandler;
///            set
///            {
///                if (_bsSimple.Count > 0) return;
///
///                _bsSimple.Add(value);
///                _buttonSimple.Click += value.Handler;
///            }
///        }
/// 
///     Presenter
///         _mainView.SimpleButton = new SimpleButtonEventHandler(OnSimple, CanSimple);
/// 
/// </summary>

namespace ToExcelUI.Views.EventHandlers
{
    public class SimpleButtonEventHandler : SimpleEventHandler, INotifyPropertyChanged
    {
        private Func<bool> _setterEnableProperty;

        //ctor
        public SimpleButtonEventHandler(Action handlerExecutor) : this(handlerExecutor, null)
        {
        }
        public SimpleButtonEventHandler(Action handlerExecutor, Func<bool> setterEnableProperty) : base(handlerExecutor)
        {
            if (setterEnableProperty == null)
            {
                _setterEnableProperty = () => true;
            }
            else
            {
                _setterEnableProperty = setterEnableProperty;
            }
        }


        /// <summary>
        /// Доступность кнопки для нажатия
        /// </summary>
        private bool _Enabled = true;
        public bool Enabled
        {
            get => _Enabled;
            private set
            {
                _Enabled = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Инициализация проверки доступности кнопки
        /// </summary>
        public void CheckEnabled()
        {
            Enabled = _setterEnableProperty();
        }


        //INPC
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
