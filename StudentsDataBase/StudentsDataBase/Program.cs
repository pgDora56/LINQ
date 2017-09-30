using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsDataBase
{
    class Program
    {
        static List<Student> Students;
        static void Main(string[] args)
        {
            // データをリストに格納。一旦は初期値で入れてるけど、何かしらで追加等できるようにする。
            // データは全て架空で意味は無いです。ほんとです。
            Students = new List<Student>()
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

            int command = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("次のうちから行いたいことを数字で選んでください");
                Console.Write("1:新規登録　2:閲覧　9:終了 > ");
                if(int.TryParse(Console.ReadLine(),out int c))
                {
                    switch(c)
                    {
                        case 1:
                            Write();
                            break;
                        case 2:
                            Read();
                            break;
                        case 9:
                            break;
                    }
                    if (c == 9) break;
                }
            }
            /*

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

            */
        }

        static void Write()
        {
            int no;
            string nam = "";
            string Facu = "";
            while(true)
            {
                Console.Clear();
                Console.Write("学生番号を入力してください > ");
                if(int.TryParse(Console.ReadLine(),out no))
                {
                    bool IsIdOk = true;
                    foreach(Student s in Students)
                    {
                        if(no == s.StudentNo)
                        {
                            IsIdOk = false;
                            break;
                        }
                    }
                    if(IsIdOk) break;
                    else
                    {
                        Console.WriteLine("すでに存在するIDです\n");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("無効な数値です\n");
                }
            }

            while (true)
            {
                Console.Write("名前を入力してください > ");
                nam = Console.ReadLine();
                if(nam !="")
                {
                    break;
                }
            }

            while (true)
            {
                Console.Write("学部を入力してください > ");
                Facu = Console.ReadLine();
                if (Facu != "")
                {
                    break;
                }
            }

            Students.Add(new Student(no, nam, Facu));
        }

        static void Read()
        {
            var displayStudents = Students.OrderBy(stu => stu.StudentNo);
            int n = 1;
            while(true)
            {
                Console.Clear();
                foreach(Student s in displayStudents)
                {
                    s.Write();
                }
                while (true)
                {
                    Console.WriteLine("\nソート順を変更する／終了する");
                    Console.Write("1:番号順 2:名前順 3:学部順 9:終了 > ");
                    if(int.TryParse(Console.ReadLine(),out n))
                    {
                        if (n > 0 && n < 5 || n == 9) 
                        {
                            break;
                        }
                    }
                }
                switch(n)
                {
                    case 1:
                        displayStudents = displayStudents.OrderBy(st => st.StudentNo);
                        break;
                    case 2:
                        displayStudents = displayStudents.OrderBy(st => st.Name);
                        break;
                    case 3:
                        displayStudents = displayStudents.OrderBy(st => st.Faculty);
                        break;
                    case 9:
                        return;
                }
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
