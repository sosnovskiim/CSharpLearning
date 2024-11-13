using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CSharpLearning.Task14
{
    /*
     * На основе данных входного файла составить список студентов группы,
     * включив следующие данные: ФИО, год рождения, домашний адрес, какую школу окончил.
     * Вывести в новый файл информацию о студентах, сгруппировав данные по номеру школы.
     */
    internal class Task14
    {
        internal static void Execute()
        {
            List<Student> students = new List<Student>();
            using (StreamReader fileIn = new StreamReader("../../../Task14/input.txt"))
            {
                string line;
                while ((line = fileIn.ReadLine()) != null)
                {
                    string[] data = line.Split();
                    students.Add(new Student(data[0], data[1], data[2], int.Parse(data[3]), data[4], int.Parse(data[5])));
                }
            }
            using (StreamWriter fileOut = new StreamWriter("../../../Task14/output_queries.txt"))
            {
                var query = from student in students group student by student.GraduatedSchool;
                foreach (var items in query)
                {
                    foreach (var student in items)
                    {
                        fileOut.WriteLine(student);
                    }
                }
            }
            using (StreamWriter fileOut = new StreamWriter("../../../Task14/output_methods.txt"))
            {
                var query = students.GroupBy(student => student.GraduatedSchool);
                foreach (var items in query)
                {
                    foreach (var student in items)
                    {
                        fileOut.WriteLine(student);
                    }
                }
            }
        }
    }
}
