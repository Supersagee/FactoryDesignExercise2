using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPatterExercise
{
    public class SQLDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product() { Name = "RTX 3080", Price = 699},
            new Product() { Name = "Monitor", Price = 149}
        };

        public List<Product> LoadData()
        {
            Console.WriteLine($"I am reading data from a SQL database");

            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine($"I am saving data from a SQL database");
        }
    }
}
