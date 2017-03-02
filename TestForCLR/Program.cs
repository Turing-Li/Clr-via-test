using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestForCLR
{
    class Program
    {
        static void Main(string[] args)
        {
            //DelegateTest dt = new DelegateTest();
            //normalDelegate nd = new normalDelegate(dt.testDelegate);
            //Delegate d = nd;
            //d.DynamicInvoke();
            //Console.Write(nd is Delegate);

            //WaitCallback callback = null;
            //callback += DelegateTestStaticFunc.TestDelegateFuncSugar;
            //callback += x =>
            //{
            //    Console.WriteLine("noNameFunc:{0}", x);
            //};

            //ThreadPool.QueueUserWorkItem(callback, 10);

            //test sttribute of class and methods
             //List<object> classAttrs= typeof(BaseAttributeTestClassSon1).GetCustomAttributes(false).ToList();
             //MethodInfo methodsInfo = typeof(BaseAttributeTestClassSon2).GetMethod("TestSttribute");
            //测试标记类作用
            //BaseAttributeTestClass attrTest = null;
            //attrTest = new BaseAttributeTestClassSon1();
            //attrTest.DoAction();
            //attrTest = new BaseAttributeTestClassSon2();
            //attrTest.DoAction();

            //Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            //excel.Application.Workbooks.Add(true);
            //string d = excel.Cells[1, 2].value;

            //动态解析测试
            //dynamic s =new { a = 1d };
            //string aass = s.a;

            //一场throw堆栈分析测试
            //try
            //{
            //    ExceptionThrowTestInStackTrack.ExecptionTest();
            //}
            //catch (Exception)
            //{
                
            //    throw;
            //}

            //cpu占用测试
            //for (; ; )
            //{
            //    int i = 1;
            //}


            //GC Test
            Timer t = new Timer(GcTest.GcTestFunc, null, 0,2000);
            GC.Collect();
            Console.ReadLine();
              //  Console.Read();
        }

    }
}
