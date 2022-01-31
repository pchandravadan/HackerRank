using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Sorting
{
    public class Bubble
    {
        List<int> unsorted = new List<int> { 10, 11,22, 5, 2, 4,4, 1, 33, 3, 8 };

        public void bubbleSort()
        {
            int stepsCount = 0;
            Console.WriteLine("Total : " + unsorted.Count);
            Console.WriteLine(string.Join(',', unsorted));
            Console.WriteLine("...........................");

            for (int i=unsorted.Count -1 ; i > 0; i--)
            {
                for (int j = 0; j < unsorted.Count -1; j++)
                {
                    int left = unsorted[j];
                    int right = unsorted[j+1];

                    if(left > right)
                    {
                        unsorted[j] = right;
                        unsorted[j + 1] = left;
                    }
                }

                Console.WriteLine(" " + ++stepsCount + "  :" + string.Join(',', unsorted));
            }
        }
    }
}
