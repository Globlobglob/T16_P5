using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Site
    {

        public string Adress { get; set; }
        public string Ip { get; set; }
        public string Web { get; set; }
        public DateTime Date  { get; set; }
        public DateTime Time { get; set; }


        public Site(string adress,string ip,string web, DateTime date,DateTime time) {
        
           Adress = adress;
            Ip = ip;
            Web = web;
            Date = date;
            Time = time;
            
        }

        
        public void Print()
        {
            Console.WriteLine($"\n Адресс {Adress}\n Ip {Ip} \n web-браузер посетителя {Web} \n дата визита {Date:dddd} \n время визита {Time.ToShortDateString()}");
        } 

    }
}
