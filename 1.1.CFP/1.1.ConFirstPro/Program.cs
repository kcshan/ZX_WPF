using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1.ConFirstPro  // 命名空间，默认情况与项目名称一样的
{
    /// <summary>
    /// 入口类 文档注释
    /// 命名规则：类 属性 方法 结构体 Pascal 首字母大写
    /// </summary>
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

            // 可控类型
            // Nullable<T> int? float? double? Nullable<int>
            // int c = null; // 引用类型 null
            int? c = null; // right
            // bool true false 默认值false 有 无 成功 失败
            bool bol = false;
            bol = c > 0 ? true : false;
            if (bol)
            {
                Console.WriteLine("123");
            }

            // 枚举类型 enum
            Sex sex = Sex.Female;

            Console.WriteLine(sex); // Female
            int intFemale = (int)sex; // 枚举转换为整型

            string strSex = sex.ToString();
            // int 转换成枚举？？
            Sex sex2 = (Sex)0;
            // 获取枚举中的常量名称数组
            string[] sexNamesArr = Enum.GetNames(typeof(Sex));
            // 获取枚举中的常量值数组
            Console.WriteLine(sexNamesArr);
       
            Array sexValuesArr = Enum.GetValues(typeof(Sex));
            Console.WriteLine(sexValuesArr);

            StudentInfo stu1 = new StudentInfo(23, "小星星");
            stu1.ShowInfo();

            StudentInfo stu2;
            stu2.age = 23;
            //stu2.StuName = "小星星";  // 属性不能直接赋值

            //Console.ReadLine();
            Console.ReadKey();
        }

        /// <summary>
        /// 枚举类型
        /// </summary>
        enum Sex
        {
            Male=0,
            Female=1
        }
        /// <summary>
        /// 结构体 不能继承于其他的结构体或类
        /// </summary>
        struct StudentInfo: IPeople
        {
            // 不能显示定义无参构造函数
            //public StudentInfo()
            //{
            //}
            /// <summary>
            /// 可以有带参数的构造函数
            /// </summary>
            /// <param name="_age"></param>
            /// <param name="stuName"></param>
            public StudentInfo(int _age, string stuName)
            {
                age = _age;
                StuName = stuName;
            }
            public int age;  // 不能赋初值 字段或变量
            public string StuName { get; set; }  // 属性
            // 方法 void 没有返回值
            public void ShowInfo()  // 方法
            {
                Console.WriteLine($"年龄：{age}, 姓名：{StuName}");
            }

            // 结构体不能有析构函数
            //~StudentInfo()
            //{
            //}
        }

        struct People
        {

        }
        // class类
        class PeopleBase
        {

        }
        // 接口
        interface IPeople
        {
            void ShowInfo();
        }
    }
}
