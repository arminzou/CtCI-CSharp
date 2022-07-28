using ctci.Library;
using StacksAndQueues;

/*var stack = new MyStack<int>();
stack.Push(1);
Console.WriteLine(stack);*/

// 3.1 MultiStack
/*var multiStack = new MultiStack(2);
multiStack.Push(0, 1);
Console.WriteLine(multiStack.Peek(0));
multiStack.Push(1, 5);
Console.WriteLine(multiStack.Peek(1));
multiStack.Push(2, 10);
multiStack.Push(2, 15);
multiStack.Pop(2);
Console.WriteLine(multiStack.Peek(2));*/

// 3.2 Stack With Min
/*var stack = new StackWithMin();
var stack2 = new StackWithMin2();

for (var i = 1; i <= 10; i++)
{
	var value = AssortedMethods.RandomIntInRange(0, 100);
	stack.Push2(value);
	stack2.Push2(value);
	Console.Write(value + ", ");
}

Console.WriteLine('\n');
for (var i = 1; i <= 10; i++)
{
	Console.WriteLine("Popped " + stack.Pop().Value + ", " + stack2.Pop2());
	Console.WriteLine("New min is " + stack.Min() + ", " + stack2.Min());
}*/

// 3.3 Stack Of Plates
/*const int capacityPerSubstack = 5;
var set = new SetOfStacks(capacityPerSubstack);

Console.WriteLine("IsEmpty? {0}", set.IsEmpty());

for (var i = 0; i < 34; i++)
{
	set.Push(i);
}
Console.WriteLine("IsEmpty? {0}", set.IsEmpty());

for (var i = 0; i < 34; i++)
{
	if (i == 0)
	{
		set.PopAt(i);
	}
	else
	{
		Console.WriteLine("Popped " + set.Pop());
	}
}*/

// 3.4 Queue via Stacks
/*var myQueue = new StackQueue<int>();

// Let's test our code against a "real" queue
var testQueue = new Queue<int>();

for (var i = 0; i < 100; i++)
{
    var choice = AssortedMethods.RandomIntInRange(0, 10);

    if (choice <= 5)
    {
        // enqueue
        var element = AssortedMethods.RandomIntInRange(1, 10);
        testQueue.Enqueue(element);
        myQueue.Enqueue(element);
        Console.WriteLine("Enqueued " + element);
    }
    else if (testQueue.Count > 0)
    {
        var top1 = testQueue.Dequeue();
        var top2 = myQueue.Dequeue();

        if (top1 != top2)
        { // Check for error
            Console.WriteLine("******* FAILURE - DIFFERENT TOPS: " + top1 + ", " + top2);
        }
        Console.WriteLine("Dequeued " + top1);
    }

    if (testQueue.Count == myQueue.Size())
    {
        if (testQueue.Count > 0 && testQueue.Peek() != myQueue.Peek())
        {
            Console.WriteLine("******* FAILURE - DIFFERENT TOPS: " + testQueue.Peek() + ", " + myQueue.Peek() + " ******");
        }
    }
    else
    {
        Console.WriteLine("******* FAILURE - DIFFERENT SIZES ******");
    }
}*/


// 3.5 Sort Stack
/*Stack<int> stack = new Stack<int>();
stack.Push(2);
stack.Push(15);
stack.Push(8);
stack.Push(1);
stack.Push(10);
stack.Push(99);
stack.Sort();
while (stack.Count > 0)
{
    Console.WriteLine(stack.Pop());
}
var sortedStack = stack.MergeSort();
while (sortedStack.Count > 0)
{
    Console.WriteLine(sortedStack.Pop());
}*/

// 3.6 ANimal Shelter
AnimalQueue animals = new AnimalQueue();
animals.Enqueue(new Cat("Callie"));
animals.Enqueue(new Cat("Kiki"));
animals.Enqueue(new Dog("Fido"));
animals.Enqueue(new Dog("Dora"));
animals.Enqueue(new Cat("Kari"));
animals.Enqueue(new Dog("Dexter"));
animals.Enqueue(new Dog("Dobo"));
animals.Enqueue(new Cat("Copa"));

Console.WriteLine("Dequeued:" + animals.DequeueAny().Name);
Console.WriteLine("Dequeued:" + animals.DequeueAny().Name);
Console.WriteLine("Dequeued:" + animals.DequeueAny().Name);

animals.Enqueue(new Dog("Dapa"));
animals.Enqueue(new Cat("Kilo"));

while (animals.Size() != 0)
{
    Console.WriteLine(animals.DequeueAny().Name);
}
