using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas
{
    class Aulad17
    {
        public string Nome; 
        public int Idade;
        public double Altura;
    }
    class UtilizandoObj
    {
       // public static void Main()
        {
            Aulad17 Pessoa1 = new Aulad17
            {
                Nome = "Daniel",
                Idade = 24,
                Altura = 1.70
            };
            Console.WriteLine($"{Pessoa1.Nome} tem {Pessoa1.Altura} de altura e {Pessoa1.Idade} anos de idade");
        }
        
    }

}
