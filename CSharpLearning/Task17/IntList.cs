using System.Text;

namespace CSharpLearning.Task17
{
    internal class IntList
    {
        private const string EmptyIntList = "Список пуст.";
        private const string KeyIntList = "В списке отсутствует ключевое значение.";

        private IntNode head;
        private IntNode tail;

        public IntList()
        {
            head = null;
            tail = null;
        }

        public void AddBegin(int number)
        {
            IntNode r = new IntNode(number);
            if (head == null)
            {
                head = r;
                tail = r;
            }
            else
            {
                r.Next = head;
                head = r;
            }
        }

        public void AddEnd(int number)
        {
            IntNode r = new IntNode(number);
            if (head == null)
            {
                head = r;
                tail = r;
            }
            else
            {
                tail.Next = r;
                tail = r;
            }
        }

        public int TakeBegin()
        {
            if (head == null) throw new EmptyIntListException(EmptyIntList);
            IntNode r = head;
            head = head.Next;
            if (head == null) tail = null;
            return r.Number;
        }

        public int TakeEnd()
        {
            if (head == null) throw new EmptyIntListException(EmptyIntList);
            IntNode r = head;
            if (head.Next == null)
            {
                head = null;
                tail = null;
            }
            else
            {
                while (r.Next != tail) r = r.Next;
                IntNode temp = tail;
                tail = r;
                r = temp;
                tail.Next = null;
            }
            return r.Number;
        }

        public bool IsEmpty { get { return head == null; } }

        public IntNode Find(int keyNumber)
        {
            if (head == null) throw new EmptyIntListException(EmptyIntList);
            IntNode r = head;
            while (r != null)
            {
                if (r.Number == keyNumber) break;
                r = r.Next;
            }
            if (r == null) throw new KeyIntListException(KeyIntList);
            return r;
        }

        public void Insert(int keyNumber, int number)
        {
            if (head == null) throw new EmptyIntListException(EmptyIntList);
            IntNode r = Find(keyNumber);
            if (r != null)
            {
                IntNode p = new IntNode(number);
                p.Next = r.Next;
                r.Next = p;
            }
            else throw new KeyIntListException(KeyIntList);
        }

        public void Delete(int keyNumber)
        {
            if (head == null) throw new EmptyIntListException(EmptyIntList);
            if (head.Number == keyNumber)
            {
                head = head.Next;
                if (head == null) tail = null;
            }
            else
            {
                IntNode r = head;
                while (r.Next != null)
                {
                    if (r.Next.Number == keyNumber)
                    {
                        r.Next = r.Next.Next;
                        return;
                    }
                    else r = r.Next;
                }
                throw new KeyIntListException(KeyIntList);
            }
        }

        public void DeleteAllPrevious(int keyNumber)
        {
            if (head == null) throw new EmptyIntListException(EmptyIntList);
            while (head.Next.Number == keyNumber) head = head.Next;
            IntNode r = head;
            while (r.Next.Next != null)
            {
                if (r.Next.Next.Number == keyNumber)
                {
                    r.Next = r.Next.Next;
                }
                else r = r.Next;
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            IntNode r = head;
            while (r != null)
            {
                builder.Append(r.Number);
                builder.Append(' ');
                r = r.Next;
            }
            return builder.ToString();
        }
    }
}
