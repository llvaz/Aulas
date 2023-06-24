using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas
{
    class AulaPt2
    {
        public string NomeProd;
        public double Preco;
        public static double Desc = 0.5;

        public AulaPt2()
        {

        }
        public AulaPt2(string nomeProd, double preco)
        {
            NomeProd = nomeProd;
            Preco = preco;
        }
        public double CalValor()
        {
            double ValorComDesconto = Preco - (Preco * Desc);
            return ValorComDesconto;
        }

    }
}

