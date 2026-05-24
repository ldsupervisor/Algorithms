// Stack initialization
// Stack operations: Push, Pop, Peek, Contains, Count, Clear
// Stack follows Last In First Out (LIFO) principle
Stack<int> stack = new Stack<int>();

// Adding elements to the stack (Push)
stack.Push(10);
stack.Push(20);
stack.Push(30);

Console.WriteLine("Elements in stack");
foreach (int item in stack)
{
    Console.WriteLine(item);
}

// View top element (Peek)
Console.WriteLine("\nOn the top of the stack there is " + stack.Peek());

// Remove element from stack (Pop)
int removed = stack.Pop();
Console.WriteLine("\n " + removed);

// Check if stack contains a value
Console.WriteLine("\nIs the stack containing 20 " + stack.Contains(20));

// The number of elements
Console.WriteLine("The quantity of elements in stack " + stack.Count);

// Clearing the stack
stack.Clear();
Console.WriteLine("\nStack after clearing " + stack.Count + " elementów");