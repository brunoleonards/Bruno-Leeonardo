using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i >= 1; i = i - 1) 
            {
                Console.WriteLine("Esse é" + i + "ª");
            }
            for ( int L = 1; L <= 100; L = L + 1)
            {
                Console.WriteLine("Serie é "+ L +"º");
            }
            
        }
       
        
    }
}
