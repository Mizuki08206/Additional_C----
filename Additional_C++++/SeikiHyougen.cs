using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Additional_C____
{
    public class SeikiHyougen
    {
        public static void a()
        {
            /*文字列をパターンで表現する
             * 使い道（型番、電話番号、メールアドレスのチェックなど）
             */
            //---位置を表すもの---
            //行頭：^
            //行末：$

            //---文字を表すもの---
            //文字を表すもの
            //なんでも一文字：.
            //タブ：\t
            //改行：\n
            //スペース、タブ、改行などの空白：\s

            //---量を表すもの---
            //*：直前の要素が０個以上連続する
            //+：直前の要素が１個以上連続する
            //?：直前の要素が０か１個ある
            //{n}：直前の要素がn回繰り返し
            //{n,m}：直前の要素がn回以上、m回以内の繰り返し
            //{n,}：直前の要素をn回以上の繰り返し

            //---数字を表すもの---
            //[0123456789]
            //[5-9]：範囲でも書ける
            //\d：[0-9]と同じ、だが環境によっては全角も含んでしまう

            //[ABCDEFGHIJKLMNOPQRSTUVWXYZ]：大文字アルファベット
            //[A-Z]：大文字アルファベット
            //[a-z]：小文字アルファベット
            //[a-zA-Z0-9]：大小アルファベットか数字
            //\w：大小アルファベットと数字と_（アンダースコア）

            //C#でパターンマッチングを使うには、
            //System.Text.RegularExpression.Regexクラスを使用する

            //---IsMatchメソッド---
            //staticで使うとき
            string phone = "080-1234-5678";
            //var result1 = Regex.IsMatch("調べる文字列", @"正規表現の文字列");//boolを返す
            var result1 = Regex.IsMatch(phone, @"0[7-9]0-\d{4}-\d{4}");//boolを返す
            Console.WriteLine(result1);
            Console.WriteLine("==========");
            /*出力：
             * True
             * ==========
             */

            //インスタンスで使うとき
            //var regex = new Regex(@"正規表現の文字列");
            //var result2 = regex.IsMatch("調べる文字列");
            string adress = "mizuki_00000@outlook.jp";
            var regex = new Regex(@"\w{3,}@(outlook.jp|gmail.com|docomo.co.jp)");
            var result2 = regex.IsMatch(adress);
            Console.WriteLine(result2);
            Console.WriteLine("----------");
            /*出力：
             * True
             * ----------
             */

            //---Matchesメソッド---
            //var matches = Regex.Matches("調べる対象", @"正規表現の文字列");
            //foreach (Match match in matches)
            //{
            //    Console.WriteLine(match.Value);//中身の文字列が取れる
            //    foreach (Group group in match.Groups)
            //    {
            //        Console.WriteLine(group.Value);//グループ毎に中身が取れる
            //    }
            //}
            string str = "m-otomo@powersolutions.co.jp";
            var matches = Regex.Matches(str, @"(\w{0,})-(\w{0,})@([a-z]{1,}).[a-z]{2}.[a-z]{2}");
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value+"*******");//中身の文字列が取れる
                foreach (Group group in match.Groups)
                {
                    Console.WriteLine(group.Value+"+++++++");//グループ毎に中身が取れる
                }
                //ここでいうグループは、正規表現の文字列中に指定した（）毎のこと
                //group[0]は文字列すべてとれる
                //group[1]からグループに取得する
            }
            /*出力：
             * m-otomo@powersolutions.co.jp*******
             * m-otomo@powersolutions.co.jp+++++++
             * m+++++++
             * otomo+++++++
             * powersolutions+++++++
             */

            //---Replaceメソッド---置換
            //staticで使うとき
            //var result3 = Regex.Replace("置換される文字列",@"正規表現の文字列","置換する文字列");//置換後のstringを返す
            //第二引数の正規表現の文字列は、その文字列があった場合に変換する。
            //変換対象がなくてもエラーにはならない
            var result3 = Regex.Replace(phone,@"1234","99999");
            Console.WriteLine(result3);
            /*出力：
             * 080-99999-5678
             */

            //インスタンスで使うとき
            //var regex = new Regex(@"正規表現の文字列");
            //var result4 = regex.Replace("置換される文字列","置換する文字列");

        }
        //終了
    }
}
