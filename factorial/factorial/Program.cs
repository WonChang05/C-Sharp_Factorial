using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //(for迴圈練習)讓使用者輸入一個數字，計算出階乘出來的結果
            Console.WriteLine("*********階乘*********");
            Console.Write("請輸入一個數值:");

            int temp = Convert.ToInt16(Console.ReadLine());
            int result = 1;
            string strResult = "";
            //i=5 --> 5*4*3*2*1
            for (int i = temp; i > 0; i--)
            { 
                result = result * i;
                strResult = strResult + i + "*";
            }
            strResult = strResult.TrimEnd('*');
            Console.WriteLine($"{strResult}={result}");
        }
    }
}
