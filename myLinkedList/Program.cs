SingleLinkedList list = new SingleLinkedList();
int listLength = 5;
int tmpListValue = 1;


Console.WriteLine("Filling out the list Inserting last element as head value");

while (listLength > 0)
{
    list.InsertFront(list, tmpListValue++);
    --listLength;
}

list.PrintListValues();

Console.WriteLine("\n\nFilling out the list Inserting first element as head value\n\n");

list = new SingleLinkedList();
tmpListValue = 1;
listLength = 5;

while (listLength > 0)
{
    list.insertLast(list, tmpListValue++);
    --listLength;
}

list.PrintListValues();

Console.WriteLine("\n\nInserting value in between other values\n\n");

Node node = list.GetNodeByValue(list, 3);

list.InsertAfter(node, 10);


Console.WriteLine("\n\nNew values after insertion in between values\n\n");
list.PrintListValues();

Console.WriteLine("\n\nReverse LinkedList\n\n");

Console.WriteLine("\n\nLinkedList BEFORE Reverse\n\n");

list.PrintListValues();

list.ReverseLinkedList(list);

Console.WriteLine("\n\nLinkedList AFTER Reverse\n\n");

list.PrintListValues();