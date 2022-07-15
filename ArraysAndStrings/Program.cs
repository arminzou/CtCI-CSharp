using ctci.Library;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { -1, 0, 1, 2, -1, -4 };
            ThreeSum(nums);
        }

        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);
            var result = new List<IList<int>>();

            for (int i = 0; i < nums.Length - 2; i++)
            {
                int left = i+1, right = nums.Length - 1;
                if (nums[i] > 0 || (i > 0 && nums[i] == nums[i - 1]))
                    continue;

                while (left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];
                    if (sum > 0)
                    {
                        right--;
                    }
                    else if (sum < 0)
                    {
                        left++;
                    }
                    else if (sum == 0)
                    {
                        result.Add(new int[] { nums[i], nums[left], nums[right] });
                        left++;
                        while(nums[left] == nums[left - 1] && left < right)
                        {
                            left++;
                        }
                    }
                }
            }
            return result;
        }

    }
}
