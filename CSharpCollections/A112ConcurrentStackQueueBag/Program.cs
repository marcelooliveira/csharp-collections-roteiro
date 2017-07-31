using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A112ConcurrentStackQueueBag
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new ConcurrentQueue<string>();
            var stack = new ConcurrentStack<string>();
            var bag = new ConcurrentBag<string>();

            queue.Enqueue("hello");
            queue.Enqueue("world");

            var first = string.Empty;
            if (queue.TryPeek(out first))
            {
                //fazer algo com first
            }

            queue.TryDequeue(out first);

            stack.Push("hello");
            stack.Push("world");
            stack.PushRange(new[] { "foo", "bar" }); //4

            stack.TryPeek(out first);
            stack.TryPop(out first);

            var array = new string[3];
            stack.TryPopRange(array);

            bag.Add("hello");
            bag.Add("world");
        }
    }
}
