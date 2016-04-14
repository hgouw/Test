using System.Collections.Generic;

namespace TDD
{
    public class Stak
    {
        public List<object> Stack { get; set; } = null;
        public bool IsEmpty
        {
            get
            {
                return Stack.Count == 0;
            }
        }

        public Stak()
        {
            Stack = new List<object>();
        }

        public object Pop()
        {
            if (!IsEmpty)
            {
                var item = Stack[0];
                Stack.RemoveAt(0);
                return item;
            }
            else
            {
                return null;
            }
        }

        public void Push(object item)
        {
            Stack.Add(item);
        }
    }
}