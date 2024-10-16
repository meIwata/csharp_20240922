using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsDemo.Models
{
    //類別實作特定介面(s)
    internal class SuperMan : IFly
    {
        //方法重載
        public void flying()
        {
            Console.WriteLine($"超人飛起來!!");
        }

        public void Help(string who) 
        {
            Console.WriteLine($"超人要救:{who}!!!");
        }

        public void flying(string thing)
        {
            Console.WriteLine($"超人吃: {thing} 飛起來!!");
        }
    }
}
