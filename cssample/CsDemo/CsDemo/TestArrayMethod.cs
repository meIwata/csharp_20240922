using CsDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//操作陣列類型 背後靈
namespace CsDemo
{
    internal class TestArrayMethod
    {
        public static void Main() 
        {
            //呼叫自訂模組 class Member(static method) 取出特定數量成績單
            Int32[] scores = ArrayUtility.csGenData(100);
            Console.WriteLine($"總共有{scores.Length}份成績");

            // 計數及格的成績
            int passCount = 0;

            //篩選出成績及格的???
            Array.ForEach<Int32>(scores,
                //傳遞功能指標 直接寫上功能functional delegate 類型
                //使用 Lambda Expression
                (score) => 
                {
                    if (score >= 60)
                    {
                        Console.WriteLine($"及格成績: {score}");
                        passCount++;
                    }
                }

                );
            Console.WriteLine($"共有 {passCount} 位及格");
        }
    }
}
