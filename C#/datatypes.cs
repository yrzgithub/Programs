using System;

namespace DataTypes {
    class DataTypes {
            public void datatypes()
            {
                string bike = "Honda";
                String name = "Hornet";    // String == string

                Console.WriteLine(bike + name);    // speed

                // Integer

                int i = -1;
                uint ui = 2;
                nint ni = 3;
                nuint nui = 4;

                long l = 5;
                ulong ul = 6;

                short s = 7;
                ushort us = 8;

                byte b = 9;
                sbyte sb = -10;

                // Character 

                char c = 'A';

                // Decimal

                float f = 1.5f;                   // f
                double d = 2.5;                   // default
                decimal dec = 3.5m;               // m

                decimal double_2_double = (decimal) d;     // Type Casting
                double @double_2_decimal = (double) dec;

                // Boolean

                bool boolean = true;

                // Constant

                const float pi = 3.14f;

                Console.WriteLine(b);
                Console.WriteLine(s);
                Console.WriteLine(i);
                Console.WriteLine(l);
                Console.WriteLine(ni);

                Console.WriteLine(sb);
                Console.WriteLine(us);
                Console.WriteLine(ui);
                Console.WriteLine(ul);
                Console.WriteLine(nui);

                Console.WriteLine(c);

                Console.WriteLine(f);
                Console.WriteLine(d);
                Console.WriteLine(dec);

                Console.WriteLine(boolean);

                Console.WriteLine(pi);
            }
    }
}