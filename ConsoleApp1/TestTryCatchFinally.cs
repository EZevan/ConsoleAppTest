using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    //class TestTryCatchFinally
    //{
    //    public People Test()
    //    {
    //        People people = new People()
    //        {
    //            Age = 20,
    //            Code = 1,
    //            Name = "evan"
    //        };

    //        ///注意这里的执行顺序：
    //        ///如果没有异常出现，而且finally语句中没有return，则会执行try里边的return，
    //        ///并且，会将变量暂存起来(对象存的是引用的地址)，再去执行finally中的语句，
    //        ///这时候，如果返回值是基本数据类型或者字符串，则finally相当于更改副本，不会对暂存值有影响；
    //        ///但是，如果返回值是对象，则finally中的语句，仍会根据地址的副本，改变原对象的值
    //        try
    //        {
    //            ++people.Age;
    //            //return people; //如果在try里有return，当执行完finally里的语句块后，会跳回到try里的return，反之则直接执行try-catch-finally之后的return
    //        }
    //        catch
    //        {

    //        }
    //        finally
    //        {
    //            ++people.Age;
    //        }
    //        return people;
    //    }

    //    static void Main(string[] args)
    //    {
    //        TestTryCatchFinally t = new TestTryCatchFinally();
    //        int y = t.Test().Age;
    //        Console.WriteLine(y);
    //        Console.ReadLine();
    //    }
    //}

    //class People
    //{
    //    public int Code { get; set; }
    //    public string Name { get; set; }
    //    public int Age { get; set; }
    //}

    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    //class Test
    //{
    //    public int aaa()
    //    {
    //        int x = 1;

    //        try
    //        {
    //            return ++x;
    //        }
    //        catch (Exception e)
    //        {

    //        }
    //        finally
    //        {
    //            ++x;
    //        }
    //        return x;
    //    }

    //    public static void Main(String[] args)
    //    {
    //        Test t = new Test();
    //        int y = t.aaa();
    //        Console.WriteLine(y);
    //        Console.ReadKey();
    //    }

    //  }


    ///=========================================================================================================================================================================================================================


    class TestStringBuilder
    {
        public void TestMethod()
        {

            string s = "Hello World";
            StringBuilder sb = new StringBuilder(s);

            sb.Append(" evan");

        }

        static void Main(string[] args)
        {
            TestStringBuilder t = new TestStringBuilder();
            t.TestMethod();
        }


    }
}
