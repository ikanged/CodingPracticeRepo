using System.Collections.Generic;
using System.Text;

namespace CodingPractice.Problems.DataStructures
{

	public class LinkedListDataStructure : AbsProblem, IProblem
	{
		private LinkedList<char> linkedList;
		private LinkedList<int> linkedListInt;
		private Dictionary<int, string> linkedListMthds = new Dictionary<int, string>();

		public LinkedListDataStructure() : base("Listed List Data Structure")
		{
		}

		public override void Begin()
		{
			//Initialize Linked List
			//InitializeCharLinkedList();

			InitializeIntLinkedList();

			BeginProblem();
		}

		private void BeginProblem()
		{
			InitializeMethodList();
			

			UserInput userInput = new UserInput();

			do
			{
				DisplayMethods();
				var iUserInput = userInput.intUserInput();
				DisplayMessage("*-----------------------*");

				if (linkedListMthds.ContainsKey(iUserInput))
				{
					switch (iUserInput)
					{
						//Iterate
						case 1:
							{
								Iterate();
								break;
							}
						//Insert
						case 2:
							{
								DisplayMessage("Enter Index and Value to Insert to Linked List");
								int index = userInput.intUserInput();
								char value = userInput.charUserInput();

								linkedList = Insert(index, value);

								Iterate();
								break;
							}
						//Delete
						case 3:
							{
								break;
							}
						case 4:
							{
								Iterate();
								int sum = SumOfAllNums(0, linkedListInt);
								DisplayMessage($"Sum: {sum}");
								break;
							}
						case 5:
							{
								Iterate();

								int value = userInput.intUserInput();

								bool found = FindValue(value);

								DisplayMessage($"{ found }");

								break;
							}
						case 6:
							{
								Iterate();

								ReverseLinkedList();

								Iterate();

								break;
							}
						default:
							{
								break;
							}
					}
				}
			} while (RunMethodAgain());
		}


		private void ReverseLinkedList()
		{
			LinkedList<int> prev = null;
			LinkedList<int> current = linkedListInt;
			LinkedList<int> next = linkedListInt._next;

			while (next != null)
			{
				current = prev;
				
			}
		}

		private bool FindValue(int value)
		{
			var root = linkedListInt;

			while(root != null)
			{
				if(root._value == value)
				{
					return true;
				}

				root = root._next;
			}

			return false;
		}

		private int SumOfAllNums(int sum, LinkedList<int> node)
		{

			if(node == null)
			{
				return sum;
			}

			sum += node._value;
			return SumOfAllNums(sum, node._next);
		}

		private LinkedList<char> Insert(int index, char value)
		{
			LinkedList<char> newNode = new LinkedList<char>(value);

			var root = linkedList;
			LinkedList<char> currentNode = linkedList;
			LinkedList<char> temp;

			if (index == 0)
			{
				temp = root;
				root = newNode;
				root._next = temp;
			}
			else if (index > 0)
			{
				for (int i = 0; i <= index; i++)
				{
					if(index-1 == i)
					{
						temp = currentNode._next;
						newNode._next = temp;
						root._next = newNode;

						break;
					}
					else
					{
						currentNode = root._next;
					}
				}
			}

			return root;
		}

		private void InitializeCharLinkedList()
		{
			linkedList = new LinkedList<char>('A');
			linkedList._next = new LinkedList<char>('B');
			linkedList._next._next = new LinkedList<char>('C');
			linkedList._next._next._next = new LinkedList<char>('D');
		}

		private void InitializeIntLinkedList()
		{
			linkedListInt = new LinkedList<int>(2);
			linkedListInt._next = new LinkedList<int>(8);
			linkedListInt._next._next = new LinkedList<int>(3);
			linkedListInt._next._next._next = new LinkedList<int>(7);
		}

		private void Iterate()
		{
			LinkedList<int> root = linkedListInt;
			StringBuilder strBuilder = new StringBuilder();
			while (root != null)
			{
				strBuilder.Append($"{ root._value }, ");
				root = root._next;
			}

			DisplayMessage($"{strBuilder}");
		}

		private void InitializeMethodList()
		{
			linkedListMthds.Add(1, "Iterate");
			linkedListMthds.Add(2, "Insert");
			linkedListMthds.Add(3, "Delete");
			linkedListMthds.Add(4, "Sum");
			linkedListMthds.Add(5, "Find");
			linkedListMthds.Add(6, "Reverse Linked List");
		}

		private void DisplayMethods()
		{
			for (int i = 1; i <= linkedListMthds.Count; i++)
			{
				DisplayMessage($"{i}. {linkedListMthds[i]}");
			}

			DisplayMessage("*-----------------------*");
		}

		private bool RunMethodAgain()
		{
			//New Line
			DisplayMessage("");
			DisplayMessage("*-----------------------*");
			DisplayMessage("Run Again? Enter 1 for Yes");

			bool bRunAgain = false;
			UserInput input = new UserInput();

			if (input.intUserInput() == 1)
			{
				bRunAgain = true;
			}

			return bRunAgain;
		}

	}

	class LinkedList<T>
	{
		public T _value;
		public LinkedList<T> _next;

		public LinkedList(T value)
		{
			_value = value;
			_next = null;
		}
	}
}
