using CommonUtilities.Models;
using Dapper;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
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
            string appetizerSql = $"insert into Appetizers (dish_id,Price,Quantity,calories,Type_id,description) values(@dish_id,{item.Prices},{item.Quantity},{item.Calorie},{item.Type_ID},'{item.Description}');";
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
        public bool AddDeserts(Desert desert)
        {
            string dishSql = $"insert into dishes (name) value ('{desert.Name}');  SELECT LAST_INSERT_ID();";
            string desertSql = $"insert into deserts (dish_id,Price,Quantity,calories,description) values(@dish_id,{desert.Prices},{desert.Quantity},{desert.Calorie},'{desert.Description}')";
            using (IDbConnection connection = Connection)
            {
                connection.Open();
                var dish_id = connection.Query<int>(dishSql);
                int count = connection.Execute(desertSql, new
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
        public bool AddMainCourse(Item item)
        {
            string dishSql = $"insert into dishes (name) value ('{item.Name}');  SELECT LAST_INSERT_ID();";
            string mainCourseSql = $"insert into main_course (dish_id,Price,Quantity,calories,Type_id,description) values(@dish_id,{item.Prices},{item.Quantity},{item.Calorie},{item.Type_ID},'{item.Description}')";
            using (IDbConnection connection = Connection)
            {
                connection.Open();
                var dish_id = connection.Query<int>(dishSql);
                int count = connection.Execute(mainCourseSql, new
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
        public bool AddBeverages(Beverage beverage)
        {
            string dishSql = $"insert into dishes (name) value ('{beverage.Name}');  SELECT LAST_INSERT_ID();";
            string beveragesSql = $"insert into bevarages (dish_id,Price,Quantity,calories,alcoholic,description) values(@dish_id,{beverage.Prices},{beverage.Quantity},{beverage.Calorie},{beverage.Alocoholic},'{beverage.Description}')";
            using (IDbConnection connection = Connection)
            {
                connection.Open();
                var dish_id = connection.Query<int>(dishSql);
                int count = connection.Execute(beveragesSql, new
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
        public bool AddEntrees(Item item)
        {
            string dishSql = $"insert into dishes (name) value ('{item.Name}');  SELECT LAST_INSERT_ID();";
            string entreesSql = $"insert into entrees (dish_id,Price,Quantity,calories,Type_id,description) values(@dish_id,{item.Prices},{item.Quantity},{item.Calorie},{item.Type_ID},'{item.Description}')";
            using (IDbConnection connection = Connection)
            {
                connection.Open();
                var dish_id = connection.Query<int>(dishSql);
                int count = connection.Execute(entreesSql, new
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
        public bool AddSalads(Item item)
        {
            string dishSql = $"insert into dishes (name) value ('{item.Name}');  SELECT LAST_INSERT_ID();";
            string saladsSql = $"insert into salads (dish_id,Price,Quantity,calories,Type_id,description) values(@dish_id,{item.Prices},{item.Quantity},{item.Calorie},{item.Type_ID},'{item.Description}')";
            using (IDbConnection connection = Connection)
            {
                connection.Open();
                var dish_id = connection.Query<int>(dishSql);
                int count = connection.Execute(saladsSql, new
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
        public bool AddChefSpecials(Item item)
        {
            string dishSql = $"insert into dishes (name) value ('{item.Name}');  SELECT LAST_INSERT_ID();";
            string chefSpecialsSql = $"insert into chefSpecials (dish_id,Price,Quantity,calories,Type_id,description) values(@dish_id,{item.Prices},{item.Quantity},{item.Calorie},{item.Type_ID},'{item.Description}')";
            using (IDbConnection connection = Connection)
            {
                connection.Open();
                var dish_id = connection.Query<int>(dishSql);
                int count = connection.Execute(chefSpecialsSql, new
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
        public bool AddSoups(Item item)
        {
            string dishSql = $"insert into dishes (name) value ('{item.Name}');  SELECT LAST_INSERT_ID();";
            string soupsSql = $"insert into soups (dish_id,Price,Quantity,calories,Type_id,description) values(@dish_id,{item.Prices},{item.Quantity},{item.Calorie},{item.Type_ID},'{item.Description}')";
            using (IDbConnection connection = Connection)
            {
                connection.Open();
                var dish_id = connection.Query<int>(dishSql);
                int count = connection.Execute(soupsSql, new
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
        public bool AddTables(Tables table)
        {
            IEnumerable<int> result = null;
            string tablesSql = $"insert into tables (Occupancy,Vacancy,Price) values('{table.Occupancy}',{table.Vacancy})";
            using (IDbConnection connection = Connection)
            {
                connection.Open();

                result = connection.Query<int>(tablesSql);

                if (result!=null&&Convert.ToInt32(result)!=0)
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
