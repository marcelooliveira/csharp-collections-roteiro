using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace A81ArraysMultidimensionais
{
    class Program
    {
        static ConcurrentDictionary<int, string> _dictionary =
            new ConcurrentDictionary<int, string>();

        static void Main(string[] args)
        {
            _dictionary.TryAdd(1, "hello");
            _dictionary.TryAdd(2, "world");

            PrintDictionary();

            var t1 = new Thread(new ThreadStart(A));
            var t2 = new Thread(new ThreadStart(B));
            var t3 = new Thread(new ThreadStart(C));

            t1.Start();
            t2.Start();
            t3.Start();

            t1.Join();
            t2.Join();
            t3.Join();

            _dictionary.AddOrUpdate(7, "dog", (k, v) => v + "2"); //7, dog
            _dictionary.AddOrUpdate(7, "dog", (k, v) => v + "2"); //7, dog2
            PrintDictionary();

            var cat = _dictionary.GetOrAdd(8, "cat"); //cat
            cat = _dictionary.GetOrAdd(8, "fish"); //cat
            PrintDictionary();

        }

        private static void PrintDictionary()
        {
            foreach (var item in _dictionary)
                Console.WriteLine(item);
            Console.WriteLine();
        }

        static void A()
        {
            _dictionary.TryAdd(3, "foo");
            Console.WriteLine("A()");
            PrintDictionary();

        }

        static void B()
        {
            var value = string.Empty;
            _dictionary.TryRemove(1, out value);
            Console.WriteLine("B()");
            PrintDictionary();

        }

        static void C()
        {
            var value = string.Empty;
            _dictionary.TryUpdate(2, "world2", "world3");
            Console.WriteLine("C()");
            PrintDictionary();

        }
    }
}
