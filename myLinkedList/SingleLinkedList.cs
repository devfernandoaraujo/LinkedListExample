using System.Text;
internal class SingleLinkedList
{
    internal Node head;

    /// <summary>
    /// Insert a new value at the front of the list
    /// </summary>
    /// <param name="list"></param>
    /// <param name="new_data"></param>
    internal void InsertFront(SingleLinkedList list, int new_data)
    {
        Node newNode = new Node(new_data);
        newNode.next = list.head;
        list.head = newNode;
    }

    /// <summary>
    /// Return the last node in a list
    /// </summary>
    /// <param name="list"></param>
    /// <returns></returns>
    internal Node GetLastNode(SingleLinkedList list)
    {

        Node temp = list.head;
        while (temp.next != null)
        {
            temp = temp.next;
        }

        return temp;

    }

    /// <summary>
    /// Return Node by Reference
    /// </summary>
    /// <param name="list"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    internal Node GetNodeByValue(SingleLinkedList list, int value)
    {

        Node temp = list.head;

        if (temp.data == value)
        {
            return temp;
        }

        while (temp.next != null)
        {
            temp = temp.next;
            if (temp.data == value)
            {
                return temp;
            }
        }

        Console.WriteLine("\nNo node found with the value {0}\n", value);
        return null;
    }

    /// <summary>
    /// Insert a value at the end of the list.
    /// </summary>
    /// <param name="list"></param>
    /// <param name="new_data"></param>
    internal void insertLast(SingleLinkedList list, int new_data)
    {

        Node newNode = new Node(new_data);
        if (list.head == null)
        {
            list.head = newNode;
            return;
        }

        Node lastNode = GetLastNode(list);
        lastNode.next = newNode;
    }

    /// <summary>
    /// Insert after a specific node 
    /// </summary>
    /// <param name="prev_node"></param>
    /// <param name="new_data"></param>
    internal void InsertAfter(Node prev_node, int new_data)
    {
        if (prev_node == null)
        {
            Console.WriteLine("The given previous node Cannot be nuLL");
            return;
        }
        Node new_node = new Node(new_data);
        new_node.next = prev_node.next;
        prev_node.next = new_node;

    }

    /// <summary>
    /// Remove a value frrom the LinkedList
    /// </summary>
    /// <param name="list"></param>
    /// <param name="key"></param>
    internal void DeleteNodeByKey(SingleLinkedList list, int key)
    {
        Node temp = list.head;
        Node prev = null;

        if (temp != null && temp.data == key)
        {
            list.head = temp.next;
            return;
        }

        while (temp != null && temp.data != key)
        {
            prev = temp;
            temp = temp.next;
        }

        if (temp == null)
        {
            return;
        }

        prev.next = temp.next;
    }

    /// <summary>
    /// Reverse the LinkedList
    /// </summary>
    /// <param name="list"></param>
    public void ReverseLinkedList(SingleLinkedList list)
    {
        Node prev = null;
        Node current = list.head;
        Node temp = null;
        while (current != null)
        {
            temp = current.next;
            current.next = prev;
            prev = current;
            current = temp;
        }

        list.head = prev;
    }

    /// <summary>
    /// Print the 
    /// </summary>
    /// <param name="list"></param>
    public void PrintListValues()
    {

        Node temp = this.head;
        var sb = new StringBuilder();

        if (temp == null)
        {
            Console.WriteLine("There is no value in the list.\n");
            return;
        }

        sb.AppendLine("***********************List Values***********************");
        while (temp != null)
        {
            sb.AppendLine(temp.data.ToString());
            temp = temp.next;
        }

        Console.WriteLine(sb);
    }


}





