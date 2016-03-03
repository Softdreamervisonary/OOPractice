using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public interface I勇者
    {
        void 接受召喚(string pMessage);

        void 勇者姓名();

        void 被消滅(string pMessage);
    }
}
