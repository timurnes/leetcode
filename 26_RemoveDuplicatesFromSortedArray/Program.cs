using System;

namespace _26_RemoveDuplicatesFromSortedArray {
    class Program {
        static void Main(string[] args) {
            var nums = new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            var result = RemoveDuplicates(nums);
        }

        public static int RemoveDuplicates(int[] nums) {
            if (nums == null || nums.Length == 0) {
                return 0;
            }
            if (nums.Length == 1) {
                return 1;
            }

            var result = 1;
            var index = 1;

            while (index < nums.Length) {
                if (nums[result - 1] == nums[index]) {
                    index++;
                    continue;
                }

                nums[result++] = nums[index++];
            }

            return result;
        }
    }
}
