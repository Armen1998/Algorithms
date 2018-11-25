using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsImplementation
{
    public class BubbleSort : ClassAlgorithms
    {
        int[] array;
        public override SortType SortingProperty
        { get => base.SortingProperty; set => base.SortingProperty = value; }
        public BubbleSort(int numberOfElements) : base(numberOfElements) { }

        public void GenerateArray(SortType sortType)
        {
            array = GetArray(sortType);
        }

        public void SortArray()
        {
            int t;
            for (int p = 0; p <= array.Length - 2; p++)
            {
                for (int i = 0; i <= array.Length - 2; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        t = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = t;
                    }
                }
            }
        }
        public void Print()
        {
            PrintArray(array);
        }


    }
}
