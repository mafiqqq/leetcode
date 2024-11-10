using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leetcode
{
    public class ContainsDuplicate_BubbleSort
    {

        public static void Main(){
            int[] nums = {1,2,3,5,2};
            bool found = false;

            Array.Sort(nums);

            // After sort we just need to compare each other
            for(int i=0; i<nums.Length-1; i++)
            {
                if(nums[i] == nums[i+1])
                {
                    found = true;
                }
            }

            Console.WriteLine(found);
        }
    }
}