namespace CSharpLearning.Task17
{
    internal class IntNode
    {
        private int number;
        private IntNode next;

        public IntNode(int number)
        {
            this.number = number;
            next = null;
        }

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public IntNode Next
        {
            get { return next; }
            set { next = value; }
        }
    }
}
