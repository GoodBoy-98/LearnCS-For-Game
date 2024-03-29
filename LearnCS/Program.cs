﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace LearnCS
{
    class Human
    {
        //상태, 멤버 변수 또는 필드
        public int m_age;
        public string m_name;
        public float m_weight;
        public float m_height;
        public string m_gender;


        //생성자, 클래스가 new 키워드 통해서 생설 될 때 호출되는 메소드

        public Human()
        {
            Console.WriteLine("휴먼 생성");     //기본 생성자
        }

        //생성자는 보통 멤버 변수들 초기화 할 때 쓰임
        //생성자도 오버로딩이 가능
        public Human(int _age, string _n, float _w, float _h, string _g)
        {
            m_age = _age;
            m_name = _n;
            m_weight = _w;
            m_height = _h;
            m_gender = _g;
        }



        //기능, 멤버 함수 또는 메소드

        public void Eat()
        {
            Console.WriteLine("치킨 좋아");
        }
        
        public void Talk()
        {
            Console.WriteLine("수다 좋아");
        }

        public void Study()
        {
            Console.WriteLine("c# 좋아");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"이름:{m_name}, 나이:{m_age}, 성별:{m_gender}, 키:{m_height}, 몸무게:{m_weight}");
        }

        //소멸자, 객체가 삭제될 대 호출

        ~Human() { Console.WriteLine("휴먼 삭제"); }
    }

    class Dog
    {
        public int age;
        public string name;
        public string color;
        public string gender;
        

        public void Eat()
        {
            Console.WriteLine("냠냠");
        }
        public void Bark()
        {
            Console.WriteLine("멍멍");
        }
        public void ShowInfo()
        {
            Console.WriteLine($"이름:{name}, 나이:{age}, 색상:{color}, 성별:{gender}");
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            //클래스 Class
            //Human a = new Human();

            //a.m_age = 20;
            //a.m_name = "yong";
            //a.m_weight = 67.5f;
            //a.m_height = 172.1f;
            //a.m_gender = "남성";

            //a.Eat();
            //a.Study();
            //a.Talk();
            //a.ShowInfo();

            //Human b = new Human();

            //b.m_age = 20;
            //b.m_name = "kim";
            //b.m_weight = 64.6f;
            //b.m_height = 179;
            //b.m_gender = "남성";

            //b.Eat();
            //b.Study();
            //b.Talk();
            //b.ShowInfo();

            //Dog dog = new Dog();

            //dog.age = 1;
            //dog.name = "happy";
            //dog.color = "black";
            //dog.gender = "male";

            //dog.Bark();
            //dog.Eat();
            //dog.ShowInfo();

            //Human human = new Human();

            //Human human1 = new Human(10, "yong", 50f, 150f, "남성");
            //human1.ShowInfo();

            //Earth.Human human2 = new Earth.Human();
            //Pandora.Human human3 = new Pandora.Human();

            Human human = new Human();
            Cat cat = new Cat(2,"나비","검정","암컷");
            cat.ShowInfo();







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


            //int[] arr = new int[30];

            ////1~100 랜덤한 값을 arr 각 공간에 대입.

            ////1~100 사이의 숫자를 하나 입력받아서 입력받은 값이 배열안에 있는지 없는지 출력하고 있다면 그 인덱스까지 출력

            //Random ran = new Random();

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = ran.Next(1, 101);
            //}

            //while (true)
            //{
            //    Console.Write("숫자 입력(1~100) : ");
            //    int input = int.Parse(Console.ReadLine());



            //    bool isFound = false;
            //    int index = 0;

            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (arr[i] == input)
            //        {
            //            isFound = true;
            //            index = i;
            //            break;
            //        }
            //    }


            //    if (isFound)
            //    {
            //        Console.WriteLine($"해당 값은 배열의 [{index}]번째 위치에 있습니다.");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("해당 값은 배열에 없습니다.");
            //    }
            //}

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

            //Print();        //호출!! 콜!! call

            //Add(1, 2);

            //Console.WriteLine(Add(2, 3.14f)); //Console.WriteLine(2 + 3.14f);


            //int x = Add(3, 4, 5);       // int y = 3 + 4 + 5;


            //int a = 5;
            //int b = 6;

            //Add(a, b);


            //Console.WriteLine(Move(2));
            //Console.WriteLine(Move(0));

            //int speed = 0;

            ////Console.WriteLine(Move(speed));

            //if(Move(speed))     //if(true)  //if(false)
            //{
            //    Console.WriteLine("이동 중");
            //}
            //else
            //{
            //    Console.WriteLine("대기 중");
            //}

            //int a = 5;
            //int b = 10;

            //int x = a;
            //int y = b;

            //int temp2 = x;
            //x = y;
            //y = temp2;

            //Console.WriteLine($"{a}, {b}");


            //int temp = a;
            //a = b;
            //b= temp;

            ////값에 의한 호출

            //Console.WriteLine($"Swap 전 - a:{a}, b:{b}");

            //Swap(a, b);

            //Console.WriteLine($"Swap 후 - a:{a}, b:{b}");


            ////참조에 의한 호출
            //Console.WriteLine();

            //Console.WriteLine($"Swap 전 - a:{a}, b:{b}");

            //Swap(ref a, ref b);

            //Console.WriteLine($"Swap 후 - a:{a}, b:{b}");


            //out

            //int a;

            ////Add(a, 1, 2);     
            ////메소드 호출시 기본적으론 매개변수에 변수를 활용하면 변수에 값이 할당되어있어야 함

            //Add(out a, 1, 2);

            //Console.WriteLine(a);


            //int b = 0;

            //Add(b, 3, 4);

            //Console.WriteLine(b);


            //params

            //Total(1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 10, 11, 12, 13, 14, 15, 16, 17);

            //int[] arr = new int[] { 1, 2, 3, 4, 5 };

            //Total(arr);

            //Console.WriteLine(Factorial(5));

            //int[] arr = new int[] { 2, 4, 6, 8, 10 };

            //Console.WriteLine(TotalSum(arr));

            //int[] arr2 = new int[] { 10, 12, 6, 1, 9 };

            //Console.WriteLine("정렬 전");

            //foreach (int i in arr2) Console.WriteLine(i);

            //Console.WriteLine();

            //SortArray(arr2);

            //Console.WriteLine("정렬 후");

            //foreach (int i in arr2) Console.WriteLine(i);

            //int[,] arr = new int[5, 5];
            //int idx = 1;    //배열에 대입할 요소
            //int x = 0;      //좌우측 방향 제어

            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        arr[i, x] = idx++;

            //        if (i % 2 == 0)
            //        {
            //            if (j < 4) ++x;
            //        }
            //        else
            //        {
            //            if (j < 4) --x;
            //        }
            //    }
            //}

            //for(int i = 0; i<arr.GetLength(0); i++)
            //{
            //    for(int j = 0; j<arr.GetLength(1); j++)
            //    {
            //        Console.Write($"{arr[i,j]}\t");
            //    }
            //    Console.WriteLine();
            //}

            //int[,] arr = new int[5, 5];
            //int idx = 1;
            //int y = 0;

            //for(int i = 0; i<arr.GetLength(0); i++)
            //{
            //    for(int j = 0; j<arr.GetLength(1); j++)
            //    {
            //        arr[y, i] = idx++;

            //        if (i % 2 == 0)
            //        {
            //            if (j < 4) y++;
            //        }
            //        else
            //        {
            //            if (j < 4) y--;
            //        }
            //    }
            //}

            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.Write($"{arr[i, j]}\t");
            //    }
            //    Console.WriteLine();
            //}

            //int[,] arr = new int[5, 5];
            //int nextTurnCount = 4;      //방향 회전이 일어나기 까지 남은 횟수
            //int moveCount = 5;          //회전 전까지 이동 횟수
            //int turnCount = 0;          //x, y축 변경
            //int dir = 1;                //축에 따른 방향

            //int x = 0;
            //int y = 0;

            //for(int i = 0; i < arr.Length; i++)
            //{
            //    arr[y, x] = i + 1;

            //    if(i == nextTurnCount)
            //    {
            //        if(turnCount % 2 == 0)
            //        {
            //            moveCount--;    //다음 턴 까지 남은 이동 횟수 감소
            //        }
            //        else
            //        {
            //            dir *= -1;      //방향 변경
            //        }

            //        nextTurnCount += moveCount;     //다음 턴까지 이동 횟수 추가
            //        turnCount++;
            //    }

            //    if (turnCount % 2 == 0) x = x + dir;    //좌우이동
            //    else y = y + dir;                       //상하이동
            //}

            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.Write($"{arr[i, j]}\t");
            //    }
            //    Console.WriteLine();
            //}

        }

        //static void Print()
        //{
        //    Console.WriteLine("안녕하세요");
        //    Console.WriteLine("헬로우");
        //    Console.WriteLine("봉쥬르");
        //    Console.WriteLine("니하오");
        //    Console.WriteLine("곤니찌와");
        //}

        //static void Printint(int i)
        //{
        //    Console.WriteLine(i);
        //}

        //static void PrintString(string str)
        //{
        //    Console.WriteLine(str);
        //}

        //static void PrintArray(int[] arr)
        //{
        //    foreach(int i in arr) Console.WriteLine(i);
        //}

        //static int Returnint(int a)
        //{
        //    return a;
        //}

        //static int Add(int a, int b)
        //{
        //    return a + b;
        //}

        //static int Minus(int a, int b)
        //{
        //    return a - b;
        //}

        //static int Divide(int a, int b)
        //{
        //    return a % b;
        //}

        //static int Spare(int a, int b)
        //{
        //    return a / b;
        //}

        ////메소드 오버로딩
        ////매개변수 형식 또는 갯수가 다르면 같은 이름의 메소드를 작성 가능

        //static int Add(int a, int b, int c) // Add가 이미 있지만 매개 변수의 갯수가 하나더 많아서 중복 가능
        //{
        //    return a + b + c;
        //}

        //static float Add(float a, float b) // Add가 이미 있고 매개 변수 갯수도 같지만 형식이 달라서 중복 가능
        //{
        //    return a + b;
        //}

        //static void Print()     //반환형식과 매개변수가 없는 메소드
        //{
        //    Console.WriteLine("안녕하세요");
        //    Console.WriteLine("반갑습니다");
        //}

        //static void Add(int a, int b)       //반환형식이 없고 정수형 매개변수가 둘 있는 메소드
        //{
        //    Console.WriteLine(a + b);
        //}



        //static int Add(int a, float b)      //정수형 반환 형식, 정수형, 실수형 각각 하나인 메소드
        //{
        //    return a + (int)b;
        //}

        //static bool Move(int speed)
        //{
        //    //if (speed > 0) return true;
        //    //else return false;

        //    return speed > 0 ? true : false;
        //}


        ////call by value , call by reference
        ////값에 의한 호출, 참조에 의한 호출

        //static void Swap(int x, int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}

        //static void Swap(ref int x, ref int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}


        ////out
        ////변수의 초기화 없이 참조 가능

        //static void Add(out int x, int y, int z)
        //{
        //    //out 키워드 매개 변수에 반드시 값을 할당해야함
        //    x = y + z;
        //}

        //static void Add(int a, int b, int c) //정수형 매개변수가 셋인 메소드
        //{
        //    a = b + c;
        //}



        ////params
        ////가변 인자 매개변수
        ////개수의 제한없이 매개변수를 넘기는 기능

        //static void Total(params int[] list)
        //{
        //    foreach (int i in list) Console.WriteLine(i);
        //}

        //static void Total(int a, int b, int c, params int[] list)  //params 키워드를 활용한 매개변수는 하나만.
        //{                                                          //그 위치는 마지막 매개변수
        //    foreach (int i in list) Console.WriteLine(i);
        //}

        ////재귀 함수
        ////자기 자신을 호출하는 메소드 함수

        //static int Factorial(int n)
        //{
        //    if (n == 0) return 1;
        //    else
        //    {
        //        return n * Factorial(n - 1);
        //    }
        //}

        //static void Func()
        //{
        //    Func();
        //}


        ////배열의 모든 요소를 더해서 반환하는 메소드를 만들어주세요.

        //static int TotalSum(int[] arr)
        //{
        //    int sum = 0;        //매개변수의 배열안의 요소들을 더해 줄 변수

        //    foreach (int i in arr) sum += i;     //배열 안의 요소들을 sum 변수에 더해줌

        //    return sum;         //더한 결과를 반환
        //}



        ////배열을 오름차순하는 메소드를 만들어주세요.

        //static void SortArray(int[] arr)
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        for (int j = i + 1; j < arr.Length; j++)
        //        {
        //            if (arr[i] > arr[j])
        //            {
        //                int temp = arr[i];
        //                arr[i] = arr[j];
        //                arr[j] = temp;
        //            }
        //        }
        //    }
        //}


    }
}

namespace Earth
{
    class Human
    {

    }
}

namespace Pandora
{
    class Human
    {

    }
}
