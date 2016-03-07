using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 樣板方法

            公會管理 小羊公會 = new 銅牌公會();

            公會管理 Emily公會 = new 鑽石公會();

            公會管理 Tony公會 = new 黃金公會();

            #endregion
        }
    }
}
