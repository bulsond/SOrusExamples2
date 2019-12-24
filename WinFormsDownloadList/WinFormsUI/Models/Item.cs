using System;

namespace WinFormsUI.Models
{
    public class Item
    {
        public string Address { get; }
        public string Response { get; set; }

        public Item(string address)
        {
            if (string.IsNullOrEmpty(address))
                throw new ArgumentException(nameof(address));

            Address = address;
            Response = String.Empty;
        }
    }
}
