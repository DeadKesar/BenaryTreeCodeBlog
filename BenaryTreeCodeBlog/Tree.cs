using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenaryTreeCodeBlog
{
    class Tree <T>
        where T: IComparable
    {
        public Node<T> Root { get; private set; }
        public int Count { get; private set; }


        public void Add (T data)
        {
            var node = new Node<T>(data);
            if (Root == null)
            {
                Root = node;
                Count = 1;
                return;
            }
            var current = Root;

            switch (current.Data.CompareTo(node.Data))
                case (-1):
                {
                    
                }

        }

    }
}
