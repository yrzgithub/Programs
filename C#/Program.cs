// using DataTypes;
using Constants;

class Basics {
    public static void Main(String[] args)
    {
        DataTypes.DataTypes types = new DataTypes.DataTypes();
        types.datatypes();


        Constant constant = new Constant();


        int @int = 143;            // Using pre-defined keyword as variable or identifier.
        Console.WriteLine(@int);   // Accessing the variable.

        string str = @"String";
        Console.WriteLine(str);

        Console.Write("A : ");
        int a = Convert.ToInt32(Console.ReadLine());  // 4 byte or 32 bit

        Console.Write("B : ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("A + B : " + add(a,b));
    }

    public static int add(int a,int b)
    {
        return a+b;
    }
}