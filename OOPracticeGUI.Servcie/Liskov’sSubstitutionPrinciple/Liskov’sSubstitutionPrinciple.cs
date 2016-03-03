using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPracticeGUI.Servcie.Liskov_sSubstitutionPrinciple
{
    /// <summary>
    /// Let q(x) be a property provable about objects x of type T. Then q(y) should be provable for objects y of type S where S is a subtype of T.
    /// </summary>
    public class Liskov_sSubstitutionPrinciple
    {

    }


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
            base.Fly();
            Console.WriteLine("...然後拉屎在你頭上");
        }

    }

    public class Ostrich : Bird
    {
        public override void Fly()
        {
            Console.WriteLine("...阿咧我不會飛啊");
        }
    }
}
