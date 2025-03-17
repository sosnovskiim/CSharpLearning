using System;

namespace CSharpLearning.Task18
{
    internal class IntTree
    {
        private class IntNode
        {
            public int number;
            public IntNode left;
            public IntNode right;

            public IntNode(int number)
            {
                this.number = number;
                left = null;
                right = null;
            }

            public static void Add(ref IntNode r, int number)
            {
                if (r == null) r = new IntNode(number);
                else
                {
                    if (r.number > number) Add(ref r.left, number);
                    else Add(ref r.right, number);
                }
            }

            public static void DirectTraverse(IntNode r)
            {
                if (r != null)
                {
                    Console.Write($"{r.number} ");
                    DirectTraverse(r.left);
                    DirectTraverse(r.right);
                }
            }

            public static void SymmetricTraverse(IntNode r)
            {
                if (r != null)
                {
                    SymmetricTraverse(r.left);
                    Console.Write($"{r.number} ");
                    SymmetricTraverse(r.right);
                }
            }

            public static void ReverseTraverse(IntNode r)
            {
                if (r != null)
                {
                    ReverseTraverse(r.left);
                    ReverseTraverse(r.right);
                    Console.Write($"{r.number} ");
                }
            }

            public static void Find(IntNode r, int keyNumber, out IntNode item)
            {
                if (r == null) item = null;
                else if (r.number == keyNumber) item = r;
                else if (r.number > keyNumber) Find(r.left, keyNumber, out item);
                else Find(r.right, keyNumber, out item);
            }

            private static void Del(IntNode t, ref IntNode tr)
            {
                if (tr.right != null) Del(t, ref tr.right);
                else
                {
                    t.number = tr.number;
                    tr = tr.left;
                }
            }

            public static void Delete(ref IntNode t, int keyNumber)
            {
                if (t == null) throw new Exception("В дереве отсутствует ключевое значение.");
                else if (t.number > keyNumber) Delete(ref t.left, keyNumber);
                else if (t.number < keyNumber) Delete(ref t.right, keyNumber);
                else if (t.left == null) t = t.right;
                else if (t.right == null) t = t.left;
                else Del(t, ref t.left);
            }

            public static void SumOdd(IntNode r, ref int sum)
            {
                if (r.number % 2 != 0) sum += r.number;
                if (r.left != null) SumOdd(r.left, ref sum);
                if (r.right != null) SumOdd(r.right, ref sum);
            }
        }

        private IntNode root;

        public int Root
        {
            get { return root.number; }
            set { root.number = value; }
        }

        public IntTree() { root = null; }

        private IntTree(IntNode r) { root = r; }

        public void Add(int number) { IntNode.Add(ref root, number); }

        public void DirectTraverse() { IntNode.DirectTraverse(root); }

        public void SymmetricTraverse() { IntNode.SymmetricTraverse(root); }

        public void ReverseTraverse() { IntNode.ReverseTraverse(root); }

        public IntTree Find(int keyNumber)
        {
            IntNode r;
            IntNode.Find(root, keyNumber, out r);
            IntTree t = new IntTree(r);
            return t;
        }

        public void Delete(int keyNumber) { IntNode.Delete(ref root, keyNumber); }

        public int SumOdd()
        {
            int sum = 0;
            if (root != null) IntNode.SumOdd(root, ref sum);
            return sum;
        }
    }
}
