using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    public abstract class 公會管理
    {
        #region enum defined
        public enum GuildType
        {
            銅牌公會,
            黃金公會,
            鑽石公會
        }
        #endregion

        #region hook 
        public abstract GuildType SetGuildType { get; set; }

        public abstract bool 經驗加倍();

        #endregion

        public  void 公會日常可做事情()
        {
            //銅牌會員做的事情
     
            if (SetGuildType == GuildType.銅牌公會)
            {
                Console.WriteLine("每天可以重置副本一次");
            }

            if (SetGuildType == GuildType.鑽石公會)
            {
                Console.WriteLine("每天可以領鑽石100顆一次");
            }

            if (SetGuildType == GuildType.黃金公會)
            {
                Console.WriteLine("每天可以從泉水中召喚勇者一次");
            }

            if (經驗加倍())
            {
                //每黃金公會是周1、3、5經驗加倍 讚石則是每天 銅牌只有禮拜一
                Console.WriteLine("每天可以打銅牌副本");
            }

        }


    }

 
}
