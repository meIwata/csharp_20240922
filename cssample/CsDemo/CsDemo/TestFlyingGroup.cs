using CsDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//飛行者聯盟
namespace CsDemo
{
    internal class TestFlyingGroup
    {
        public static void Main() 
        {
            //集合物件 收集會飛的(不同類的) 介面多型化
            List<IFly>group= new List<IFly>();

            //超人來了
            SuperMan superman = new SuperMan();
            group.Add(superman);

            //鳥類
            Bird bird = new Bird();
            group.Add(bird);

            //飛機
            Airplane airplane = new Airplane();
            group.Add(airplane);


            //出任務 通通飛起來
            //走訪
            foreach (IFly fly in group) 
            {
                //操作功能 碰到超人 請他吃熱狗
                //問一下本尊是?
                if (fly is SuperMan)
                {
                    //Explicit Casting 明確性轉型。Java使用instanceof
                    ((SuperMan)fly).Help("路易絲");
                }
                else 
                {
                    fly.flying();
                    //fly.flying("熱狗");
                }

            }
        }
    }
}
