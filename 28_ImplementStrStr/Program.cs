using System;

namespace _28_ImplementStrStr {
    class Program {
        static void Main(string[] args) {
            var haystack = "mississippi";
            var needle = "issip";

            var result = StrStr(haystack, needle);
        }

        public static int StrStr(string haystack, string needle) {
            if (haystack == null) {
                return -1;
            }
            if (needle == null || needle.Length == 0) {
                return 0;
            }
            if (needle.Length > haystack.Length) {
                return -1;
            }

            var hIndex = 0;
            var nIndex = 0;

            while (hIndex < haystack.Length) {
                if (haystack[hIndex++] == needle[nIndex]) {
                    nIndex++;
                } else {
                    hIndex -= nIndex;
                    nIndex = 0;
                }

                if (hIndex + nIndex > haystack.Length) {
                    return -1;
                }
                if (nIndex == needle.Length) {
                    return hIndex - needle.Length;
                }
            }

            return -1;
        }
    }
}
