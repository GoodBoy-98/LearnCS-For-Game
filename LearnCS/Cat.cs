using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCS
{
    internal class Cat
    {
        public int age;
        public string name;
        public string color;
        public string gender;


        public Cat(int age, string name, string color, string gender)
        {
            this.age = age;
            this.name = name;
            this.color = color;
            this.gender = gender;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {name}, 나이 : {age}, 색상 : {color}, 성별 : {gender}");
        }

        ~Cat() { Console.WriteLine("야옹"); }
    }
}
