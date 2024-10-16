using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//測試長整數 64bit
namespace CsDemo
{
    internal class TestLongInteger
    {
        //主程式method
        public static void Main() 
        {
            //問長整數範圍
            Int64 min = Int64.MinValue;
            Int64 max = Int64.MaxValue;
            Console.WriteLine($"長整數最小值:{min} 最大值{max}"); //範圍: -9223372036854775808 ~ 9223372036854775807

            //定義郭老闆薪水
            Int64 salary = 123456789087654321;
            Console.WriteLine($"郭老闆的薪水:{salary}");
            //張三丰薪水
            Int64 salary2 = 1L; //這樣寫也可以 因為Int64本來就是長整數
            long salary3 = 1L; //意思就是一塊錢裝在L的大箱子裡
        }
    }
}
