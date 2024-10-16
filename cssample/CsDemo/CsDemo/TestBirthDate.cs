using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//CLI 輸入字串 轉換成DateTime? 如何比較日期
namespace CsDemo
{
    internal class TestBirthDate
    {
        //Entry Point(Main Program)
        public static void Main() 
        {
            //提示 輸出字串
            Console.WriteLine("您的生日(exp:2001/01/01):");

            //等待輸入 標準輸入
            String dateString = Console.ReadLine();

            //所有結構struc 都有static method可以分析字串 轉換成相對結構型別
            //DateTime day = DateTime.Parse(dateString); //如果輸入: 2000/02/30 可能無法轉換 會拋出例外(要進行管理)

            //先準備一個一個DateTime區域變數
            DateTime day;

            //採用方法可以協助進行分析 分析好將結果採用位址回傳
            Boolean r = DateTime.TryParse(dateString, out day); //out 參數為傳址 by reference，如果dateString是有效的話，塞回去day
            if (r==true) //可以簡化寫成if (r)
            {
                //生日轉換成民國年
                Console.WriteLine($"民國: {day.Year - 1911}年{day.Month}月{day.Day}日");
            }
            else
            {
                Console.WriteLine($"輸入日期: {dateString} 不合法");
            }
        }

    }
}
