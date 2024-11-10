using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leetcode
{
    public class ContainsDuplicate_HashSet
    {
        public static void Main()
        {
            int[] nums = {1,2,3,5,2};
            bool found = false;
            HashSet<int> seen = new HashSet<int>();

            for (int i=0; i<nums.Length; i++)
            {
                if (seen.Contains(nums[i]))
                {
                    found = true;
                }

                seen.Add(nums[i]);
            }
			if (found)
			{
				Console.WriteLine("Found");
			} else 
			{
				Console.WriteLine("Not found");
			}
        }
    }
}