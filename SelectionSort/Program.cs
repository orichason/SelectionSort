using System;
using System.Collections.Generic;

namespace SelectionSort
{
    class Program
    {
        public static void SelectionSort(List<int> NumberList)
        {
            //bool isSorted = false;

            int count = 1;
            int count2 = 0;
            int temp = 0;
            bool swapMade = false;

            //while (!isSorted)
            //{

            for (int i = 0; i < NumberList.Count; i++)
            {
                swapMade = false;
                temp = NumberList[i];
                for (int y = count; y < NumberList.Count; y++)
                {
                    if (NumberList[i] > NumberList[y] && NumberList[y] < temp)
                    {
                        temp = NumberList[y];
                        count2 = y;
                        swapMade = true;
                    }
                }
                if (swapMade)
                {
                    NumberList[count2] = NumberList[i];
                    NumberList[i] = temp;
                }

                count++;
            }
            //isSorted = true;

            //}
        }

        static void Main(string[] args)
        {
            Random gen = new Random();
            List<int> UnsortedList = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                UnsortedList.Add(gen.Next(1, 100));
            }
            SelectionSort(UnsortedList);
        }
    }
}
