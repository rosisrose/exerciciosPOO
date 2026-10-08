using exerciciosdePOO;
using System;
using System.Collections.Generic;
using System.Text;

namespace exerciciosdePOO
{

    

    
    
         internal class pessoa
        {
          
            public string nome = "";
            public int idade = 0;
            
            public void Apresentar() // void significa que o método não retorna nada
        {
                Console.WriteLine($"Olá, meu nome é {nome} e tenho {idade} anos.");
            }
        }
    }   