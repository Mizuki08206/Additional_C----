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
            //
            //ジェネリックメソッド
            //メソッド定義時のメソッド名の後ろに<型引数名>を追加する
            //public void PrintValues<T>(IEnumerable<T> value) {
            //  foreach(T v in values) {
            //      Console.WriteLine(v);
            //  }
            //}
            //
            //
            //
            //

            //
            /*ここまでの理解は
             * ジェネリックでフィールドやメソッドを定義すれば、データ型の自由度が上がる
             * 例えば、引数をstringで定義してしまうとstringしか入らないけど、Tで定義すれば、stringもintも入る
             */
        }

    }
}
