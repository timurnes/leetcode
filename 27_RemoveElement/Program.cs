using System;

namespace _27_RemoveElement {
    class Program {
        static void Main(string[] args) {
            var nums = new[] { 0, 1, 2, 2, 3, 0, 4, 2 };
            var result = RemoveElement(nums, 2);
        }

        public static int RemoveElement(int[] nums, int val) {
            if (nums == null || nums.Length == 0) {
                return 0;
            }

            var result = 0;
            var index = 0;

            while (index < nums.Length) {
                if (nums[index] == val) {
                    index++;
                    continue;
                }

                nums[result++] = nums[index++];
            }

            return result;
        }
    }
}
