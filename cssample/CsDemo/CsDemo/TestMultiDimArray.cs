using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//兩個維度陣列 平衡維度_多及多個人 每一個人有三科成績
namespace CsDemo
{
    internal class TestMultiDimArray
    {
        public static void Main()
        {   
            /* 也可以這樣寫
             // 定義維度
                Int32 d1 = 5; // 行數
                Int32 d2 = 3; // 列數

             // 定義兩個維度的整數類型陣列
                Int32[,] scores = new Int32[d1, d2];
             */

            //定義區域變數 整數類型陣列(兩個維度 )
            Int32[,] scores = new Int32[5, 3];
            //陣列元素數量
            Int32 v = scores.Length; //Length Property getter
            Console.WriteLine(v); //總元素數量 5X3
            Int32 d1 = scores.GetLength(0);
            Int32 d2 = scores.GetLength(1);

            Console.WriteLine(d1);
            Console.WriteLine(d2);

            //打分數
            scores[0, 0] = 100;
            scores[0, 1] = 100;
            scores[0, 2] = 100;
            scores[1, 0] = 90;
            scores[1, 1] = 90;
            scores[1, 2] = 90;
            scores[2, 0] = 80;
            scores[2, 1] = 80;
            scores[2, 2] = 80;
            scores[3, 0] = 70;
            scores[3, 1] = 70;
            scores[3, 2] = 70;
            scores[4, 0] = 60;
            scores[4, 1] = 60;
            scores[4, 2] = 60;
            //問出每一個學生 每一科成績 for loop 迴圈，使用嵌套的 foreach 遍歷二維陣列
            //for(初始值;條件;遞增或者遞減
            for (Int32 outer = 0; outer < scores.GetLength(0); outer++)
            {
                Int32 passCount = 0;
                Int32 failCount = 0;

                // 問相對的學生每一科成績
                for (Int32 inner = 0; inner < scores.GetLength(1); inner++) 
                {
                    //取出相對學生相對科目成績
                    Int32 score = scores[outer, inner];
                    Console.Write($"學生: {outer+1} 第幾:{inner+1} 科目成績:{score}\t");

                    if (score >= 60)
                    {
                        passCount++;
                    }
                    else 
                    {
                        failCount++;
                    }
                }

                // 輸出及格和不及格的科目數
                Console.WriteLine($"\n學生: {outer + 1} 的及格科目數: {passCount}，不及格科目數: {failCount}");

                //切下一行
                //Console.Write("\n");  //escape \n newline
                Console.WriteLine(""); //這樣寫也可以
            }

        }
    }
}
