using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_C____
{
    public static class Seiteki
    {
        //すべてのメンバが、クラスメンバ（staticメンバ・静的メンバ）であるクラス
        //staticをクラス宣言部に付与することで、下記の特性を持つクラスとなる
        
        //static class XXX{ /*クラスメンバ定義*/ }
        
        //---特徴---
        //・クラスメンバのみ宣言可能、インスタンスメンバは宣言不可
        //・インスタンス化ができない
        //・継承不可（親はobjectクラス限定）
        
        //標準で用意されているMathクラスのような、
        //特定の問題領域に対する処理を行うためのメソッド・プロパティ・定数などを提供することを
        //目的としたクラス（ユーティリティクラス）をstaticクラスにすることが多い

    }
}
