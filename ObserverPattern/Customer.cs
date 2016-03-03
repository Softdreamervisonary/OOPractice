using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class 英雄 : I勇者
    {
        public string MyName { private get; set; }

        public 英雄(string pName)
        {
            MyName = pName;
        }

        // 更新最新消息
        public void 接受召喚(string pMessage)
        {
            Console.WriteLine("{1}獲得了{0}作為你公會的一份子 :", MyName, pMessage);
        }

        public void 被消滅(string pMessage)
        {
            Console.WriteLine("{0} 被{1}擊殺", MyName, pMessage);
        }

        public void 勇者姓名()
        {
            Console.WriteLine("                                   {0}", MyName);
        }
    }
}
