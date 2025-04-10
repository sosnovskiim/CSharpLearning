using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLearning.Task18
{
    internal class IntTree
    {
        private class IntNode
        {
            public int number;
            public int count;
            public IntNode left;
            public IntNode right;

            public IntNode(int number)
            {
                this.number = number;
                count = 1;
                left = null;
                right = null;
            }

            public int Count { get { return (this != null) ? this.count : 0; } }

            public int BalanceFactor
            {
                get
                {
                    int count_right = (right != null) ? right.count : 0;
                    int count_left = (left != null) ? left.count : 0;
                    return count_right - count_left;
                }
            }

            public void UpdateCount()
            {
                int count_right = (right != null) ? right.count : 0;
                int count_left = (left != null) ? left.count : 0;
                count = count_right + count_left + 1;
            }

            public static void Add(ref IntNode r, int number)
            {
                if (r == null) r = new IntNode(number);
                else
                {
                    if (r.number > number) Add(ref r.left, number);
                    else Add(ref r.right, number);
                }
                r.UpdateCount();
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

            public static void DirectTraverseWithCount(IntNode r)
            {
                if (r != null)
                {
                    Console.WriteLine($"{r.number} {r.count}");
                    DirectTraverseWithCount(r.left);
                    DirectTraverseWithCount(r.right);
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
                else
                {
                    if (t.number > keyNumber) Delete(ref t.left, keyNumber);
                    else if (t.number < keyNumber) Delete(ref t.right, keyNumber);
                    else if (t.left == null) t = t.right;
                    else if (t.right == null) t = t.left;
                    else Del(t, ref t.left);
                    t.UpdateCount();
                }
            }

            public static void SumOdd(IntNode r, ref int sum)
            {
                if (r.number % 2 != 0) sum += r.number;
                if (r.left != null) SumOdd(r.left, ref sum);
                if (r.right != null) SumOdd(r.right, ref sum);
            }

            public static void GetDepth(IntNode r, int keyNumber, ref int depth, ref bool isExists)
            {
                if (r != null)
                {
                    if (r.number != keyNumber)
                    {
                        depth++;
                        if (r.number > keyNumber) GetDepth(r.left, keyNumber, ref depth, ref isExists);
                        else GetDepth(r.right, keyNumber, ref depth, ref isExists);
                    }
                    else isExists = true;
                }
            }

            public static void MakePerfectlyBalanced(IntNode r, ref IntNode result)
            {
                if (r != null)
                {
                    if (r.BalanceFactor > 1) DeleteUnbalancedNode(ref r.right, ref result);
                    else if (r.BalanceFactor < -1) DeleteUnbalancedNode(ref r.left, ref result);
                    else
                    {
                        MakePerfectlyBalanced(r.left, ref result);
                        MakePerfectlyBalanced(r.right, ref result);
                    }
                    r.UpdateCount();
                }
            }

            public static void DeleteUnbalancedNode(ref IntNode r, ref IntNode result)
            {
                if (r != null)
                {
                    if (r.BalanceFactor > 0)
                    {
                        DeleteUnbalancedNode(ref r.right, ref result);
                        r.UpdateCount();
                    }
                    else if (r.left != null)
                    {
                        DeleteUnbalancedNode(ref r.left, ref result);
                        r.UpdateCount();
                    }
                    else
                    {
                        result = new IntNode(r.number);
                        r = null;
                    }
                }
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

        public void DirectTraverseWithCount() { IntNode.DirectTraverseWithCount(root); }

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

        public int GetNodeDepth(int keyNumber)
        {
            int depth = 0;
            bool isExists = false;
            IntNode.GetDepth(root, keyNumber, ref depth, ref isExists);
            if (isExists) return depth;
            return -1;
        }

        public string MakePerfectlyBalanced(int n)
        {
            List<IntNode> nodesToDelete = new List<IntNode>();
            for (int i = 0; i < n + 1; i++)
            {
                IntNode result = null;
                IntNode.MakePerfectlyBalanced(root, ref result);
                if (result != null) nodesToDelete.Add(result);
                else break;
            }
            if (nodesToDelete.Count > n)
                return $"Нельзя удалить не более {n} узлов так, " +
                    "чтобы дерево стало идеально сбалансированным";
            if (nodesToDelete.Count == 0)
                return "Дерево уже идеально сбалансированно";
            StringBuilder builder = new StringBuilder();
            foreach (IntNode node in nodesToDelete)
            {
                builder.Append(node.number);
                builder.Append(' ');
            }
            return "Чтобы дерево стало идеально сбалансированным, " +
                $"можно удалить следующие узлы: {builder}";
        }
    }
}
