using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    public class 銅牌公會 : 公會管理
    {
        public override GuildType SetGuildType
        {
            get
            {
               return  GuildType.銅牌公會;
            }
            set { }
        }

        public override bool 經驗加倍()
        {
            return DateTime.Now.DayOfWeek == DayOfWeek.Monday; 
        }
    }
}
