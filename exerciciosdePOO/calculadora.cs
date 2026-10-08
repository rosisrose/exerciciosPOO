using System;
using System.Collections.Generic;
using System.Text;

namespace exerciciosdePOO
{
    public class calculadora
    {
        public int a = 0;
        public int b = 0;

       public int soma()
        {
            return a + b;
        }

        public int subtrai ()
        {
            return a - b;
        }

        public void MostarCalculo()
        {
            Console.WriteLine($"a soma deu : {soma()} e a subtração seu: {subtrai()}"); // quando for declarar subtrai e soma são metodos não variavel tem que declarar soma()

        }


    }
}
