using CsDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsDemo
{
    internal class TestDelegate
    {
        public static void Main()
        {
            //定義一個型別
            MyFlying flying = (thing) =>
            {
                //處理程序
                String content = $"小飛象 吃:{thing} 起來了!!";
                Console.WriteLine(content);
            };
            flying.Invoke("熱狗");
        }
    }
}
