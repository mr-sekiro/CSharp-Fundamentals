namespace _06_Loop_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Loop Statments
            #region for 

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Control Statements 2. Loop Statments [for, foreach]


            //// 1. For

            //// Collection [Array, List, Dictionary]

            //int[] Numbers = { 1, 2, 3, 4, 5 };

            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Numbers[i] += 10;
            //    Console.WriteLine(Numbers[i]);
            //}

            //Console.WriteLine("***********************");

            //// 2. Foreach
            //foreach (int number in Numbers)
            //{
            //    //number += 10; //Invalid Take Copy From Collection XXXXX
            //    Console.WriteLine(number);
            //}


            #endregion

            #region Control Statements 2. Loop Statments [while, do..while]
            ////**** Do While Loop ***////

            //Not Definsive Code
            //int Number;
            //do
            //{
            //    Console.Write("Please Enter An Even Number: ");
            //    Number = int.Parse(Console.ReadLine());
            //} while (Number % 2 == 1);


            //int Number;
            //bool flag = false;
            //do
            //{
            //    Console.Write("Please Enter An Even Number: ");
            //    //Number = int.Parse(Console.ReadLine());
            //    //flag = int.TryParse(Console.ReadLine() , out Number);
            //} while (!int.TryParse(Console.ReadLine(), out Number) || Number % 2 == 1);


            ////**** While Loop ****////

            //int i = 1;

            //while(i <= 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            #endregion
            #endregion
        }
    }
}
