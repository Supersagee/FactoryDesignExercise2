using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPatterExercise
{
    public class MongoDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product() { Name = "AirPods", Price = 139},
            new Product() { Name = "PS5", Price = 499}
        };

        public List<Product> LoadData()
        {
            Console.WriteLine($"I am reading data from a Mongo database");

            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine($"I am saving data from a Mongo database");
        }
    }
}
