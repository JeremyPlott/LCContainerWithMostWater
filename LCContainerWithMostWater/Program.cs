using System;

namespace LCContainerWithMostWater
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] containerLines = new int[] { 2, 3, 4, 5, 18, 17, 6 };

            Console.WriteLine(LargestContainer(containerLines));

            int LargestContainer(int[] height)
            {
                var largest = 0;

                int leftSide = 0;
                int rightSide = height.Length - 1;                

                while (leftSide < rightSide)
                {
                    var overflowHeight = Math.Min(height[leftSide], height[rightSide]);
                    var distanceBetween = rightSide - leftSide;

                    largest = Math.Max(overflowHeight * distanceBetween, largest);

                    if (height[leftSide] > height[rightSide])
                    {
                        rightSide--;
                    }
                    else
                    {
                        leftSide++;
                    }
                }

                return largest;
            }
        }
    }
}
