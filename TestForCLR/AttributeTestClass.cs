using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForCLR
{
    public class BaseAttributeTestClass
    {
        public virtual void DoAction()
        {
            bool isAttr = this.GetType().IsDefined(typeof(DoActionAdd1Attribute),false);
            if (isAttr)
            {
                Console.WriteLine("class has DoActionAdd1Attribute attribute ,{0}",this.GetType().Name);
            }
            else
            {
                Console.WriteLine("class has no attribute ,{0}", this.GetType().Name);
            }
            Console.Write("ceshiyixia");
        }
    }
    [DoActionAdd1Attribute]
    public class BaseAttributeTestClassSon1 : BaseAttributeTestClass
    {

    }
    public class BaseAttributeTestClassSon2 : BaseAttributeTestClass
    {
        [DoActionAdd1Attribute]
        public void TestSttribute()
        { 
        }
    }
}
