
// Initialisation of queue of type int
// Follows the First In First Out (FIFO) principle
Queue<int> queue = new Queue<int>();

// Adding elements to the queue (Enqueue)
queue.Enqueue(10);
queue.Enqueue(20);
queue.Enqueue(30);

Console.WriteLine("Content of the queue");
foreach (int item in queue)
{
    Console.WriteLine(item);
}

// Removing elements from the queue (Dequeue)
Console.WriteLine("\nRemoving from the queue " + queue.Dequeue()); // 10
Console.WriteLine("Removing from the qeue " + queue.Dequeue()); // 20

// Peek the first element
Console.WriteLine("\nFirst element in queue " + queue.Peek()); // 30

// Checking if the queue contains a value
Console.WriteLine("\nDoes the queue contains 30? " + queue.Contains(30));
Console.WriteLine("Does the queue contains 100? " + queue.Contains(100));

// The number of elements in the queue
Console.WriteLine("\nLNumber of elements in queue " + queue.Count);

// Clearing the queue
queue.Clear();
