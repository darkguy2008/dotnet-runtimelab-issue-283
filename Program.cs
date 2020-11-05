using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pomelo.EntityFrameworkCore.MySql causes the bug!
            Pomelo.EntityFrameworkCore.MySql.Storage.CharSet c = new Pomelo.EntityFrameworkCore.MySql.Storage.CharSet("aaa", 123);
            Console.WriteLine("Hello World!");
        }
    }
}
