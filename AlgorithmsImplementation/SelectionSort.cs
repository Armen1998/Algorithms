using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsImplementation
{
    public class SelectionSort : ClassAlgorithms
    {
        int[] array;
        public override SortType SortingProperty
        { get => base.SortingProperty; set => base.SortingProperty = value; }
        public SelectionSort(int numberOfElements) : base(numberOfElements) { }

        public void GenerateArray(SortType sortType)
        {
            array = GetArray(sortType);
        }

        public void SortArray()
        {
            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
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
