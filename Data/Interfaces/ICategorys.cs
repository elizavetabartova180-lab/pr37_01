using Shop_Bartova.Data.Models;
using System.Collections.Generic;

namespace Shop_Bartova.Data.Interfaces
{
    public interface ICategorys
    {
        public IEnumerable<Categorys> AllCategorys { get; }

    }
}
