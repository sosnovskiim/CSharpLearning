using System.Collections.Generic;
using System.IO;

namespace CSharpLearning.Task12
{
    /*
     * Решить задачу, реализовав собственную структуру для хранения информации.
     * На основе данных входного файла составить список студентов,
     * включив следующие данные: ФИО, номер группы, результаты сдачи трёх экзаменов.
     * Вывести в новый файл информацию о студентах, успешно сдавших сессию, отсортировав по номеру группы.
     */
    internal class Task12
    {
        private const string Unsatisfactory = "неудовлетворительно";

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
                            passedStudents.Add(new Student(data[0], data[1], data[2], int.Parse(data[3]), data[4], data[5], data[6]));
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
