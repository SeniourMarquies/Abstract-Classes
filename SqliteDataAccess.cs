using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes
{
    public class SqliteDataAccess : DataAccess
    {
        // Override base loadConnectionString Methode
        // for this, we gonna use override to virtual
        // remember we have use virtual at base methode
        public override string LoadConnectionString(string name)
        {
            string output =  base.LoadConnectionString(name);
            output += "(from Sql Lite)";
            return output;
        }
        // let's override abstract methodes..
        // again we will use override keyword

        public override void LoadData(string sql)
        {
            Console.WriteLine("Loading SqLite Data");
        }
        public override void SaveData(string sql)
        {
            Console.WriteLine("Saving data to SQlite");
        }
    }
}
