using System;
//設計區域變數 型別是整數類型(struct)

namespace CsDemo
{
    internal class TestInteger
    {
        //主程式Entry Point(Method)
        //void沒有回應值
        public static void Main() 
        {
            //定義區域變數Local Variable(生命週期活在這一個區段 )
            //C#強型別Strong Type(先定義變數型別 再賦值-變數內容 經由=指派的 assign )
            //問一下結構Byte 範圍是多少
            
            Byte min = Byte.MinValue; //MinValue為const視為靜態 
            Byte max = Byte.MaxValue;
            Console.WriteLine($"Byte最小值:{min} 最大值:{max}"); //{} Expression；前面加個$就可以印出結果
            Console.WriteLine("Byte最小值:" + min + " 最大值:" +  max); //也可以用+號當字串串接結果
        }
    }
}
