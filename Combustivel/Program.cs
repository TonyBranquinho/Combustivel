using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combustivel {
    class Program {
        static void Main(string[] args) {

            int codigo, alcool, gasolina, diesel;

            Console.Write("Digite um codigo (1, 2, 3) ou 4 para parar:");
            codigo = int.Parse(Console.ReadLine());

            alcool = 0;
            gasolina = 0;
            diesel = 0;

            while (codigo != 4) {
                Console.Write("Digite um codigo (1, 2, 3) ou 4 para parar:");
                codigo = int.Parse(Console.ReadLine());
                if (codigo == 1) {
                    alcool = alcool + 1;
                }
                else if (codigo == 2) {
                    gasolina = gasolina + 1;
                }
                else if (codigo == 3) {
                    diesel = diesel + 1;
                }
            }
            Console.WriteLine("MUITO ORBIGADO.");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}
