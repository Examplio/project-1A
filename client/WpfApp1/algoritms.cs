using System;


public class SortAlgo // 1 class all metods
{
	public static int[] BubleSort(int[] array)
	{
        for (int write = 0; write < arr.Length; write++)
        {
            for (int sort = 0; sort < arr.Length - 1; sort++)
            {
                if (arr[sort] > array[sort + 1])
                {
                    temp = arr[sort + 1];
                    array[sort + 1] = array[sort];
                    array[sort] = temp;
                }
            }
            Console.Write("{0} ", arr[write]);
        }
    }

    public static int[] HeapSort(int[] array)// heap sort
    {
        if (size <= 1)
            return array;
        for (int i = size / 2 - 1; i >= 0; i--)
        {
            Heapify(array, size, i);
        }
        for (int i = size - 1; i >= 0; i--)
        {
            var tempVar = array[0];
            array[0] = array[i];
            array[i] = tempVar;
            Heapify(array, i, 0);
        }
        return array;
    }

    static void Heapify(int[] array, int size, int index) // make a heap
    {
        var largestIndex = index;
        var leftChild = 2 * index + 1;
        var rightChild = 2 * index + 2;

        if (leftChild < size && array[leftChild] > array[largestIndex])
        {
            largestIndex = leftChild;
        }

        if (rightChild < size && array[rightChild] > array[largestIndex])
        {
            largestIndex = rightChild;
        }

        if (largestIndex != index)
        {
            var tempVar = array[index];
            array[index] = array[largestIndex];
            array[largestIndex] = tempVar;

            Heapify(array, size, largestIndex);
        }
    }

    public static int[] CreateRandomArray(int size)// random array create 
    {
        var array = new int[size];
        var rand = new Random();

        for (int i = 0; i < size; i++)
            array[i] = rand.Next();

        return array;
    }

    public int[] InsertionSort(int[] array, int length) // InsertionSort
    {
        for (int i = 1; i < length; i++)
        {
            var key = array[i];
            var flag = 0;

            for (int j = i - 1; j >= 0 && flag != 1;)
            {
                if (key < array[j])
                {
                    array[j + 1] = array[j];
                    j--;
                    array[j + 1] = key;
                }
                else flag = 1;
            }
        }

        return array;
    }



}
