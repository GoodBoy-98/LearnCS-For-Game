using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
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


            //별찍기 역순

            //for(int v = 5; v > 0; v--)
            //{
            //    for(int x = 1; x <= 5; x++)
            //    {
            //        if(x >= v) Console.Write("*");
            //        else Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}



            //다이아몬드 찍기

            //for (int i = 1; i <= 5; i+=2)
            //{
            //    for (int j = 1; j <= (5 - i) / 2; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= i; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for(int i = 3; i >= 1; i -= 2)
            //{
            //    for (int j = 1; j <= (5 - i) / 2; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= i; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}



            // 배열 array

            //int[] arr = new int[5];
            //arr[0] = 10;
            //Console.WriteLine(arr[0]);

            //int a = 5;
            //Console.WriteLine(arr.Length);

            //if (arr.Length < a)
            //arr[a] = 20;

            //int[] arr2 = new int[8];

            //for(int i = 0; i < arr2.Length; i++)
            //{
            //    arr2[i] = i;
            //    Console.WriteLine(arr2[i]);
            //}

            //Console.WriteLine();

            //arr2[4] = 20;
            //arr2[6] = 100;

            //foreach(int i in arr2)
            //{
            //    Console.WriteLine($"{i}");
            //}

            //배열의 선언과 초기화 방법

            //int[] arr = new int[5];
            //int[] arr2 = new int[] { 2, 10, 5, 8, 9 };
            //int[] arr3 = { 6, 2, 42, 1, 0 }; //선언과 동시에 초기화 해야함

            //foreach (int i in arr) Console.WriteLine(i);
            //foreach (int i in arr2) Console.WriteLine(i);
            //foreach (int i in arr3) Console.WriteLine(i);

            //int[] arr4;
            //arr4 = arr;

            //int a = 5;
            //int b = a;


            //요일 랜덤
            //string[] week = new string[7] { "월", "화", "수", "목", "금", "토", "일" };

            //Random ran = new Random();
            //Console.WriteLine(week[ran.Next(0, week.Length)]);


            //배열 정렬

            //오름차순

            //swap

            //int a = 10;
            //int b = 20;

            //Console.WriteLine($"스왑 전 - a:{a}, b:{b}");

            //a = b;

            //int c = a;
            //a = b;
            //b = c;

            //Console.WriteLine($"스왑 후 - a:{a}, b:{b}");

            //int[] arr = new int[] { 11, 31, 76, 1, 9, 32, 0, 8, 90, 2, 5, 7, 100, 4 };
            //foreach ( int i in arr ) Console.WriteLine(i);

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] > arr[j])
            //        {
            //            int temp = arr[i];
            //            arr[i] = arr[j];
            //            arr[j] = temp;
            //        }
            //    }
            //}

            //Array.Sort(arr);
            //Array.Reverse(arr);

            //2차원 배열

            //int[,] arr = new int[3, 4];

            //Console.WriteLine(arr.Length);
            //Console.WriteLine(arr.GetLength(0));
            //Console.WriteLine(arr.GetLength(1));

            //Random ran = new Random();

            //for(int i = 0; i<arr.GetLength(0); i++)
            //{
            //    for(int j = 0; j <arr.GetLength(1); j++)
            //    {
            //        arr[i, j] = ran.Next(0, 101);
            //        Console.Write($"arr[{i},{j}]:{arr[i,j]}  ");
            //    }
            //    Console.WriteLine();
            //}


            int[] arr = new int[30];

            //1~100 랜덤한 값을 arr 각 공간에 대입.

            //1~100 사이의 숫자를 하나 입력받아서 입력받은 값이 배열안에 있는지 없는지 출력하고 있다면 그 인덱스까지 출력

            Random ran = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = ran.Next(1, 101);
            }

            while (true)
            {
                Console.Write("숫자 입력(1~100) : ");
                int input = int.Parse(Console.ReadLine());



                bool isFound = false;
                int index = 0;

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == input)
                    {
                        isFound = true;
                        index = i;
                        break;
                    }
                }


                if (isFound)
                {
                    Console.WriteLine($"해당 값은 배열의 [{index}]번째 위치에 있습니다.");
                    break;
                }
                else
                {
                    Console.WriteLine("해당 값은 배열에 없습니다.");
                }
            }

            //// 2차원
            //int[,] arr = new int[4, 4];

            //Console.WriteLine(arr.Length);
            //Console.WriteLine(arr.GetLength(0));
            //Console.WriteLine(arr.GetLength(1));

            //Random ran = new Random();

            //for(int i = 0; i<arr.GetLength(0); i++)
            //{
            //    for(int k = 0; k< arr.GetLength(1); k++)
            //    {
            //        arr[i, k] = ran.Next(0, 100);
            //        Console.WriteLine($"arr[{i},{k}]:{arr[i,k]}\t");
            //    }
            //    Console.WriteLine();
            //}
            //arr[0, 0] = 1000;
            //Console.WriteLine(arr[0,0]);


            //int[,] arr2 = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
            //foreach (int i in arr2) { Console.WriteLine(i); }

            //Console.WriteLine();
            ////3차원
            //int[,,] arr3 = new int[2, 2, 2]
            //{
            //    { { 1,2},{ 3,4} },
            //    { { 5,6}, { 7,8} }
            //};

            //Console.WriteLine(arr3[0,1,0]);
            //foreach(int i in arr3) Console.WriteLine(i);

            //int[,] arr = new int[5, 5];
            //int id = 1;

            //for(int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for(int k = 0; k < arr.GetLength(1); k++)
            //    {
            //        Console.Write($"{id}\t");
            //        arr[i, k] = id++;
            //    }
            //    Console.WriteLine();
            //}



            //int[,] arr = new int[,]
            //{
            //    {1,2,3,4,5 },
            //    {6,7,8,9,10 },
            //    {11,12,13,14,15 },
            //    {16,17,18,19,20 },
            //    {21,22,23,24,25 }
            //};


            //for (int j = 0; j < arr.GetLength(1); j++)
            //{
            //    for (int i = 0; i < arr.GetLength(0); i++)
            //    {
            //        Console.Write($"{arr[i,j]}");
            //    }
            //    Console.WriteLine();
            //}


            //함수, 메소드
            //Print(); //호출

            //for (int i = 0; i < 5; i++) Print();

            //Printint(100);

            //int a = 20;
            //Printint(a);
            //PrintString("아시겠죠??");

            //int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            //PrintArray(arr);
            //PrintArray(new int[] { 10, 11, 12, 13, 14, 15 });

            //int a = Returnint(100);
            //Console.WriteLine(a);

            //int b = Add(10, 20);
            //Console.WriteLine(b);

            //Console.WriteLine(Add(1,2,3));
            //Console.WriteLine(Add(1.4f, 2.4f));

        }

        static void Print()
        {
            Console.WriteLine("안녕하세요");
            Console.WriteLine("헬로우");
            Console.WriteLine("봉쥬르");
            Console.WriteLine("니하오");
            Console.WriteLine("곤니찌와");
        }

        static void Printint(int i)
        {
            Console.WriteLine(i);
        }

        static void PrintString(string str)
        {
            Console.WriteLine(str);
        }

        static void PrintArray(int[] arr)
        {
            foreach(int i in arr) Console.WriteLine(i);
        }

        static int Returnint(int a)
        {
            return a;
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Minus(int a, int b)
        {
            return a - b;
        }

        static int Divide(int a, int b)
        {
            return a % b;
        }

        static int Spare(int a, int b)
        {
            return a / b;
        }

        //메소드 오버로딩
        //매개변수 형식 또는 갯수가 다르면 같은 이름의 메소드를 작성 가능

        static int Add(int a, int b, int c) // Add가 이미 있지만 매개 변수의 갯수가 하나더 많아서 중복 가능
        {
            return a + b + c;
        }

        static float Add(float a, float b) // Add가 이미 있고 매개 변수 갯수도 같지만 형식이 달라서 중복 가능
        {
            return a + b;
        }

    }
}
