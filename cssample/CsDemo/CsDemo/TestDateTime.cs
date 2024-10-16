using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsDemo
{
    internal class TestDateTime
    {
        //Entry Point
        public static void Main() 
        {
            //取出電腦系統日期與時間 使用DateTime static Now Property取出(getter)，電腦的時間只能取用不能設置
            DateTime today = DateTime.Now;

            //輸出日期時間格式
            Console.WriteLine(today.ToString()); //ToString不寫跟有寫意思一樣
            Console.WriteLine(today);

            //問時間
            Console.WriteLine("時間:" + today.ToShortTimeString());
        }
    }
}
