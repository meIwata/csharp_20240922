using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsDemo.Models
{
    internal interface IFly
    {
        //注意C#這裡void前面不用寫修飾詞，Java要寫(public、private...)
        void flying();
        void flying(String thing);

    }
}
