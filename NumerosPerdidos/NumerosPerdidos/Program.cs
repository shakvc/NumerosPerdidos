using System;
using System.Collections;

namespace NumerosPerdidos
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            int m = Convert.ToInt32(Console.ReadLine());
            string[] brr_temp = Console.ReadLine().Split(' ');
            int[] brr = Array.ConvertAll(brr_temp, Int32.Parse);
            Array.Sort(arr); Array.Sort(brr);
            int[] result = missingNumbers(arr, brr);
            Console.WriteLine(String.Join(" ", result));
            Console.ReadKey();
        }

        static int[] missingNumbers(int[] arrayA, int[] arrayB)
        {
            // Complete this function
            int i = 0, j = 0;
            ArrayList missingNumbersArrayList = new ArrayList();
            while (i < arrayB.Length)
            {
                if (j < arrayA.Length)
                {
                    int numB = arrayB[i];
                    int numA = arrayA[j];
                    if (numA == numB)
                    {
                        i++;
                        j++;
                    }
                    else
                    {
                        if (!missingNumbersArrayList.Contains(numB))
                            missingNumbersArrayList.Add(numB);
                        i++;
                    }
                }
                else
                {
                    if (!missingNumbersArrayList.Contains(arrayB[i]))
                        missingNumbersArrayList.Add(arrayB[i]);
                    i++;
                }
            }

            missingNumbersArrayList.Sort();
            int[] arrayInt = missingNumbersArrayList.ToArray(typeof(int)) as int[];
            return arrayInt;
        }

    }
}
