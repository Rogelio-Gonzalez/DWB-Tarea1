using System;
using System.Linq;
using TareaNorthWind.DataAccess;

namespace TareaNorthWind
{
    class Program
    {
        public static void Exercise()
        {
            NorthwindContext dataContext = new NorthwindContext();
            var queryEmp = dataContext.Employees.Select(e => e);

            var output = queryEmp.ToList();
            Console.WriteLine(output);
        }
        static void Main(string[] args)
        {
            Exercise();
        }
    }
}
