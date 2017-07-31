using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace A111ConcurrentDictionary
{
    class Program
    {
        static ConcurrentDictionary<int, string> _dictionary =
            new ConcurrentDictionary<int, string>();

        static void Main(string[] args)
        {
            _dictionary.TryAdd(1, "hello");
            _dictionary.TryAdd(2, "world");

            var t1 = new Thread(new ThreadStart(A));
            var t2 = new Thread(new ThreadStart(B));
            var t3 = new Thread(new ThreadStart(C));

            t1.Start();
            t2.Start();
            t2.Start();

            t1.Join();
            t2.Join();
            t2.Join();

            _dictionary.AddOrUpdate(7, "dog", (k, v) => v + "2"); //dog
            _dictionary.AddOrUpdate(7, "dog", (k, v) => v + "2"); //dog2

            var cat = _dictionary.GetOrAdd(8, "cat"); //cat
            cat = _dictionary.GetOrAdd(8, "fish"); //cat
        }

        static void A()
        {
            _dictionary.TryAdd(3, "foo");
        }

        static void B()
        {
            var value = string.Empty;
            _dictionary.TryRemove(1, out value);
        }

        static void C()
        {
            var value = string.Empty;
            //fail safe
            _dictionary.TryUpdate(2, "world 2", "world 3");//fail
            _dictionary.TryUpdate(2, "world 2", "world 3");//fail
        }
    }
}
