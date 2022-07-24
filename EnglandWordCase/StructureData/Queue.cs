using System;

namespace EnglandWordCase.StructureData
{
    public class Queue<T>
    {
        private T[] queue;
        private int index;


        public Queue()
        {
            CreateArray(0);
        }

        public Queue(int count)
        {
            CreateArray(count);
        }

        private void CreateArray(int count)
        {
            queue = new T[count];
            index = 0;
        }

        public void Enqueue(T item)
        {
            if (index == queue.Length)
            {
                queue = new T[queue.Length + 5];
            }
            queue[index] = item;
            index++;
        }

        public T Dequeue()
        {
            T answer = Peek();
            index--;
            var queue2 = new T[queue.Length - 1]; 
            for (var i = 1; i < queue.Length; i++)
            { 
                queue2[i-1]=queue[i];
            }
            queue = queue2;
            queue2 = null; 
            return answer;
        }


        public T Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue was is empty");
            return queue[0];
        }


        public bool IsEmpty()
        { 
            return queue.Length == 0;
        }

    }
}
