using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> list = new CustomList<int>();
            list.Add(2);
            list.Add(22);
            list.Add(45);
            list.Add(56);
            list.Add(14);
            list.Add(24);
            list.Show();
        }
        class CustomList<T>
        {
            private int capacity;
            private  T[] _list;
            public int count;

            public CustomList()
            {
                _list = new T[0];
            }
            public CustomList(params T[] nums)
            {
                _list = new T[nums.Length];
                for (int i = 0; i < nums .Length; i++)
                {
                    _list[i] = nums[i];
                }
            }
            public void Add(T input)
            {
                Array.Resize(ref _list, _list.Length + 1);
                _list[_list.Length - 1] = input;
                Console.WriteLine(input);
            }
            public void Show()
            {
                foreach (var item in _list)
                {
                    Console.WriteLine(item);
                }
            }
            public void Revorse()
            {
                for (int i = _list.Length-1; i >=0; i--)
                {
                    Console.WriteLine(_list[i]);
                }
            }
            public void Count()
            {
                for (int i = 0; i <_list.Length; i++)
                {
                    count++;
                }
            }
        }
    }
}
