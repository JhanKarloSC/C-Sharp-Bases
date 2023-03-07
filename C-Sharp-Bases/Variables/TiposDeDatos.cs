namespace C_Sharp_Bases.Variables
{
    internal class TiposDeDatos
    {
        void Enteros()
        {
            int int1 = 100_000_000; // -2.147.483.648 a 2.147.483.647
            uint uint1 = 3_000_000_000; //0 hasta 4.294.967.295

            long long1 = 1_000_000_000_000_000_000;//-9.223.372.036.854.775.808 hasta 9.223.372.036.854.775.807
            ulong ulong1 = 1_000_000_000_000_000_000;//0 hasta 18.446.744.073.709.551.615

            byte byte1 = 150; // 0 hasta el 255
            sbyte sbyte1 = 100; // -128 hasta 127

            short short1 = 30_000; // -32.768 hasta 32.767
            ushort ushort1 = 0; // 0 hasta 65.535
            
        }

        void Flotantes()
        {
            float float1 = 18.123456789f; // ocupa 4 bytes; de 6 a 9 dígitos de precisión
            Console.WriteLine("El float1 es:");
            Console.WriteLine(float1);

            double double1 = 475.955541811545451554d; // ocupa 8 bytes; de 15 a 17 dígitos de precisión
            Console.WriteLine("El double1 es:");
            Console.WriteLine(double1);

            decimal decimal1 = 99.99m; // ocupa 16 bytes; de 28 a 29 dígitos de precisión
            Console.WriteLine("El decimal1 es:");
            Console.WriteLine(decimal1);
        }

        void Booleano()
        {
            bool soyHumano = true;
            bool estoyApagado = false;
        }

        void Textos()
        {
            char unaLetra = 'a';
            string palabra = "Jhan Karlo";
        }
    }
}
