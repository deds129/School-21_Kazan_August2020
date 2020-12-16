using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace Dmitriy
{
    class Program
    {
        static void Main()
        {
            //Считывание студентов
            List<Student> stu = new List<Student>();
            String line;
            try
            {
                StreamReader sr = new StreamReader("C:\\Users\\1\\source\\repos\\ConsoleApp11\\ConsoleApp11\\Student.txt");
                line = sr.ReadLine();
                while (line != null)
                {
                    String[] spl = line.Split();
                    stu.Add(new Student(spl[0], spl[1], spl[2], spl[3], spl[4]));
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //Считывание предметов

            List<Subject> sub = new List<Subject>();
            try
            {
                StreamReader sr = new StreamReader("C:\\Users\\1\\source\\repos\\ConsoleApp11\\ConsoleApp11\\Subject.txt");
                line = sr.ReadLine();
                while (line != null)
                {
                    String[] spl = line.Split();
                    sub.Add(new Subject(spl[0], spl[1], spl[2], spl[3]));                   
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //Добавление факультативов студентам с оценками
            List<Academic_plan> aca = new List<Academic_plan>();
            Console.Write("Семестров всего было: ");
            int semester = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 0 если студент не посещал факультатив иначе его оценку");
            for (int i = 0; i < semester; i++)
            {
                Console.WriteLine("Семестр: " + (i + 1));
                foreach (Student aPart in stu)
                {
                    foreach (Subject aPart2 in sub)
                    {
                        Console.Write("Имя-" + aPart.name + " Предмет-" + aPart2.name + " Оценка ");
                        int appraisal = Convert.ToInt32(Console.ReadLine());
                        if (appraisal != 0)
                        {
                            aca.Add(new Academic_plan(aPart, aPart2, appraisal));
                        }
                    }
                }
            }

            //Вывод в файл
            StreamWriter sw = new StreamWriter("Отчет.txt");
            int endAppraisal = 0;//Доп переменная чтоб запомнить итоговую оценку
            foreach (Student student in stu)
            {
                //student.Print();
                sw.WriteLine(student.secondName + " " + student.name + " " + student.patronymic + " " + student.adress + " " + student.number);
                sw.WriteLine("Оценки: ");
                foreach (Subject subject in sub)
                {                    
                    foreach (Academic_plan aPart in aca)
                    {
                        if(student.secondName==aPart.student.secondName && student.name==aPart.student.name && student.patronymic==aPart.student.patronymic && subject.name == aPart.subject.name)
                        {
                            sw.WriteLine(subject.name + " " + aPart.appraisal+"\n");
                            endAppraisal = aPart.appraisal;
                        }
                    }
                    sw.WriteLine("Итоговая оценка по "+ subject.name+": "+ endAppraisal);
                }
            }
            //Console.ReadKey();
            sw.Close();
        }
    }
}
