using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 猜數字練習
{
    class Program
    {
        static void Main(string[] args)
        {
            int keyin; //user key in 猜的數字
            int guees;  //電腦亂數產生的數字
            int count;  //猜了幾次
            int min;    //猜完數字後的範圍最小值
            int max;    //猜完數字後的範圍最大值

            count = 0;  //初始化猜的次數
            min = 1;    //最小值1
            max = 100;  //最大值100

            Random rm = new Random(); //建立亂數
            guees = rm.Next(1, 100);
            Console.WriteLine("猜數字=================");
            Console.WriteLine();

            do
            {
                Console.WriteLine($"{min} < ? < {max} ");
                keyin = int.Parse(Console.ReadLine());
                if (keyin >= min && keyin <= max) //驗證值局限在上下限之內
                {
                    count += 1; // 計算猜的次數
                    if (keyin == guees)
                    {
                        Console.WriteLine($"猛哥，一猜就中{guees} 總猜次數{count} ");
                        break;//結束
                    }

                    else if (keyin > guees)
                    {
                        max = keyin; //將keyin 值指派給最大值，縮小範圍
                        Console.Write("大哥，小點吧");
                    }
                    else if (keyin < guees)
                    {
                        min = keyin; //將keyin 值指派給最小值，擴大範圍
                        Console.Write("大哥，不夠大");
                    }
                    Console.WriteLine($"猜了{count} 了");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("\n  請輸入提示範圍內的數字!!");
                }
            }
            while (true);//無窮迴圈(需使用break 跳出。

            Console.Read();
        }
    }
}
