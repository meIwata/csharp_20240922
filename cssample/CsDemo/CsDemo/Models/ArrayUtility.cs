using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsDemo.Models
{
    //修飾可見度 到處看得到 public
    public class ArrayUtility
    {
        //提供一個功能(Method)
        //static 這是共用功能(Global)其他人可以調用， 這一個類別無須個別化產生物件，儲存應用程式個別操作資訊
        public static Int32[] csData()
        {
            //區域變數 整數一個維度陣列(同類型資料集合)
            Int32[] scores = new Int32[] { 100,90,80,70,0,50,40,30,20,10 }; //這裡new Int32[]，中括號裡面不寫，就會去找{}裡面的數量，有寫的話{}裡面就要擺對應數量的值
            return scores;
        }


        public static Int32[] csGenData(Int32 counter)
        {
            //區域變數 整數一個維度陣列(同類型資料集合)
            //動態產生成績(隨機碼)
            //建構一個隨機類別個體物件(new 建構子())
            Random rnd = new Random();
            //陣列元素數量
            Int32[] scores = new int[counter];
            //for loop 配合參數值 跑相對次數
            for (Int32 pos = 0; pos < counter; pos++)
            {
                //隨機碼物件產生成績(0-100)
                Double r = rnd.NextDouble(); //0<=r<1
                Int32 number = (Int32)(r * 100) + 1;
                //Int32 number = rnd.Next(0, 101); //也可以這樣寫，0 <= number <= 100
                scores[pos] = number;
            }
            return scores;
        }

        //6個人 三科成績初始化
        public static Int32[,] csMultiDimData()
        {
            //建構多維度陣列
            Int32[,] scores = new int[,] {
                {100,100,100},
                {90,90,90},
                {80,80,80},
                {70,70,70},
                {60,60,60},
                {50,50,50}
            };
            return scores;
        }
        // 不平衡維度 有人考三科 或者四科 
        public static Int32[][] csJagMutliData()
        {
            Int32[][] scores = new int[5][];
            //陣列中陣列
            scores[0] = new int[] { 100, 100, 100 };
            scores[1] = new int[] { 90, 90, 90, 90 };
            scores[2] = new int[] { 80, 80 };
            scores[3] = new int[] { 70, 70, 70 };
            scores[4] = new int[] { 10, 10 };
            return scores;
        }

    }
}
