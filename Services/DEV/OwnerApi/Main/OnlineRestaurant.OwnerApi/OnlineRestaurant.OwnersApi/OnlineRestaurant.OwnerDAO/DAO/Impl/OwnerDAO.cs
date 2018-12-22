using Dapper;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using OnlineRestaurant.OwnerDAO.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace OnlineRestaurant.OwnerDAO.DAO.Impl
{
    public class OwnerDAO : IOwnerDAO
    {
        public IConfiguration _config;
        public OwnerDAO(IConfiguration config)
        {
            this._config = config;
        }

        public IDbConnection Connection
        {
            get
            {
                return new MySqlConnection(_config.GetConnectionString("OnlineRestaurantConnectionString"));
            }
        }
        public bool AddAppetizers(Item item)
        {
            string dishSql = $"insert into dish (name) value ({item.Name});  SELECT LAST_INSERT_ID();";
            string appetizerSql = $"insert into Appetizer (Name,Price,Quantity,calories,Type_id,dish_id) values({item.Name},{item.Prices},{item.Calorie},{item.Type_ID},@dish_id)";
            using (IDbConnection connection = Connection)
            {
                connection.Open();
                int dish_id = connection.Execute(dishSql);
                int count = connection.Execute(appetizerSql, new
                {
                    dish_id = dish_id
                });

                if (count > 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
    }
}
