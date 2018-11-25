using AlgorithmsImplementation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            //BubbleSort bubbleSort = new BubbleSort(50000);

            //for (int i = 0; i < 5; i++)
            //{
            //    bubbleSort.GenerateArray(ClassAlgorithms.SortType.reverseSorted);
            //    stopwatch.Start();
            //    bubbleSort.SortArray();
            //    stopwatch.Stop();
            //    Console.WriteLine(stopwatch.Elapsed);
            //    stopwatch.Reset();
            //}

            //InsertionSort insertionSort = new InsertionSort(50000);

            //for (int i = 0; i < 5; i++)
            //{
            //    insertionSort.GenerateArray(ClassAlgorithms.SortType.reverseSorted);
            //    stopwatch.Start();
            //    insertionSort.SortArray();
            //    stopwatch.Stop();
            //    Console.WriteLine(stopwatch.Elapsed);
            //    stopwatch.Reset();
            //}

            //SelectionSort selectionSort = new SelectionSort(50000);

            //for (int i = 0; i < 5; i++)
            //{
            //    selectionSort.GenerateArray(ClassAlgorithms.SortType.reverseSorted);
            //    stopwatch.Start();
            //    selectionSort.SortArray();
            //    stopwatch.Stop();
            //    Console.WriteLine(stopwatch.Elapsed);
            //    stopwatch.Reset();
            //}

            ShellSort shellSort = new ShellSort(50000);

            for (int i = 0; i < 5; i++)
            {
                shellSort.GenerateArray(ClassAlgorithms.SortType.sorted);
                stopwatch.Start();
                shellSort.SortArray();
                stopwatch.Stop();
                Console.WriteLine(stopwatch.Elapsed);
                stopwatch.Reset();
            }


            Console.ReadKey();
        }
    }
}
