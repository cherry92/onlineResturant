using Dapper;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using OnlineRestaurant.OwnerApi.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace OnlineRestaurant.OwnerDAO.DAO.Impl
{
    public class OwnerDAOImpl : IOwnerDAO
    {
        public IConfiguration _config;
        public OwnerDAOImpl(IConfiguration config)
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
            string dishSql = $"insert into dishes (name) value ('{item.Name}');  SELECT LAST_INSERT_ID();";
            string appetizerSql = $"insert into Appetizers (dish_id,Name,Price,Quantity,calories,Type_id) values(@dish_id,'{item.Name}',{item.Prices},{item.Quantity},{item.Calorie},{item.Type_ID})";
            using (IDbConnection connection = Connection)
            {
                connection.Open();
                var dish_id = connection.Query<int>(dishSql);
                int count = connection.Execute(appetizerSql, new
                {
                    dish_id = dish_id
                });

                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public bool AddDeserts(Item item)
            {
                string dishSql = $"insert into dishes (name) value ('{item.Name}');  SELECT LAST_INSERT_ID();";
                string desertSql = $"insert into Appetizers (dish_id,Name,Price,Quantity,calories,Type_id) values(@dish_id,'{item.Name}',{item.Prices},{item.Quantity},{item.Calorie},{item.Type_ID})";
                using (IDbConnection connection = Connection)
                {
                    connection.Open();
                    var dish_id = connection.Query<int>(dishSql);
                    int count = connection.Execute(appetizerSql, new
                    {
                        dish_id = dish_id
                    });

                    if (count > 0)
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
