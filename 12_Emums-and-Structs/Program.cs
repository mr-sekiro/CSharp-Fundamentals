namespace _12_Emums_and_Structs
{
    enum Gender
    {
        Male,
        Female
    }

    enum Grade : Byte //0-255
    {
        // Labels
        A = 10, B, C = 100, D, E = 254, F
    }

    [Flags] // Attribute
    enum Permission : byte
    {
        Write = 1, Read = 2, Execute = 4, Delete = 8
    }

    class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }
        public Permission Permission { get; set; }
    }

    internal struct Point
    {
        #region Attributes

        public int X;
        public int Y;
        #endregion

        #region Constructors
        public Point()
        {
            X = default; // 0
            Y = default;
        }
        public Point(int _X, int _Y)
        {
            X = _X;
            Y = _Y;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"({/*this.*/X}, {/*this.*/Y})";
        }
        #endregion
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Enum

            #region Example 01
            //Person person = new Person();
            //person.Gender = Gender.Male;
            //Gender X = Gender.Male;

            //Grade G01 = Grade.A;

            //if (G01 == Grade.A)
            //Console.WriteLine(":)");
            //else
            //Console.WriteLine(":(");

            //Grade G01 = (Grade)10;

            //Console.WriteLine(G01); // A 
            #endregion

            #region Example 02
            //Gender myGender;

            //Console.Write("Plese Enter Your Gender:");

            #region Parse Method
            //////myGender = (Gender) Enum.Parse(typeof(Gender), Console.ReadLine() ?? ""); //boxing and unboxing
            ////myGender = Enum.Parse<Gender>(Console.ReadLine() ?? "", true);
            #endregion

            #region TryParse Method
            ////Enum.TryParse(typeof(Gender), Console.ReadLine(), true, out object? obj);
            ////myGender = (Gender?) obj;

            ////Enum.TryParse/*<Gender>*/(Console.ReadLine(), true, out myGender); 
            #endregion

            //Console.WriteLine(myGender); 
            #endregion

            #region Example 03
            //Employee employee = new Employee();
            //employee.Id = 101;
            //employee.Name = "Abdullah";
            //employee.Salary = 9_000;
            //employee.Permission = (Permission)7;
            //Console.WriteLine(role); // 7

            //Permission MyP = (Permission)3; // Write, Read

            ////If U Want To Add "Execute" Permission To MyP, Do OR Bitwise Operation

            //MyP |= Permission.Execute; // MyP = MyP | Permission.Execute
            //                           // 3[0011] | 4 [0100] = 0111 => 0+4+2+1 -> 7

            ////If U Want To Deny "Execute" Permission From MyP, Do NANd Bitwise Operation

            //MyP &= ~(Permission.Read); // 0010 -> 1101 & 0111 = 0101 // 5

            ////If U Want To Toggle Permissions , Do XOR Bitwise Operation

            //MyP ^= Permission.Execute;
            //MyP ^= Permission.Execute;

            ////If U Want To Check Permission is Existed or Not, Do AND Bitwise Operation

            //if((MyP & Permission.Read) == Permission.Read) //permissions.HasFlag(Permission.Read)
            //    Console.WriteLine("Read Permission is Existed");
            //else
            //    Console.WriteLine("Read Permission is Not Existed");

            //Console.WriteLine(MyP);

            //// GetValues
            //foreach (Permission permission in Enum.GetValues(typeof(Permission)))
            //    Console.WriteLine(permission.ToString());
            #endregion

            #endregion

            #region Struct
            //Point P1;

            //P1 = new Point(10, 20);

            ////Console.WriteLine(P1.X); // 10
            ////Console.WriteLine(P1.Y); // 20

            //Console.WriteLine(P1.ToString()); // _12_Emums_and_Structs
            //Console.WriteLine(P1); // _12_Emums_and_Structs
            ////after override ToString()
            //Console.WriteLine(P1.ToString()); //(10, 20)
            //Console.WriteLine(P1); //(10, 20)

            //int X = 10;

            //Console.WriteLine(X.ToString()); // 10 System.Int32 
            #endregion
        }
    }
}
