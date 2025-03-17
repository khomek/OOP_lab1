using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_3
{
    public class Tree
    {
        public int val {  get; set; }
        public List<Tree> children;

        public Tree(int val)
        {
            this.val = val;
            children = new List<Tree>();
        }

        public void AddKid(Tree item)
        {
            children.Add(item);
        }
        public void Print()
        {
            Console.WriteLine(val);
            if (children.Count == 0)
            {
                return;
            }
                foreach ( Tree item in children)
                {
                    item.Print();
                }
        }
    }
}
