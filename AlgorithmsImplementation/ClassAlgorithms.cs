using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsImplementation
{
    abstract public class ClassAlgorithms
    {
        Random random;
        int[] array;

        public virtual SortType SortingProperty { get; set; }
        public enum SortType { random, sorted, reverseSorted }
        protected ClassAlgorithms(int NumberOfElements)
        {
            array = new int[NumberOfElements];
        }
        protected int[] GetArray(SortType sortType = SortType.random)
        {
            random = new Random();
            for(int i = 0; i < array.Length - 1; i++)
            {
                array[i] = random.Next(0, 10000);
            }

            if(sortType != SortType.random)
            {
                Array.Sort(array);

                if (sortType == SortType.reverseSorted)
                    Array.Reverse(array);
            }
            return array;
        }
            
        protected void PrintArray(int[] array)
        {
            foreach(int i in array)
            {
                Console.Write(i + " | ");
            }
            Console.WriteLine();
        }
    }
}
