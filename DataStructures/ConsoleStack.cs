using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    /// <summary>
    /// 
    /// </summary>
    class ConsoleStack : Stack
    {
        public ConsoleStack(int size) : base(size)
        {

        }
        public void print()
        {
            for (int i = 0; i < this.Count; i++)
            {
                Console.WriteLine(this.Peek(i));
            }

        }

    }
}
