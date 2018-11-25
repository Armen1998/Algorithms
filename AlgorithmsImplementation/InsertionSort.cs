using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsImplementation
{
    public class InsertionSort : ClassAlgorithms
    {
        int[] array;
        public override SortType SortingProperty
        { get => base.SortingProperty; set => base.SortingProperty = value; }
        public InsertionSort(int numberOfElements) : base(numberOfElements) { }

        public void GenerateArray(SortType sortType)
        {
            array = GetArray(sortType);
        }
        public void SortArray()
        {
            int temp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        temp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = temp;
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
