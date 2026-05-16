using Shop_Bartova.Data.Models;
using System.Collections;
using System.Collections.Generic;

namespace Shop_Bartova.Data.Interfaces
{
    public interface IItems
    {
        public IEnumerable<Items> AllItems { get; }
        public int Add(Items Item);
        public bool Update(Items Item);
        public bool Delete(int id);
        public Items GetItemById(int id);
    }
}
