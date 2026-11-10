
using static System.Console;

namespace Collection
{
    internal class Task3
    {
        private readonly List<int> _listOfInts = new List<int>();

            public void TaskLoop()
            {
                WriteLine("=== Задача 1: List<int> ===");
                WriteLine("Введите от 3 до 6 чисел (по одному):");

                int count = 0;
                while (count < 3 || count > 6)
                {
                    Write($"Сколько чисел ввести (3–6)? ");
                    if (!int.TryParse(ReadLine(), out count) || count < 3 || count > 6)
                    {
                        WriteLine("Ошибка: нужно число от 3 до 6.");
                        count = 0;
                    }
                }

                for (int i = 0; i < count; i++)
                {
                    Write($"Число {i + 1}: ");
                    if (int.TryParse(ReadLine(), out int value))
                        _listOfInts.Add(value);
                    else
                    {
                        WriteLine("Ошибка ввода, попробуйте снова.");
                        i--;
                    }
                }

                WriteLine("Прямой порядок: " + string.Join(", ", _listOfInts));

                Write("Обратный порядок: ");
                for (int i = _listOfInts.Count - 1; i >= 0; i--)
                    Write(_listOfInts[i] + (i > 0 ? ", " : "\n"));
            }
        }

      class LinkedListTask
        {
            private class Node
            {
                public int Value;
                public Node Next;
                public Node Previous;
            }

            private Node _head;  
            private Node _tail;  

            public void AddLast(int value)
            {
                Node newNode = new Node { Value = value };

                if (_head == null)          
                {
                    _head = _tail = newNode;
                }
                else
                {
                    newNode.Previous = _tail;
                    _tail.Next = newNode;
                    _tail = newNode;
                }
            }

            public void PrintForward()
            {
                Node current = _head;
                while (current != null)
                {
                    Write(current.Value + (current.Next != null ? " ⇄ " : "\n"));
                    current = current.Next;
                }
            }

            public void PrintBackward()
            {
                Node current = _tail;
                while (current != null)
                {
                    Write(current.Value + (current.Previous != null ? " ⇄ " : "\n"));
                    current = current.Previous;
                }
            }

            public void TaskLoop()
            {
                WriteLine("=== Задача 2: Двусвязный список ===");
                WriteLine("Введите от 3 до 6 чисел (по одному):");

                int count = 0;
                while (count < 3 || count > 6)
                {
                    Write("Сколько чисел ввести (3–6)? ");
                    if (!int.TryParse(ReadLine(), out count) || count < 3 || count > 6)
                    {
                        WriteLine("Ошибка: нужно число от 3 до 6.");
                        count = 0;
                    }
                }

                for (int i = 0; i < count; i++)
                {
                    Write($"Число {i + 1}: ");
                    if (int.TryParse(ReadLine(), out int value))
                        AddLast(value);
                    else
                    {
                        WriteLine("Ошибка ввода, попробуйте снова.");
                        i--;
                    }
                }

                Write("Прямой порядок:    ");
                PrintForward();

                Write("Обратный порядок:  ");
                PrintBackward();
            }
        

       
        }
    }
