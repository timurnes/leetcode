using System;
using System.Text;

namespace _21_MergeTwoSortedLists {
    class Program {
        static void Main(string[] args) {
            var node1 = new ListNode(1) {
                next = new ListNode(2) {
                    next = new ListNode(6) {
                        next = new ListNode(8)
                    }
                }
            };
            var node2 = new ListNode(1) {
                next = new ListNode(3) {
                    next = new ListNode(4) {
                        next = new ListNode(5)
                    }
                }
            };

            var result = MergeTwoLists(node1, node2);

            var sb = new StringBuilder();
            while (result != null) {
                sb.AppendFormat("{0} - ", result.val);
                result = result.next;
            }
            Console.WriteLine(sb.ToString());
        }

        public static ListNode MergeTwoLists(ListNode l1, ListNode l2) {
            if (l1 == null && l2 == null) {
                return null;
            }

            if (l1 == null) {
                return l2;
            }
            if (l2 == null) {
                return l1;
            }

            var result = new ListNode(0);
            ListNode currentNode = null;

            while (l1 != null || l2 != null) {
                var previousNode = currentNode;

                if (l1 == null) {
                    currentNode = l2;
                    l2 = l2.next;
                } else if (l2 == null) {
                    currentNode = l1;
                    l1 = l1.next;
                } else {
                    if (l1.val <= l2.val) {
                        currentNode = l1;
                        l1 = l1.next;
                    } else {
                        currentNode = l2;
                        l2 = l2.next;
                    }
                }

                if (previousNode == null) {
                    result = currentNode;
                } else {
                    previousNode.next = currentNode;
                }
            }

            return result;
        }
    }

    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
