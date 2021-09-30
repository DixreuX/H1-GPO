using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace H1_GPO
{
    public class QuickSort
    {
        // Class used by RO2_Soertering

        static public int Partition(int[] numbers, int left, int right)
        {
            int pivot = numbers[left];
            while (true)
            {
                while (numbers[left] < pivot)
                    left++;

                while (numbers[right] > pivot)
                    right--;

                 if (left < right)
                 {
                    int temp = numbers[right];
                    numbers[right] = numbers[left];
                    numbers[left] = temp;
                 }
                 else
                 {
                    return right;
                 }
            }
        }

        static public void SortQuick(int[] arr, int left, int right)
        {
            // For recursion
            if(left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                    SortQuick(arr, left, pivot - 1);

                if (pivot + 1 < right)
                    SortQuick(arr, pivot + 1, right);
            }
        }

        public void DisplayQuickSort()
        {
            Clear();

            Write("\n  Sorting a numeric array using Quick Sorting using a custom method");

            Write("\n\n  Enter number of elements in array: ");

            int max = Convert.ToInt32(ReadLine());

            WriteLine();

            int[] numbers = new int[max];



            for (int i = 0; i < max; i++)

            {

                Write("  Enter [" + (i + 1).ToString() + "] element: ");

                numbers[i] = Convert.ToInt32(ReadLine());

            }



            Write("\n\n  Input int array:\n");

            Write("\n");

            for (int k = 0; k < max; k++)

            {

                Write("  " + numbers[k] + " ");

                Write("\n");

            }



            WriteLine("\n\n  QuickSort By Recursive Method\n");

            SortQuick(numbers, 0, max - 1);

            for (int i = 0; i < max; i++)

                WriteLine("  " + numbers[i]);

            ReadLine();
        }



    }
}
