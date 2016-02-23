using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPracticeGUI.Servcie
{
    /// <summary>
    /// Single Responsibility Principle 
    /// 單一責任原則--錯誤示範
    /// 因為draw適用在GUI畫圖
    /// 而area是用在Cal計算面積
    /// 基於單一原則RectanRectangle這個class若更動會影響到OOPracticeCal和OOPracticeGUI
    /// 故建議將RectanRectangle拆成更細的RectangleCAL和RectangleGUI兩個類別
    /// </summary>
    public class RectanRectangle
    {
        
        public string draw()
        {


            return "我畫畫到GUI上";
        }

        
        public string area()
        {

            return "我是計算程式";
        }
    }
}
