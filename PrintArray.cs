using System;

namespace GenericBubblesort

{
    class PrintArray <T>
    {
        public  void PrintZeArray(T[] array)
        {
            foreach (T i in array)
            {
                Console.Write(i.ToString() + "  ");
            }
        }
    }
}