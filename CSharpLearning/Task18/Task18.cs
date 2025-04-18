using System.IO;

namespace CSharpLearning.Task18
{
    internal class Task18
    {
        /*
        По входной последовательности целых чисел построить дерево бинарного поиска и:
            1. найти дня него сумму нечётных значений узлов дерева;
            2. найти глубину заданного узла;
            3. проверить, можно ли удалить не более n узлов в дереве так,
                чтобы дерево осталось деревом бинарного поиска и стало
                идеально сбалансированным (указать удаляемые узлы).
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
                    // 1. fileOut.WriteLine(intTree.SumOdd());
                    // 2. fileOut.WriteLine(intTree.GetNodeDepth(12));
                    fileOut.WriteLine(intTree.MakePerfectlyBalanced(2));
                }
            }
        }
    }
}
