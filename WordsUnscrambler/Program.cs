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

            //  adding items to array, another way
            int[] myArray2 = { 1, 4, 3 };

            //  sorting array
            Array.Sort(myArray);

            //-- FOR LOOP
            for (int i = 0; i < myArray.Count(); i++)
            {
                Console.WriteLine("Step: {0}, value: {1}", i, myArray[i]);
            }

            //-- WHILE LOOP (if the condition is true, the loop will not be executed even once)
            int k = 0;
            while (k < 5) 
            {
                Console.WriteLine("INT: {0}", k);
                k++;
            }

            //-- DO WHILE LOOP (will be executed at least one, even if condifition is true)
            int l = 0;
            do
            {
                Console.WriteLine("INT_2: {0}", l);
                l++;
            } while (l < 5);

            //-- FOREACH LOOP
            string words = "pizza";
            foreach (char letter in words)
            {
                Console.WriteLine(letter);
            }

            //-- REFERENCE

            //-- VALUE TYPES

        }
    }
}
