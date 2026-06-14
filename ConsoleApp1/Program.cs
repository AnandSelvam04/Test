using ConsoleApp1;
using System.ComponentModel;
namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("2nd branch");
            Add add = new Add();
            add.Addition(4, 5);
        }
    }
}




