namespace _05_Conditional_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Control Statements 
            #region 1. Conditional Statements

            #region Example 01 [Year Quarter] - [If,Switch With Numeric type using Constant Pattern]

            //Console.Write("Please Enter A Month Number Existed in 1st Quarter : ");
            //int.TryParse(Console.ReadLine(), out int monthNumber);

            #region if else
            //if (monthNumber == 1)
            //	Console.WriteLine("Hello January");
            //else if (monthNumber == 2)
            //	Console.WriteLine("Hello February");
            //else if (monthNumber == 3)
            //	Console.WriteLine("Hello March");
            //else
            //	Console.WriteLine("The Entered Month Number is not a Valid Month At First Quarter"); 
            #endregion

            #region switch 
            // Jump Table 
            //switch (monthNumber)
            //{
            //	case 1:
            //		Console.WriteLine("Hello Jan");
            //		break;
            //	case 2:
            //		Console.WriteLine("Hello Feb");
            //		break;
            //	case 3:
            //		Console.WriteLine("Hello March");
            //		break;
            //	default:
            //		Console.WriteLine("The Entered Month Number is not a Valid Month At First Quarter");
            //		break;
            //}
            #endregion

            //Console.ReadKey();
            #endregion

            #region Example 02 [Student Age] - [If,Switch With Numeric type using Relational Pattern]
            /// Age is greater than 22 => Student Age Is greater than 22 
            /// Age is Less than 22 => Student Age Is Less than 22 
            /// Age is 22 => Student Age is 22 

            //Console.Write("Please Enter Student Age : ");
            //int.TryParse(Console.ReadLine(), out int age );

            #region if else
            //if (age > 22)
            //	Console.WriteLine("Student Age Is greater than 22 ");
            //else if (age < 22)
            //	Console.WriteLine("Student Age Is less than 22 ");
            //else
            //	Console.WriteLine("Student Age Is 22 "); 
            #endregion

            #region switch
            // No Jump Table Will be Created 
            //switch( age )
            //{
            //	case > 22:
            //		Console.WriteLine("Student Age Is greater than 22 ");
            //		break;
            //	case < 22:
            //		Console.WriteLine("Student Age Is less than 22 ");
            //		break;
            //	default:
            //		Console.WriteLine("Student Age Is 22");
            //		break;
            //}
            #endregion


            #endregion

            #region Example 03 [Student Name] - [If,Switch With String type]
            /// name = Abdullah => Hello Abdullah 
            /// name = Hussein => Hello Hussein 
            /// name = Ismail => Hello Ismail 

            //Console.Write("Enter Student Name : ");
            //string name = Console.ReadLine() ?? "No Name Entered";

            #region if else 
            //if(name == "Abdullah")
            //	Console.WriteLine("Hello Abdullah");
            //else if(name == "Hussein")
            //	Console.WriteLine("Hello Hussein");
            //else if(name == "Ismail")
            //	Console.WriteLine("Hello Ismail");
            #endregion
            #region switch 
            //// No Jump Table Will Be Created
            //// Compiler will generate a sequence of string comparisons
            //switch (name)
            //{
            //	case "Abdullah":
            //		Console.WriteLine("Hello Abdullah");
            //		break;
            //	case "Hussein":
            //		Console.WriteLine("Hello Hussein");
            //		break;
            //	case "Ismail":
            //		Console.WriteLine("Hello Ismail");
            //		break;
            //}
            #endregion
            #endregion

            #region Example 04 [Budget] - [Switch With Goto]
            /// Budget is 1000 => Option 01
            /// Budget is 2000 => Option 01 , Option 02
            /// Budget is 3000 => Option 01 , Option 02 , Option 03

            //Console.Write("Please Enter Your Budget : ");
            //int.TryParse(Console.ReadLine(), out int Budget);

            //switch(Budget)
            //{
            //	case 1000:
            //		Console.WriteLine("Option 01");
            //		break;
            //	case 2000:
            //		Console.WriteLine("Option 02");
            //		goto case 1000;
            //		//Console.WriteLine("Option 01");
            //		//break;
            //	case 3000:
            //		Console.WriteLine("Option 03");
            //		goto case 2000;
            //		//Console.WriteLine("Option 02");
            //		//Console.WriteLine("Option 01");
            //		//break;
            //}

            #endregion

            #region Goto 

            //Retry:
            //Console.Write("Please Enter Your Name : ");
            //string name = Console.ReadLine();

            //if(name == "Abdullah")
            //	goto Retry;
            //else
            //	Console.WriteLine($"Name is {name}");

            #endregion



            #endregion
            #endregion
        }
    }
}
