using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using System.Collections;

namespace Deligat_glav
{

    internal class Program
    {
        delegate List<Student> Operation(List<Student> _list_);

        static void Main(string[] args)
        {
            List<Student> spisok = new List<Student>() { };
            //Student[] spisok = new Student[] {};


            XmlSerializer serilzer = new XmlSerializer(typeof(List<Student>));

            using (StreamReader sr = new StreamReader("C:/1/student.xml", System.Text.Encoding.Default))
            {
                List<Student> newPerson = (List<Student>)serilzer.Deserialize(sr);
                Console.WriteLine("Объекты десериализован");
                /*foreach (Student a in newPerson)
                {
                    a.Dis();
                }*/


                Operation Vivid;
                Vivid = Vivod;
                Operation Dobiv;
                Dobiv = Dobav;
                Operation Periv;
                Periv = Perev;





                bool t = true;
                while (t)
                {
                    Console.WriteLine();
                    Console.WriteLine("Введите ключ операции (1 - вывести группу, 2 - добавить студента, 3 - перевести студента, выход - любая кнопка):::");
                    string n = Console.ReadLine();

                    switch (n)
                    {
                        case "1":
                            Vivod(newPerson);
                            break;

                        case "2":

                            spisok = Dobav(newPerson);
                            break;
                        case "3":
                            spisok = Perev(newPerson);
                            break;

                        default:
                            Console.WriteLine("Программа завершена...");
                            t = false;
                            break;
                    }


                }

            }
            //File.Delete(@"C:/1/student.xml");

            using (FileStream fs = new FileStream(@"C:/1/student.xml", FileMode.OpenOrCreate))
            {
                serilzer.Serialize(fs, spisok);
                Console.WriteLine("Объекты сериализован.");
            }
            Console.WriteLine("Спасибо за использование нашей программы...");
            Console.ReadKey();


        }

        public static List<Student> Vivod(List<Student> newPerson)
        {
            Console.WriteLine("Какую группу просматриваем?");
            string grp = Console.ReadLine();
            var selst = from s in newPerson where s.@Group == grp select s;
            foreach (Student a in selst)
            {
                a.Dis();
            }
            return newPerson;
        }
        public static List<Student> Dobav(List<Student> newPerson)
        {
            Student NEWER = new Student("Chel. O.P.", "BSBO-09-23", "TVP");
            newPerson.Add(NEWER);
            Console.WriteLine("Добавлен новый студент");
            //spisok = newPerson;
            return newPerson;

        }
        public static List<Student> Perev(List<Student> newPerson)
        {
            Console.WriteLine("Какого студента переводим?");
            string fio_per = Console.ReadLine();
            var tut = from s in newPerson where s.FIO == fio_per select s;
            foreach (Student a in tut)
            {
                Console.WriteLine("В какую группу переводим?");
                string new_group = Console.ReadLine();
                a.Group_new(new_group);
            }
            return newPerson;

        }

}

}
[Serializable]
public class Student
{
    public string FIO;
    public string Group;
    public string Profil;

    public Student()
    { }
    public Student(string FIO, string Group, string Profil)
    {
        this.FIO = FIO;
        this.Group = Group;
        this.Profil = Profil;
    }

    public void Dis()
    {
        Console.WriteLine($"FIO: {FIO} Group: {Group} Profil: {Profil}");
    }
    public void Group_new(string Group)
    {
        this.Group = Group;
    }


}
