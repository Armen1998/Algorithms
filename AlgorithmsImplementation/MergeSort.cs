using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsImplementation
{
    public class MergeSort : ClassAlgorithms
    {
        int[] array;
        public override SortType SortingProperty
        { get => base.SortingProperty; set => base.SortingProperty = value; }
        public MergeSort(int numberOfElements) : base(numberOfElements) { }

        public void GenerateArray(SortType sortType)
        {
            array = GetArray(sortType);
        }

        public void MainMerge(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[numbers.Length];
            int i, eol, num, pos;

            eol = (mid - 1);
            pos = left;
            num = (right - left + 1);

            while ((left <= eol) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[pos++] = numbers[left++];
                else
                    temp[pos++] = numbers[mid++];
            }

            while (left <= eol)
                temp[pos++] = numbers[left++];

            while (mid <= right)
                temp[pos++] = numbers[mid++];

            for (i = 0; i < num; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }

        public void SortArray(int left, int right)
        {
            int mid;

            if (right > left)
            {
                mid = (right + left) / 2;
                SortArray(left, mid);
                SortArray((mid + 1), right);
                MainMerge(array, left, (mid + 1), right);
            }
        }
        public void Print()
        {
            PrintArray(array);
        }
    }
}
