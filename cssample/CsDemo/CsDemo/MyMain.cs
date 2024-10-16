//引用命名空間(使用其中資料型別-Data Type)
//定義命名空間 管理自訂類別
using System;

namespace CsDemo
{
    //定義類別
    //定義一個當作主程式跑第一支method
    //static modifer-修飾這一個方法 無須透過物件來(直接被抽離出來執行的Global 程序)
    public class MyMain //建議這裡的命名跟程式名稱一樣，但不一樣也可以
    {
        //定義一個當作主程式跑第一支method
        //static modifer-修飾這一個方法 無須透過物件來(直接被抽離出來執行的Global 程序)
        public static void Main()
        {
            //操作Console C> 進行標準輸出 要將CLI(C>) 當作一個物件??? 使用共用Global的架構
            //直接使用類別呼叫方法(static成員)(無須一個個體物件)
            Console.WriteLine("Hello World");
        }
    }
}//區段block