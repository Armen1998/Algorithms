using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsImplementation
{
    public class ShellSort : ClassAlgorithms
    {
        int[] array;
        public override SortType SortingProperty
        { get => base.SortingProperty; set => base.SortingProperty = value; }
        public ShellSort(int numberOfElements) : base(numberOfElements) { }

        public void GenerateArray(SortType sortType)
        {
            array = GetArray(sortType);
        }

        public void SortArray()
        {
            int i, j, inc, temp;
            inc = 3;
            while (inc > 0)
            {
                for (i = 0; i < array.Length; i++)
                {
                    j = i;
                    temp = array[i];
                    while ((j >= inc) && (array[j - inc] > temp))
                    {
                        array[j] = array[j - inc];
                        j = j - inc;
                    }
                    array[j] = temp;
                }
                if (inc / 2 != 0)
                    inc = inc / 2;
                else if (inc == 1)
                    inc = 0;
                else
                    inc = 1;
            }
        }
        public void Print()
        {
            PrintArray(array);
        }
    }
}
