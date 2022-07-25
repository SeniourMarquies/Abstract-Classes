using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<DataAccess> databases = new List<DataAccess>
            {
                new SqlDataAccess(),
                new SqliteDataAccess()

            };

            foreach (var db in databases)
            {
                Console.WriteLine(db.LoadConnectionString("Demo"));
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
