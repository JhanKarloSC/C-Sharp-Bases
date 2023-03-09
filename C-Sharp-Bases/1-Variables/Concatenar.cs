namespace C_Sharp_Bases._1_Variables
{
    internal class Concatenar
    {
        public Concatenar()
        {
            var nombre = "Jhan Karlo";
            var apellido = "Santamaria";

            var nombreCompleto1 = nombre + apellido;

            var nombreCompleto2 = $"{nombre} {apellido}";

            var nombreCompleto3 = nombre + " " + apellido;

            Console.WriteLine(nombreCompleto1);
            Console.WriteLine(nombreCompleto2);
            Console.WriteLine(nombreCompleto3);

            var numero1 = 1;
            var numero2 = 2;
            var resultado = numero1 + numero2;
            string texto = "La suma de " + numero1 + " + " + numero2 + " es:" + resultado;
            Console.WriteLine(texto);

            Console.WriteLine($"La suma de {numero1} + {numero2} es: {resultado}");
        }
    }
}
