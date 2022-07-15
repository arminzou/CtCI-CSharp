using ctci.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    internal class RemoveDups
    {
        public static void DeleteDups(ListNode n)
        {
            var set = new HashSet<int>();
            ListNode prev = null;

            while (n != null)
            {
                if (set.Contains((int)n.Data))
                {
                    prev.Next = n.Next;
                }
                else
                {
                    set.Add((int)n.Data);
                    prev = n;
                }
                n = n.Next;
            }
        }
    }
}
