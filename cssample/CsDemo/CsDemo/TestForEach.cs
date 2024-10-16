using CsDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//For each逐一走訪(Enumeration) 無須順序性
namespace CsDemo
{
    internal class TestForEach
    {
        //Entry Point
        public static void Main() 
        {
            //跟自訂模組(Modules) 類別成員(Class Member) 無須個體物件操作 要成績單(陣列)
            Int32[] scores=ArrayUtility.csData();

            //走訪 一個問過一個foreach
            //準備一個陣列 元素 收集及格的
            //Int32[] ok = new Int32[300]; //固定元素數量，數量固定，有幾個就要寫幾個值
            //使用集合物件Collection Framework 建構一個個體物件 具有順序性
            //List<Generic泛型>  Generic影響到該物件操作方法(Property)參數或者回應值

            /*List<XXX>，XXX這裡的型別讓你預設，也可以寫成double*/
            List<Int32>okcol=new List<Int32>(); //new 建構子() Constructor
            Int32 position = 1;
            foreach (Int32 score in scores) //走訪目標 資料來源是哪一種型別?(會有模糊狀)。這裡的score是區域變數，只用在foreach裡面，但類型要與scores類型一致
            {
                Console.WriteLine($"第:{position} 個 成績:{score}");
                if (score >= 60) 
                {
                    //執行階段進行參考(?)一個整數(結構 是值型別 Value Type)
                    okcol.Add(score);/*上面的型別預設成什麼這裡的score就是什麼*/ //Autoboxing 將整數封裝成一個具有位址的物件(Object類型)
                }
                position++;
            }


            //及格的是誰???
            foreach (Int32 w in okcol) 
            {
                Console.WriteLine($"及格分數: {w}");
            }
            Console.WriteLine($"及格的有: {okcol.Count}位");
        }
    }
}
