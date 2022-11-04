using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_C____
{
    internal class Generics
    {
        public static void Discription()
        {
            /*ジェネリック＝総称型
             * List<T>の<T>の部分
             * 使用するときに、Tに要素にしたいデータ型を指定する
             * var intValues = new List<int>();
             * var employees = new List<Employee>();
             * 要素の型にTが指定した型となる
             * Tは実際には型引数と呼ばれるもので、使うときに好きな型を使用することができる
             * 実際の動作イメージ的にはList<T>型のソースコードの内容（メソッド、プロパティ、フィールドの定義）でT型とされている箇所が、
             * すべて指定した型に置き換わる
             * フィールドはT[]型で用意されているため、int[]やEmployee[]になる
             * メソッドやプロパティも同様
             * void Add(T item)はvoid Add(int item)とかvoid Add(Employee item)
             * List<T>型自体も、要素の方に応じて別物となる
             * List<int>とList<Employee>は別の型として認識される
             * クラス定義を示すType型のインスタンスレベルでも別物になる
             * typeof(List<int>) != typeof(List<Employee>) //true
             * intValues = employees;のようなことはできない（Tの型が異なるため、）
             */

            //ジェネリックの定義方法

            //ジェネリッククラス
            //クラス定義時のクラス名の後ろに<型引数名>を追加する
            //型引数名は１津田家の場合は一般的にT
            //各メンバの定義時の型に、指定した型引数を使用できる
            //public class GenericSample<T> {
            //  private T _field;
            //  public T Property { get { return _field; } }
            //  public GenericSample(T value) {
            //      _field = value;
            //  }
            //}
            //型引数は複数でも可で、複数の場合は「,」で区切る
            //GenericSample<T1,T2>

            //ジェネリックメソッド
            //メソッド定義時のメソッド名の後ろに<型引数名>を追加する
            //public void PrintValues<T>(IEnumerable<T> value) {
            //  foreach(T v in values) {
            //      Console.WriteLine(v);
            //  }
            //}

            //default演算子
            //ジェネリッククラス/メソッドの処理の中で、型引数T型の値として、その型に合わせた規定値を使いたいとき
            //stringなどの参照型 => null
            //intなどの数値型    => 0
            //bool             => false
            //など、要は全てが０のビットパターンで表現される値

            //default(T)とすることで、型引数Tに合わせた規定値の意味になる
            //T value = default(T);

            //NULL許容値型
            //構造体（値型）はNULLの状態を持つことができない
            //構造体自体のメンバ（フィールド）は全て対象の変数を示すメモリ上に直接格納されるため
            //DBでは、NULLの可否を指定できるため、DBにNULLを差し込みたい場合に用いる
            //NULLの状態になりうる値型のための型として、Nullable<T>型という専用の値型（Null許容型）が用意されている

            //Nullable<T>
            //Tに指定できるのは値型のみ
            //Nullable<int>のように書くこともできるが、単にT?の形式で書くこともできる
            //int? nullableInt; //そのため、普通はT?の形式で書く
            //プロパティとして、以下の２つを持つ
            //bool HasValue { get; }
            //値がある　＝nullではない場合は、True
            //値がない　＝nullの場合は、false
            //T Value { get; }
            //値がある場合の、実際の値で、HasValueがfalseの場合に参照すると例外発生
            //値の代入は、T型自体、もしくはnullを普通に代入可能
            //int? ni1 = 100;   //HasValue = true,Value = 100;
            //int? ni2 = null;  //HasValue = false;
            //null比較もOK
            //※参照型はもともとnullが入るため、Nullableが必要ない

            /*ここまでの理解は
             * ジェネリックでフィールドやメソッドを定義すれば、データ型の自由度が上がる
             * 例えば、引数をstringで定義してしまうとstringしか入らないけど、Tで定義すれば、stringもintも入る
             * 参照型はnullを元からnullを許容するが、値型でnullを許容する場合は、Nullable<T>を使用する
             */
        }
        //終了
    }
}
