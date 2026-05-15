using Shop_Bartova.Data.Models;
using System.Collections;
using System.Collections.Generic;

namespace Shop_Bartova.Data.Interfaces
{
    public interface IItems
    {
        public IEnumerable<Items> AllItems { get; }
    }
}
