using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Worker
    {
         int tablenum;
        public int Tablenum { get => tablenum; set => tablenum=value; }
        /// <summary>
        /// initialize surname field
        /// </summary>
        string surname;
        public string Surname { get => surname; set =>surname=(value!="")?value:"Unknown"; }

        /// <summary>
        /// initialize name field
        /// </summary>
        string name;
        public string Name { get => name;set=>name=(value!="")?value:"Unknown"; }

        /// <summary>
        /// initialize lastname fiiled
        /// </summary>
        string lastname;
        public string Lastname { get => lastname; set => lastname = (value != "") ? value : "Unknown"; }
        /// <summary>
        /// init date filed DateTime
        /// </summary>
        private DateTime date;
        public DateTime Date { get => date; set => date =value; }

        /// <summary>
        /// initialize string post 
        /// </summary>
        private string post;
        public string Post { get => post; set => post = (value!="")?value:"Unknown"; }
        /// <summary>
        /// initialize int money field
        /// </summary>
        private int money;
        public int Money { get => money; set => money = (value!=0)?value:0  ; }

        /// <summary>
        /// non static constructor with parameters
        /// </summary>
        /// <param name="surname"></param>
        /// <param name="date"></param>
        /// <param name="post"></param>
        /// <param name="money"></param>
        public Worker(string name,string surname, string lastname, DateTime date,string post,int money)
        {
            this.lastname = lastname;
            this.name = name;
            this.surname = surname;
            this.date = date;
            this.post = post;
            this.money = money;
            if (date.Month < DateTime.Now.Month) { Console.WriteLine( date.AddYears(-1)); }

        }
        /// <summary>
        /// method print with output 
        /// </summary>
        public void Print()
        {
            Console.WriteLine($" \nName {name}\nSurname {surname}\n LastName {lastname}\nDate:{date:d}\nPost:{post}\nMoney:{money}\nAgeWorker:{DateTime.Now.Year-date.Year}");
        }




       
    }
}
