using System;

namespace WindowsFormsApp.ViewModel
{
    public class CarsViewModel
    {
        //событие изменения цены
        public event EventHandler<(int from, int to)> PriceChanged;

        private int _priceFrom;
        public int PriceFrom
        {
            get => _priceFrom;
            set
            {
                _priceFrom = value;
                //сообщаем что цена изменилась
                PriceChanged?.Invoke(this, (PriceFrom, PriceTo));
            }
        }

        private int _priceTo;
        public int PriceTo
        {
            get => _priceTo;
            set
            {
                _priceTo = value;
                PriceChanged?.Invoke(this, (PriceFrom, PriceTo));
            }
        }
    }
}
