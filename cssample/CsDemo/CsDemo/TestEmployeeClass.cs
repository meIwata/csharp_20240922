using CsDemo.Models.Com;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsDemo
{
    internal class TestEmployeeClass
    {
        //主程式
        public static void Main()
        {   
            //類別類型class
            GjunEmployees emp1;

            //建構一個個體物件
            emp1 = new GjunEmployees();  //= 將建構起來的物件 參考位址 指派給變數
            emp1.id = 2;
            //emp1._salary = 40000;  因為_salary設定為private 

            emp1.name = "Linda";
            emp1.address = "台中市";
            emp1.birthdate = new DateTime(2024, 12, 31);

            //設定薪水為5000，會去跑封裝，出來會變成封裝指定的方法
            emp1.salary = 5000;
            Console.WriteLine($"{emp1.name}'s Salary: {emp1.salary}"); // 輸出薪水


            Console.WriteLine("--------------------------");

            //第二個員工 直接建構 採用物件初始化語法一氣呵成
            GjunEmployees emp2 = new GjunEmployees()
            {
                id = 2,
                name = "Bill",
                address = "台北市",
                salary = 70000
            }; //物件初始化語法
            //核算薪水
            emp1.calSalary(22, 2000);

            emp2.calSalary(11, 2000);
            //實際薪水
            Console.WriteLine($"姓名:{emp1.name} 實際薪水:{emp1.actSalary}");
            Console.WriteLine($"姓名:{emp2.name} 實際薪水:{emp2.actSalary}");

            Console.WriteLine(emp1.GetHashCode()); //HashCode是父類別的方法
            Console.WriteLine(emp2.GetHashCode());
        }
    }
}
