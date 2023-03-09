using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Bases._3._bucles
{
    internal class iteracciones
    {
        void bucleWhile()
        {
            var contador = 1;
            //contar hasta 100
            while (contador <= 100)
            {
                Console.WriteLine(contador);
                contador++;
            }
        }

        void bucleDoWhile()
        {
            var contador = 1;

            do
            {
                Console.WriteLine(contador);
                contador++;
            } while (contador <= 100);
        }

        void bucleFor()
        {
            //contar hasta 100
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
        }

        void bucleForeach()
        {
            var nombre = "Jhan Karlo";

            foreach (var letra in nombre)
            {
                Console.WriteLine(letra);
            }
        }

        void BreakContinue()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i == 5)
                {
                    continue;
                }

                if (i == 90)
                {
                    break;
                }

                Console.WriteLine(i);
            }
        }
    }
}
