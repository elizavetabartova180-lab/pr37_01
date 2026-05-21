using MySql.Data.MySqlClient;
using Shop_Bartova.Data.Common;
using Shop_Bartova.Data.Interfaces;
using Shop_Bartova.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace Shop_Bartova.Data.DataBase
{
    public class DBItems :IItems
    {
        public IEnumerable<Categorys> Categorys = new DBCategory().AllCategorys;
        public IEnumerable<Items> AllItems
        {
            get
            {
                List<Items> items = new List<Items>();
                MySqlConnection MySqlConnection = Connection.MySqlOpen();
                MySqlDataReader ItemsData = Connection.MySqlQuery("SELECT*FROM Shop.items ORDER BY 'Name';", MySqlConnection);
                while (ItemsData.Read())
                {
                    items.Add(new Items()
                    {
                        Id = ItemsData.IsDBNull(0) ? -1 : ItemsData.GetInt32(0),
                        Name = ItemsData.IsDBNull(1) ? "" : ItemsData.GetString(1),
                        Description = ItemsData.IsDBNull(2) ? "" : ItemsData.GetString(2),
                        Img = ItemsData.IsDBNull(3) ? "" : ItemsData.GetString(3),
                        Price = ItemsData.IsDBNull(4) ? -1 : ItemsData.GetInt32(4),
                        Category = ItemsData.IsDBNull(5) ? null : Categorys.Where(x=>x.Id == ItemsData.GetInt32(5)).First()
                    });
                }
                MySqlConnection.Close();
                return items;
            }
        }
        public int Add(Items Item)
        {
            MySqlConnection MySqlConnection = Connection.MySqlOpen();
            Connection.MySqlQuery(
                $"INSERT INTO `Items`( `Name`, `Description`, `Img`, `Price`, `IdCategory`) VALUES('{Item.Name}', '{Item.Description}', '{Item.Img}',{Item.Price}, {Item.Category.Id});", 
                MySqlConnection);
            MySqlConnection.Close() ;
            int IdItem = -1;
            MySqlConnection = Connection.MySqlOpen();
            MySqlDataReader mySqlDataReaderItem = Connection.MySqlQuery(
                $"SELECT `Id` FROM `items` WHERE `Name` = '{Item.Name}' AND `Description` = '{Item.Description}' AND `Price` = {Item.Price} AND `IdCategory` = {Item.Category.Id};",
                MySqlConnection);
            if (mySqlDataReaderItem.HasRows)
            {
                mySqlDataReaderItem.Read();
                IdItem = mySqlDataReaderItem.GetInt32(0);
            }
            MySqlConnection.Close();
            return IdItem;
        }
        public Items GetItem(int id)
        {
            MySqlConnection MySqlConnection = Connection.MySqlOpen();
            MySqlDataReader mySqlDataReaderItem = Connection.MySqlQuery(
                $"SELECT * FROM `Items` WHERE `Id` = {id};",
                MySqlConnection);
            Items item = null;
            if (mySqlDataReaderItem.HasRows)
            {
                mySqlDataReaderItem.Read();
                item = new Items()
                {
                    Id = mySqlDataReaderItem.IsDBNull(0) ? -1 : mySqlDataReaderItem.GetInt32(0),
                    Name = mySqlDataReaderItem.IsDBNull(1) ? "" : mySqlDataReaderItem.GetString(1),
                    Description = mySqlDataReaderItem.IsDBNull(2) ? "" : mySqlDataReaderItem.GetString(2),
                    Img = mySqlDataReaderItem.IsDBNull(3) ? "" : mySqlDataReaderItem.GetString(3),
                    Price = mySqlDataReaderItem.IsDBNull(4) ? -1 : mySqlDataReaderItem.GetInt32(4),
                    Category = mySqlDataReaderItem.IsDBNull(5) ? null : Categorys.Where(x => x.Id == mySqlDataReaderItem.GetInt32(5)).First()
                };
            }
            MySqlConnection.Close();
            return item;
        }
        public int Update(Items Item)
        {
            MySqlConnection MySqlConnection = Connection.MySqlOpen();
            Connection.MySqlQuery(
                $"UPDATE `Items` SET `Name` = '{Item.Name}', `Description` = '{Item.Description}', `Img` = '{Item.Img}', `Price` = {Item.Price}, `IdCategory` = {Item.Category.Id} WHERE `Id` = {Item.Id};",
                MySqlConnection);
            MySqlConnection.Close();
            return Item.Id;
        }
        public bool Delete(int id)
        {
            MySqlConnection MySqlConnection = Connection.MySqlOpen();
            Connection.MySqlQuery(
                $"DELETE FROM `Items` WHERE `Id` = {id};",
                MySqlConnection);
            MySqlConnection.Close();
            return true;
        }
    }
}

