using System;

namespace GenericBubblesort
{
    class Program
    {
        static void Main(string[] args)
        {
            BubbleSort<string> bubbleSort = new BubbleSort<string>();
            PrintArray<string> ToPrintUnsortedArray = new PrintArray<string>();
            string[] Array = new string[] {"A","B","C","G","Z","M","P"};
            Console.Write("Unsorted Array \n");
            ToPrintUnsortedArray.PrintZeArray(Array);
            Console.Write("\n");
            Console.Write("\n");
            Console.Write("Bubble Sorted Array \n");
            bubbleSort.Sort(Array);
        }
    }
}
