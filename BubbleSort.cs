using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace GenericBubblesort
{
    class BubbleSort <T>
    {
        public void Sort( T[] input)
        {
            for (int i = 0; i <= input.Length - 2; i++)
            {
                for (int j = 0; j <= input.Length - 2; j++)
                {
                    Comparer<T> comparer = Comparer<T>.Default;
                    int Result = comparer.Compare(input[j], input[j + 1]);
                    if (Result == 1)
                    {
                        T Temp = input[j];
                        input[j] = input[j + 1];
                        input[j + 1] = Temp;
                    }
                }
            }

            PrintArray<T> printArray = new PrintArray<T>();
            printArray.PrintZeArray(input);
        }   
    }
}
