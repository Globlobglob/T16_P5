using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string name=Console.ReadLine();

            switch(name)
            {
                case "Task1":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\tОписать класс счетчика посещения сайта со следующей структурой\n\t");
                    Console.ResetColor();

                    Console.Write("адрес открытой web-странички ");
                    string adress = Console.ReadLine();

                    Console.Write(" ip-адрес посетителя ");
                    string ip = Console.ReadLine();

                    Console.Write(" web-браузер посетителя ");
                    string web = Console.ReadLine();

                    Console.Write("дата визита ");
                    DateTime date = DateTime.Parse(Console.ReadLine());

                    Console.Write("время визита ");
                    DateTime time = DateTime.Parse(Console.ReadLine());

                    Site s1 = new Site(adress, ip, web, date, time);
                    s1.Print();
                    Console.ReadLine();
                    break;

                case "Task2":
                    Console.WriteLine("Enter n ");
                    int n =int.Parse(Console.ReadLine());

                    Conditioner []conditioner=new Conditioner[n];
                     for (int i =0; i < conditioner.Length; i++)
                    {

                        Console.Write("Date on ");
                        DateTime dateon = DateTime.Parse(Console.ReadLine());
                        Console.Write("Time on ");
                        DateTime timeon= DateTime.Parse(Console.ReadLine());
                        Console.Write("Set mode ");
                        string mode=Console.ReadLine();
                        Console.Write(" Set temperature ");
                        int tem=int.Parse(Console.ReadLine());
                        conditioner[i] = new Conditioner(dateon, timeon, mode, tem);
                       
                        Console.ReadLine ();
                     }

                    Console.WriteLine("All activities");
                    foreach (var elem in conditioner) { elem.GetPrint(); }
                    foreach(var elem in conditioner)
                    {
                       if(elem.Dateon > DateTime.Now & elem.Dateon < DateTime.Now.AddDays(1)) 
                       {
                         Console.WriteLine("\ntomorrow:");
                            elem.GetPrint(); 
                       }
                    }
                    
                    Console.ReadLine() ;
                    break;




            }

        }


        
    }
}
