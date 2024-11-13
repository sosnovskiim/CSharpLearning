using System;

namespace CSharpLearning.Task14
{
    internal readonly struct Student : IComparable<Student>
    {
        public string Surname { get; }
        public string Name { get; }
        public string Patronymic { get; }
        public int BirthYear { get; }
        public string HomeAddress { get; }
        public int GraduatedSchool { get; }

        public Student(string surname, string name, string patronymic, int birthYear, string homeAddress, int graduatedSchool)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            BirthYear = birthYear;
            HomeAddress = homeAddress;
            GraduatedSchool = graduatedSchool;
        }

        public int CompareTo(Student other)
        {
            return GraduatedSchool.CompareTo(other.GraduatedSchool);
        }

        public override string ToString()
        {
            return $"{Surname} {Name} {Patronymic} {BirthYear} {HomeAddress} {GraduatedSchool}";
        }
    }
}
