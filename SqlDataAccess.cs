using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes
{
    public class SqlDataAccess : DataAccess
    {
        public override string LoadConnectionString(string name)
        {
            return base.LoadConnectionString(name);
        }
        public override void LoadData(string sql)
        {
            Console.WriteLine("loading Sql Data");
        }
        public override void SaveData(string sql)
        {
            Console.WriteLine("Saving Sql Data");
        }
    }
}
