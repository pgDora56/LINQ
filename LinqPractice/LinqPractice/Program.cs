using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 2, 3, 4, 5, 6, 7, 8, 9, 10, 13, 94, 5 };
            ArrayWrite(arr);

            var squareArr = arr.Select(value => value * value);
            // { 4, 9, 16, 25, 36, 49, 64, 81, 100, 169, 8836, 25 }
            // Selectは写像。メンバに一つずつ関数を適用し、その戻り値で新しい配列（コレクション）を作る。
            // このとき、各値を2乗した配列を返す。
            ArrayWrite(squareArr);

            var oddArr = arr.Where(value => value % 2 == 1);
            // { 3, 5, 7, 9, 13, 5 }
            // Whereはフィルター。メンバの中から条件に合う要素を取り出す。
            // このとき、奇数の値のみを抽出した配列を返す。
            ArrayWrite(oddArr);

            Console.WriteLine(arr.Aggregate((total, value) => total + value)); // 166
            Console.WriteLine(arr.Aggregate(50, (total, value) => total + value)); // 216
            // Aggregateは畳み込み、各要素について同じ処理を繰り返す。
            // 例で言うと、2つ目の引数のvalueに各要素が一度ずつ入り、total + valueを1つめの引数のtotalに代入する。つまりこれは合計値を求めている。
            // 2例目のように、最初にデータを与えるとそれをtotalの初期値として行う。

            Console.WriteLine("\n################################\n");

            var datas = new Data[]
            {
                new Data(2,"Starter","World"),
                new Data(3,"CSharp","C#"),
                new Data(6,"Manage","GitHub"),
                new Data(5,"Manage","Git"),
                new Data(1,"Starter","Hello"),
                new Data(4,"CSharp","LINQ"),
            };
            DataWrite(datas);

            var datasGenreOrder = datas.OrderBy(data => data.Genre);
            // OrderByはソート。昇順に整列する。比較に使う関数を引数のように与える。
            // Dataクラス配列datasをGenreの昇順に整列(同Genre内は元の順になる)
            DataWrite(datasGenreOrder);

            var datasGenreNoOrder = datas.OrderBy(data => data.Genre).ThenBy(data => data.No);
            // OrderByで指定した値がおなじになる場合はThenByで順列をつけることが可能。
            // 上記と同じ作業をしたあと、同Genre内をNoの昇順に整列
            DataWrite(datasGenreNoOrder);

            var datasDescendingOrder = datas.OrderByDescending(data => data.Genre);
            // OrderByの降順版。ThenByもThenByDescendingで降順が可能。
            DataWrite(datasDescendingOrder);



        }

        public static void ArrayWrite(IEnumerable<int> arr)
        {
            foreach (int i in arr) Console.WriteLine(i);
            Console.WriteLine("\n################################\n");
        }

        public static void DataWrite(IEnumerable<Data> datas)
        {
            foreach (Data d in datas) d.Write();
            Console.WriteLine("\n################################\n");
        }
    }

    class Data
    {
        public int No { get; set; }
        public string Genre { get; set; }
        public string Text { get; set; }        
        public Data(int n, string g, string t)
        {
            No = n;
            Genre = g;
            Text = t;
        }
        public void Write()
        {
            Console.WriteLine($"[{No}]{Genre}:{Text}");
        }
    }
}
