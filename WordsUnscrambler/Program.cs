using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsUnscrambler
{
    class Program
    {
        static void Main(string[] args)
        {
            //-- LISTS
            List<int> myList = new List<int>();
            //  adding items to list
            myList.Add(6);
            //  removing item from list
            myList.Remove(1); // removes first item where value is 1 

            //-- ARRAYS
            int[] myArray = new int[3]; // array of 10 items
            //  adding items to array
            myArray[0] = 1;
            myArray[1] = 4;
            myArray[2] = 3;

            // OR
            int[] myArray2 = { 1, 4, 3 };

            //  sorting array
            Array.Sort(myArray);

            //-- FOR LOOP
            for (int i = 0; i < myArray.Count(); i++)
            {
                Console.WriteLine("Step: {0}, value: {1}", i, myArray[i]);
            }

        }
    }
}
