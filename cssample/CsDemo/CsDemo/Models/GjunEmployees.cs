//引用命名空間
using System;

//規劃命名空間
namespace CsDemo.Models.Com
{
    //類別具有繼承性 類型 有規劃的Method or Property 被使用 就得使用建構子
    //修飾詞 可見度 public protected internal private
    //類別具有繼承性 沒有特別指定父親 一律繼承System.Object
    public class GjunEmployees : Object //:繼承
    {
        //結構成員設計Data Field/Proprty/Method...
        //Data Field 
        public Int32 id; //沒有寫Modifier 預設為private 
        public String name;
        public String address;
        public String phone;
        private Decimal _salary; //採用封裝性(資訊隱藏) 採用Property代表
        public DateTime birthdate;
        //private Decimal _actSalary; //實際薪水(經過計算的)
        protected Decimal _actSalary; //需要改成protected，這樣子類別才能使用父類別，Object不能使用

        //沒有寫上Constructor 編譯產生預設架構子 空參數的
        //id name address 參數 區域變數 (產生在Stack 堆疊 後進先出)
        public GjunEmployees(Int32 id, String name, String address)
        {
            //this 相對這一個物件
            this.id = id;
            this.name = name;
            this.address = address;
        }
        //建構子OverLoading 多載
        public GjunEmployees()
        {

        }


        //規劃屬性Property 程序 使用等號操作
        public Decimal salary
        {
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

        //唯讀屬性
        public Decimal actSalary
        {
            get
            {
                return _actSalary;
            }
        }

        //功能核算個別化的實際薪水--核算薪資
        public virtual void calSalary(Int32 days, Decimal bons)
        {
            //核算 程序
            if (days > 0)
            {
                Decimal sa = (Decimal)(days / 22.0) * _salary;
                //加上津貼
                _actSalary = sa + bons;
            }
            else
            {
                _actSalary = 0;
            }
        }
    }
}