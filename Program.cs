using System;

namespace _16_09
{
    delegate void Func(string str);

    class MyClass
    {
        private string str;

        public MyClass(string str)
        {
            this.str = str;
        }

        public void Space(string str)
        {
            char symbol = '_';
            string newWord = string.Join(symbol.ToString(), str.ToCharArray());
            Console.WriteLine(newWord);
        }

        public void Reverse(string str)
        {
            char[] letters = str.ToCharArray();
            Array.Reverse(letters);
            string reverseWord = new string(letters);
            Console.WriteLine(reverseWord);
        }
    }

    class Run
    {
        public void runFunc(Func func, string str)
        {
            MyClass myClass = new MyClass(str);
            func.Invoke(str);
          
        }
    }

    class Program
    {
        public static void Main()
        {
            Console.Write("Enter string: ");
            var str = Console.ReadLine();

            MyClass cls = new MyClass(str);
            Func funcDel = new Func(cls.Space); // params sadece sizin ora vereceyiniz parametrlerdi	
            funcDel += new Func(cls.Reverse);

            Run run = new Run();
            run.runFunc(funcDel, str); //cagiranda Space() ve Reverse() functionlari ise dusmelidir
        }
    }
}