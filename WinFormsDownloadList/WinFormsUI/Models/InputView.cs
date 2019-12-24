using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsUI.Models
{
    class InputView
    {
        public string Address { get; set; }
        public string Parameter { get; set; }
        public int From { get; set; }
        public int To { get; set; }

        public List<Item> GetItems()
        {
            List<Item> items = new List<Item>();


            return items;
        }
    }
}
