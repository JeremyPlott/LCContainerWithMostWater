public class Solution
{
    public int MaxArea(int[] height)
    {

        //The strategy here is to start at the outside edges and work our way inwards.
        //This way we are guaranteed to start with the maximum distance between container walls,
        //and the only way to find a larger container is if the walls are high enough

        //first we are just creating a variable to track the largest capacity found,
        //and the two variables that we are going to use to go through the array from the outside in
        var largest = 0;

        int leftSide = 0;
        int rightSide = height.Length - 1;

        //continue this process until our two sides would cross each other
        while (leftSide < rightSide)
        {
            //a container filled with water will overflow at the lowest point
            //the lower side * distance to other side is the capacity of the current container
            var overflowHeight = Math.Min(height[leftSide], height[rightSide]);
            var distanceBetween = rightSide - leftSide;

            //is the current container bigger than the largest found so far?
            largest = Math.Max(overflowHeight * distanceBetween, largest);

            //move whichever side is smaller towards the middle.
            //Since we started on the edges at max distance apart, the only way to find a larger container is
            //if there are higher sides further in that are tall enough to make up for the shorter distance apart
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