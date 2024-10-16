using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsDemo
{
    internal class TestWhile
    {
        //Entry Point
        public static void Main() 
        {
            Int32 counter = 10;
            Int32 start = 1;

            //迴圈 while ()
            while (start<=10) 
            {
                //...處理
                String content = $"跑第幾圈:{start}圈";
                Console.WriteLine(content);
                //累計一下
                //start = start + 1;
                start++;
            }
        }
    }
}
