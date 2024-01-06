using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2023.12.31

            //반복문

            //for(int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine();

            //for (int i = 5; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}


            //while

            //int a = 0;      //초기식

            //while(a < 5)   //조건식
            //{
            //    Console.WriteLine(a++); //증감식
            //}

            //Console.WriteLine();

            //while (true)
            //{
            //    Console.WriteLine(a--);

            //    if (a == 0) break;  //반복문을 끝냄
            //}



            //do ~ while

            //while과는 달리 먼저 코드를 한 번 실행 후 조건에 따라 반복 여부 결정.


            //int c = 0;

            //do
            //{
            //    Console.WriteLine(c--); //코드를 먼저 실행.
            //} while (c > 0);


            //int a = 0;

            //do
            //{
            //    Console.WriteLine(a++);
            //}while (a < 5);


            //foreach
            //배열이나 컬렉션의 반복을 위해 사용

            //int[] arr = new int[5];

            //for(int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = i;
            //}

            //foreach(int i in arr) Console.WriteLine(i);

            //int b;



            //입력

            //Console.WriteLine("문자를 입력하세요:");
            //string str = Console.ReadLine();
            //Console.WriteLine(str);


            //Console.WriteLine("숫자를 입력하세요~");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine(num);


            //숫자를 하나 입력받아서 그 횟수만큼 문자를 출력하는 코드를 작성하세요.
            //for, while

            //Console.WriteLine("숫자를 입력하세요:");
            //int a = Convert.ToInt32(Console.ReadLine());

            //for(int i = 0; i < a; i++)
            //{
            //    Console.WriteLine("해피 뉴 이어~");
            //}

            //int cnt = 0;

            //while(true)
            //{
            //    Console.WriteLine("새해 복~");
            //    cnt++;
            //    if (cnt == a) break;
            //}

            //for(int i = 0; i < a; i++)
            //{
            //    Console.WriteLine($"{a} + {i} = {a + i}");
            //}



            //입력받은 수 만큼 랜덤한 수(0~100)를 출력하는 코드를 작성하세요.

            //Console.WriteLine("숫자를 입력하세요:");
            //int a = Convert.ToInt32(Console.ReadLine());

            //Random ran = new Random();

            //for(int i = 0; i < a; i++)
            //{
            //    Console.WriteLine(ran.Next(0,101));
            //}


            //숫자 하나 입력받아 그 숫자의 구구단을 출력하는 코드를 작성하세요.

            //Console.WriteLine("숫자를 입력하세요:");
            //int a = Convert.ToInt32(Console.ReadLine());

            //for(int i = 1; i <= 9; i++)
            //{
            //    Console.WriteLine($"{a} * {i} = {a * i}");
            //}

            //int cnt = 1;

            //while(cnt < 10)
            //{
            //    Console.WriteLine($"{a} * {cnt} = {a * cnt++}");
            //}


            //중첩 반복문

            //for(int i = 0; i < 5; i++)
            //{
            //    for(int j = 0; j < 5; j++)
            //    {
            //        Console.WriteLine("한 해 고생많으셨습니다~");
            //    }
            //}


            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Happy New Year~");

            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.WriteLine("한 해 고생많으셨습니다~");

            //        for(int k = 0; k < 2; k++)
            //        {
            //            Console.WriteLine("2024~");
            //        }
            //    }

            //    Console.WriteLine();
            //}

            //중첩 반복문을 활용해서 2~9단까지 모두 출력하는 코드를 작성하세요.

            //for(int i = 2; i <= 9; i++)
            //{
            //    for(int j = 1; j <= 9; j++)
            //    {
            //        Console.WriteLine($"{i} * {j} = {i * j}");
            //    }

            //    Console.WriteLine();
            //}


            //제어문
            //break

            //for(int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("점심 식사 맛있게 드세요~");

            //    if(i == 2)
            //    {
            //        Console.WriteLine("탈출~");
            //        break;  //반복문의 조건과는 상관없이 반복문 종료
            //    }
            //}


            //for(int i = 0; i < 5; i++)
            //{
            //    for(int k = 0; k < 5; k++)
            //    {
            //        Console.WriteLine("제어문!!");

            //        if (k == 3) break; //내부 반복문만 종료.
            //    }

            //    if (i == 2) break;
            //    Console.WriteLine();
            //}


            //continue

            //for(int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("안녕~");

            //    if (i == 2) continue; 
            //    //continue 이후의 코드들은 실행하지 않고 해당 회차를 종료. 반복문을 재실행.

            //    Console.WriteLine(i);
            //}


            //for(int i = 0; i < 3; i++)
            //{
            //    if (i == 1) continue;

            //    for(int k = 0; k < 3; k++)
            //    {
            //        if (k == 1) continue;

            //        Console.WriteLine("배고파");
            //    }

            //    Console.WriteLine();
            //}


            //반복문을 활용해서 100개의 난수 1~100 발생.
            //홀수 짝수 구분한 후 각각 몇개인지 카운트 출력


            //Random ran = new Random();
            //int cnt = 0;

            //for(int i = 0; i < 100; i++)
            //{
            //    int temp = ran.Next(1, 101);    //temp 변수에 1~100사이 임의의 값 할당.
            //    Console.WriteLine(temp);

            //    if (temp % 2 == 0) cnt++;       //temp 나머지 2의 값이 0이라면 카운트(짝수)
            //}

            //Console.WriteLine();

            //Console.WriteLine($"홀수:{100 - cnt}, 짝수:{cnt}");



            //Random ran = new Random();


            //int even = 0;
            //int odd = 0;

            //for (int i = 0; i < 100; i++)
            //{
            //    int num = ran.Next(1, 101);

            //    if (num % 2 == 0) even++;

            //    else odd++;

            //}

            //Console.WriteLine("홀 : " + odd);
            //Console.WriteLine("짝 : " + even);

            //for(int i = 2; i <= 9; i++)
            //{
            //    Console.WriteLine($"{i}단");
            //    for(int j = 1; j <= 9; j++)
            //    {
            //        Console.WriteLine($"{i} * {j} = {i * j}");
            //    }
            //}



            //별찍기

            //*
            //**
            //***
            //****
            //*****

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < i + 1; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //거꾸로 별찍기

            //for (int i = 5; i >= 1; i--)
            //{
            //    for (int j = 0; j <= i - 1; ++j)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            for(int v = 5; v > 0; v--)
            {
                for(int x = 1; x <= 5; x++)
                {
                    if(x >= v) Console.Write("*");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }



            //다이아몬드 찍기
            for (int i = 1; i <= 5; i+=2)
            {
                for (int j = 1; j <= (5 - i) / 2; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for(int i = 3; i >= 1; i -= 2)
            {
                for (int j = 1; j <= (5 - i) / 2; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            



        }
    }
}
