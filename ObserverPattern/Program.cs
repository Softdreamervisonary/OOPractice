using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {


            冒險公會 瘋子冒險公會 = new 冒險公會();
            瘋子冒險公會.系統公告("小羊的遊戲開始囉");

            英雄 Tony = new 英雄("Tony");
            瘋子冒險公會.召喚勇者(Tony);
            英雄 Emily = new 英雄("Emily");

            瘋子冒險公會.增加勇者(Emily);
            瘋子冒險公會.系統公告("你點擊隊伍欄，你目前擁有的英雄為：");
            瘋子冒險公會.取得所有勇者();
            Emily.被消滅("被小羊怪擊殺了。請其他隊友為他報仇");
            瘋子冒險公會.刪除勇者(Tony);
            瘋子冒險公會.系統公告("你點擊隊伍欄，你目前擁有的英雄為：");
            瘋子冒險公會.取得所有勇者();
            Console.Read();
          
        }
    }
}
