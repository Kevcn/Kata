namespace LeetCodeIt;


public class MergeTwoSortedLists
{
    public static ListNode MergeSorted(ListNode list1, ListNode list2)
    {
        /* a dummy first node to hang the result on */
        ListNode dummyNode = new ListNode();

        /* tail points to the last result node */
        ListNode tail = dummyNode;
        while(true)
        {
            if(list1 == null)
            {
                tail.next = list2;
                break;
            }
            if(list2 == null)
            {
                tail.next = list1;
                break;
            }

            // Compare 2 pointers, the smaller is appended onto the tail and move pointer forward by 1
            if(list1.Val <= list2.Val)
            {
                tail.next = list1;
                list1 = list1.next;
            }
            else
            {
                tail.next = list2;
                list2 = list2.next;
            }

            /* Now that the tail has either A or B, advance the tail */
            tail = tail.next;
        }
        return dummyNode.next;
    }




    public static void Run()
    {
        var list1 = new ListNode(1, new ListNode(5, new ListNode(9)));
        var list2 = new ListNode(3, new ListNode(4, new ListNode(7)));

        var merged = MergeSorted(list1, list2);

        var test = new ListNode(1);

        if (!string.IsNullOrWhiteSpace(test.test1))
        {
            Console.WriteLine("erm?");
        }
        
    }

}

public class ListNode {

    public int Val;
    public ListNode? next;
    public string test1 { get; set; }

    public ListNode(int val = 0, ListNode? next = null ) {
        Val = val;
        next = next;
    }
}