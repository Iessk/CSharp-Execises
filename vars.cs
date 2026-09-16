using System;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {


            byte b1 = 255;

            sbyte sb1 = -128;
            sbyte sb2 = 127;
            Console.WriteLine("\nByte : ");
            Console.WriteLine("Min = {0} , Max = {1}", Byte.MinValue, Byte.MaxValue);


            Console.WriteLine("\nSByte : ");
            Console.WriteLine("Min = {0} , Max = {1}", SByte.MinValue, SByte.MaxValue);

            short s1 = -32768;
            short s2 = 32767;

            ushort us1 = 65535;

            Console.WriteLine("\nShort : ");
            Console.WriteLine("Min = {0} , Max = {1}", Int16.MinValue, Int16.MaxValue);

            Console.WriteLine("\nUShort : ");
            Console.WriteLine("Min = {0} , Max = {1}", UInt16.MinValue, UInt16.MaxValue);

            int i = -2147483648;
            int j = 2147483647;

            uint ui1 = 4294967295;

            Console.WriteLine("\nInt : ");
            Console.WriteLine("Min = {0} , Max = {1}", Int32.MinValue, Int32.MaxValue);

            Console.WriteLine("\nUInt : ");
            Console.WriteLine("Min = {0} , Max = {1}", UInt32.MinValue, UInt32.MaxValue);

            long l1 = -9223372036854775808;
            long l2 = 9223372036854775807;

            ulong ul1 = 18223372036854775808ul;
            ulong ul2 = 18223372036854775808UL;

            Console.WriteLine("\nLong : ");
            Console.WriteLine("Min = {0} , Max = {1}", Int64.MinValue, Int64.MaxValue);

            Console.WriteLine("\nULong:");
            Console.WriteLine("Min = {0} , Max = {1}", UInt64.MinValue, UInt64.MaxValue);


            float f1 = 123456.5F;
            float f2 = 1.123456f;

            Console.WriteLine("\nFloat : ");
            Console.WriteLine("Min = {0} , Max = {1}", float.MinValue, float.MaxValue);


            double d1 = 12345678912345.5d;
            double d2 = 1.123456789123456d;

            Console.WriteLine("\nDouble : ");
            Console.WriteLine("Min = {0} , Max = {1}", double.MinValue, double.MaxValue);


            decimal d3 = 123456789123456789123456789.5m;
            decimal d4 = 1.1234567891345679123456789123m;

            Console.WriteLine("\nDecimal : ");
            Console.WriteLine("Min = {0} , Max = {1}", decimal.MinValue, decimal.MaxValue);


            //Use e or E to indicate the power of 10 

            double d = 0.12e2;
            Console.WriteLine(d);  // 12;

            float f = 123.45e-2f;
            Console.WriteLine(f);  // 1.2345

            decimal m = 1.2e6m;
            Console.WriteLine(m);// 1200000


            //hex & Binary
            int hex = 0x2F;
            int binary = 0b_0010_1111;

            Console.WriteLine(hex);
            Console.WriteLine(binary);

            Console.ReadKey();

        }
    }
}
