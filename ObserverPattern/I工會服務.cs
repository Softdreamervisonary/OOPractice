using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public interface I工會服務
    {
        void 增加勇者(I勇者 pObserver);
        void 刪除勇者(I勇者 pObserver);
        void 取得所有勇者();
    }
}
