using System.Collections;
using System.Collections.Generic;
using Shop_Bartova.Data.Models;

namespace Shop_Bartova.Data.ViewModell
{
    public class VMItems
    {
        public IEnumerable<Items> Items { get; set; }
        public IEnumerable<Categorys> Categorys { get; set; }
        public int SelectCategory = 0;
    }
}
