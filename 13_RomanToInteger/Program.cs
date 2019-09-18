using System;
using System.Collections.Generic;

namespace _13_RomanToInteger {
    class Program {
        static void Main(string[] args) {
            var res1 = RomanToInt1("MMCDLXVII");
            var res2 = RomanToInt2("MMCDLXVII");
        }

        public static int RomanToInt1(string s) {
            var result = 0;

            for (var i = 0; i < s.Length; i++) {
                var t = GetIntFromRoman(s[i]);
                if (i < s.Length - 1 && GetIntFromRoman(s[i + 1]) > t) {
                    t = -t;
                }

                result += t;
            }

            return result;
        }

        public static int RomanToInt2(string s) {
            var dict = new Dictionary<char, int> {
                {'I', 1 },
                {'V', 5 },
                {'X', 10 },
                {'L', 50 },
                {'C', 100 },
                {'D', 500 },
                {'M', 1000 }
            };

            var result = 0;

            for (var i = 0; i < s.Length; i++) {
                var t = dict[s[i]];
                if (i < s.Length - 1 && dict[s[i + 1]] > t) {
                    t = -t;
                }

                result += t;
            }

            return result;
        }

        private static int GetIntFromRoman(char c) {
            switch (c) {
                case 'I': return 1;
                case 'V': return 5;
                case 'X': return 10;
                case 'L': return 50;
                case 'C': return 100;
                case 'D': return 500;
                case 'M': return 1000;
                default: throw new InvalidOperationException();
            }
        }
    }
}
