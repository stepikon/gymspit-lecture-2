//added Dump and IsEmpty methods to MyList and MyLinkedList
//added Clear methods to queue and stack
//added Contains method for q and s.
//added FirstIndexOf method for stack
//added EasierQueue class
using System;


namespace Lecture4
{
	class Program
	{
		static void Main(string[] args)
		{
			Person a = new Person();
			a.firstName = "First";
			a.lastName = "Last";
			a.age = 42;

			Person b = new Person();
			b.firstName = "Tsrif";
			b.lastName = "Tsal";
			b.age = 24;

			MyList<Person> list = new MyList<Person>();
			list.Add(a);
			list.Add(b);
			Console.WriteLine(list.Count());
			Console.WriteLine(list.Get(0) == a);
			Console.WriteLine(list.Get(1) == b);
			Console.WriteLine(list.Get(0).firstName);
			Console.WriteLine(list.Get(0).lastName);
			Console.WriteLine(list.Get(0).age);

			MyList<int> intList = new MyList<int>();
			intList.Add(15);
			intList.Add(16);
			intList.Add(31);
			Console.WriteLine(intList.Count());
			for (int i = 0; i < intList.Count(); i += 1) {
				Console.WriteLine(intList.Get(i));
			}

			list.Clear();
			intList.Clear();
			//Console.WriteLine(list.Get(0)); - throws an Exception
			//Console.WriteLine(intList.Get(0)); - throws an Exception
			Console.WriteLine("Empty: " + list.IsEmpty());
			Console.WriteLine("Empty: " + intList.IsEmpty());

			MyLinkedList<int> linkList = new MyLinkedList<int>();
			linkList.AddFirst(1);
			linkList.AddLast(3);
			linkList.AddAfter(2, linkList.GetFirst());

			Console.WriteLine(linkList.Count());
			for (var node = linkList.GetFirst(); node != null; node = node.next) {
				Console.WriteLine(node.Item);
			}

			linkList.Clear();
			Console.WriteLine("empty: {0}", linkList.IsEmpty());

			MyQueue<string> queue = new MyQueue<string>();
			queue.Enqueue("this");
			queue.Enqueue("is");
			queue.Enqueue("queue");
			Console.WriteLine(queue.Peek());
			while (!queue.IsEmpty()) {
				Console.WriteLine(queue.Dequeue());
			}
			queue.Clear();
			while (!queue.IsEmpty())
			{
				Console.WriteLine(queue.Dequeue());
			}
			queue.Enqueue("Hello");
			queue.Enqueue("there");
			Console.WriteLine(queue.Peek());
			Console.WriteLine("Contains: " + queue.Contains("Hello"));
			Console.WriteLine("Contains: " + queue.Contains("Memes"));
			while (!queue.IsEmpty())
			{
				Console.WriteLine(queue.Dequeue());
			}

			MyStack<string> stack = new MyStack<string>();
			stack.Push("this");
			stack.Push("is");
			stack.Push("stack");
			Console.WriteLine(stack.Peek());
			while (!stack.IsEmpty()) {
				Console.WriteLine(stack.Pop());
			}
			stack.Clear();
			while (!stack.IsEmpty())
			{
				Console.WriteLine(stack.Pop());
			}
			stack.Push("Hello");
			stack.Push("there");
			Console.WriteLine(stack.Peek());
			Console.WriteLine("Contains " + stack.Contains("Hello"));
			Console.WriteLine("Contains " + stack.Contains("Memes"));
			Console.WriteLine("FirstIndexOf " + stack.FirstIndexOf("Hello"));
			Console.WriteLine("FirstIndexOf " + stack.FirstIndexOf("Memes"));
			while (!stack.IsEmpty())
			{
				Console.WriteLine(stack.Pop());
			}

			EasierQueue<int> eq = new EasierQueue<int>();
			eq.Enqueue(1);
			eq.Enqueue(12);
			eq.Enqueue(23);
			eq.Enqueue(34);
			eq.Enqueue(69);
			eq.Enqueue(77);
			while (!eq.IsEmpty())
			{
				Console.WriteLine(eq.Dequeue());
			}
			eq.Enqueue(34);
			eq.Enqueue(69);
			Console.WriteLine("Contains " + eq.Contains(69));
			Console.WriteLine("Contains " + eq.Contains(2));
			Console.WriteLine("FirstIndexOf " + eq.FirstIndexOf(69));
			Console.WriteLine("FirstIndexOf " + eq.FirstIndexOf(2));

			Console.ReadKey();
		}
	}
}
