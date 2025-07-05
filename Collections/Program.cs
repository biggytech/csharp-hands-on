using System;
using System.Collections; // ArrayList
using System.Collections.Generic; // List, LinkedList, Queue, Stack
using System.Collections.ObjectModel; // ObservableCollection
using System.Collections.Specialized; // ObservableCollection events types
using static System.Console;

namespace Collections {
    class Program {
        static void Main(string[] args) {
            // UseArrayList();
            // UseList();
            // UseLinkedList();
            // UseQueue();
            // UseStack();
            // UseDictionary();
            // UseObservableCollection();
            // UseINumerables();
            UseIterators();
        }

        public static void UseArrayList() {
            ArrayList list = new ArrayList();
            list.Add(2.3);
            list.Add(34);
            list.AddRange(new string[] { "Hello", "world"});

            foreach(object o in list) {
                WriteLine(o);
            }

            list.RemoveAt(0);
            list.Reverse();
            WriteLine(list[0]);

            foreach(object o in list) {
                WriteLine(o);
            }
            WriteLine(list.Count);
        }

        public static void UseList() {
            List<int> list = new() { 1, 2, 3 };
            list.Add(4);
            list.AddRange(new int[] { 5, 6, 7 });
            list.Insert(2, 22);
            list.RemoveAt(0);

            foreach(int num in list) {
                WriteLine(num);
            } 
        }

        public static void UseLinkedList() {
            LinkedList<int> list = new();
            list.AddLast(1);
            list.AddFirst(2);
            list.AddAfter(list.Last, 3);

            foreach(int num in list) {
                WriteLine(num);
            }

            WriteLine($"Second node: {list.First.Next.Value}");
        }

        public static void UseQueue() {
            Queue<int> line = new();
            line.Enqueue(1);
            line.Enqueue(2);
            line.Enqueue(3);

            WriteLine($"First el: {line.Peek()}");

            int el = line.Dequeue();
            WriteLine($"Removed first el: {el}");
            WriteLine(line.Count);

            foreach(int num in line) {
                WriteLine(num);
            }
        }

        public static void UseStack() {
            Stack<int> stack = new();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            WriteLine($"First el: {stack.Peek()}");
            WriteLine($"First removed el: {stack.Pop()}");

            foreach(int num in stack) {
                WriteLine(num);
            }
        }

        public static void UseDictionary() {
            Dictionary<int, string> dict = new();
            dict.Add(1, "One");
            dict.Add(2, "Two");
            dict.Add(3, "Three");

            dict[3] = "Third";
            dict.Remove(2);

            // foreach dict.Keys || dict.Values
            foreach(KeyValuePair<int, string> pair in dict) {
                WriteLine($"{pair.Key} - {pair.Value}");
            }
        }

        public static void UseObservableCollection() {
            ObservableCollection<int> coll = new() {
                1, 2, 3
            };

            coll.CollectionChanged += (object sender, NotifyCollectionChangedEventArgs e) => {
                switch(e.Action) {
                    case NotifyCollectionChangedAction.Add:
                        int n = (int)e.NewItems[0];
                        WriteLine($"Added: {n}");
                        break;
                    case NotifyCollectionChangedAction.Remove:
                        int num = (int)e.OldItems[0];
                        WriteLine($"Removed: {num}");
                        break;
                    case NotifyCollectionChangedAction.Replace:
                        int num1 = (int)e.NewItems[0];
                        int num2 = (int)e.OldItems[0];
                        WriteLine($"Replace: {num2} - {num1}");
                        break;
                }
            };

            coll.Add(4);
            coll.RemoveAt(0);
            coll[0] = 22;
        }

        public static void UseINumerables() {
            /*
            int[] list = { 1, 2, 3 };
            IEnumerator ie  = list.GetEnumerator();
            // WriteLine(ie.Current); // ERROR
            while (ie.MoveNext()) {
                int item = (int)ie.Current;
                WriteLine(item);
            }
            ie.Reset();
            */

            Week w = new Week();
            // WriteLine((w.GetEnumerator()).Current); // our ERROR
            foreach(string v in w) {
                WriteLine(v);
            } 
        }

        class WeekEnumerator : IEnumerator {
            string[] nums;
            int pos = -1;
            public WeekEnumerator(string[] n) {
                nums = n;
            }
            public object Current {
                get {
                    if (pos == -1 || pos >= nums.Length) {
                        throw new InvalidOperationException();
                    }
                    return nums[pos];
                }
            }

            public bool MoveNext() {
                if (pos < nums.Length - 1) {
                    pos++;
                    return true;
                }

                return false;
            }

            public void Reset() {
                pos = -1;
            }
        }

        class Week : IEnumerable {
            string[] nums = { "One", "Two", "Three" };
            public IEnumerator GetEnumerator() {
                return new WeekEnumerator(nums);
            }
        }

        public static void UseIterators() {
            Numbers nums = new Numbers(new int[] { 1, 2, 3 });

            /*
            foreach(int num in nums) {
                WriteLine(num);
            }
            */
            IEnumerable<int> n = nums.GetNums();
            foreach (int num in n) {
                WriteLine(num);
            }
        }

        class Numbers {
            int[] numbers;

            public Numbers(int[] nums) {
                numbers = nums;
            }

            public IEnumerator GetEnumerator() {
                foreach(int num in numbers) {
                    yield return num;
                }
                yield return 100;
            }

            public IEnumerable<int> GetNums() {
                foreach(int num in numbers) {
                    if (num == 2) {
                        yield break;
                    }
                    yield return num;
                }
                yield return 100;
            }
        }

    }
}