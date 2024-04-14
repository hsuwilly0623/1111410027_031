using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1111410027_許哲瑋031
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入單字(50字內)");                    //請使用者輸入要查的單字
            string str = Console.ReadLine().ToLower();                  //將輸入定義為str並轉換為小寫
            if (str.Length > 50)                                       //要是使用者輸入的文字長度>50 
            {
                Console.WriteLine("太長!!!");                           //則說(太長了)
                System.Environment.Exit(System.Environment.ExitCode);   //並直接結束程式
            }
            string[] words = str.Split(' ');                             //將上面使用者的輸入字串轉換為分割字串並定義為words
            Console.WriteLine("請輸入你要搜尋的英文字母");              //請使用者輸入要搜尋的字元
            char one = Console.ReadLine().ToLower()[0];                //將輸入定義為one並轉換為小寫
            bool found = false;                                          //定義found =false
            for (int i = 0; i < words.Length; i++)                           //將words排列
            {
                if (words[i].IndexOf(one) >= 0)                           //要是分割字串中含有搜尋的字元
                {
                    Console.Write(i);                                   //則輸出字串的順序
                    found = true;                                       //找到為true
                }
            }
            if (!found)                                                 //要是沒有出現要找的字元
            {
                Console.WriteLine("[]");                               //顯示空白
            }


        }
    }
}
