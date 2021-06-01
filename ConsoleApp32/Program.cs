using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

/// <summary>
/// 1ИСП11-17 Маханов А.А.
/// </summary>

namespace ConsoleApp32
{
    class Program
    {
        static public void prog1()
        {
            string res, txt;
            int year = 2021, age, born;
            res = Interaction.InputBox("В каком году Вы родились?", "Год рождения");
            born = Int32.Parse(res);
            age = year - born;
            txt = "Тогда вам " + age + " лет";
            MessageBox.Show(txt, "Возраст");
        }
        static public void prog2()
        {
            Console.WriteLine("Напишите что либо то бы использовать окна");
            string a = Console.ReadLine();
            bool flag = a != "";
            string FName, LName;
            if (flag)
            {
                FName = Interaction.InputBox("Ваше имя?", "Имя");
                LName = Interaction.InputBox("Ваша Фамилия?", "Фамилия");
                MessageBox.Show(FName + " " + LName, "Ваше имя");
            }
            else
            {
                Console.WriteLine("Ваше имя?");
                FName = Console.ReadLine();
                Console.WriteLine("Ваша Фамилия?");
                LName = Console.ReadLine();
                Console.WriteLine(FName, LName, "Ваше имя");
            }
        }
        static public void prog3()
        {
            Console.WriteLine("Напишите что либо то бы использовать окна");
            string a = Console.ReadLine();
            bool flag = a != "";
            string FName, Age;
            if (flag)
            {
                FName = Interaction.InputBox("Ваше имя?", "Имя");
                Age = Interaction.InputBox("Ваш возраст?", "Возраст");
                MessageBox.Show("Имя: " + FName + ", возраст: " + Age, "Ваше имя и возратст");
            }
            else
            {
                Console.WriteLine("Ваше имя?");
                FName = Console.ReadLine();
                Console.WriteLine("Ваш возраст?");
                Age = Console.ReadLine();
                Console.WriteLine(FName, Age, "Ваше имя и возраст");
            }
        }
        static public void prog4()
        {
            Console.WriteLine("Напишите что либо то бы использовать окна");
            string a = Console.ReadLine();
            bool flag = a != "";
            string Weekday, Month, Day;
            if (flag)
            {
                Weekday = Interaction.InputBox("День недели", "День недели");
                Month = Interaction.InputBox("Месяц", "Месяц");
                Day = Interaction.InputBox("День", "День");
                MessageBox.Show("День: " + Weekday + " " + Day + " " + Month, "День");
            }
            else
            {
                Console.WriteLine("День недели");
                Weekday = Console.ReadLine();
                Console.WriteLine("Месяц");
                Month = Console.ReadLine();
                Console.WriteLine("День");
                Day = Console.ReadLine();
                Console.WriteLine("День: " + Weekday + " " + Day + " " + Month);
            }
        }
        static public void prog5()
        {
            Console.WriteLine("Напишите что либо то бы использовать окна");
            string a = Console.ReadLine();
            bool flag = a != "";
            string Month, Days;
            if (flag)
            {
                Month = Interaction.InputBox("Месяц", "Месяц");
                Days = Interaction.InputBox("Дней", "Дней");
                MessageBox.Show(Days + " дней в месяце " + Month, "Дней");
            }
            else
            {
                Console.WriteLine("Месяц");
                Month = Console.ReadLine();
                Console.WriteLine("Дней");
                Days = Console.ReadLine();
                Console.WriteLine(Days + " дней в месяце " + Month);
            }
        }
        static public void prog6()
        {
            string res, txt;
            int year = 2021, age, born;
            Console.WriteLine("В каком году Вы родились?");
            res = Console.ReadLine();
            born = Int32.Parse(res);
            age = year - born;
            txt = "Тогда вам " + age + " лет";
            Console.WriteLine(txt);
        }
        static public void prog7()
        {
            Console.WriteLine("Напишите что либо то бы использовать окна");
            string a = Console.ReadLine();
            bool flag = a != "";
            if (flag)
            {
                string res, txt, name;
                int year = 2021, age, born;
                res = Interaction.InputBox("В каком году Вы родились?", "Год рождения");
                name = Interaction.InputBox("Ваше имя?", "Имя");
                born = Int32.Parse(res);
                age = year - born;
                txt = "Тогда вам " + age + " лет и вас зовут " + name;
                MessageBox.Show(txt, "Возраст");
            }
            else
            {
                string res, txt, name;
                int year = 2021, age, born;
                Console.WriteLine("В каком году Вы родились?");
                res = Console.ReadLine();
                Console.WriteLine("Ваше имя?");
                name = Console.ReadLine();
                born = Int32.Parse(res);
                age = year - born;
                txt = "Тогда вам " + age + " лет и вас зовут " + name;
                Console.WriteLine(txt);
            }
        }
        static public void prog8()
        {
            Console.WriteLine("Напишите что либо то бы использовать окна");
            string a = Console.ReadLine();
            bool flag = a != "";
            if (flag)
            {
                string res, txt;
                int year = 2021, age, born;
                res = Interaction.InputBox("В каком году Вы родились?", "Год рождения");
                age = Int32.Parse(res);
                born = year - age;
                txt = "Тогда вы родились в " + born + " году";
                MessageBox.Show(txt, "Возраст");
            }
            else
            {
                string res, txt;
                int year = 2021, age, born;
                Console.WriteLine("В каком году Вы родились?");
                res = Console.ReadLine();
                age = Int32.Parse(res);
                born = year - age;
                txt = "Тогда вы родились в " + born + " году";
                Console.WriteLine(txt);
            }
        }
        static public void prog9()
        {
            Console.WriteLine("Напишите что либо то бы использовать окна");
            string a = Console.ReadLine();
            bool flag = a != "";
            string x, y, res;
            if (flag)
            {
                x = Interaction.InputBox("Число 1", "Х");
                y = Interaction.InputBox("Число 2", "У");
                res = (Int32.Parse(x) + Int32.Parse(y)).ToString();
                MessageBox.Show(res, "Результат");
            }
            else
            {
                Console.WriteLine("Число 1");
                x = Console.ReadLine();
                Console.WriteLine("Число 2");
                y = Console.ReadLine();
                res = (Int32.Parse(x) + Int32.Parse(y)).ToString();
                Console.WriteLine(res);
            }
        }
        static public void prog10()
        {
            Console.WriteLine("Напишите что либо то бы использовать окна");
            string a = Console.ReadLine();
            bool flag = a != "";
            string x, res;
            if (flag)
            {
                x = Interaction.InputBox("Число", "Х");
                res = (Int32.Parse(x) - 1).ToString() + ", " + x + ", " + (Int32.Parse(x) + 1).ToString();
                MessageBox.Show(res, "Результат");
            }
            else
            {
                Console.WriteLine("Число");
                x = Console.ReadLine();
                res = (Int32.Parse(x) - 1).ToString() + ", " + x + ", " + (Int32.Parse(x) + 1).ToString();
                Console.WriteLine(res);
            }
        }
        static public void prog11()
        {
            Console.WriteLine("Напишите что либо то бы использовать окна");
            string a = Console.ReadLine();
            bool flag = a != "";
            string x, y, res;
            if (flag)
            {
                x = Interaction.InputBox("Число 1", "Х");
                y = Interaction.InputBox("Число 2", "У");
                res = "суммма " + (Int32.Parse(x) + Int32.Parse(y)).ToString() + ", разность" + (Int32.Parse(x) - Int32.Parse(y)).ToString();
                MessageBox.Show(res, "Результат");
            }
            else
            {
                Console.WriteLine("Число 1");
                x = Console.ReadLine();
                Console.WriteLine("Число 2");
                y = Console.ReadLine();
                res = "суммма " + (Int32.Parse(x) + Int32.Parse(y)).ToString() + ", разность" + (Int32.Parse(x) - Int32.Parse(y)).ToString();
                Console.WriteLine(res);
            }
        }
        static void Main(string[] args)
        {
            string num = Interaction.InputBox("Какую программу открыть?", "Программа");
            switch (num)
            {
                case "1":
                    prog1();
                    break;
                case "2":
                    prog2();
                    break;
                case "3":
                    prog3();
                    break;
                case "4":
                    prog4();
                    break;
                case "5":
                    prog5();
                    break;
                case "6":
                    prog6();
                    break;
                case "7":
                    prog7();
                    break;
                case "8":
                    prog8();
                    break;
                case "9":
                    prog9();
                    break;
                case "10":
                    prog10();
                    break;
                case "11":
                    prog11();
                    break;
                default:
                    MessageBox.Show("Неверный номер");
                    break;
            }
            Console.ReadLine();
        }
    }
}
