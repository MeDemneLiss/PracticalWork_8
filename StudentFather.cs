using System;
using System.Collections.Generic;
using System.Text;

namespace PracticalWork_8
{


    class StudentFather : IMan, IComparable, ICloneable
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public bool IsFather { get; set; }
        public string Group { get; set; }
        public StudentFather()
        {
            Name = string.Empty;
            Surname = string.Empty;
            Patronymic = string.Empty;
            IsFather = false;
            Group = string.Empty;

        }
        public StudentFather(string initName, string initSurname, string initPatronymic, bool isFather, string initPosition)
        {
            Name = initName;
            Surname = initSurname;
            Patronymic = initPatronymic;
            IsFather = isFather;
            Group = initPosition;
        }
        public string GetInformation()
        {
            string info = $" Фамилия: {Surname}\n Имя: {Name}\n Отчество: {Patronymic}\n Должность: {Group}\n Имеются дети";
            return info;
        }
        public StudentFather WatherWorkerClone()
        {
            return (StudentFather)MemberwiseClone();
        }
        public object Clone()
        {
            StudentFather father = new StudentFather(Name, Surname, Patronymic, IsFather, Group);
            return father;
        }
        public int CompareTo(object obj)
        {
            IMan father = (IMan)obj;
            if (Surname.Length > father.Surname.Length) return 1;
            if (Surname.Length < father.Surname.Length) return -1;
            return 0;
        }
    }
}

