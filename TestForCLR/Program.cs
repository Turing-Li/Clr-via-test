using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
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
            //Timer t = new Timer(GcTest.GcTestFunc, null, 0,2000);
            //GC.Collect();

            //反射测试
            //Type t = typeof(TypeTestClass);
            //List<ConstructorInfo> ConstructorInfolists = t.GetTypeInfo().DeclaredConstructors.ToList();
            //PropertyInfo p= t.GetTypeInfo().GetDeclaredProperty("prototy");
            //TypeTestClass tobj=new TypeTestClass();
            //var pdelegate = p.SetMethod.CreateDelegate(typeof(Action<String>),tobj);
            //pdelegate.DynamicInvoke("test type");
            //Console.Write(tobj.prototy);

            //序列化测试
            //SerializableTest test = new SerializableTest();
            //test.Str = "SerializableTest...";
            //Stream stream = SerializableHelper.ConvertToMemoryStream(test);
            //stream.Position = 0;
            //BinaryFormatter formatter = new BinaryFormatter();
            //SerializableTest desTest = (SerializableTest)formatter.Deserialize(stream);
            //Console.WriteLine(desTest.Str);

            //Task

            //Task<String> t = new Task<String>((s) =>
            //{
            //    Thread.Sleep(1000);
            //    object s1 = s.ToString();
            //    Console.WriteLine("Task Current ThreadId:{0}", Thread.CurrentThread.ManagedThreadId);
            //    return s1.ToString();
            //},1000);

            //t.Start();

            //Console.WriteLine("Main ThreadId:{0}", Thread.CurrentThread.ManagedThreadId);

            CancellationTokenSource ctc = new CancellationTokenSource();
            Task stopTask = new Task(() =>
            {

                Thread.Sleep(3000);
                Console.Write("do here now.");
            }, ctc.Token);

            Task continueTask = stopTask.ContinueWith(task =>
            {
                Console.Write("continueTask");
            });

            stopTask.Start();

            //ctc.Cancel();
            Console.ReadLine();
            //  Console.Read();
        }

    }
}
