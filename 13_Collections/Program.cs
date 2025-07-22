namespace _13_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList
            ///ArrayList is a non - generic collection class defined in the System.Collections namespace.
            ///It can store elements of any type, including a mix of value types and reference types, because it stores items as object.
            ///However, it's not type-safe and less efficient than generic collections like List<T>.


            ///Key Features of ArrayList:
            ///Dynamically resizable.
            ///Can store different data types(boxing / unboxing occurs for value types).
            //Not type - safe(no compile - time type checking).

            //ArrayList list = new ArrayList();
            //list.Add("test");
            //list.Add(true);
            //list.Add(5);
            //list.AddRange(new int[] { 4, 3, 2 });
            //list.Insert(5, 1);
            //Console.WriteLine($"Capacity: {list.Capacity}");
            //Console.WriteLine($"Count: {list.Count}");

            //Console.WriteLine("the index of 3 = " + list.IndexOf(3));
            //Console.WriteLine("Is list Contain 5 : " + list.Contains(5));

            ////list.Clear();
            ////list.Remove(4);
            ////list.RemoveAt(4);
            //list.RemoveRange(0, 2);

            //Console.WriteLine("list before sorting");
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //list.Sort();
            //Console.WriteLine("list after sorting");

            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //} 
            #endregion

            #region List<T>
            /// List<T> is a generic collection class defined in the System.Collections.Generic namespace.
            /// It provides type safety, better performance, and avoids boxing/unboxing issues.
            /// It is the preferred replacement for ArrayList in modern C# development.

            /// Key Features of List<T>:
            /// Dynamically resizable.
            /// Type-safe — stores only one data type.
            /// No boxing/unboxing for value types.

            //List<int> list = new List<int>();
            //list.Add(60);
            //list.Add(50);
            //list.Add(40);
            //list.AddRange(new int[] { 30, 10, 1 });
            //list.Insert(4, 20);
            //list.InsertRange(7, new int[] { 2, 3, 4, 5, 6, 7, 8 });

            //Console.WriteLine($"Capacity: {list.Capacity}");
            //Console.WriteLine($"Count: {list.Count}");

            //Console.WriteLine("The index of 40 = " + list.IndexOf(40));
            //Console.WriteLine("Is list containing 50: " + list.Contains(50));

            //// list.Clear();
            //// list.Remove(20);
            //// list.RemoveAt(3);
            ////list.RemoveRange(1, 2);

            //Console.WriteLine("List before sorting:");
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //list.Sort();
            //Console.WriteLine("List after sorting:");

            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}
            #endregion

            #region Dictionary<TKey, TValue>

            ///Dictionary<TKey, TValue> is a generic collection that stores data in key-value pairs. It belongs to the System.Collections.Generic namespace.

            //Key Features of Dictionary<TKey, TValue>:

            //Stores data in key - value format.
            //Fast lookup, add, and remove operations(based on keys).
            //Keys must be unique.
            //Type - safe(generic).
            //Uses hashing internally for performance.
            Dictionary<string, int> ages = new Dictionary<string, int>();

            ages.Add("Ali", 25);
            ages.Add("Sara", 30);
            ages.Add("Omar", 22);

            Console.WriteLine("Sara's age: " + ages["Sara"]);

            if (ages.ContainsKey("Omar"))
            {
                Console.WriteLine("Omar is " + ages["Omar"] + " years old.");
            }

            Console.WriteLine("\nAll People:");
            foreach (KeyValuePair<string, int> pair in ages)
            {
                Console.WriteLine($"{pair.Key} => {pair.Value}");
            }

            ages["Ali"] = 26;

            ages.Remove("Sara");

            Console.WriteLine("\nAfter updates:");
            foreach (var kvp in ages)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }

            #endregion
        }
    }
}
