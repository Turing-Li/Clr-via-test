﻿using System;
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
            BaseAttributeTestClass attrTest = null;
            attrTest = new BaseAttributeTestClassSon1();
            attrTest.DoAction();
            attrTest = new BaseAttributeTestClassSon2();
            attrTest.DoAction();
            Console.Read();
        }

    }
}
