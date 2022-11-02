using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_C____
{
    public static class Kakutyo
    {
        //既存のクラスなどの型に対して、追加のインスタンスメソッドを定義できる（ように見える）機能
        //staticクラスのstaticメソッドで、最初の引数を以下のようにする
        //・thisを付与する
        //・引数の型を、拡張メソッドを追加する対象の型にする
        //対象の型を、拡張メソッドを定義しているクラスが定義されている名前空間をusingすることで、拡張メソッドが有効になる
        public static int ParseInt(this string self)
        {
            return int.Parse(self);
        }
        //"123456".ParseInt();//123456(int)
        //実際には、対応するstaticメソッドの呼び出しがされているだけ
        //なお、拡張メソッドは普通のstaticメソッドの発展版なので、、下記のように呼び出すこともできる

        //Kakutyo.ParseInt("123456");

        //Q.同一ファイル内であればおそらくクラス名は不要
        //Q.同じファイル内に書いていればusingは必要ない？

    }
}
