using Shop_Bartova.Data.Interfaces;
using Shop_Bartova.Data.Models;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Shop_Bartova.Data.Mocks
{
    public class MockItems: IItems
    {
        public ICategorys _category = new MockCategorys();
        public IEnumerable<Items> AllItems
        {
            get
            {
                return new List<Items>()
                {
                    new Items()
                    {
                        Id = 0,
                        Name = "DEXP MS-70",
                        Description = "Компактная микроволновая печь соло-типа объёмом 20 литров с мощностью нагрева 700 Вт и простым механическим управлением посредством поворотных переключателей \r\nwww.dns-shop.ru\r\n. Модель отличается эмалированным внутренним покрытием, габаритами 44×25,8×35,5 см и доступна в чёрном или белом цвете, что делает её практичным решением для базового разогрева пищи"
                        Img = "https://avatars.mds.yandex.net/get-mpic/5270077/2a000001934e3e26ff00501e54d0f1a7a322/900x1200"
                        Price = 3699,
                        Category = _category.AllCategorys.Where(x=>x.Id == 0).First(),
                    },
                    new Items()
                    {
                        Id = 1,
                        Name = "BBK 20MWS-526M/W",
                        Description = "Микроволновая печь с грилем объёмом 20 литров и мощностью 800 Вт. Оснащена поворотным механизмом, 6 уровнями мощности и таймером на 35 минут. Внутреннее покрытие из нержавеющей стали легко очищается.",
                        Img = "https://avatars.mds.yandex.net/get-mpic/3223885/2a0000018a428e5e8f9c8b5e5c5d5e5f5a5b/900x1200",
                        Price = 5499,
                        Category = _category.AllCategorys.Where(x=>x.Id == 0).First(),
                    },
                    new Items()
                    {
                        Id = 2,
                        Name = "Horoz HZ-271",
                        Description = "Бюджетная микроволновая печь объёмом 23 литра с механическим управлением. Мощность микроволн 700 Вт, 5 уровней мощности, поворотный стол диаметром 24,5 см. Компактный дизайн подойдёт для любой кухни.",
                        Img = "https://avatars.mds.yandex.net/get-mpic/4567123/2a0000018b539f6f9g0d9c6f6d6e6f6g6b6c/900x1200",
                        Price = 4299,
                        Category = _category.AllCategorys.Where(x=>x.Id == 0).First(),
                    },
                    new Items()
                    {
                        Id = 5,
                        Name = "REDMOND RMC-M90",
                        Description = "Мультиварка объёмом 5 литров с мощностью 900 Вт. 35 автоматических программ, отложенный старт до 24 часов, поддержание температуры. Чаша с керамическим покрытием, дисплей, удобное управление.",
                        Img = "https://avatars.mds.yandex.net/get-mpic/1122334/2a0000018e862i9i2j3g2f9i9g9h9i9j9e9f/900x1200",
                        Price = 6999,
                        Category = _category.AllCategorys.Where(x=>x.Id == 1).First(),
                    },
                    new Items()
                    {
                        Id = 6,
                        Name = "Polaris PMC 0517AD",
                        Description = "Компактная мультиварка на 3 литра с 12 программами приготовления. Мощность 500 Вт, таймер отложенного старта, функция подогрева. Идеальный выбор для небольшой семьи или дачи.",
                        Img = "https://avatars.mds.yandex.net/get-mpic/2233445/2a0000018f973j0j3k4h3g0j0h0i0j0k0f0g/900x1200",
                        Price = 3499,
                        Category = _category.AllCategorys.Where(x=>x.Id == 1).First(),
                    },
                };
            }
        }
    }
}
