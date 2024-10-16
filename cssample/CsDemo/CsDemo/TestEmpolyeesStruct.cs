using CsDemo.Models.Com;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//使用自訂的結構
namespace CsDemo
{
    internal class TestEmpolyeesStruct
    {
        //Entry Point
        public static void Main()
        {
            //一個員工資料(Struct)
            //Employees emp1;
            Employees emp1 = new Employees(); //使用封裝的資料所以需要new
            emp1.id = 1;
            emp1.name = "Eric"; //先建構一個Eric字串物件 將位址指派給name
            emp1.address = "台中市逢甲路";
            emp1.phone = "04-45454545";
            emp1.birthdate = new DateTime(1995, 12, 31);
            emp1.salary = 50000;

            //Employees emp2; 
            Employees emp2 = new Employees(); //使用封裝的資料所以需要new
            emp2.id = 2;
            emp2.name = "Sam"; //先建構一個Eric字串物件 將位址指派給name
            emp2.address = "台北市中山路";
            emp2.phone = "02-45454545";
            emp2.birthdate = new DateTime(1990, 12, 31);
            emp2.salary = -50000; //不合邏輯，回到Employees.cs改動salary成封裝

            //使用建構子Constrctor
            Employees emp3 = new Employees();
            emp3.id = 3;
            emp3.name = "Linda"; //先建構一個Eric字串物件 將位址指派給name
            emp3.address = "台南市中山路";
            emp3.phone = "06-45454545";
            emp3.birthdate = new DateTime(1992, 12, 31);
            emp3.salary = 60000;


            Decimal s1 = emp1.salary; //getter
            //輸出
            Console.WriteLine($"編號:{emp1.id} 姓名:{emp1.name} 薪資:{s1} 生日:{emp1.birthdate}");
            Console.WriteLine($"編號:{emp2.id} 姓名:{emp2.name} 薪資:{emp2.salary} 生日:{emp2.birthdate}");
            Console.WriteLine($"編號:{emp3.id} 姓名:{emp3.name} 薪資:{emp3.salary} 生日:{emp3.birthdate}");

        }
    }
}