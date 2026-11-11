using System;
using System.Collections.Generic;

namespace Collection
{
    internal class Task3
    {

        private class LinkedListTask
        {
            private class Node
            {
                public int Value;
                public Node? Next;
                public Node? Prev;

                public Node(int value)
                {
                    Value = value;
                }
            }

            private Node? _head;
            private Node? _tail;
            private int _count;

            public void AddLast(int value)
            {
                var node = new Node(value);

                if (_head == null)
                {
                    _head = node;
                    _tail = node;
                }
                else
                {
                    node.Prev = _tail;
                    _tail!.Next = node;
                    _tail = node;
                }

                _count++;
            }

            public void PrintForward()
            {
                Console.Write("Прямой порядок:    ");
                var current = _head;
                while (current != null)
                {
                    Console.Write(current.Value);
                    if (current.Next != null) Console.Write(" ");
                    current = current.Next;
                }
                Console.WriteLine();
            }

            public void PrintBackward()
            {
                Console.Write("Обратный порядок:  ");
                var current = _tail;
                while (current != null)
                {
                    Console.Write(current.Value);
                    if (current.Prev != null) Console.Write(" ");
                    current = current.Prev;
                }
                Console.WriteLine();
            }

            public int Count => _count;

            public void TaskLoop()
            {
                Console.WriteLine("=== Задание 3: двусвязный список ===");

                int count = ReadCount(3, 6);
                for (int i = 0; i < count; i++)
                {
                    AddLast(ReadInt($"Введите элемент {i + 1}: "));
                }

                PrintForward();
                PrintBackward();
            }
        }

        private static int ReadInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out int value))
                    return value;
                Console.WriteLine("Ошибка: введите целое число.");
            }
        }

        private static int ReadCount(int min, int max)
        {
            while (true)
            {
                Console.Write($"Сколько элементов создать ({min}-{max})? ");
                if (int.TryParse(Console.ReadLine(), out int n) && n >= min && n <= max)
                    return n;
                Console.WriteLine($"Ошибка: нужно число от {min} до {max}.");
            }
        }
    }
}
    

               
