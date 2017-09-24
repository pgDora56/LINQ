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


            var squareArr = arr.Select(value => value * value);
            // { 4, 9, 16, 25, 36, 49, 64, 81, 100, 169, 8836, 25 }
            // Selectは写像。メンバに一つずつ関数を適用し、その戻り値で新しい配列（コレクション）を作る。
            // このとき、各値を2乗した配列を返す。

            var oddArr = arr.Where(value => value % 2 == 1);
            // { 3, 5, 7, 9, 13, 5 }
            // Whereはフィルター。メンバの中から条件に合う要素を取り出す。
            // このとき、奇数の値のみを抽出した配列を返す。

        }

    }
}
