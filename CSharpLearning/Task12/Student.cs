using System;

namespace CSharpLearning.Task12
{
    struct Student : IComparable<Student>
    {
        private string surname;
        private string name;
        private string patronymic;
        private string group;
        private string exam1;
        private string exam2;
        private string exam3;

        public Student(string surname, string name, string patronymic, string group, string exam1, string exam2, string exam3)
        {
            this.surname = surname;
            this.name = name;
            this.patronymic = patronymic;
            this.group = group;
            this.exam1 = exam1;
            this.exam2 = exam2;
            this.exam3 = exam3;
        }

        public int CompareTo(Student other)
        {
            return this.group.CompareTo(other.group);
        }
    }
}
