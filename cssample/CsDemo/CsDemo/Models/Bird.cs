using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsDemo.Models
{
    //類別實作特定介面(s)
    internal class Bird : IFly
    {
        //方法重載
        public void flying()
        {
            Console.WriteLine($"鳥類飛起來!!");
        }

        public void flying(string thing)
        {
            Console.WriteLine($"鳥類吃:{thing} 飛起來!!");
        }
    }
}
