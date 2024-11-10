using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leetcode
{
    public class MaxProductSubaray
    {
        /* 
        Given an integer array nums, find the contiguous subarray within an array
        which has the largest product

        Input: [2,3,-2,4]
        Output: 6
        */
        public static void Main()
        {
            int[] nums = {2, 3, -2, 4};

            int maxProduct=nums[0];
            int currentMax=nums[0];
            int currentMin=nums[0];

            for(int i=1; i<nums.Length; i++)
            {
                
                int tmp = currentMax * nums[i];
                currentMax = Math.Max(nums[i], Math.Max(currentMax * nums[i], currentMin * nums[i]));
                currentMin = Math.Min(nums[i], Math.Min(tmp, currentMin * nums[i]));

                // Update overall maxProduct
                maxProduct = Math.Max(maxProduct, currentMax);
            }

            Console.WriteLine(maxProduct);
        }
    }
}