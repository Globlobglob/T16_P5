using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("enter n num");
            int n = int.Parse(Console.ReadLine());

            Worker[] omas = new Worker[n];
            for (int i = 0; i < omas.Length; i++)
            {
                Console.WriteLine("Worker Name ");
                string name = Console.ReadLine();
                Console.WriteLine("Worker Surname");
                string surname = Console.ReadLine();
                Console.WriteLine("Worker LastName");
                string lastname = Console.ReadLine();
                Console.WriteLine("Date year YYYY:MM:DD ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Post ");
                string post = Console.ReadLine();
                Console.WriteLine("Money ");
                int money = int.Parse(Console.ReadLine());
                    omas[i]= new Worker(name,surname,lastname, date, post, money);
                Console.WriteLine();
            }

            foreach(var num in omas)
            {
                Worker w1 = new Worker(num.Name, num.Surname, num.Lastname, num.Date, num.Post, num.Money);
                w1.Print();
            }
            Console.ReadKey();
        }
    }
}
