//引用命名空間
using System;
//規劃命名空間
namespace CsDemo.Models.Com
{
    //類型 結構Structure
    //修飾詞 可見度 public > protected > internal > private
    public struct Employees
    {
        //結構成員設計Data Field/Proprty/Method...
        //Data Field 
        public Int32 id; //沒有寫Modifier 預設為private 
        public String name;
        public String address;
        public String phone;
        private Decimal _salary; //採用封裝性(資訊隱藏) 採用Property代表。這裡封裝了，用_salary代替，正式名稱給下面使用
        public DateTime birthdate;
        //沒有寫上Constructor 編譯產生預設架構子 空參數的
        //規劃屬性Property 程序 使用等號操作
        public Decimal salary
        {   
            //設定
            set
            {
                if (value > 30000)
                {
                    _salary = value;
                }
                else
                {
                    _salary = 30000;
                }
            }
            //取得
            get
            {
                return _salary;
            }
        }
    }
}