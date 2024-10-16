using System;
//CLI輸入字串(Class--參考型別) 物件 轉換成整數 結構(Struct--值型別)

namespace CsDemo
{
    internal class TestStringToInt
    {   //主程式
        public static void Main() 
        {
            //提示 輸出
            Console.WriteLine("輸入C#成績(0-100):");
            //等待輸入 標準輸入
            String value = Console.ReadLine(); //static method
            Console.WriteLine($"你輸入成績:{value}...");
            //轉換字串物件 變成一種結構 固定長度的整數值
            //Int32 score = Int32.Parse(value);
            int score = int.Parse(value); //int關鍵字用法，int預設也是int32
            Int32? score2 = null; //結構允許? nullable，如果允許空值要加上?

            //視同正常 判斷成績是否及格
            Boolean r = score >= 60; //Boolean 兩種值(Literal) true or false
            
            //區域變數Local variable 不會有預設值 
            //String message = null; //a. 參考型別預設值 不知道 給空值;
            String message;

            if (r) //() Condictional 控制
            {
                //及格 進行處理
                message = $"成績:{score} 及格!!";
            }
            else
            {
                //不及格處理
                message = $"成績:{score} 不及格!!";
                //a. 如果else這裡message都不處理的話，上方要加上String message = null;
            }
            Console.WriteLine(message);
        }
    }
}
