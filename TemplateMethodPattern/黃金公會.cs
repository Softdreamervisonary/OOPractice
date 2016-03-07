using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    public class 黃金公會 : 公會管理
    {
        DayOfWeek[] 黃金公會經驗加倍日期 = new DayOfWeek[] { DayOfWeek.Monday, DayOfWeek.Friday, DayOfWeek.Wednesday };
        public override GuildType SetGuildType
        {
            get
            {
               return  GuildType.黃金公會;
            }
            set { }
        }

        public override bool 經驗加倍()
        {
            
            return 黃金公會經驗加倍日期.Contains(DateTime.Now.DayOfWeek);
        }
    }
}
