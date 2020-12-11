using System;

namespace DataStructures
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //Stack a = new Stack(10);
            /// Stack b = new ConsoleStack(5);

            //b.Push(10);
            // b.Push(4);
            // b.Push(8);
            // b.Push(9);


            ///for (int i = 0; i < b.Count ; i++)

            //Console.WriteLine(b.Peek(i));


            Queue whatevcer = new Queue(5);
            whatevcer.Enqueue(2);
            whatevcer.Enqueue(4);
            int num = whatevcer.Dequeue();

            //Console.WriteLine(num);


            for (int i = 0; i != whatevcer.length1(); i++)
            {
                Console.WriteLine(whatevcer.Print(i));


            }
            

        }

    }
}

