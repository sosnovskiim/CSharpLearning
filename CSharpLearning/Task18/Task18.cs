using System.IO;

namespace CSharpLearning.Task18
{
    internal class Task18
    {
        /*
         * �� ������� ������������������ ����� ����� ��������� ������ ��������� ������
         * � ����� ��� ���� ����� �������� �������� ����� ������;
         */
        internal static void Execute()
        {
            using (StreamReader fileIn = new StreamReader("../../../Task18/input.txt"))
            {
                using (StreamWriter fileOut = new StreamWriter("../../../Task18/output.txt"))
                {
                    string[] data = fileIn.ReadToEnd().Split();
                    IntTree intTree = new IntTree();
                    foreach (string item in data) intTree.Add(int.Parse(item));
                    intTree.DirectTraverse();
                    fileOut.WriteLine(intTree.SumOdd());
                }
            }
        }
    }
}
