using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork_8
{
    class Student : IMan, IComparable, ICloneable
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Group { get; set; }
        public Student()
        {
            Name = string.Empty;
            Surname = string.Empty;
            Patronymic = string.Empty;
            Group = string.Empty;
        }

        public Student(string initName, string initSurname, string initPatronymic, string initPosition)
        {
            Name = initName;
            Surname = initSurname;
            Patronymic = initPatronymic;
            Group = initPosition;
        }
        public string GetInformation()
        {
            string info = $" Фамилия: {Surname}\n Имя: {Name}\n Отчество: {Patronymic}\n Должность: {Group}";
            return info;
        }
        public Student WatherWorkerClone()
        {
            return (Student)MemberwiseClone();
        }
        public object Clone()
        {
            Student student = new Student(Name, Surname, Patronymic, Group);
            return student;
        }
        public int CompareTo(object obj)
        {
            IMan student = (IMan)obj;
            if (Surname.Length > student.Surname.Length) return 1;
            if (Surname.Length < student.Surname.Length) return -1;
            return 0;
        }
    }






}

