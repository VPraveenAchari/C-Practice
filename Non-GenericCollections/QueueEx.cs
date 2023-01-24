using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsExample
{
    public class QueueEx
    {
        public void Display()

        {
            Queue queue= new Queue();
            queue.Enqueue(true);
            queue.Enqueue("This is Queue");
            queue.Enqueue(67.8f);
            queue.Enqueue("C#");
            queue.Enqueue(9748758364);
            queue.Enqueue(90);
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }
    }
}
