using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_C____
{
    internal class NullEnzanshi
    {
        public static void Description()
        {
            /*
             * 
             * 
             */
            //int? でnullの時は、０代入したいなど
            //①
            //int i=0;
            //if ( ni.HasValue ) {
            //  i = ni.Value;
            //}
            //②三項演算子
            //var i = ni.HasValue ? ni.Value : 0 ;
            //以上の①と②は同一の処理だが、メソッドも用意されているし、専用の演算子がある
            //左項 ?? 右項　で左項がnullでなければni.Value、nullなら右項を返す
            //int i = ni ?? 0 ; //niがnullでなければni.Value、nullなら０
            //演算子のため、普通の参照型にも使用できる
            //var message = erorMessage ?? "正常終了" ;
            
            //??=演算子
            //nullの歳には値を代入する処理のために「??=」が用意されている
            //左項 ??= 右項 で左項がnullでなければ何もしない、nullなら右項の値を左項に代入する
            //s ??= "default string" ;
            //sがnullでなければ何もしない
            //sがnullならば"default string"を代入する
            
            //基本構文をさらに短く書くための演算子
        }
        //終了
    }
}
