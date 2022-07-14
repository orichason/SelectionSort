using System;
using System.Collections.Generic;

namespace SelectionSort
{
    class Program
    {
        public static void SelectionSort(List<int> NumberList)
        {
            bool isSorted = false;

            int count = 0;
            int temp = 0;

            while (!isSorted)
            {

                for (int i = 0; i < NumberList.Count; i++)
                {
                    for (int y = count; y < NumberList.Count - count; y++)
                    {
                        if (NumberList[i] < NumberList[y])
                        {
                            temp = NumberList[y];
                        }
                    }
                    NumberList[i] = temp;
                    count++;
                }

            }
        }

        static void Main(string[] args)
        {
            List<int> UnsortedList = new List<int> { 43, 17, 5, 87, 29 };

            SelectionSort(UnsortedList);
        }
    }
}
