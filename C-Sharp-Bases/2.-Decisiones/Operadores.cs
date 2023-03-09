using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Bases._2._Decisiones
{
    internal class Operadores
    {
        public Operadores()
        {
            //Boleano
            var numero = 10;

            var esValido = numero > 5 && numero < 20;
            var esValido2 = numero > 5 || numero == 20;

            var nombre = "jhankarlo";
            var esIgual = nombre == "jhankarlo";

            //true && true => true
            //true && false => false
            //false && true => false
            //false && false => false

            //true || true => true
            //true || false => true
            //false || true => true
            //false || false => false
        }

        public void sentenciaIf()
        {
            var numero = 10;

            if (numero > 0)
            {
                Console.WriteLine("Es mayor que 0");
            }

            if (numero > 0)
                Console.WriteLine("Es mayor que 0");

            if (numero > 0)
            {
                Console.WriteLine("Es mayor que 0");
            }
            else
            {
                Console.WriteLine("Es menor que 0");
            }

            if (numero > 0)
                Console.WriteLine("Es mayor que 0");
            else
                Console.WriteLine("Es menor que 0");

            if (numero == 0)
            {
                Console.WriteLine("Es igual a 0");
            }
            else if (numero > 10)
            {
                Console.WriteLine("Es mayor a 10");
            }
            else if (numero > 20)
            {
                Console.WriteLine("Es mayor a 20");
            }
            else
            {
                Console.WriteLine("Condición por defecto");
            }
        }

        void Ternario()
        {
            var numero = 11;
            var esValido = numero > 10 ? "Si es mayor" : "No es mayor";
        }

        void sentenciaSwitch()
        {
            var posicion = 10;

            switch (posicion)
            {
                case 1:
                    Console.WriteLine("Lugar 1");
                    break;
                case 2:
                    Console.WriteLine("Lugar 2");
                    break;
                case 3:
                    Console.WriteLine("Lugar 3");
                    break;
                default:
                    Console.WriteLine("No ganaste");
                    break;
            }
        }

        void patronesRelacionales()
        {
            var edad = 31;

            var mensaje = edad switch
            {
                >= 18 => "Mayor edad",
                <= 17 => "Menor edad"
            };
        }

        void patronesLogicos()
        {
            string? nombre = "Jhan Karlo";

            if (nombre is not null)
            {
                Console.WriteLine(nombre.ToUpper());
            }

            var edad = 18;
            var mensaje = edad switch
            {
                > 0 and < 18 => "Menor edad",
                >= 18 => "Mayor edad"
            };

            var fecha = DateTime.Today;

            var parteAnio = fecha.Month switch
            {
                1 or 2 or 3 or 4 or 5 or 6 => "Primera parte del año",
                7 or 7 or 8  or 9 or 10 or 11 or 12 =>"Segunda parte del año",
                _ => "no hay que decir"
            };
        }

        void expresionSwitchDiscard()
        {
            var edad = 65;
            var mensaje = edad switch
            {
                >64=>"adulto mayor",
                _ => "nara"
            };
        }
    }
}
