namespace _11_Exception_Handling
{
    internal class Program
    {
        /*Exception
        //// 1. SystemException (software)
        ////////// 1. FormatException
        ////////// 2. IndexOutOfRangeException
        ////////// 3. NullRefernceException
        ////////// 4. InvalidOperationException
        ////////// 5. ArithmeticException
        //////////////// 5.1. DivideByZeroException
        //////////////// 5.2. OverflowException
        //// 2. ApplicationException (hardware)
        */

        #region Exception Handling & Protective Code
        //static void DoSomeCode()
        //{
        //    try
        //    {
        //        int X, Y, Z;

        //        X = int.Parse(Console.ReadLine() ?? "0");
        //        Y = int.Parse(Console.ReadLine() ?? "0");

        //        Z = X / Y;

        //        int[] Arr = { 1, 2, 3 };
        //        Arr[100] = 20;
        //    }

        //    catch (Exception ex)
        //    {
        //        // Friendly Message
        //        Console.WriteLine(ex.Message);
        //    }
        //}

        //static void DoSomeProtectiveCode()
        //{

        //    int X, Y, Z;

        //    do
        //    {
        //        Console.Write("Enter The First Number: ");

        //    } while (!int.TryParse(Console.ReadLine(), out X));


        //    do
        //    {
        //        Console.Write("Enter The Second Number: ");


        //    } while (!int.TryParse(Console.ReadLine(), out Y) || Y == 0);

        //    Z = X / Y;

        //    int[] Arr = { 1, 2, 3 };

        //    if (Arr?.Length > 100)
        //        Arr[100] = 20;

        //}
        #endregion
        static void Main(string[] args)
        {
            #region Exception Handling & Protective Code
            //try
            //{
            //	DoSomeProtectiveCode();
            //	throw new Exception();	
            //}
            //catch (Exception ex)
            //{

            //	Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //	// DeAllocate | Release | Free | Close | Delete UnManaged Resources [DB Connection | File]
            //	Console.WriteLine("Finally");
            //} 
            #endregion
        }
    }
}
