using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leetcode
{
    public class TwoSum
    {
        
        public static string TwoSumCalc(int[] nums, int target)
        {
            // Dictionary to store the number and its index
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i=0; i < nums.Length; i++)
            {
                // Find the target minus current num to see what value needed
                int complement = target - nums[i];

                // Check if complement exist in Dict
                if (map.ContainsKey(complement))
                {
                    return $"Indices {map[complement]} and {i}";
                }

                // Add the current number and its index to dict
                map[nums[i]] = i;
            }

            return "Not found";
        }
        
        public static void Main()
        {
            int[] nums = {2,7,11,15};
            int target = 9;

            Console.WriteLine(TwoSumCalc(nums, target));
        }
    }
}