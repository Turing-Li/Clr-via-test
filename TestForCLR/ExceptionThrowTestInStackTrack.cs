using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForCLR
{
    class ExceptionThrowTestInStackTrack
    {
        public static void ExecptionTest()
        {
            new ExceptionTest().dotestForException();
        }
    }
    class ExceptionTest
    {
        public void dotestForException()
        { 
            throwOneException();
        }

        public void throwOneException()
        {
            //intelli track工具重可以跟踪到具体抛出异常的出发点
            throw new Exception("异常测试堆栈分析");
        }
    }
}
