using CsDemo.Models.Com;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsDemo.Models
{
    //明確繼承父類別(Pure OOP 只能有一個父親)
    public class Sales : GjunEmployees
    {
        //Data Field
        //封裝性的東西都用_命名
        private Decimal _qa; //業績
        private Decimal _qaBons; //業績獎金
        private String _dept;
        private Decimal _actQa;

        //建構子沒有繼承性 沒有寫 編譯產生預設架構子 Sales(.指向父親先建構()..)
        public Sales(Int32 id, String name, String address, String dept) : base(id, name, address) //base() 指向父親建構子
        {
            this._dept = dept;
        }


        /*以下使用精靈產生，對著_qa右鍵->快速動作與重構->封裝欄位(但仍使用欄位)*/
        public decimal Qa { get => _qa;

            set 
            {
                if (value >= 0) 
                {
                    _qa = value;
                }
            } 
        }

        //唯讀屬性Property
        public decimal QaBons { get => _qaBons; } //只能看獎金，不能設定獎金，把set欄位拿掉
        public string Dept { get => _dept; set => _dept = value; }

        //實際業績屬性
        public decimal ActQa { get => _actQa; set => _actQa = value; }

        //業務員方法 計算獎金
        public void calBons()
        {
            //達成率九成就可以算
            if (_actQa >= _qa * (Decimal)0.9)
            {
                _qaBons = _actQa * 0.05M; //後面帶上一個M也是代表Decimal
            }
        }
        public override void calSalary(int days, decimal bons)
        {
            //原來算法繼續要用
            base.calSalary(days, bons);
            //得加上業績獎金
            _actSalary += _qaBons;
        }
    }
}
