﻿using System;

namespace _30_F3
{
    class Program
    {
        static void Main(string[] args)
        {
            const int largura = 19;
            int cont = 0;
            int contLinha = 1;
            int contFigura = 0;

            for (int altura = 7; cont < altura; cont++)

            {
                if (cont < contLinha) // linha 1
                {

                    for (int caractere = 0; caractere < largura; caractere++)
                    {
                        if (caractere > contFigura)
                        {
                        Console.Write("*");
                        }
                        else 
                        {
                        Console.Write("+");          
                        }
                    }
                    
                    Console.WriteLine();
                }

                contLinha++;
                contFigura++;
            }
        }
    }
}

