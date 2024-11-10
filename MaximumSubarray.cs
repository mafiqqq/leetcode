using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leetcode
{
    public class MaximumSubarray
    {
        public static void Main(){
            // Implementation using Kadane's Algorithm
            // 1. Initialize maxSum and currentSum
            // 2. Iterate array. Update currentSum by choosing larger
            // value between current element itself and currentSum + currentElement
            // Update maxSum if currentSum >
            int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 }; // {1,2,3,4}
    
            // Init to first element
            int maxSum=nums[0];
            int currentSum=nums[0];
            // To find out which subarray combination
            int start=0, end=0, tempStart=0;
            

            // Iterate through array from second element
            for (int i=1; i<nums.Length; i++)
            {
                // Update currentSum to be either the current element alone 
                // OR extending the current sum
                // currentSum = Math.Max(nums[i], currentSum + nums[i]);

                if (nums[i] > currentSum + nums[i])
                {
                    tempStart=i;
                    currentSum = nums[i];
                } 
                else 
                {
                    currentSum += nums[i];
                }

                // Update maxSum if the new currentSum is larger
                // maxSum = Math.Max(maxSum, currentSum);

                if(currentSum > maxSum)
                {
                    maxSum = currentSum;
                    start = tempStart;
                    end = i;
                }
                Console.WriteLine("Current " + currentSum);
                Console.WriteLine("Max " + maxSum);

            }

            Console.WriteLine($"The max sum: {maxSum}");

            for (int i=start; i<=end; i++)
            {
                Console.Write(nums[i] + " ");
            }
        }
        
    }
}