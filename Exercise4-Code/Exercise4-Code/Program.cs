using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4_Code
{
    class Program
    {
        const int ARRAY_SIZE = 10;
        const int RANDOM_MAX = 1000;

        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] nums = new int[ARRAY_SIZE];
            for (int i = 0; i < ARRAY_SIZE; i++)
                // randomly generate an integer beteen 0 and RAMDOM_MAX
                nums[i] = rand.Next(RANDOM_MAX);


            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("before heap sorting:");
            for (int i = 0; i < ARRAY_SIZE; i++)
            {
                Console.WriteLine(nums[i]);
            }

            HeapSort(nums);

            Console.WriteLine();
            Console.WriteLine("after heap sorting:");
            for (int i = 0; i < ARRAY_SIZE; i++)
            {
                Console.WriteLine(nums[i]);
            }

            Console.ReadLine();
        }

        // convert a complete binary tree into a heap
        static void HeapBottomUp(int[] data)  //Note: In the algorithm, the array index starts from 1
        {
            int n = data.Length;
            for (int i = (n - 1) / 2; i >= 0; i--)
            {
                // to be completed
                int k = i;
                int v = data[k];
                bool heap = false;
                while ((!heap) && ((2 * k + 1) <= n - 1))
                {
                    int j = 2 * k + 1;
                    if (j < n - 1) // There are two children
                    {
                        // Find which children to swap
                        if (data[j] < data[j + 1])
                        {
                            j = j + 1;
                        }
                    }
                    // If the current key is greater than
                    // the selected child, we have a heap
                    // and can stop
                    if (v >= data[j])
                    {
                        heap = true;
                    }
                    // Otherwise (if the big child is larger
                    // than the key), we swap them
                    else
                    {
                        data[k] = data[j]; // Swap
                        k = j; // Update the key index
                    }
                }
                data[k] = v;
            }
        }

        // sort the elements in an array 
        static void HeapSort(int[] data)
        {
            //Use the HeapBottomUp procedure to convert the array, data, into a heap
            //To be completed
            HeapBottomUp(data);

            //repeatly remove the maximum key from the heap and then rebuild the heap
            //To be completed
            for (int v = 0; v <= data.Length - 2; v++)
            {
                MaxKeyDelete(data, data.Length - v);
            }
        }

        //delete the maximum key and rebuild the heap
        static void MaxKeyDelete(int[] data, int size)
        {
            //Exchange the root’s key with the last key K of the heap;
            int temp = data[0];
            data[0] = data[size - 1];
            data[size - 1] = temp;

            Console.WriteLine("Deleting key: {0},", temp);
            foreach (int number in data)
            {
                Console.Write("{0}, ", number);
            }

            //“Heapify” the complete binary tree.
            // to be completed

            // Decrease the heap's size by 1
            int n = size - 1;

            // Heapify: Since the root has been exchanged,
            // we only need to heapify from the root
            // to be completed
            int k = 0; // New root
            int v = data[k];
            bool heap = false;
            while ((!heap) && ((2 * k + 1) <= n - 1))
            {
                int j = 2 * k + 1;
                if (j < n - 1) // There are two children
                {
                    // Find which children to swap
                    if (data[j] < data[j + 1])
                    {
                        j = j + 1;
                    }
                }
                // If the current key is greater than
                // the selected child, we have a heap
                // and can stop
                if (v >= data[j])
                {
                    heap = true;
                }
                // Otherwise (if the big child is larger
                // than the key), we swap them
                else
                {
                    data[k] = data[j]; // Swap
                    k = j; // Update the key index
                }
            }
            data[k] = v;

            Console.WriteLine("Re-heapify", temp);
            foreach (int number in data)
            {
                Console.Write("{0}, ", number);
            }
            Console.WriteLine();
        }
    }
}





