using System;
using System.Collections.Generic;

namespace _1_TwoSum {
    class Program {
        static void Main(string[] args) {
            var result = TwoSum(new[] { 2, 11, 7, 15 }, 9);
        }

        public static int[] TwoSum(int[] nums, int target) {
            var comp = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++) {
                var value = nums[i];
                var complement = target - value;
                if (comp.ContainsKey(complement)) {
                    return new[] { comp[complement], i };
                }

                comp[value] = i;
            }

            throw new InvalidOperationException();
        }
    }
}
