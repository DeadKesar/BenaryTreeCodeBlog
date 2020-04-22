using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenaryTreeCodeBlog
{
    class Node<T> :IComparable 
            where T:IComparable
    {

        public T Data { get; set; }
        public Node<T> Left { get; private set; }
        public Node<T> Right { get; private set; }
        public Node(T data)
        {
            Data = data;
        }
        public Node(T data, Node<T> right, Node<T> left)
        {
            Data = data;
            Right = right;
            Left = left;
        }

        public int CompareTo(object obj)
        {
            
            if(obj is Node<T> item)
            {
                return Data.CompareTo(item);
            }
            else
            {
                throw new ArgumentException("Not correct type", nameof(obj));
            }

        }
    }
}
