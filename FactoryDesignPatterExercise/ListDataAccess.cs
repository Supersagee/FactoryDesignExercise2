using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPatterExercise
{
    public class ListDataAccess : IDataAccess
    {

        public static List<Product> Products = new List<Product>()
        {
            new Product() { Name = "iPhone 13", Price = 699},
            new Product() { Name = "Keyboard", Price = 49}
        };

        public List<Product> LoadData()
        {
            Console.WriteLine($"I am reading data from a List database");

            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine($"I am saving data from a List database");
        }
    }
}
