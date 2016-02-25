using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPracticeGUI
{
    //Let q(x) be a property provable about objects x of type T.Then q(y) should be provable for objects y of type S where S is a subtype of T.
    public class Bird
    {
        public virtual void Fly()
        {
            Console.WriteLine("我正在飛");
        }
    }

    public class Pigeon : Bird
    {
        public override void Fly()
        {
           
            Console.WriteLine("我是頭鴿子");
            base.Fly();
            Console.WriteLine("然後大便在你頭上");
        }

    }

    public class Ostrich : Bird
    {
        public override void Fly()
        {
            Console.WriteLine("...我是鴕鳥，阿咧我不會飛啊，叫我飛有病阿?");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var Birds = new List<Bird>();
            Birds.Add(new Ostrich());
            Birds.Add(new Pigeon());

            foreach(Bird i in Birds)
            {
                i.Fly();
            }

            Console.WriteLine("按任意鍵結束...");
            Console.ReadKey(true);
        }
    }
}
