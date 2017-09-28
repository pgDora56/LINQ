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
            
        }
    }

    class Students
    {
        private int No; // 学生番号
        private string Nam; // 名前
        private string Dept; // 学科
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

        public string Department
        {
            get
            {
                return Dept;
            }
            set
            {
                Dept = value;
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

        public Students(int no, string na, string de, string fa)
        {
            No = no;
            Nam = na;
            Dept = de;
            Facu = fa;
        }
    }
}
