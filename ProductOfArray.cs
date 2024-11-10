using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leetcode
{
    public class ProductOfArray
    {
        /*
        Int array nums then return an array that answer[i] is equal to
        the product of all elements except nums[i]

        Input = [1,2,3,4]
        Output = [24,12,8,6]
        */
        public static void Main()
        {
            int[] nums = {1,2,3,4,5};

            // Can solve this by calculating Prefix and Postfix
            // If the value at beginning or end assume the pre/post-fix value is 1
            // Input    = [ 1    ,2     ,3    ,4   ,5    ]
            // Prefix   : | 1   | 2   |  6 |   24 |  120  |
            // Postfix  : [ 120 | 120 | 60 |   20 |  5   ]

            // Multiply Prefix 1 + Postfix 1
            // Output   : [120  | 60  | 40 |  30  | 24   ]

            int[] output = new int[5];
            
            // Prefix
            int prefix = 1;
            for (int i=0; i < nums.Length; i++)
            {
                // Fill for results[i]
                // A: Value of nums[i-1] * output[i-1]
                // Why i-1? Because output[0]=1 is the imaginary prefix beginning
                // output[i] = nums[i-1] * output[i-1];
                output[i] = nums[i] * prefix;
                prefix = output[i];
                Console.WriteLine(string.Join(",", output));
            }

            // Postfix
            int postfix = 1; // Imaginary out of bound postfix
            for (int j=nums.Length-1; j > 0; j--)
            {
                // Fill for results[j] *Last one
                // 
                output[j] = nums[j] * postfix;
                postfix *= nums[j];
                Console.WriteLine(string.Join(",", output));
            }

            Console.WriteLine(string.Join(",", output));

        }
        
    }
}