using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{


    class Queue
    {
        int[] queue;
        int ep;
        int max;
        int fp;

        public int length1()
        {
            return max;

        }

        public Queue(int size)
        {
            max = size;
            queue = new int[max];
            ep = 0;
            fp = 0;
        }

        public int Print(int index)
        {

            return queue[index];
        
        }




        public void Enqueue(int item)
        {
            if (ep < max)
            {
                queue[ep] = item;
                ep++;

            }
            else
                throw new Exception("Queue full");
        
        }
       
        
        
        
        
        public int Dequeue()
        {
            if (fp != ep)
            {
               
                int item = queue[fp];
                fp++;
                return item;
               

            }
            else
                throw new Exception("Queue is empty");


        }

    }
}
