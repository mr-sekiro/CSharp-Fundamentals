namespace _04_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Operators 

            #region Unary Operators [ ++ , -- ]
            //int X = 10;

            ////1. ++
            //// 1.1 PreFix [Increment and Then Print]
            //Console.WriteLine(++X); // 11
            //Console.WriteLine(X); // 11

            //// 1.2 PostFix [Print and Then Increment]
            //Console.WriteLine(X++); // 10 
            //Console.WriteLine(X); // 11


            ////2. --
            //// 2.1 PreFix [Decrement and Then Print]
            //Console.WriteLine(--X); // 9
            //Console.WriteLine(X); // 9

            //// 2.2 PostFix [Print and Then Decrement]
            //Console.WriteLine(X--); // 10 
            //Console.WriteLine(X); // 9
            #endregion

            #region Binary | Arithmetic Operators [+ , - , * , / , %]

            //int sumResult, subResult, mulResult, divResult, modResult;
            //int number01 = 6, number02 = 2;
            //sumResult = number01 + number02; // 8 
            //subResult = number01 - number02; // 4
            //mulResult = number01 * number02; // 12
            //divResult = number01 / number02; // 3
            //modResult = number01 % number02; // 0

            #endregion

            #region Assignment Operators [= , += , -= , *= , /= , %=]

            //int X;
            //X = 4;
            //X += 2; // X = X + 2
            //X -= 2; // X = X - 2
            //X *= 2; // X = X * 2
            //X /= 2; // X = X / 2
            //X %= 2; // X = X % 2

            #endregion

            #region Relational | Comparsion Operators [== , != , < , > , <=, >=]
            //int X = 10, Y = 10;

            //Console.WriteLine(X == Y); // True
            //Console.WriteLine(X != Y); // False 
            //Console.WriteLine(X > Y); // False 
            //Console.WriteLine(X < Y); // False
            //Console.WriteLine(X >= Y); // True 
            //Console.WriteLine(X <= Y); // True

            #endregion

            #region Logical Operators [! , && , ||]
            //// Short Circuit
            //Console.WriteLine(!true); // False
            //Console.WriteLine(false && true); // False
            //Console.WriteLine(false || true); // True 


            //Console.WriteLine(4 < 5 && 7 < 9); // True
            //Console.WriteLine(4 < 5 && 7 > 9); // False
            //Console.WriteLine(4 > 5 && 7 < 9); // False

            #endregion

            #region BitWise Operator [& , | , ^ , ~ , << , >> ]
            //// Long Circuit
            //Console.WriteLine(false & true); // False
            //Console.WriteLine(true | false); // True 
            //Console.WriteLine(false ^ true); // True 

            //int X = 5 , Y = 3; // X = 0101 , Y = 0011
            //Console.WriteLine(X & Y);  // 1 (0101 & 0011 = 0001)
            //Console.WriteLine(X | Y);  // 7 (0101 | 0011 = 0111)
            //Console.WriteLine(X ^ Y);  // 6 (0101 ^ 0011 = 0110)
            //Console.WriteLine(~X);     // -6 (complement of 0101 is 1010)
            //Console.WriteLine(X << 1); // 10 (1010)  
            //Console.WriteLine(X >> 1); // 2  (0010)
            #endregion

            #region Terany Operator [Conditional Operator] [?:]

            //int X = 10, Y = 5;

            //string Message = X > Y ? "X > Y" : "X < Y";

            //Console.WriteLine(Message);
            #endregion

            #region Operators Priority and Associativity

            //int a = 20;
            //int b = 15;
            //int c = 10;
            //int d = 5;
            //int Result;

            //Result = (a + b) * c / d; // ( 20 + 15 ) * 10 / 5 = 70
            //Result = ((a + b) * c) / d; // (( 20 + 15 ) * 10 ) / 5 = 70
            //Result = (a + b) * (c / d); // ( 20 + 15 ) * ( 10 / 5 ) = 70
            //Result = a + (b * c) / d; // 20 + ( 15 * 10 ) / 5 = 50

            #endregion
            #endregion

            #region C# Math
            //Console.WriteLine("Max of 5, 10 is: {0}", Math.Max(5, 10));
            //Console.WriteLine("Min of 5, 10 is: {0}", Math.Min(5, 10));
            //Console.WriteLine("Squir Root of 64 is: {0}", Math.Sqrt(64));
            //Console.WriteLine("Absolute (positive) value of  -4.7 is: {0}", Math.Abs(-4.7));
            //Console.WriteLine("Round of 9.99 is: {0}", Math.Round(9.99)); 
            #endregion

            #region Random Function
            //Random rnd = new Random();

            //for (int j = 0; j < 4; j++)
            //{
            //    Console.WriteLine(rnd.Next(10, 20)); //Console.WriteLine(Random.Shared.Next(10,20)); //returns random integers >= 10 and < 20
            //}
            #endregion
        }
    }
}
