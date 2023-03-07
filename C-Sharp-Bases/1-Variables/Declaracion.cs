namespace C_Sharp_Bases.Variables
{
    public class Declaracion
    {
        void Explisita()
        {
            //int edadPersona;
            //string nombrePersona;
            //bool mayorDeEdad;

            //edadPersona = 30;
            //nombrePersona = "Jhan Karlo";
            //mayorDeEdad = true;

            int edadPersona = 30;
            string nombrePersona = "Jhan Karlo";
            bool mayorDeEdad = true;

            Console.WriteLine(edadPersona);
            Console.WriteLine(nombrePersona);
            Console.WriteLine(mayorDeEdad);

            //int 1Variables = ""; //no es válido
            //int @variable@ = ""; //no es válido
            //int double = 0; //no es válido
            //int string = ""; //no es válido
            //int variable-con-guio = ""; //no es válido

            int miVariable = 0;//Camel Case recomendado
        }

        void Implisita()
        {
            var numeros = 0;
            var texto = "";
            var fecha = DateTime.Now;
            var dinero = 9.99m;
        }

        void ValoresPorDefecto()
        {
            int entero = default; //Por defecto 0
            Console.WriteLine(entero);

            int entero2 = default(int);//0
            Console.WriteLine(entero2);

            bool esVerdaderoONo = default;//falso
            Console.WriteLine(esVerdaderoONo);

            decimal decimal1 = default;//01/01/01
            Console.WriteLine(decimal1);

            DateTime dateTime1 = default;
            Console.WriteLine(dateTime1);

            string texto = default;// null
            Console.WriteLine(texto);
        }
    }
}
