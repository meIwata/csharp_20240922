﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//短整數16bit Int16(具有正負)
namespace CsDemo
{
    internal class TestInt16
    {
        //主程式
        public static void Main()
        {
            //購屋網站16bit夠用
            Int16 amount, amount2;
            //要買幾間??
            //Assign內容
            amount = 20; //凡是整數數值 被預設為32bit(Int32) 進行隱含轉型(Implicit)16bit
            Int16 min=Int16.MinValue;
            Int16 max=Int16.MaxValue;
            Console.WriteLine($"Int16最小值:{min} Int16最大值:{max}"); //Int16範圍:　-32768～32767
            Console.WriteLine($"購屋數:{amount}");
            Int32 house = 32000; //house寫的數字在Int16跟Int32範圍裡
            Int32 min2 = Int32.MinValue;
            Int32 max2 = Int32.MaxValue;
            Console.WriteLine($"Int32最小值:{min2} Int32最大值:{max2}"); //Int32範圍:　-2147483648 ~ 2147483647
            
            //house(Int32)要塞回去amount(Int16)裡
            amount2 = (Int16)house; //變數之間不會隱含轉型--改換強制性轉型(Explicit)
            Console.WriteLine($"aount2 購屋數:{amount2}");

        }
    }
}