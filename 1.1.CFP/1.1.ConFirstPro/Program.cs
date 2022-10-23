using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1.ConFirstPro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;

            // 1. 单行注释
            // Console.Clear(); // 清屏

            // 2. 块注释
            /*
            Console.WriteLine("a");
            string ss = Console.ReadLine();
            Console.WriteLine(ss);
            Console.WriteLine($"信息：{ss}");
            Console.WriteLine("{0},欢迎来到xxx", ss);
            */

            // 关键词
            int rowID = 123;
            int a; // 声明变量
            // = 赋值运算符
            a = 12; // 初始化
            a = rowID + 2;
            byte bl = 255; // 256超范围

            a = 23;
            // a = 2147483648;
            long longNum = 34567;
            var money = 2.3; // double
            float f1 = 3.45f;  // float
            double d2 = 23.56d; // double 不带后缀也可带，D或d
            decimal del = 2.3M; // decimal 带后缀 M m

            // sizeof(Type)分配空间大小
            Console.WriteLine(sizeof(decimal));

            DateTime dt = DateTime.Now;

            // Nullable<T> int? float? double? Nullable<int>

            //Console.ReadLine();
            Console.ReadKey();
        }
    }
}
