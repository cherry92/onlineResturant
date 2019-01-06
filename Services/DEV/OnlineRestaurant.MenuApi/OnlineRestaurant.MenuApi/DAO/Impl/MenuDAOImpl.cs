using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using CommonUtilities.Models;
using Dapper;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace OnlineRestaurant.MenuApi.DAO.Impl
{
    public class MenuDAOImpl : IMenuDAO
    {
        public IConfiguration _config;
        public MenuDAOImpl(IConfiguration config)
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

        public IEnumerable<Item> GetVegAppetizers()
        {
            IEnumerable<Item> result = null;
            string sql = "SELECT d.name,i.calories,i.quantity,i.price  from Appetizers i inner join dishes d on d.dish_id=i.dish_id where i.type_id=1";
            try
            {
                using (IDbConnection connection = Connection)
                {
                    result = connection.Query<Item>(sql).ToList();
                }
            }
            catch(Exception e)
            {
                Console.Write(e.Message);
            }
            return result;

        }
        public IEnumerable<Item> GetChickenAppetizers()
        {
            IEnumerable<Item> result = null;
            string sql = "SELECT d.name,i.calories,i.quantity,i.price  from Appetizers i inner join dishes d on d.dish_id=i.dish_id where i.type_id=2";
            try
            {
                using (IDbConnection connection = Connection)
                {
                    result = connection.Query<Item>(sql).ToList();
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            return result;

        }
        public IEnumerable<Item> GetMuttonAppetizers()
        {
            IEnumerable<Item> result = null;
            string sql = "SELECT d.name,i.calories,i.quantity,i.price  from Appetizers i inner join dishes d on d.dish_id=i.dish_id where i.type_id=3";
            try
            {
                using (IDbConnection connection = Connection)
                {
                    result = connection.Query<Item>(sql).ToList();
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            return result;

        }
        public IEnumerable<Item> GetSeaFoodAppetizers()
        {
            IEnumerable<Item> result = null;
            string sql = "SELECT d.name,i.calories,i.quantity,i.price  from Appetizers i inner join dishes d on d.dish_id=i.dish_id where i.type_id=4";
            try
            {
                using (IDbConnection connection = Connection)
                {
                    result = connection.Query<Item>(sql).ToList();
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            return result;

        }

        public IEnumerable<Beverage> GetAlcoholicBeverages()
        {
            IEnumerable<Beverage> result = null;
            string sql = "SELECT d.name,i.calories,i.quantity,i.price from bevarages i inner join dishes d on d.dish_id=i.dish_id where i.alcoholic=1";
            try
            {
                using (IDbConnection connection = Connection)
                {
                    result = connection.Query<Beverage>(sql).ToList();
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            return result;
        }
        public IEnumerable<Beverage> GetNonAlcoholicBeverages()
        {
            IEnumerable<Beverage> result = null;
            string sql = "SELECT d.name,i.calories,i.quantity,i.price from bevarages i inner join dishes d on d.dish_id=i.dish_id where i.alcoholic=0";
            try
            {
                using (IDbConnection connection = Connection)
                {
                    result = connection.Query<Beverage>(sql).ToList();
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            return result;
        }

        public IEnumerable<Item> GetVegChefSpecials()
        {
            IEnumerable<Item> result = null;
            string sql = "SELECT d.name,i.calories,i.quantity,i.price,i.type_id  from chefSpecials i inner join dishes d on d.dish_id=i.dish_id where i.type_id=1;";
            try
            {
                using (IDbConnection connection = Connection)
                {
                    result = connection.Query<Item>(sql).ToList();
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            return result;
        }
        public IEnumerable<Item> GetChickenChefSpecials()
        {
            IEnumerable<Item> result = null;
            string sql = "SELECT d.name,i.calories,i.quantity,i.price,i.type_id  from chefSpecials i inner join dishes d on d.dish_id=i.dish_id where i.type_id=2;";
            try
            {
                using (IDbConnection connection = Connection)
                {
                    result = connection.Query<Item>(sql).ToList();
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            return result;
        }
        public IEnumerable<Item> GetMuttonChefSpecials()
        {
            IEnumerable<Item> result = null;
            string sql = "SELECT d.name,i.calories,i.quantity,i.price,i.type_id  from chefSpecials i inner join dishes d on d.dish_id=i.dish_id where i.type_id=3;";
            try
            {
                using (IDbConnection connection = Connection)
                {
                    result = connection.Query<Item>(sql).ToList();
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            return result;
        }
        public IEnumerable<Item> GetSeaFoodChefSpecials()
        {
            IEnumerable<Item> result = null;
            string sql = "SELECT d.name,i.calories,i.quantity,i.price,i.type_id  from chefSpecials i inner join dishes d on d.dish_id=i.dish_id where i.type_id=4;";
            try
            {
                using (IDbConnection connection = Connection)
                {
                    result = connection.Query<Item>(sql).ToList();
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            return result;
        }

        public IEnumerable<Desert> GetDeserts()
        {
            IEnumerable<Desert> result = null;
            string sql = "SELECT d.name,i.calories,i.quantity,i.price from deserts i inner join dishes d on d.dish_id=i.dish_id";
            try
            {
                using (IDbConnection connection = Connection)
                {
                    result = connection.Query<Desert>(sql).ToList();
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            return result;
        }

        public IEnumerable<Item> GetVegEntrees()
        {

            IEnumerable<Item> result = null;
            string sql = "SELECT d.name,i.calories,i.quantity,i.price,i.type_id  from entrees i inner join dishes d on d.dish_id=i.dish_id  where i.type_id=1";
            try
            {
                using (IDbConnection connection = Connection)
                {
                    result = connection.Query<Item>(sql).ToList();
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            return result;
        }
        public IEnumerable<Item> GetChickenEntrees()
        {

            IEnumerable<Item> result = null;
            string sql = "SELECT d.name,i.calories,i.quantity,i.price,i.type_id  from entrees i inner join dishes d on d.dish_id=i.dish_id  where i.type_id=2";
            try
            {
                using (IDbConnection connection = Connection)
                {
                    result = connection.Query<Item>(sql).ToList();
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            return result;
        }
        public IEnumerable<Item> GetMuttonEntrees()
        {

            IEnumerable<Item> result = null;
            string sql = "SELECT d.name,i.calories,i.quantity,i.price,i.type_id  from entrees i inner join dishes d on d.dish_id=i.dish_id  where i.type_id=3";
            try
            {
                using (IDbConnection connection = Connection)
                {
                    result = connection.Query<Item>(sql).ToList();
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            return result;
        }
        public IEnumerable<Item> GetSeaFoodEntrees()
        {

            IEnumerable<Item> result = null;
            string sql = "SELECT d.name,i.calories,i.quantity,i.price,i.type_id  from entrees i inner join dishes d on d.dish_id=i.dish_id where i.type_id=4";
            try
            {
                using (IDbConnection connection = Connection)
                {
                    result = connection.Query<Item>(sql).ToList();
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            return result;
        }

        public IEnumerable<Item> GetVegMainCourse()
        {

            IEnumerable<Item> result = null;
            string sql = "SELECT d.name,i.calories,i.quantity,i.price,i.type_id  from main_course i inner join dishes d on d.dish_id=i.dish_id where i.type_id=1";
            try
            {
                using (IDbConnection connection = Connection)
                {
                    result = connection.Query<Item>(sql).ToList();
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            return result;

        }
        public IEnumerable<Item> GetChickenMainCourse()
        {

            IEnumerable<Item> result = null;
            string sql = "SELECT d.name,i.calories,i.quantity,i.price,i.type_id  from main_course i inner join dishes d on d.dish_id=i.dish_id where i.type_id=2";
            try
            {
                using (IDbConnection connection = Connection)
                {
                    result = connection.Query<Item>(sql).ToList();
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            return result;

        }
        public IEnumerable<Item> GetMuttonMainCourse()
        {

            IEnumerable<Item> result = null;
            string sql = "SELECT d.name,i.calories,i.quantity,i.price,i.type_id  from main_course i inner join dishes d on d.dish_id=i.dish_id where i.type_id=3";
            try
            {
                using (IDbConnection connection = Connection)
                {
                    result = connection.Query<Item>(sql).ToList();
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            return result;

        }
        public IEnumerable<Item> GetSeaFoodMainCourse()
        {

            IEnumerable<Item> result = null;
            string sql = "SELECT d.name,i.calories,i.quantity,i.price,i.type_id  from main_course i inner join dishes d on d.dish_id=i.dish_id where i.type_id=3";
            try
            {
                using (IDbConnection connection = Connection)
                {
                    result = connection.Query<Item>(sql).ToList();
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            return result;

        }

        public IEnumerable<Item> GetVegSalads()
        {
            IEnumerable<Item> result = null;
            string sql = "SELECT d.name,i.calories,i.quantity,i.price,i.type_id  from salads i inner join dishes d on d.dish_id=i.dish_id where i.type_id=1";
            try
            {
                using (IDbConnection connection = Connection)
                {
                    result = connection.Query<Item>(sql).ToList();
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            return result;
        }
        public IEnumerable<Item> GetChickenSalads()
        {
            IEnumerable<Item> result = null;
            string sql = "SELECT d.name,i.calories,i.quantity,i.price,i.type_id  from salads i inner join dishes d on d.dish_id=i.dish_id where i.type_id=2";
            try
            {
                using (IDbConnection connection = Connection)
                {
                    result = connection.Query<Item>(sql).ToList();
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            return result;
        }

        public IEnumerable<Item> GetVegSoups()
        {

            IEnumerable<Item> result = null;
            string sql = "SELECT d.name,i.calories,i.quantity,i.price,i.type_id from soups i inner join dishes d on d.dish_id=i.dish_id where i.type_id=1";
            try
            {
                using (IDbConnection connection = Connection)
                {
                    result = connection.Query<Item>(sql).ToList();
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            return result;

        }
        public IEnumerable<Item> GetChickenSoups()
        {

            IEnumerable<Item> result = null;
            string sql = "SELECT d.name,i.calories,i.quantity,i.price,i.type_id from soups i inner join dishes d on d.dish_id=i.dish_id where i.type_id=2";
            try
            {
                using (IDbConnection connection = Connection)
                {
                    result = connection.Query<Item>(sql).ToList();
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            return result;

        }

        public IEnumerable<Tables> GetTables()
        {

            IEnumerable<Tables> result = null;
            string sql = "SELECT * from tables";
            try
            {
                using (IDbConnection connection = Connection)
                {
                    result = connection.Query<Tables>(sql).ToList();
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            return result;

        }
    }
}
