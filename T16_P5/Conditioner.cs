using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Conditioner
    {
        DateTime dateon;
         public DateTime Dateon { get => dateon; set => dateon = value; }

        DateTime timeon;
        public DateTime Timeon { get => timeon; set => timeon = value; }

        string mode;
        public string Mode { get => mode; set => mode = value; }

        int tem;
        public int Tem { get =>tem; set => tem=value; }

        Conditioner() { }

       public Conditioner(DateTime dateon, DateTime timeon, string mode , int tem) 
        {
        
            this.dateon = dateon;  this.timeon = timeon; this.mode = mode; this.tem = tem;
            if (tem > 20) { this.mode = "heating"; } else { this.mode = "colling"; }
        }

        public void  GetPrint()
        {
            Console.WriteLine($"\nAll modes {mode}\nAll minutes until conditioner on {(DateTime.Now-dateon).TotalMinutes:F0}");
            Console.WriteLine($"Date on {dateon:d}");
        }

      
    }
}
