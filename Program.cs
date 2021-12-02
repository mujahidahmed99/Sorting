using System;

namespace Sorting
{
    public class SortingAlgorithm
    {
        public static void Sort(Char[] stringVals)
        {
            // for loop iterates through the elements
            for(int i = 0; i < stringVals.Length - 1; i++)
            {
                int minIndex = i;
                Char minValue = stringVals[i];

                // used to find the smallest value in the unsorted part
                for (int j = i + 1; j < stringVals.Length; j++)
                {
                    if(stringVals[j] < minValue)
                    {
                        minIndex = j;
                        minValue = stringVals[j];
                    }
                }
                Switch(stringVals, i, minIndex);
            }
        }
        private static void Switch(Char[] array, int first, int second)
        {
            Char temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            char[] stringValues = {'A','W','B','Z','B','W','R','C'};
            SortingAlgorithm.Sort(stringValues);

            Console.WriteLine(string.Join(", ", stringValues)); 

        }
    }
}
