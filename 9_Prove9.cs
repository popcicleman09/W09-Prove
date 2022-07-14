/**
 * CSE212 
 * (c) BYU-Idaho
 * 07-Prove
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
 * to post it online.  Storage into a personal and private repository (e.g. private
 * GitHub repository, unshared Google Drive folder) is acceptable.
 */
using prove_9;

public class Prove9 {
    /// <summary>
    /// Entry point for the Prove 9 tests
    /// </summary>
    public static void Run() {
        // Sample Test Cases (may not be comprehensive) 
        Print("\n=========== PROBLEM 1 TESTS ===========");
        Bst tree = new Bst();
        tree.Insert(5);
        tree.Insert(3);
        tree.Insert(7);
        // After implementing 'no duplicates' rule,
        // this next insert will have no effect on the tree.
        tree.Insert(7);  
        tree.Insert(4);
        tree.Insert(10);
        tree.Insert(1);
        tree.Insert(6);
        Print(tree.ToString()); // 1, 3, 4, 5, 6, 7, 10

        Print("\n=========== PROBLEM 2 TESTS ===========");
        Print(tree.Contains(3)); // True
        Print(tree.Contains(2)); // False
        Print(tree.Contains(7)); // True
        Print(tree.Contains(6)); // True
        Print(tree.Contains(9)); // False

        // Todo add test cases
        // ll.InsertTail(1);
        // ll.Insert(2);
        // ll.Insert(2);
        // ll.Insert(2);
        // ll.Insert(3);
        // ll.Insert(4);
        // ll.Insert(5);
        // Print(ll.ToString()); // linked_list[5, 4, 3, 2, 2, 2, 1];
        // ll.InsertTail(0);
        // ll.InsertTail(-1);
        // Print(ll.ToString()); // linked_list[5, 4, 3, 2, 2, 2, 1, 0, -1];
        //
        // Print("\n=========== PROBLEM 2 TESTS ===========");
        // ll.RemoveTail();
        // Print(ll.ToString()); // linked_list[5, 4, 3, 2, 2, 2, 1, 0]
        // ll.RemoveTail();
        // Print(ll.ToString()); // linked_list[5, 4, 3, 2, 2, 2, 1]
        //
        // Print("\n=========== PROBLEM 3 TESTS ===========");
        // ll.InsertAfter(3, 35);
        // ll.InsertAfter(5, 6);
        // Print(ll.ToString()); // linked_list[5, 6, 4, 3, 35, 2, 2, 2, 1]
        // ll.Remove(-1);
        // Print(ll.ToString()); // linked_list[5, 6, 4, 3, 35, 2, 2, 2, 1]
        // ll.Remove(3);
        // Print(ll.ToString()); // linked_list[5, 6, 4, 35, 2, 2, 2, 1]
        // ll.Remove(6);
        // Print(ll.ToString()); // linked_list[5, 4, 35, 2, 2, 2, 1]
        // ll.Remove(1);
        // Print(ll.ToString()); // linked_list[5, 4, 35, 2, 2, 2]
        // ll.Remove(7);
        // Print(ll.ToString()); // linked_list[5, 4, 35, 2, 2, 2]
        // ll.Remove(5);
        // Print(ll.ToString()); // linked_list[4, 35, 2, 2, 2]
        // ll.Remove(2);
        // Print(ll.ToString()); // linked_list[4, 35, 2, 2]
        //
        // Print("\n=========== PROBLEM 4 TESTS ===========");
        // ll.Replace(2, 10);
        // Print(ll.ToString()); // linked_list[4, 35, 10, 10]
        // ll.Replace(7, 5);
        // Print(ll.ToString()); // linked_list[4, 35, 10, 10]
        // ll.Replace(4, 100);
        // Print(ll.ToString()); // linked_list[100, 35, 10, 10]
        //
        //
        // Print("\n=========== PROBLEM 5 TESTS ===========");
        // Print(ll.Reverse().Cast<int>().ToArray());  // [10, 10, 35, 100]
    }

    private static void Print(bool value)
    {
        Console.WriteLine(value);
    }

    private static void Print(string value) {
        Console.WriteLine(value);
    }

    private static void Print(int[] value) {
        Console.WriteLine("[" + String.Join(", ", value) + "]");
    }
}
