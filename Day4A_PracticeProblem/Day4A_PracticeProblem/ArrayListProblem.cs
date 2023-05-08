using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4A_PracticeProblem
{
    public class ArrayListProblem
    {
        private readonly NlogClass nlog = new NlogClass();
        public void ArrayListExample()
        {
            ArrayList list = new ArrayList();

            Console.WriteLine("Add data to the list");
            list.Add("Apple");
            list.Add("Banana");
            list.Add("Cherry");
            list.Add("Durian");

            nlog.LogDebug("Debug successfully.");
            Console.WriteLine("Update the list");
            // Update an item in the list
            list[1] = "Blackberry";

            Console.WriteLine("Insert");
            // Insert an item into the list
            list.Insert(0, "Apricot");

            Console.WriteLine("Remove items");
            // Remove an item from the list
            list.Remove("Cherry");

            Console.WriteLine("clear");

            // Clear the list
            //list.Clear();

            foreach (string i in list)
            {
                Console.WriteLine(i);
                nlog.LogDebug("Debug successfully.");
                nlog.LogWarning("Having null value");
                nlog.LogInfo("Any numbers should not equal to zero");
            }
            nlog.LogDebug("Debug successfully.");
        }
    }
}
