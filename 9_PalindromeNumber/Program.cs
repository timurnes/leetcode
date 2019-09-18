using System;

namespace _9_PalindromeNumber {
    class Program {
        static void Main(string[] args) {
            var res1 = IsPalindrome(121);
            var res2 = IsPalindrome(-121);
            var res3 = IsPalindrome(12321);
        }

        public static bool IsPalindrome(int x) {
            if (x < 0 || (x % 10 == 0 && x != 0)) {
                return false;
            }

            int revertedNumber = 0;
            while (x > revertedNumber) {
                revertedNumber = revertedNumber * 10 + x % 10;
                x /= 10;
            }

            return x == revertedNumber || x == revertedNumber / 10;
        }
    }
}
