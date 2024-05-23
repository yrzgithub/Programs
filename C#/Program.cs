// using DataTypes;
using Decisions;
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

        //Console.Write("A : ");
        //int a = Convert.ToInt32(Console.ReadLine());  //  16, 32, 64 bit

        //Console.Write("B : ");
        //int b = Convert.ToInt32(Console.ReadLine());

        //Console.Write("A + B : " + add(a,b));


        Console.WriteLine("Size of int : " + sizeof(int));

        // is and as operator

        Console.WriteLine(constant is Constant);    // Check if a variable is of the given type.
        Console.WriteLine(constant is int);

        Object convertObj = new StringReader("as");
        StringReader reader = convertObj as StringReader;

        Console.WriteLine(reader);



        Decisions.Decisions decision = new Decisions.Decisions();
        decision.decideif();
        decision.decideSwitch(2);
        decision.ElseIf();
    }

    public static int add(int a,int b)
    {
        return a+b;
    }
}