using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas
{

    class ExercicioMetodosComRetorno

    {
        public double Conversao(double real)
        {
            return real / 4.8;
        }
    }
   
    public class Convert
    {
        //public static void Main()
        {
            ExercicioMetodosComRetorno conv = new ExercicioMetodosComRetorno();
            Console.WriteLine("Digite o valor em real: ");
            double.TryParse(Console.ReadLine(), out double real);
            ///Console.WriteLine($"Valor em dolar: {ExercicioMetodosComRetorn}");
        }
    }

}

  