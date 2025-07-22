namespace _09_Nullable
{
    struct Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
    }
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!; //null forgiveness operator
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public Department? Department { get; set; }
    }
    class Department
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Nullable ValueTypes [C# 2.0 (.NET Framework 2.0) in 2005]

            /// Null Is not A Valid Value For The Variables Of Datatype: ValuesType [Struct, Enum]
            /// Nullable ValueTypes: ValueType + Allow NULL As Valid Value
            /// int : Allow Values Integers Only
            /// int?: Allow Values Integers + NULL

            #region Part 01

            //int? Age; // Nullable<int> Age

            //Age = 22;

            //Age = null;

            ////Console.WriteLine(Age is not null ? Age : 0);
            //Console.WriteLine(Age.HasValue ? Age.Value : 0 );

            #endregion

            #region Part 02
            #region Casting From Value Type To Nullable<ValueType>

            //int X = 10;

            //// X is int : Allows Integers Only
            //// Y is int?: Allows Integers + NULL

            //int? Y = X;
            //// Casting From Value Type [int] To Nullable<Int> [Nullable Value Type] Implicitly
            //// Safe Casting
            //Console.WriteLine(Y);

            #endregion

            #region Casting From Nullable<ValueType> To Value Type

            //int? X = 10;

            //X = null;

            //// X is int? Nullable<int> : Allow integers + NULL
            //// Y is int                : Allow integers Only

            //int Y;
            //// int Y = (int) X;
            //// Casting From Nullable<ValueType> [int?] To Value Type [int] Explicitly
            //// Unsafe Casting 

            ///*********** Protective Code *******************/

            //if (X is not null)
            //	Y = (int)X;
            //else
            //	Y = 0;

            ///******************************/

            //if (X.HasValue)
            //	Y = X.Value;
            //else
            //	Y = 0;

            ///******************************/

            //Y = X.HasValue ? X.Value : 0;

            ///******************************/

            //// Null Coalecsing Operator

            //Y = X ?? 0;  // Syntax Sugar For ---> Y = X.HasValue ? X.Value : 0;


            //Console.WriteLine(Y);

            #endregion
            #endregion

            #region Part 03
            //Person? person = new Person() { Id = 1, Name = "Abdullah", Age = 23, Salary = 8000 };
            //person = null;

            //if (person.HasValue)
            //{
            //    Console.WriteLine(person.Value.Id);
            //    Console.WriteLine(person.Value.Name);
            //    Console.WriteLine(person.Value.Age);
            //    Console.WriteLine(person.Value.Salary);
            //}
            #endregion

            #endregion

            #region Nullable ReferenceTypes [C# 10.0 (.NET 6.0) in Nov 2021]

            // NULL Is Valid Value For Varibales Of DataType: Reference Types [Class, Interface]
            // Compiler Enhancement

            //string? Mesaage01 = null;

            //Console.WriteLine(Mesaage01);

            #endregion

            #region NULL Propagation Operator | Conditional Operator
            //int[]? Numbers = { 1, 2, 3 };
            //Numbers = null;

            #region Example 01

            //if (Numbers is not null)
            //{
            //	for (int i = 0; i < Numbers.Length; i++)
            //	{
            //		Console.WriteLine(Numbers[i]);
            //	} 
            //}

            ////for (int i = 0;(Numbers is not null) && i < Numbers.Length; i++)
            ////{
            ////	Console.WriteLine(Numbers[i]);
            ////}

            //for (int i = 0; i < Numbers?.Length /*(Numbers is not null) */; i++)
            //{
            //	Console.WriteLine(Numbers[i]); 
            //}
            #endregion

            #region Example 02
            //int Length;

            //if (Numbers is not null)
            //	Length = Numbers.Length;
            //else
            //	Length = 0;

            //Length = Numbers?.Length ?? 0;

            //// Numbers?.Length 
            //// Numbers is not null ? Numbers.Length : 0;

            #endregion

            #region Example 03
            //Employee? employee;

            //employee = new Employee()
            //{
            //	Id = 100,
            //	Name = "Abdullah",
            //	Age = 22,
            //	Salary = 8_000,
            //	Department = new Department()
            //	{
            //		Id = 1001,
            //		// Name = "HR"
            //	}
            //};

            //// employee = null;

            //if (employee is not null)
            //{
            //	if (employee.Department is not null)
            //	{
            //		if (employee.Department.Name is not null)
            //		{
            //			Console.WriteLine(employee.Department.Name);  
            //		} 
            //	}
            //}

            //Console.WriteLine(employee?.Name);
            //Console.WriteLine(employee?.Department?.Name ?? "NA"); 
            #endregion

            #endregion
        }
    }
}
