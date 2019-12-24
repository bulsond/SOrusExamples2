using System;

namespace WinFormsUI.Models
{
    public class Item
    {
        public string Address { get; }
        public string Answer { get; set; }

        public Item(string address)
        {
            if (string.IsNullOrEmpty(address))
                throw new ArgumentException(nameof(address));

            Address = address;
            Answer = String.Empty;
        }
    }
}
