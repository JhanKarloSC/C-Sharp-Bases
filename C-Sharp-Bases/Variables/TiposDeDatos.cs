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
        
    }
}
