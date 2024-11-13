using System.Collections.Generic;
using System.IO;

namespace CSharpLearning.Task12
{
    /*
     * ������ ������, ���������� ����������� ��������� ��� �������� ����������.
     * �� ������ ������ �������� ����� ��������� ������ ���������,
     * ������� ��������� ������: ���, ����� ������, ���������� ����� ���� ���������.
     * ������� � ����� ���� ���������� � ���������, ������� ������� ������, ������������ �� ������ ������.
     */
    internal class Task12
    {
        private const string Unsatisfactory = "�������������������";

        internal static void Execute()
        {
            using (StreamReader fileIn = new StreamReader("../../../Task12/input.txt"))
            {
                using (StreamWriter fileOut = new StreamWriter("../../../Task12/output.txt"))
                {
                    List<Student> passedStudents = new List<Student>();
                    string line;
                    while ((line = fileIn.ReadLine()) != null)
                    {
                        string[] data = line.Split();
                        if (data[4] != Unsatisfactory && data[5] != Unsatisfactory && data[6] != Unsatisfactory)
                        {
                            passedStudents.Add(new Student(data[0], data[1], data[2], data[3], data[4], data[5], data[6]));
                        }
                    }
                    passedStudents.Sort();
                    foreach (Student passedStudent in passedStudents)
                    {
                        fileOut.WriteLine(passedStudent);
                    }
                }
            }
        }
    }
}
