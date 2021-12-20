using System.Windows;
using System;

namespace PracticalWork_8
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            first.IsChecked = true;
        }
        StudentFather firstStudentFather = new StudentFather();
        StudentFather secondStudentFather = new StudentFather();
        Student firstStudent = new Student();
        Student secondStudent = new Student();

        private void EnterInformation_Click(object sender, RoutedEventArgs e)
        {
            if (father.IsChecked == true)
            {
                if (first.IsChecked == true)
                {
                    firstStudentFather = new StudentFather(name.Text, surname.Text, patronymic.Text, true, group.Text);
                    firstStudentOut.Text = firstStudentFather.GetInformation();
                    firstStudent = null;
                }
                else
                {
                    secondStudentFather = new StudentFather(name.Text, surname.Text, patronymic.Text, true, group.Text);
                    secondStudentOut.Text = secondStudentFather.GetInformation();
                    secondStudent = null;
                }
            }
            else
            {
                if (first.IsChecked == true)
                {
                    firstStudent = new Student(name.Text, surname.Text, patronymic.Text, group.Text);
                    firstStudentOut.Text = firstStudent.GetInformation();
                    firstStudentFather = null;
                }
                else
                {
                    secondStudent = new Student(name.Text, surname.Text, patronymic.Text, group.Text);
                    secondStudentOut.Text = secondStudent.GetInformation();
                    secondStudentFather = null;
                }

            }
        }
        private void Comparation_Click(object sender, RoutedEventArgs e)
        {
            if(firstStudent != null && secondStudent != null)
            {
                ComparationOut(firstStudent.CompareTo(secondStudent));
                return;
            }
            if (firstStudent != null && secondStudentFather != null)
            {
                ComparationOut(firstStudent.CompareTo(secondStudentFather));
                return;
            }
            if (firstStudentFather != null && secondStudent != null)
            {
                ComparationOut(firstStudentFather.CompareTo(secondStudent));
                return;
            }
            if (firstStudentFather != null && secondStudentFather != null)
            {
                ComparationOut(firstStudentFather.CompareTo(secondStudentFather));
                return;
            }

        }

        private void ComparationOut( int Vouid)
        {
            if (Vouid == 1) { MessageBox.Show("Количество букв в фамилии первого студента больше, чем у второго", "Результат сравнения", MessageBoxButton.OK, MessageBoxImage.Information); }
            if (Vouid == -1) { MessageBox.Show("Количество букв в фамилии второго студента больше, чем у первого", "Результат сравнения", MessageBoxButton.OK, MessageBoxImage.Information); }
            if (Vouid == 0) { MessageBox.Show("Количество букв в фамилиях студентов одинаковое", "Результат сравнения", MessageBoxButton.OK, MessageBoxImage.Information); }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            name.Clear();
            surname.Clear();
            patronymic.Clear();
            group.Clear();
            father.IsChecked = false;
            firstStudentOut.Clear();
            secondStudentOut.Clear();
        }

        private void CloneStudent_Click(object sender, RoutedEventArgs e)
        {
            if (first.IsChecked == true)
            {
                if (firstStudent != null)
                {
                    secondStudent = (Student)firstStudent.Clone();
                    secondStudentOut.Text = secondStudent.GetInformation();
                    secondStudentFather = null;
                }
                if (firstStudentFather != null)
                {
                    secondStudentFather = (StudentFather)firstStudentFather.Clone();
                    secondStudentOut.Text = secondStudentFather.GetInformation();
                    secondStudent = null;
                }
            }
            else
            {
                if (secondStudent != null)
                {
                    firstStudent= (Student)secondStudent.Clone();
                    firstStudentOut.Text = firstStudent.GetInformation();
                    firstStudentFather = null;
                }
                if (secondStudentFather != null)
                {
                    firstStudentFather = (StudentFather)secondStudentFather.Clone();
                    firstStudentOut.Text = firstStudentFather.GetInformation();
                    firstStudent = null;
                }
            }
            if (firstStudent == null && secondStudent == null && firstStudentFather == null && secondStudentFather == null)
            {
                MessageBox.Show("Информация ни об одном из работников не заполнена", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Самсаков Андрей Александрович ИСП-31\nПрактическая работа №8\n Создать интерфейс - человек. Создать классы – студент и студент-отец семейства. Классы должны включать конструкторы, функцию для формирования строки информации о студенте. Сравнение производить по фамилии. ", "Информация о программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void ChoiceFirst_Click(object sender, RoutedEventArgs e)
        {
            name.Clear();
            surname.Clear();
            patronymic.Clear();
            group.Clear();
            father.IsChecked = false;
        }
        private void ChoiceSecond_Click(object sender, RoutedEventArgs e)
        {
            name.Clear();
            surname.Clear();
            patronymic.Clear();
            group.Clear();
            father.IsChecked = false;
        }
    }
}

