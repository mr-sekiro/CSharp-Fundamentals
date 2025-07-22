namespace _10_Methods
{
    /// 1. Class.
    /// 2. Inteface.
    /// 3. Struct.
    /// 4. Enum.
    internal class Program
    {
        /// 1. Class Memeber Methods [Static Methods]
        /// 2. Object Memeber Methods [Non Static Methods]

        #region Function ProtoTyping & Calling
        // Parameters vs.Arguments
        //Parameter A variable in a method definition.It's a placeholder for the value that will be passed in.
        //Argument The actual value you pass into a method when calling it.

        //static void PrintShapes(int count = 5, string pattern = ":)") //default prams must be the last params
        //{
        //    for (int i = 1; i <= count; i++)
        //        Console.WriteLine(pattern);
        //}
        #endregion

        #region Passing Value Type Parameters
        ////parameter order -> mandatory , default , params --------> static void test(int X, int Y = 0, params int[] arr) 
        #region 1. Passing By Value
        //static void Swap(int X, int Y) // Swap(9, 4)
        //{
        //    Console.WriteLine("======== SWAP ========");
        //    int Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}
        #endregion

        #region 2. Passing By Ref

        //static void Swap(ref int X, ref int Y) // Swap(A, B)
        //{
        //    Console.WriteLine("======== SWAP ========");
        //    int Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}

        #endregion

        #endregion

        #region Passing Reference Type Parameters

        #region 1. Passing By Value
        //static int SumArray(int[] Arr) // Arr = Numbers = AddressOf {1, 2, 3}
        //{
        //    int Sum = 0;

        //    if (Arr is not null)
        //    {
        //        Arr = [4, 5, 6];
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            Sum += Arr[i];
        //            //Arr[i] = 0;
        //        }
        //    }

        //    return Sum;
        //}
        #endregion

        #region 2. Passing By Ref

        //static int SumArray(ref int[] Arr) // Arr = Numbers  = {1, 2, 3} => Unreachable Object
        //{
        //    int Sum = 0;

        //    if (Arr is not null)
        //    {
        //        Arr = [4, 5, 6];
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            Sum += Arr[i];
        //            //Arr[i] = 0;
        //        }
        //    }

        //    return Sum;
        //}

        #endregion

        #endregion

        #region Passing By Out

        //static void SumMul(int X, int Y, out int Sum, out int Mul)
        //{
        //    Sum = X + Y;
        //    Mul = X * Y;

        //}

        #endregion

        #region Params

        /// static int SumArray(int X, int Y = 5, params int[] Arr) 
        /// {
        /// 	int Sum = 0;
        /// 
        /// 	if (Arr is not null)
        /// 		for (int i = 0; i < Arr.Length; i++)
        /// 			Sum += Arr[i];
        /// 
        /// 	return Sum;
        /// }

        /// static int SumArray( params IEnumerable<int> Arr) //using collection other than arrays is not allowed before .net 9.0
        /// {
        /// 	int Sum = 0;
        /// 
        /// 	if (Arr is not null)
        /// 		foreach(int number in Arr)
        /// 			Sum += number;
        /// 
        /// 	return Sum;
        /// }

        /// static void Concat<T>(params ReadOnlySpan<T> items)
        /// {
        /// 	for (int i = 0; i < items.Length; i++)
        /// 		Console.WriteLine($"{items[i]} ");
        /// 
        /// }

        #endregion
        static void Main(string[] args) // Entry Point
        {
            #region Function ProtoTyping & Calling

            //PrintShapes(12, "#_#"); // Passing Parameters By The Same Order
            // PrintShapes(pattern: "-_-", count: 10); // Passing Parameters By Naming
            // PrintShapes(pattern: "$_$");

            #endregion

            #region Passing Value Type Parameters
            //int A = 9, B = 4;

            //Console.WriteLine($"A: {A}");
            //Console.WriteLine($"B: {B}");

            //Swap(A, B);               // 1. Passing By Value [Input Parameters]
            //                          // Swap(9, 4)

            ////Swap(ref A, ref B);        // 2. Passing By Ref [Input Output Parameter]
            //                             // Swap(A, B)
            //Console.WriteLine($"A: {A}");
            //Console.WriteLine($"B: {B}");
            #endregion

            #region Passing Reference Type Parameters
            //int[] Numbers = { 1, 2, 3 };

            //Console.WriteLine($"First Element Before Calling the Method : {Numbers[0]}");


            ////int Result = SumArray(Numbers); // 1. Passing By Value [Input Parametr] // SumArray(Address of Array [1, 2, 3])

            //int Result = SumArray(ref Numbers); // 2. Passing By Ref [Input Output PArameter] // SumArray(Numbers)

            //Console.WriteLine($"The Sum of The Array : {Result}");
            //Console.WriteLine($"First Element After Calling the Method : {Numbers[0]}");
            #endregion

            #region Passing By Out
            //int A = 3, B = 4, SumResult, MulResult;

            //SumMul(A, B, out  SumResult, out  MulResult);

            //Console.WriteLine($"Sum: {SumResult}");
            //Console.WriteLine($"Mul: {MulResult}");

            //int.TryParse("Abdullah", out int Result);
            //Console.WriteLine(Result); 
            #endregion

            #region Params
            //// int[] arrayOfNumbers = { 1, 2, 3, 4, 5, 6, 7 };
            ////List<int> listOfNumbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };

            ////int Result = SumArray(listOfNumbers);

            ////Console.WriteLine(Result);
            #endregion
        }
    }
}
