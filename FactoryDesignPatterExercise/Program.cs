using System;

namespace FactoryDesignPatterExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userResponse;
            bool correctResponse;
            
            do
            {
                correctResponse = false;
                Console.WriteLine("What database would you like to use? list, sql, or mongo?");
                userResponse = Console.ReadLine();

                if (userResponse == "list" || userResponse == "sql" || userResponse == "mongo")
                {
                    correctResponse = true;                    
                }
            }while(correctResponse == false);

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
