using System;

namespace FactoryDesignPatterExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userResponse = null;
            bool correctResponse = false;

            Console.WriteLine("What database would you like to use? list, sql, or mongo?");

            while (correctResponse == false)
            {
                
                userResponse = Console.ReadLine();
                var lowered = userResponse.ToLower();

                if (lowered == "list" || lowered == "sql" || lowered == "mongo")
                {
                    correctResponse = true;
                    break;
                }

                Console.WriteLine("Try again. You can only pick from a list, sql, or mongo.");
            }

            Console.Clear();

            var userDatabase = DataAccessFactory.GetDataAccessType(userResponse);

            var products = userDatabase.LoadData();

            foreach (Product product in products)
            {
                Console.WriteLine($"Item: {product.Name} - ${product.Price}");
            }
            
            userDatabase.SaveData();
        }
    }
}
