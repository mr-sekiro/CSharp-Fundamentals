namespace _07_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region String
            #region Example 01

            //string Name01;

            //Name01 = "Abdullah"; // Stntax Sugar //Name01 = new string("Abdullah")

            //Console.WriteLine(Name01);
            //Console.WriteLine($"HashCode = {Name01.GetHashCode()}");

            //string Name02 = "Abdullah";

            //Console.WriteLine("------------");
            //Console.WriteLine(Name02);
            //Console.WriteLine($"HashCode = {Name02.GetHashCode()}");
            #endregion

            #region Example 02

            //string Name01 = "Ahmed";
            //string Name02 = "Omar";

            //Console.WriteLine($"Name01 = {Name01}");
            //Console.WriteLine($"HashCode Of Name01 =  {Name01.GetHashCode()}");
            //Console.WriteLine($"Name02 = {Name02}");
            //Console.WriteLine($"HashCode Of Name02 =  {Name02.GetHashCode()}");

            //Name02 = Name01;

            //Console.WriteLine($"Name01 = {Name01}");
            //Console.WriteLine($"HashCode Of Name01 =  {Name01.GetHashCode()}");
            //Console.WriteLine($"Name02 = {Name02}");
            //Console.WriteLine($"HashCode Of Name02 =  {Name02.GetHashCode()}");

            //Name01 = "Hussein";

            //Console.WriteLine(Name02);
            #endregion

            #region Example 03
            //string Message = "Hello";
            //Console.WriteLine($"Message: {Message}");
            //Console.WriteLine($"HashCode Of Message: {Message.GetHashCode()}");

            //Message += " World";

            //Console.WriteLine($"Message: {Message}");
            //Console.WriteLine($"HashCode Of Message: {Message.GetHashCode()}");
            #endregion

            #endregion

            #region String Formatting 

            //// Equation : 10 + 5 = 15
            //int X = 10, Y = 5 , result;
            //result = X + Y;
            //string message;
            //// 1. String Interpolation
            //message = $"Equation : {X} + {Y} = {result}";
            //Console.WriteLine(message);

            //// 2. String.Format Method
            //message = string.Format("Equation : {0} + {1} = {2}" , X , Y ,result);
            //Console.WriteLine(message);

            //// 3. Composite Formatting
            //Console.WriteLine("Equation :x {0} + {1} = {2}" , X , Y , result);

            //// 4. String Concatenation
            //message =  "Equation : " + X + " + " + Y + " = " + result;
            //Console.WriteLine(message);


            //// File Path 
            //// C:\MyProjects\Project01

            //string filePath = "C:\\MyProjects\\Project01";
            //filePath = @"C:\MyProjects\Project01";
            //Console.WriteLine(filePath);
            ////Scape character
            ///
            ///1. \n :  New Line 
            ///2. \r : Carriage Return
            ///3. \t: Tab                                                    
            ///4. \\ : Backslash
            ///5. \' : Single Quote                                      
            ///6. \" : Double Quote
            ///7. \b: Backspace                                        
            ///8.\u : Unicode character(4 digits)
            ///9.\U : Unicode character(8 digits)            
            ///10. @ : ignores escape sequences

            //Console.WriteLine("\"Abdullah\tHussein\"\nBackend  \bDev");

            #endregion

            #region string Methods

            //| Method                    | Description                           | Example                                   |
            //| ------------------------- | ------------------------------------- | ----------------------------------------- |
            //| `Length`                  | Gets the number of characters         | `"Hello".Length` → `5`                    |
            //| `ToUpper()`               | Converts to uppercase                 | `"hello".ToUpper()` → `"HELLO"`           |
            //| `ToLower()`               | Converts to lowercase                 | `"HELLO".ToLower()` → `"hello"`           |
            //| `Trim()`                  | Removes whitespace from start and end | `"  Hi  ".Trim()` → `"Hi"`                |
            //| `Substring(start, len)`   | Gets a substring                      | `"Hello".Substring(1, 3)` → `"ell"`       |
            //| `IndexOf(value)`          | Finds the index of a substring        | `"apple".IndexOf("p")` → `1`              |
            //| `Contains(value)`         | Checks if it contains a substring     | `"abc".Contains("b")` → `true`            |
            //| `Replace(old, new)`       | Replaces text                         | `"car".Replace("c", "b")` → `"bar"`       |
            //| `StartsWith(value)`       | Checks if it starts with a value      | `"test".StartsWith("t")` → `true`         |
            //| `EndsWith(value)`         | Checks if it ends with a value        | `"test".EndsWith("t")` → `true`           |
            //| `Equals(value)`           | Compares two strings                  | `"abc".Equals("abc")` → `true`            |
            //| `Split(char[])`           | Splits into an array of substrings    | `"a,b,c".Split(',')` → `["a", "b", "c"]`  |
            //| `Join(sep, array)`        | Joins an array into a string          | `string.Join("-", arr)` → `"a-b-c"`       |
            //| `IsNullOrEmpty(str)`      | Checks if string is null or empty     | `string.IsNullOrEmpty("")` → `true`       |
            //| `IsNullOrWhiteSpace(str)` | Also true if only spaces              | `string.IsNullOrWhiteSpace(" ")` → `true` |

            //string message = " Abdullah Hussein ";
            //Console.WriteLine(message.Length); // 18
            //Console.WriteLine(message.ToUpper()); // ABDULLAH HUSSEIN
            //Console.WriteLine(message.ToLower());//  abdullah hussein
            //Console.WriteLine(message.Trim());//Abdullah Hussein
            //Console.WriteLine(message.TrimEnd());//  Abdullah Hussein
            //Console.WriteLine(message.TrimStart());//Abdullah Hussein
            //Console.WriteLine(message.Substring(0, 5));//  Abdu
            //Console.WriteLine(message.Replace('u', 'a'));//  Abdallah Hassein
            //Console.WriteLine(message.Contains('i'));//true

            #region Split
            //string sentence = "Hello World From C#";
            //string[] words = sentence.Split(' ');

            //foreach (var word in words)
            //{
            //    Console.WriteLine(word);
            //}

            ////Split by Multiple Delimiters
            //string messy = "apple|banana;grape orange";
            //char[] separators = { '|', ';', ' ' };
            //string[] cleaned = messy.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            ////StringSplitOptions.RemoveEmptyEntries is an enum value used with string.Split() to ignore empty substrings in the result.

            //foreach (var item in cleaned)
            //{
            //    Console.WriteLine(item);
            //} 

            ////Limit the Number of Splits
            //string fullName = "Abdullah Hussein Mohamed";
            //string[] nameParts = fullName.Split(' ', 2); // Split only once

            //Console.WriteLine("First: " + nameParts[0]);
            //Console.WriteLine("Rest: " + nameParts[1]);
            #endregion

            #region Join
            ////Join with Comma
            //string[] names = { "Ali", "Mona", "Ziad" };
            //string result = string.Join(", ", names);
            //Console.WriteLine(result); // Output: Ali, Mona, Ziad

            ////Join from List<string>
            //List<string> items = new List<string> { "Pen", "Book", "Bag" };
            //string text = string.Join(" | ", items);
            //Console.WriteLine(text); // Output: Pen | Book | Bag 
            #endregion

            #endregion

            #region StringBuilder

            //StringBuilder Message; //namespace System.Text

            //Message = new StringBuilder("Hello");

            //Console.WriteLine($"Message = {Message}");
            //Console.WriteLine($"HashCode of Message = {Message.GetHashCode()}");

            //Message.Append(" Abdullah"); 
            //Console.WriteLine("Message After Appending ");

            //Console.WriteLine($"Message = {Message}");
            //Console.WriteLine($"HashCode of Message = {Message.GetHashCode()}");


            #endregion

            #region StringBuilder Methods

            //StringBuilder Message = new StringBuilder("Hello");

            //Message.Append(" Abdullah");
            //Message.AppendLine(" Hussein");
            //Message.AppendLine("Your Age Is 23");

            //Message.Remove(0, 5);
            //Message.Insert(0, "Hi");
            //Message.Clear();
            //Message.AppendFormat("{0} : {1}\n", "Class", 'A');
            //Message.AppendJoin(':', "Salary", "10000");

            //Console.WriteLine(Message);

            #endregion
        }
    }
}
