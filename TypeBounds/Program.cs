using System;

namespace TypeBounds
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ByteMin {0} ", byte.MinValue);
            Console.WriteLine("ByteMax {0} ", byte.MaxValue);

            Console.WriteLine("SByteMin {0} ", sbyte.MinValue);
            Console.WriteLine("SByteMax {0} ", sbyte.MaxValue);

            Console.WriteLine("ShortMin {0} ", short.MinValue);
            Console.WriteLine("ShortMax {0} ", short.MaxValue);

            Console.WriteLine("UShortMin {0} ", ushort.MinValue);
            Console.WriteLine("UShortMax {0} ", ushort.MaxValue);

            Console.WriteLine("IntMin {0} ", int.MinValue);
            Console.WriteLine("IntMax {0} ", int.MaxValue);

            Console.WriteLine("UIntMin {0} ", uint.MinValue);
            Console.WriteLine("UIntMax {0} ", uint.MaxValue);

            Console.WriteLine("LongMin {0} ", long.MinValue);
            Console.WriteLine("LongMax {0} ", long.MaxValue);

            Console.WriteLine("ULongMin {0} ", ulong.MinValue);
            Console.WriteLine("ULongMin {0} ", ulong.MaxValue);

            Console.WriteLine("FloatMin {0} ", float.MinValue);
            Console.WriteLine("FloatMin {0} ", float.MaxValue);

            Console.WriteLine("DoubleMin {0} ", double.MinValue);
            Console.WriteLine("DoubleMin {0} ", double.MaxValue);

            Console.WriteLine("DecimalMin {0} ", decimal.MinValue);
            Console.WriteLine("DecimalMin {0} ", decimal.MaxValue);


        }
    }
}
