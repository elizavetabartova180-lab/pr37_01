using Shop_Bartova.Data.Interfaces;
using Shop_Bartova.Data.Models;
using System.Collections.Generic;

namespace Shop_Bartova.Data.Mocks
{
    public class MockCategorys: ICategorys
    {
        public IEnumerable<Categorys> AllCategorys
        {
            get
            {
                return new List<Categorys>
                {
                    new Categorys()
                    {
                        Id = 0,
                        Name = "Микроволновые печи",
                        Description = "Микроволновые печи для быстрого разогрева, разморозки и приготовления пищи. В каталоге представлены модели соло-типа, с грилем и конвекцией — от бюджетных до премиум-класса."
                    },
                    new Categorys()
                    {
                        Id = 1,
                        Name = "Мультиварки",
                        Description = "Мультиварки для автоматического приготовления блюд: от каш и супов до выпечки и йогуртов. Устройства с различными программами, объёмом чаши и функциями отложенного старта."
                    }
                };
            }
        }
    }
}
