using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas
{
    class AtributosStaticos
    {
        // não tem static por isso tem que criar um objeto lá em baixo **
        public int Continha(int a, int b, int c)
        {
            return (a + b) * c;
        }
        
        // tem static e por isso está referenciado a classe
        public static double Continha2(int a, int b, int c)
        {
            return (a - b) * c;
        }
        class cAtributos
        {
           // public static void Main()
            {
                // este é o "lá em baixo"**
                AtributosStaticos Conta = new AtributosStaticos();

                Console.WriteLine(Conta.Continha(2, 4, 3));
                // chama com o nome da classe
                Console.WriteLine(AtributosStaticos.Continha2(6, 2, 2));
            }
            
        }
    }

}
