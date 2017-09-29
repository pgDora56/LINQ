using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsDataBase
{
    class Program
    {
        static void Main(string[] args)
        {
            // データをリストに格納。一旦は初期値で入れてるけど、何かしらで追加等できるようにする。
            // データは全て架空で意味は無いです。ほんとです。
            List<Student> Students = new List<Student>()
            {
                new Student(140101,"Shizuka Mogami","Literature"),
                new Student(120201,"Anastasia","Literature"),
                new Student(130301,"Mizuki Makabe","Economics"),
                new Student(150301,"Yayoi Takatsuki","Economics"),
                new Student(100301,"Chihaya Kisaragi","Law"),
                new Student(021301,"Ritsuko Akiduki","Science"),
                new Student(100401,"Haruka Amami","Education"),
                new Student(163401,"Loco","Design"),
                new Student(121301,"Eri Mizutani","Science"),
                new Student(100401,"Ami Futami","Education"),
                new Student(100402,"Mami Futami","Education"),
            };

            foreach(Student s in Students)
            {
                s.Write();
            }

            Console.WriteLine("\n");


            // ID順に並び替え
            var IDSort = Students.OrderBy(student => student.StudentNo);

            foreach(Student s in IDSort)
            {
                s.Write();
            }
        }
    }

    class Student
    {
        private int No; // 学生番号
        private string Nam; // 名前
        private string Facu; // 学部

        public int StudentNo
        {
            get
            {
                return No;
            }
            set
            {
                No = value;
            }
        }

        public string Name
        {
            get
            {
                return Nam;
            }
            set
            {
                Nam = value;
            }
        }
        
        public string Faculty
        {
            get
            {
                return Facu;
            }
            set
            {
                Facu = value;
            }
        }

        public Student(int no, string na, string fa)
        {
            No = no;
            Nam = na;
            Facu = fa;
        }

        public void Write()
        {
            Console.WriteLine($"ID:{No} {Name} ( {Facu} Faculty )");
        }
    }
}
