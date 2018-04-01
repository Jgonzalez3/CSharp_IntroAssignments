using System;
using System.Collections.Generic;

namespace Boxing_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
        //Boxing:
            object BoxedData = "This is clearly a string";
        // Unboxing:  The "is" keyword allouws us to discern what real type of an object is when we unbox. wHEN UNBOXING MUST ALWAYS CAST BACK TO ORIGINAL TYPE WHEN RETRIEVING
            if (BoxedData is string){
                Console.WriteLine("It is totally a string in a box!");
            }
        // Explicit Casting: Uses the "as" keyword. If fails will return a null value. Safe cast can only be used to cast nullable type. Ints are non-nullable.
            object ActuallyString = "a string";
            string ExplicitString = ActuallyString as string;

            // Assignment:
            List<object> newlist = new List<object>();
            newlist.Add(7);
            newlist.Add(28);
            newlist.Add(-1);
            newlist.Add(true);
            newlist.Add("chair");
            int sum = 0;
            for (var idx = 0; idx < newlist.Count; idx++){
                Console.WriteLine(newlist[idx]);
                if(newlist[idx] is int){
                    sum += (int)newlist[idx];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
