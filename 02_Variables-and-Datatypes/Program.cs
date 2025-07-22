using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Numerics;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _02_Variables_and_Datatypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Variables
            //The variable name can contain letters(uppercase and lowercase), underscore(_) and digits only.
            //The variable name must start with either letter, underscore or @ symbol
            //C# is case sensitive.
            //It means age and Age refers to 2 different variables.
            //A variable name must not be a C# keyword. For example, if, for, using can not be a variable name. 

            string myName = "Abdullah Hhussein";
            int x = 10; int y = 20;
            double MyDouble = 25.89D;
            char MyLetter = 'M';
            bool MyBool = true;

            #endregion

            #region Constants
            //const (short for constant) is a keyword used to declare compile-time constants — values that never change and are known at compile time.
            //Must be initialized at the time of declaration.
            //The value cannot change throughout the program.
            //const fields are implicitly static.
            //Can only be of primitive types, string, or types that can be fully evaluated at compile time.

            //const double Pi = 3.14159;
            //const int MaxScore = 100;
            //Console.WriteLine(Pi);       // Output: 3.14159
            //Console.WriteLine(MaxScore); // Output: 100

            ////const DateTime Today = DateTime.Now; // Compile-time error: not a constant expression

            #endregion

            #region Readonly
            //readonly is a keyword used to declare fields whose values can only be set once, either at declaration or inside a constructor.
            //It's useful when a value is not known at compile-time but should never change afterward.

            //Can be set in:
            //  Declaration
            //  Constructor(for instance members)
            //  Static constructor(for static readonly fields)

            //After assignment, value cannot be modified.
            //Often used for values that are known at runtime but must remain constant once set.
            //Can be of any type, including classes, structs, DateTime, arrays, etc.

            //=====================================================================//
            //const vs readonly:
            //Feature               const                           readonly
            //Set When              At declaration(compile-time)	At declaration or constructor(runtime)
            //Changeable            Never                           Only once
            //Data Type             Only primitives, string         Any type
            //Static                Implicitly static               Instance-level by default

            #endregion

            #region DataTypes

            #region Numbers Datatypes

            #region Byte

            //byte b1 = 255;
            ////byte b2 = -128;// compile-time error: Constant value '-128' cannot be converted to a 'byte'
            //sbyte sb1 = -128;
            //sbyte sb2 = 127;
            //Console.WriteLine("\nByte:");
            //Console.WriteLine("Min={0} , Max={1}", Byte.MinValue, Byte.MaxValue);

            //Console.WriteLine("\nSByte:");
            //Console.WriteLine("Min={0} , Max={1}", SByte.MinValue, SByte.MaxValue);
            #endregion

            #region Short

            //short s1 = -32768;
            //short s2 = 32767;
            //// short s3 = 35000;//Compile-time error: Constant value '35000' cannot be converted to a 'short'

            //ushort us1 = 65535;
            ////  ushort us2 = -32000; //Compile-time error: Constant value '-32000' cannot be converted to a 'ushort'

            //Console.WriteLine("\nShort:");
            //Console.WriteLine("Min={0} , Max={1}", Int16.MinValue, Int16.MaxValue);

            //Console.WriteLine("\nUShort:");
            //Console.WriteLine("Min={0} , Max={1}", UInt16.MinValue, UInt16.MaxValue);
            #endregion

            #region Int

            //int i = -2147483648;
            //int j = 2147483647;
            ////  int k = 4294967295; //Compile-time error: Cannot implicitly convert type 'uint' to 'int'.

            //uint ui1 = 4294967295;
            //// uint ui2 = -1; //Compile-time error: Constant value '-1' cannot be converted to a 'uint'

            //Console.WriteLine("\nInt:");
            //Console.WriteLine("Min={0} , Max={1}", Int32.MinValue, Int32.MaxValue);

            //Console.WriteLine("\nUInt:");
            //Console.WriteLine("Min={0} , Max={1}", UInt32.MinValue, UInt32.MaxValue);
            #endregion

            #region Long

            //long l1 = -9223372036854775808;
            //long l2 = 9223372036854775807;

            //ulong ul1 = 18223372036854775808ul;
            //ulong ul2 = 18223372036854775808UL;

            //Console.WriteLine("\nLong:");
            //Console.WriteLine("Min={0} , Max={1}", Int64.MinValue, Int64.MaxValue);

            //Console.WriteLine("\nULong:");
            //Console.WriteLine("Min={0} , Max={1}", UInt64.MinValue, UInt64.MaxValue);
            #endregion

            #region Float and Double

            //float f1 = 123456.5F;
            //float f2 = 1.123456f;

            //Console.WriteLine("\nFloat:");
            //Console.WriteLine("Min={0} , Max={1}", float.MinValue, float.MaxValue);


            ////double
            //double d1 = 12345678912345.5d;
            //double d2 = 1.123456789123456d;

            //Console.WriteLine("\nDouble:");
            //Console.WriteLine("Min={0} , Max={1}", double.MinValue, double.MaxValue);
            #endregion

            #region Decimal
            ////The decimal type has more precision and a smaller range
            ////than both float and double,
            ////and so it is appropriate for financial and monetary calculations.
            //decimal d3 = 123456789123456789123456789.5m;
            //decimal d4 = 1.1234567891345679123456789123m;

            //Console.WriteLine("\nDecimal:");
            //Console.WriteLine("Min={0} , Max={1}", decimal.MinValue, decimal.MaxValue);
            #endregion

            #region Hex and Binary

            //int hex = 0x2F;
            //int binary = 0b_0010_1111;

            //Console.WriteLine(hex);
            //Console.WriteLine(binary);
            #endregion

            #region Default Value
            ////get default value using default(type)
            //int i = default(int); // 0
            //float f = default(float);// 0
            //decimal d = default(decimal);// 0
            //bool b = default(bool);// false
            //char c = default(char);// '\0'

            //// C# 7.1 onwards
            ////get default value using default
            //int i2 = default; // 0
            //float f2 = default;// 0
            //decimal d2 = default;// 0
            //bool b2 = default;// false
            //char c2 = default;// '\0' 
            #endregion

            #endregion

            #region Char
            //// char represents a single Unicode character
            //char c1 = 'A';
            //char c2 = '\u0042'; // Unicode for 'B'
            //char c3 = (char)67; // ASCII code for 'C'

            //Console.WriteLine("\nChar:");
            //Console.WriteLine(c1); // A
            //Console.WriteLine(c2); // B
            //Console.WriteLine(c3); // C
            #endregion

            #region Boolean
            //// bool can only be true or false
            //bool isTrue = true; //1
            //bool isFalse = false; //0

            //Console.WriteLine("\nBoolean:");
            //Console.WriteLine(isTrue);  
            //Console.WriteLine(isFalse); 
            #endregion

            #region String
            //// string represents a sequence of characters
            //string s1 = "Hello";
            //string s2 = "World";
            //string s3 = s1 + " " + s2;

            //Console.WriteLine("\nString:");
            //Console.WriteLine(s1);   
            //Console.WriteLine(s2);   
            //Console.WriteLine(s3);   
            #endregion

            #region Object
            //// object is the base type from which all types derive
            //object obj1 = 123;        // int
            //object obj2 = "CSharp";   // string
            //object obj3 = true;       // bool

            //Console.WriteLine("\nObject:");
            //Console.WriteLine(obj1);  
            //Console.WriteLine(obj2);  
            //Console.WriteLine(obj3);  
            #endregion

            #region Anonymous Type
            ////you dont specify any type here , automatically will be specified
            //var student = new { Id = 20, FirstName = "Abdullah", LastName = "Husseinn" };

            //Console.WriteLine("\nExample1:\n");
            //Console.WriteLine(student.Id); //output: 20
            //Console.WriteLine(student.FirstName); //output: Abdullah
            //Console.WriteLine(student.LastName); //output: Hussein

            ////You can print like this:
            //Console.WriteLine(student);


            ////anonymous types are read-only
            ////you cannot change the values of properties as they are read-only.

            //// student.Id = 2;//Error: cannot chage value
            //// student.FirstName = "Ismail";//Error: cannot chage value


            ////An anonymous type's property can include another anonymous type.
            //var student2 = new
            //{
            //    Id = 20,
            //    FirstName = "Abdullah",
            //    LastName = "Hussein",
            //    Address = new { Id = 1, City = "Ismailia", Country = "Egypt" }
            //};

            //Console.WriteLine("\nExample2:\n");
            //Console.WriteLine(student2.Id);
            //Console.WriteLine(student2.FirstName);
            //Console.WriteLine(student2.LastName);

            //Console.WriteLine(student2.Address.Id);
            //Console.WriteLine(student2.Address.City);
            //Console.WriteLine(student2.Address.Country);
            //Console.WriteLine(student2.Address);
            #endregion

            #region Dynamic Type
            //dynamic MyDynamicVar = 100;
            //Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            //MyDynamicVar = "Hello World!!";
            //Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            //MyDynamicVar = true;
            //Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            //MyDynamicVar = DateTime.Now;
            //Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType()); 
            #endregion

            #region DateTime

            #region Basics
            DateTime dt1 = new DateTime(); // Default: 01/01/0001 00:00:00
            DateTime dt2 = new DateTime(2023, 12, 31); // Year, Month, Day
            DateTime dt3 = new DateTime(2023, 12, 31, 5, 10, 20); // Y/M/D + Time
            DateTime dt4 = new DateTime(2023, 12, 31, 5, 10, 20, DateTimeKind.Utc); // With UTC kind

            Console.WriteLine(dt1);
            Console.WriteLine(dt2);
            Console.WriteLine(dt3);
            Console.WriteLine(dt4);

            dt1 = DateTime.Now;

            // ====== Static DateTime Fields ======
            DateTime currentDateTime = DateTime.Now;
            DateTime todaysDate = DateTime.Today;
            DateTime currentDateTimeUTC = DateTime.UtcNow;
            DateTime maxDateTimeValue = DateTime.MaxValue;
            DateTime minDateTimeValue = DateTime.MinValue;

            Console.WriteLine("currentDateTime: " + currentDateTime);
            Console.WriteLine("Today: " + todaysDate);
            Console.WriteLine("currentDateTimeUTC: " + currentDateTimeUTC);
            Console.WriteLine("minDateTimeValue: " + minDateTimeValue);
            Console.WriteLine("maxDateTimeValue: " + maxDateTimeValue);
            #endregion

            #region TimeSpan
            //TimeSpan is a struct that is used to represent time in days, hour, minutes, seconds, and milliseconds.
            DateTime dt = new DateTime(2025, 7, 22, 10, 0, 0);
            TimeSpan ts = new TimeSpan(2, 30, 0);

            Console.WriteLine(ts);
            Console.WriteLine("Days: " + ts.Days);
            Console.WriteLine("Hours: " + ts.Hours);
            Console.WriteLine("Minutes: " + ts.Minutes);
            Console.WriteLine("Seconds: " + ts.Seconds);

            // Add TimeSpan to DateTime
            DateTime newDate = dt.Add(ts);
            Console.WriteLine("New Date: " + newDate);

            // Subtracting Dates returns TimeSpan
            DateTime date1 = new DateTime(2023, 2, 21);
            DateTime date2 = new DateTime(2023, 2, 25);
            TimeSpan result = date2.Subtract(date1);

            Console.WriteLine("Days Between: " + result.Days);
            #endregion

            #region DateTime Operators

            DateTime op1 = new DateTime(2015, 12, 20);
            DateTime op2 = new DateTime(2016, 12, 31, 5, 10, 20);
            TimeSpan time = new TimeSpan(10, 5, 25, 50); // 10 days, 5 hrs, 25 mins, 50 secs

            Console.WriteLine(op2 + time);      // Add TimeSpan to DateTime
            Console.WriteLine(op2 - op1);       // Difference between two dates
            Console.WriteLine(op1 == op2);      // False
            Console.WriteLine(op1 != op2);      // True
            Console.WriteLine(op1 > op2);       // False
            Console.WriteLine(op1 < op2);       // True
            Console.WriteLine(op1 >= op2);      // False
            Console.WriteLine(op1 <= op2);      // True 
            #endregion

            #region Convert String to DateTime

            string str = "6/12/2023";
            DateTime parsedDt;
            bool isValidDate = DateTime.TryParse(str, out parsedDt);

            if (isValidDate)
                Console.WriteLine("Parsed: " + parsedDt);
            else
                Console.WriteLine($"{str} is not a valid date string");

            string str2 = "6/65/2023"; // Invalid
            DateTime parsedDt2;
            bool isValidDate2 = DateTime.TryParse(str2, out parsedDt2);

            if (isValidDate2)
                Console.WriteLine("Parsed: " + parsedDt2);
            else
                Console.WriteLine($"{str2} is not a valid date string");

            #endregion

            #region Current Time
            DateTime now = DateTime.Now;
            DateTime utcNow = DateTime.UtcNow;

            Console.WriteLine("=== Current Local Time ===");
            Console.WriteLine("Now: " + now);
            Console.WriteLine();
            #endregion

            #region Standard Formats
            Console.WriteLine("=== Standard Formats ===");
            Console.WriteLine("d: " + now.ToString("d"));  // Short date
            Console.WriteLine("D: " + now.ToString("D"));  // Long date
            Console.WriteLine("t: " + now.ToString("t"));  // Short time
            Console.WriteLine("T: " + now.ToString("T"));  // Long time
            Console.WriteLine("f: " + now.ToString("f"));  // Full date + short time
            Console.WriteLine("F: " + now.ToString("F"));  // Full date + long time
            Console.WriteLine("g: " + now.ToString("g"));  // Short date + short time
            Console.WriteLine("G: " + now.ToString("G"));  // Short date + long time
            Console.WriteLine("o: " + now.ToString("o"));  // ISO 8601 format
            Console.WriteLine();
            #endregion

            #region Custom Formats
            Console.WriteLine("=== Custom Formats ===");
            Console.WriteLine("yyyy-MM-dd: " + now.ToString("yyyy-MM-dd"));
            Console.WriteLine("dd/MM/yyyy: " + now.ToString("dd/MM/yyyy"));
            Console.WriteLine("HH:mm:ss: " + now.ToString("HH:mm:ss")); // 24-hour
            Console.WriteLine("hh:mm tt: " + now.ToString("hh:mm tt")); // 12-hour
            Console.WriteLine("dddd, MMMM dd yyyy: " + now.ToString("dddd, MMMM dd yyyy"));
            Console.WriteLine();
            #endregion

            #region Culture Specific Formatting
            Console.WriteLine("=== Culture-Specific Format (ar-EG) ===");
            CultureInfo egyptCulture = new CultureInfo("ar-EG");
            Console.WriteLine("Arabic (Egypt): " + now.ToString("D", egyptCulture));
            Console.WriteLine();
            #endregion

            #region UTC Time
            Console.WriteLine("=== UTC Time ===");
            Console.WriteLine("UTC Now: " + utcNow.ToString("F"));
            #endregion

            #endregion

            #endregion
        }
    }
}
