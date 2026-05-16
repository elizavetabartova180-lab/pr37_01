using System.Collections;
using System.Collections.Generic;
using Shop_Bartova.Data.Common;
using Shop_Bartova.Data.Interfaces;
using Shop_Bartova.Data.Models;
using MySql.Data.MySqlClient;

namespace Shop_Bartova.Data.DataBase
{
    public class DBCategory: ICategorys
    {
        public IEnumerable<Categorys> AllCategorys
        {
            get
            {
                List<Categorys> categorys = new List<Categorys>();
                MySqlConnection MySqlConnection = Connection.MySqlOpen();
                MySqlDataReader CategorysData = Connection.MySqlQuery("SELECT*FROM Shop.Categorys ORDER BY 'Name';", MySqlConnection);
                while (CategorysData.Read())
                {
                    categorys.Add(new Categorys()
                    {
                        Id = CategorysData.IsDBNull(0) ? -1 : CategorysData.GetInt32(0),
                        Name = CategorysData.IsDBNull(1) ? null : CategorysData.GetString(1),
                        Description = CategorysData.IsDBNull(2) ? null : CategorysData.GetString(2)
                    });
                } 
                return categorys;
            }
        }
    }
}
