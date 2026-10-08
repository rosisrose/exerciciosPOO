using System;
using System.Collections.Generic;
using System.Text;

namespace exerciciosdePOO
{
    public class retangulo
    {

        public double altura = 3;
        public double largura = 5;

        public double CalcularArea()
        {
            return altura * largura;
        }

        public double CalcularPerimetro() 
        {
            return 2 * (altura + largura); // função que tem retorna precisa de retorno
        }





    }
}
