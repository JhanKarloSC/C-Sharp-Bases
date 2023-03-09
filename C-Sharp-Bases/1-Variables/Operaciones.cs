namespace C_Sharp_Bases._1_Variables
{
    internal class Operaciones
    {
        public Operaciones()
        {
            void OperacionesBinarias()
            {
                var numero1 = 30;
                var numero2 = 20;

                var suma = numero1 + numero2;
                var resta = numero1 - numero2;
                var multiplicacion = numero1 * numero2;
                var division = numero1 / numero2;
                var residuo = numero1 % numero2;
            }

            void OperacionesUnitarias()
            {
                var numero1 = 10;
                var numero2 = 20;

                var resultado1 = -numero1;// resultado1 = (-1) * numero1

                var resultado2 = numero1++; // resultado2 = numero1 + 1

                var resultado3 = -numero1--; // resultado3 = numero1 - 1

                var resultado4 = ++numero1; // resultado2 = numero1 + 1

                var resultado5 = --numero1; // resultado3 = numero1 - 1

                var suma1 = numero1++ + numero2;// numero1 + numero2; numero1 = numero1 + 1

                var suma2 = ++numero1 + numero2;// numero1 = numero1 + 1; numero1 + numero2


            }

            void OperacionesAsignacion()
            {
                var numero1 = 10;
                var numero2 = 20;

                var resultado = numero1 + numero2;

                numero1 += numero2;

                numero1 *= numero2;

                numero1 -= numero2;

                numero1 /= numero2;
            }

            void Constantes()
            {
                const int numero1 = 10;

                var valor = Math.PI;

                //numero1 = 1; no es posible
            }

            void Advertencias()
            {
#pragma warning disable CS0219 // Variable is assigned but its value is never used
                var numero1 = 1;
#pragma warning restore CS0219 // Variable is assigned but its value is never used
            }
        }
    }
}
