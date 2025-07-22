namespace _03_Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Casting 
            #region Implicit And Explicit Casting

            #region Example 01
            //int X = 10000; // 4 Bytes 
            //long Y = X; // 8 Bytes - Implicit Casting 
            //Console.WriteLine(Y); // 10000

            //long A = 10000;
            ////int B = A; // Invalid Implicitly 
            //int B = (int) A; // Explicit Casting Using Casting Operator
            //Console.WriteLine(B); // 10000


            //long C = 100000000000;
            //int D = (int) C; // Explicit Casting - Unsafe Casting [Might Loss Data] 
            //Console.WriteLine(D); // 1215752192 due to overflow

            //checked
            //{
            //	long E = 100000000000;
            //	int F = (int)E; // Explicit Casting - Unsafe Casting [Might Loss Data] 
            //	unchecked
            //	{
            //		Console.WriteLine(F); // System.OverflowException
            //	}
            //}


            // Protective code

            //long K = 12345678912;

            //if (K > int.MaxValue || K < int.MinValue)
            //{
            //	Console.WriteLine("Exception Will Be Throw Due To Overflow");
            //}
            //else
            //{
            //	int M = (int)K;
            //	Console.WriteLine(M);
            //}
            //// Exception Will Be Throw Due To Overflow

            //int M = K.GetType() == typeof(int) ? (int)K : 0;
            //Console.WriteLine(M); // 0 
            #endregion

            #region Example 02

            //int X = 10; // 4 bytes
            //decimal Y = X; // 16 Bytes  [Implicit Casting]
            //Console.WriteLine(Y); // 10



            //decimal K = 10.100M;
            //int M = (int)K; // Explicit Casting [May Cause Loss Of Data]
            //Console.WriteLine(M); // 10

            #endregion

            #endregion

            #region Convert 

            //Console.WriteLine("Please Enter Your Data");
            //Console.Write("Name : ");
            //string? Name = Console.ReadLine();

            //Console.Write("Age : ");
            //int Age = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Salary : ");
            //decimal Salary = Convert.ToDecimal(Console.ReadLine());

            //Console.Clear();
            //Console.WriteLine("Employee Data :");
            //Console.WriteLine("Name is " + Name);
            //Console.WriteLine("Age is " + Age);
            //Console.WriteLine("Salary is " + Salary);

            #endregion

            #region Parse()
            //Console.WriteLine("Please Enter Your Data");

            //Console.Write("Name : ");
            //string? Name = Console.ReadLine();

            //Console.Write("Age : ");
            //int Age = int.Parse(Console.ReadLine() ?? "0");

            //Console.Write("Salary : ");
            //decimal Salary = decimal.Parse(Console.ReadLine() ?? "0");

            //Console.Clear();
            //Console.WriteLine("Employee Data :");
            //Console.WriteLine("Name is " + Name);
            //Console.WriteLine("Age is " + Age);
            //Console.WriteLine("Salary is " + Salary);
            #endregion

            #region TryParse

            //string number01 = "10";
            //int X01 = int.Parse(number01);
            //Console.WriteLine(X01); // 10

            //string number02 = "Abdullah";
            //int X02 = int.Parse(number02);
            //Console.WriteLine(X02); // System.FormatException


            //string number02 = "Hussein";
            //bool IsParsed = int.TryParse(number02, out int X02); // doesn't throw exceptions
            //Console.WriteLine(IsParsed); // False 
            //Console.WriteLine(X02); // 0

            //string number03 = "10";
            //IsParsed = int.TryParse(number03, out int X03);
            //Console.WriteLine(IsParsed); // True 
            //Console.WriteLine(X03); // 10

            //Console.WriteLine("Please Enter Your Data");

            //Console.Write("Name : ");
            //string? Name = Console.ReadLine();

            //Console.Write("Age : ");
            //int.TryParse(Console.ReadLine() ?? "0", out int Age);

            //Console.Write("Salary : ");
            //decimal.TryParse(Console.ReadLine() ?? "0", out decimal Salary);

            //Console.Clear();
            //Console.WriteLine("Employee Data :");
            //Console.WriteLine("Name is " + Name);
            //Console.WriteLine("Age is " + Age);
            //Console.WriteLine("Salary is " + Salary);

            #endregion

            #endregion

            #region Boxing & UnBoxing

            //object obj;
            #region Boxing


            //obj = new object();
            //obj = new string("Abdullah");
            //obj = "Abdullah";             /// Refernce Type

            //obj = 5;                       // Casting From Value Type {int} To Refernce Type {Object}        --> Boxing 
            ///// obj = 5.5;			     // Casting From Value Type {double} To Refernce Type {Object}	   --> Boxing
            ///// obj = 'A';			     // Casting From Value Type {Char} To Refernce Type {Object}	   --> Boxing
            ///// obj = true;			     // Casting From Value Type {bool} Refernce Type {Object}		   --> Boxing
            ///// obj = new DateTime();      // Casting From Value Type {DateTime} To Refernce Type {Object}   --> Boxing

            //// Casting Implicitly == > Boxing[Safe Casting]

            //Console.WriteLine(obj); 
            #endregion

            #region UnBoxing
            //obj = 5;
            //obj = "";

            //int number;
            ////(int) obj; // Casting From Refernce Type [Object] to Value Type [int]  - ---> UnBoxing
            ///// Casting Explictly --> Unsafe Casting May Throw Exp

            //// number = obj.GetType() == typeof(int) ? (int) obj : 0;
            //number = obj is int ? (int)obj : 0;
            //Console.WriteLine(number); 
            #endregion


            #endregion
        }
    }
}
