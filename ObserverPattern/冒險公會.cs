using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class 冒險公會 : I工會服務
    {
        List<I勇者> 勇者群; // 使用List來存放觀察者名單

        public 冒險公會()
        {
            勇者群 = new List<I勇者>();
        }

        // 加入觀察者
        public void 增加勇者(I勇者 pObserver)
        {
            勇者群.Add(pObserver);
        }

        // 移除觀察者
        public void 刪除勇者(I勇者 pObserver)
        {
            if (勇者群.IndexOf(pObserver) >= 0)
                勇者群.Remove(pObserver);
        }

        // 發送通知給在監聽名單中的觀察者
        public void 取得所有勇者()
        {
            foreach (I勇者 observer in 勇者群)
            {
                observer.勇者姓名();
            }
        }


        // 取消訂閱報紙
        public void 移除勇者(I勇者 pCustomer)
        {
            刪除勇者(pCustomer);
        }

        // 發送新消息
        public void 系統公告(string pContent)
        {
            Console.WriteLine(pContent);
        }
    }
}
