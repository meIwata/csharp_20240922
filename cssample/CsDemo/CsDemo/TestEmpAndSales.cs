using CsDemo.Models.Com;
using CsDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//測式子類別

namespace CsDemo
{
    internal class TestEmpAndSales
    {
        public static void Main() 
        {
            //建構員工物件 建構子 採用具名參數架構
            GjunEmployees emp1 = new GjunEmployees(address: "高雄市", id: 1, name: "eric");
            emp1.salary = 50000;
            //建構業務員(也是員工)
            Sales sale1 = new Sales(id: 2, name: "張無忌", address: "台北市", dept: "業務部");
            //設定底薪
            sale1.salary = 30001;
            //設定目標業績
            sale1.Qa = 1000000;
            //完成業績
            sale1.ActQa = 1000000;
            //計算業績獎金 method
            sale1.calBons();
            //問實際獎金
            Console.WriteLine($"業績獎金:{sale1.QaBons}");

            //員工都要算薪水了
            emp1.calSalary(22, 2000);
            sale1.calSalary(22, 2000);
            //發薪水了
            Console.WriteLine($"姓名:{emp1.name} 實際薪水:{emp1.actSalary}");
            //Console.WriteLine($"姓名:{sale1.name} 實際薪水:{sale1.actSalary + sale1.QaBons}"); //把底薪跟獎金相加，就是業務員的薪水
            Console.WriteLine($"姓名:{sale1.name} 實際薪水:{sale1.actSalary}");
        }
    }
}
