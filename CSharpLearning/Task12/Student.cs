using System;

namespace CSharpLearning.Task12
{
    internal struct Student : IComparable<Student>
    {
        public readonly string surname;
        private string name;
        private string patronymic;
        private int group;
        private string exam1;
        private string exam2;
        private string exam3;

        public Student(string surname, string name, string patronymic, int group, string exam1, string exam2, string exam3)
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
            if (this.group > other.group) return 1;
            if (this.group == other.group) return 0;
            return -1;
        }

        public override string ToString()
        {
            return $"{surname} {name} {patronymic} {group} {exam1} {exam2} {exam3}";
        }
    }
}
