using System;
using System.Collections.Generic;

namespace _20_ValidParentheses {
    class Program {
        static void Main(string[] args) {
            var res1 = IsValid1("[[(){()}]{}]()");
            var res2 = IsValid2("[[(){()}]{}]()");
        }

        public static bool IsValid2(string s) {
            if (s == null) {
                return false;
            }
            if (s == "") {
                return true;
            }

            var brackets = new Dictionary<char, char> {
                { ']', '[' },
                { ')', '(' },
                { '}', '{' }
            };


            var stack = new Stack<char>();
            foreach (var c in s) {
                if (brackets.ContainsValue(c)) {
                    stack.Push(c);
                    continue;
                }

                if (stack.Count == 0) {
                    return false;
                }

                var openingBracket = stack.Pop();

                if (brackets[c] != openingBracket) {
                    return false;
                }
            }

            return stack.Count == 0;
        }

        public static bool IsValid1(string s) {
            if (s == null) {
                return false;
            }
            if (s == "") {
                return true;
            }

            var stack = new Stack<char>();
            foreach (var c in s) {
                if (c == '(' || c == '[' || c == '{') {
                    stack.Push(c);
                    continue;
                }

                if (stack.Count == 0) {
                    return false;
                }

                var openingBracket = stack.Pop();

                if (!IsCorrectOpeningBracket(openingBracket, c)) {
                    return false;
                }
            }

            return stack.Count == 0;
        }

        private static bool IsCorrectOpeningBracket(char opening, char closing) {
            return (opening == '[' && closing == ']') ||
                   (opening == '(' && closing == ')') ||
                   (opening == '{' && closing == '}');
        }
    }
}
