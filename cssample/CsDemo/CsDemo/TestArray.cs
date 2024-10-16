using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//陣列應用Array
namespace CsDemo
{
    internal class TestArray
    {
        //Entry Point
        public static void Main ()
        {
            //收集全班CS成績(一個維度)
            //設定整數類型陣列(陣列各種類型都可以設定) 
            //班上有十個人

            /*Int32[] csScore = new Int32[];*/

            Int32[] csScore = null; //定一個維度整數陣列變數(參考型別)
            //Int32[] csScore; 這裡的預設也是null
            //Int32 value = null; 整數Value Type 不能使用 null
            Int32 salary; //區域變數不會有預設值
            //Console.WriteLine(salary); //錯誤
            csScore = new Int32[10]; //建構陣列10元素(序號是:0~9) 將位址給 變數
            //第一格填寫成績,...
            csScore[0] = 100;
            csScore[1] = 90;
            csScore[2] = 80;
            csScore[3] = 70;
            csScore[4] = 60;
            //其他元素採用預設值為0
            //跑回圈
            Int32 pos = 0; //從序號0開始跑
            while (pos < csScore.Length)
            {
                Console.WriteLine(csScore[pos]); //csScore[pos]叫出csScore的序號資料
                pos++;
            }
        }
    }
}
