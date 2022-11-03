using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_C____
{
    internal class Delegate
    {
        public static void description()
        {
            /*デリゲートとは
             * あるメソッド自体を一つのデータとみなして、それを参照する型
             * メソッドをデリゲート型の変数に代入して使用したり、戻り値にしたりできる
             * メソッド自体もメモリ上のどこかに存在するため、その場所を参照するデータ
             * 処理をさせることができるデータ
             * 
             * ポイント
             * ・staticメソッドだけでなく、インスタンスメソッドも参照できる
             * インスタンスメソッドの場合は、メソッドだけでなく、
             * そのメソッドが作用するインスタンスも合わせて１つのデータとして参照する
             * ・複数のメソッドを同時に参照できる
             * 足し算（+=）をすることで、参照を追加できる（コンポジション）
             * 引き算（-=）は逆に参照を削除できる
             * コンポジションされたメソッドは順番に実行される
             * 戻り値がある場合は、最後のメソッドの戻り値が結果となる（通常のコンポジションはvoidであることが多い）
             * ＧＵＩアプリケーションに代表されるイベント駆動型と呼ばれるプログラミングで重要になる概念
             */

            //標準で用意されているデリゲート型

            //---Action---
            //Action<T>,Action<T1,T2>,Action<T1,T2,T3> ...
            //戻り値はvoid
            //引数に応じていろいろなパターンがジェネリクスで定義されている
            //引数がref,outの物は用意されていない
            //（例）Action => 引数なし、戻り値がないメソッドに対応
            //（例）Action<int,int> =>intの引数を２つ受け取り、戻り値がないメソッドに対応

            //--Func<TResult>---
            //Func<T,TResult>,Func<T1,T2,TResult>,Func<T1,T2,T3,TResult> ...
            //戻り値はTResultで定義した型
            //Action同様に引数の個数ごとに用意されている
            //ジェネリクスパラメータは 、先頭から第一引数、第二引数、最後が戻り値の型
            //（例）Func<int> => 引数なし、戻り値がintのメソッドに対応
            //（例）Func<int,int,int> => intの引数を2つ受け取り、戻り値がintのメソッドに対応

            //---EventHandler,EventHandler<T>,XXXXEventHandler(XXXXは色々)---
            //各種のイベントが発生した際に実行する処理を示すデリゲート型
            //GUIアプリケーションで多用される

            //デリゲートの利用
            //デリゲートの変数には、そのデリゲートの定義（引数・戻り値）に合致するメソッドを代入できる
            //ACtion<string> a = Console.WriteLine;
            //varでの宣言はできない
            //メソッド名までで指定するため、引数のパターンが複数ある可能性がある
            //そもそも同じ引数・戻り値でもデリゲート型は複数作れる

            //var l = new List<int>();
            //Action<int> adder = l.Add;
            //インスタンスメソッドの場合は、対象インスタンスメソッド名で指定
            //自身のインスタンスであれば、メソッド名だけでＯＫ
            //デリゲート型は参照型の一種なので、NULLを設定可能
            //Action<string a = null;//OK
            //対象メソッドへの参照を持つ
            //デリゲートが参照しているメソッドを実行
            //変数（引数...）で実行、もしくは、変数.Invoke（引数...）でも可
            //a("Hello!");//aに設定したメソッドが動く
            //Func<int,int> fn = Math.Abs;
            //var returnValue = fn(-10);//戻り値10がreturnValueに格納

            //デリゲートの利点
            //メソッドの引数として処理自体を渡したいケース
            //ソート処理のような、処理の大枠を提供し、その処理の中で行うプログラムごとに異なる処理を引数で指定するケース
            //（処理の大枠＝ソートアルゴリズム自体）
            //（プログラムごとに異なる処理＝並び替えのルール）

            /*ラムダ式
             *その場で一度しか使わないメソッドで、名前を付ける必要がない
             */

            //匿名メソッド式
            //Func<int,int,int> fn = delegate(int i,int j) { return i*j; }

            //ラムダ式
            //Func<int,int,int> fn = (i,j) => i*j;
            //引数 => 処理の本文
            //ラムダ式を受け取る内容から引数の型が推測できる場合は、引数の型は省略できる
            //引数が１なら（）は不要。引数がない場合は、（）を記述する必要がある。
            //処理本文がreturn文１つだけなら｛｝やreturnを省略して、戻り値とする式だけを書けばOK
            //２文以上ある場合は、｛｝とreturnは必須
            //※匿名メソッド式でかける内容はラムダ式で書けるため、ラムダ式を推奨

            //クロージャ
            //ラムダ式（匿名メソッド含む）は処理をかける任意の場所に書くことができる
            //変数は外側のスコープで定義されたものなら使える
            //ラムダ式や匿名メソッドからも、そのブロックの外側で宣言された変数が使用できる
            //引数以外の変数をラムダ式が宣言された時点のレベルで解決する関数オブジェクトのことをクロージャと呼ぶ
            //.NETのラムダ式、匿名メソッドはクロージャとしての性質を持つ
            
            //クロージャの実体
            //メソッドの戻り値がクロージャの場合
            //メソッドの中で宣言したローカル変数は、メソッドを抜けると消えるはず
            //ローカル変数はスタックメモリに用意されているので、メソッドを抜けると消される
            //static Func<int> GetCounter(){
            //  var i=0;
            //  return () => ++i;
            //}
            //var counter = GetCoutner();
            //Console.WriteLine(counter());//1
            //他メソッドのローカル変数が使用できる（コンパイラが自動で使用できるように定義している）

        }
        public static void a()
        {
            var counter = GetCounter();//メソッドが返ってきている？これがデリゲート？
            Console.WriteLine(counter);
            Console.WriteLine("a");//a
            Console.WriteLine(counter());//1
            Console.WriteLine(GetCounter());//System.Func1
        }
        public static Func<int> GetCounter()
        {
            var i = 0;
            Console.WriteLine("GetCounter");
            return () => ++i;
        }
    }
}
