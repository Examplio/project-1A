using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfApp1.Algorithms;


namespace WpfApp1
{
    

    public partial class App : Application
    {
        public App()
        {
            int[] array = { 5, 3, 8, 4, 2 };
            int[] sortedArrayBubble = SortAlgo.BubbleSort((int[])array.Clone());
            int[] sortedArrayHeap = SortAlgo.HeapSort((int[])array.Clone());
            Console.WriteLine("Original Array: " + string.Join(", ", array));
            Console.WriteLine("Sorted Array using Bubble Sort: " + string.Join(", ", sortedArrayBubble));
            Console.WriteLine("Sorted Array using Heap Sort: " + string.Join(", ", sortedArrayHeap));
        }
    }
}
