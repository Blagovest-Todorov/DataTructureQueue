using System;
using System.Collections.Generic;
using System.Collections;

namespace _03.Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Queue<string> queue = new Queue<string>(); //creating a queue object 
            queue.Enqueue("Message One");
            queue.Enqueue("Message two");
            queue.Enqueue("Message Three");
            queue.Enqueue("Message Four");

            while (queue.Count > 0) //till there is elements into the queue
            {
                string message = queue.Dequeue(); //removes the first elemetn of the  Queue
                Console.WriteLine(message);
            }
        }
    }
}
