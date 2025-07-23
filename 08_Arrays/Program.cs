using System.Drawing;
using System.Xml.Linq;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _08_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Arrays - One D Array
            /// int[] Numbers;
            //Numbers = new int[3]; // Will Intitlaize With The Default Value of int = 0


            //Console.WriteLine(Numbers[0]);	// 0
            //Console.WriteLine(Numbers[1]);	// 0
            //Console.WriteLine(Numbers[2]);    // 0


            //Numbers[0] = 1;
            //Numbers[1] = 2;
            //Numbers[2] = 3;

            //Console.WriteLine(Numbers[0]);
            //Console.WriteLine(Numbers[1]);
            //Console.WriteLine(Numbers[2]);

            #region Array Intitlization Ways
            //int[] Numbers02 = new int[3] { 1, 2, 3 };
            //int[] Numbers03 = new int[] { 1, 2, 3 };
            //int[] Numbers04 = { 1, 2, 3 };
            //int[] Numbers05 = [ 1, 2, 3 ]; 
            #endregion

            //Numbers = new int[] { 1, 2, 3 };

            ///// Numbers[4] = 5; // Invalid

            ////Console.WriteLine(Numbers[0]);
            ////Console.WriteLine(Numbers[1]);
            ////Console.WriteLine(Numbers[2]);

            //// Length & Dimenssion

            ////Console.WriteLine($"The Length Of Numbers: {Numbers.Length}");
            ////Console.WriteLine($"The Dimenssion Of Numbers: {Numbers.Rank}");


            //for(int i = 0; i < Numbers.Length; i++)
            //	Console.WriteLine(Numbers[i]);

            //Console.WriteLine("__________________________");

            //foreach(int number in Numbers)
            //	Console.WriteLine(number);

            #endregion

            #region Arrays - Two D Array [Rectangular]
            //int[,] Marks = new int[3, 5] /*{ {1, 2, 3, 4, 5 },{1, 2, 3, 3, 5 },{1, 2, 3, 4, 5 } }*/;

            //Console.WriteLine($"The Length of Marks: {Marks.Length}");
            //Console.WriteLine($"The Deimession of Marks: {Marks.Rank}");

            #region Itterate On 2D Array Using Two Nested Loop

            //bool isParsed;

            /// Insert Values Of Array
            //for(int i = 0; i < Marks.GetLength(0) /*3*/; i++)
            //{
            //	Console.WriteLine($"Please Enter Grades Of Student Number {i + 1}");

            //	for(int j = 0; j < Marks.GetLength(1) /*5*/; /*j++*/)
            //	{
            //		Console.Write($"The Grade Of Subject Number {j + 1}: ");
            //		//isParsed =  int.TryParse(Console.ReadLine(), out Marks[i, j])

            //		//if (isParsed)
            //		//	j++;

            //		j = int.TryParse(Console.ReadLine(), out Marks[i, j]) ? ++j : j; // j = isParsed ? ++j : j;
            //	}

            //using do While
            //for (int i = 0; i < Marks.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Please Enter The Grades Of Student {i + 1}");
            //    int j = 0;
            //    do
            //    {
            //        Console.Write($"The Grade Of Subject {j + 1} : ");
            //        isParsed = int.TryParse(Console.ReadLine(), out Marks[i, j]);
            //        if ( isParsed ) j++;
            //    }
            //    while (j < Marks.GetLength(1));
            //}

            //	Console.WriteLine("=====================================");

            //}

            //Console.Clear();

            ///// Print Array [Marks]
            ///// 

            //for (int i = 0; i < Marks.GetLength(0); i++)
            //{
            //	Console.WriteLine($"The Grade Of Student No: {i + 1}");

            //	for(int j = 0; j < Marks.GetLength(1); j++)
            //	{
            //		Console.WriteLine($"The Grade Of Subject No({j +1}): {Marks[i, j]}");
            //	}

            //	Console.WriteLine("=====================================");
            //} //n^2 
            #endregion

            #region Itterate On 2D Array Using One Loop

            //// Itterate At Elements Of Array To Print Each And Every Element [Using One Loop]
            //int[,] Marks = new int[3, 5];

            //for(int i = 0; i <Marks.Length /*15*/; /*i++*/)
            //{
            //  bool isParsed= int.TryParse(Console.ReadLine(), out int mark);

            //  Marks[i / Marks.GetLength(1)/* to get raw index */, i % Marks.GetLength(1)/* to get column index */] = mark;

            //	//if (isParsed)
            //	//	i++;

            //	i = isParsed ? ++i : i;
            //}

            //Console.Clear();
            //Console.Beep(323, 2000);

            //for (int i = 0; i < Marks.Length; i++)
            //Console.WriteLine(Marks[i / Marks.GetLength(1), i % Marks.GetLength(1)]); // n 
            #endregion

            #endregion

            #region Arrays - Two D Array [Judged Array]

            //Judged Array is a One Dimenssion Array With Deifferent Sizes

            //int[][] Marks = new int[3][];

            //Marks[0] = new int[3] { 9, 8, 2 };
            //Marks[1] = new int[2] { 7, 2 };
            //Marks[2] = new int[1] { 5 };

            #endregion

            #region Array Methods

            //int[] Numbers = { 9, 10, 7, 8, 6, 5, 4, 1, 2, 3, 10 };
            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = new int[5] ;

            #region 1. Class Memeber Methods [Static Method] 

            //Array.Sort(Numbers);

            //Array.Clear(Numbers);

            //Array.Copy(Arr01, Arr02, 4);

            //Array.ConstrainedCopy(Arr01, 1, Arr02, 0, 2);

            //Arr02 = (int[]) Array.CreateInstance(typeof(int), 10); // new int[10]
            //int[,] Arr03 = (int[,]) Array.CreateInstance(typeof(int), 2, 4);
            //int[,,] Arr04 = (int[,,]) Array.CreateInstance(typeof(int), 2, 4, 5);


            //foreach (int number in Arr02)
            //Console.WriteLine(number);

            //int index= Array.IndexOf(Numbers, 10);
            //int index= Array.LastIndexOf(Numbers, 10);
            //Console.WriteLine(index);

            ////String Sorting
            //string[] names = { "Hussein", "Abdullah", "Ismail", "Mohammed" };
            //Array.Sort(names);

            //Console.WriteLine("Sorted Names:");
            //foreach (string name in names)
            //{
            //    Console.Write(name + " ");
            //}

            ////Custom Sorting
            //string[] fruits = { "Apple", "Banana", "Kiwi", "Cherry" };

            //Array.Sort(fruits, (a, b) => a.Length.CompareTo(b.Length));  // Ascending by length

            //Console.WriteLine("Sorted by Length:");
            //foreach (string fruit in fruits)
            //{
            //    Console.Write(fruit + " ");
            //}
            #endregion

            #region 2. Object Memeber Method [Non Static Methods]

            //Arr01.CopyTo(Arr02, 1);

            //foreach(int number in Arr02)
            //Console.WriteLine(number);

            //Arr01.GetLength(0);
            //Arr01.GetValue(1); // Arr01[1]
            //Arr01.SetValue(100, 1); // Arr01[1] = 100

            #endregion

            #endregion

            #region Shallow Copy
            ////Shallow Copy
            ////Definition: Copies the references of the elements, not the actual objects.
            ////Effect: Both arrays point to the same objects in memory.Changing one element in the original array affects the other.

            //string[] original = { "A", "B", "C" };
            //string[] shallowCopy = original;

            //shallowCopy[0] = "Z";
            //Console.WriteLine("HashCode of original : {0}", original.GetHashCode());
            //Console.WriteLine("HashCode of shallowCopy : {0}", shallowCopy.GetHashCode());
            //Console.WriteLine("Original[0]: " + original[0]); // Output: Z (changed!)
            //Console.WriteLine("ShallowCopy[0]: " + shallowCopy[0]); // Output: Z

            #endregion

            #region Deep Copy
            ////Deep Copy
            ////Definition: Creates a new array and copies the actual data, not just references.
            ////Effect: Changing one array does not affect the other.

            //int[] original = { 1, 2, 3 };
            ////int[] deepCopy = new int[original.Length];

            ////for (int i = 0; i < original.Length; i++)
            ////{
            ////    deepCopy[i] = original[i];
            ////}
            //int[] deepCopy = (int[]) original.Clone();
            //deepCopy[0] = 99;

            //Console.WriteLine("HashCode of original : {0}", original.GetHashCode());
            //Console.WriteLine("HashCode of shallowCopy : {0}", deepCopy.GetHashCode());
            //Console.WriteLine("Original[0]: " + original[0]); // Output: 1
            //Console.WriteLine("DeepCopy[0]: " + deepCopy[0]); // Output: 99
            #endregion

        }
    }
}
