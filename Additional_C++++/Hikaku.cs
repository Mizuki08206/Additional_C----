using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_C____
{
    internal class Hikaku
    {
        public static void Description()
        {
            /*
             * 
             * 
             * 
             */
            //等価性について
            //HashSet<String>などで、各要素の大文字小文字を同一視してほしいとき
            //stringクラスのGetHashCodeはEqualsは、大文字小文字が異なれば違う結果となり、同一視してくれない
            //T型の値の等価性を検証するための機能を持つIEqualityComparer<T>インタフェースが用意されている
            //int GetHashCode(T item)
            //bool Equals(T item1,T item2)
            //HashSet<T>やDictionary<T,V>クラスにはコンストラクタでIEqualityComparer<T>を受け取るものが用意されている
            //文字列の各種IEqualityComparer<string>の実装として、StringComparerクラスが用意されている
            //staticプロパティでいろんな動作をするものが定義されている
            
            //大小比較について
            //SortedSet<string>(二分探索木)を使うときに、各要素の大文字小文字を同一視してほしい場合
            //またはSortedSet<int>で、値を大きい順に列挙できるようにしたい場合（標準だと小さい順）
            //T型の値の大小関係を比較するための機能を持つIComparer<T>インタフェースが用意されている
            //int CompareTo(T item1,T item2)
            //0未満 =item1の方が小さい（順序的に先）
            //0　　 =item1,item2は等価（順序はどっちが先でも良い）
            //1以上 =item1の方が大きい（順序的に後）
            
            //各種二分探索をベースにしているクラスには、コンストラクタでIComparer<T>を受け取るものが用意されている
            //StringComparerクラスはIEqualityComparer<stirng>だけでなく、IComparer<T>も実装している
        }
        //終了
    }
}
