using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes
{
    public abstract class DataAccess
    {
        // Base

        public virtual string LoadConnectionString(string name)
        {
            Console.WriteLine("Load Connection String");
            return "Test Connection String";
        }

        // Abstract Methodes
        public abstract void LoadData(string sql);
        public abstract void SaveData(string sql);
    }
}
