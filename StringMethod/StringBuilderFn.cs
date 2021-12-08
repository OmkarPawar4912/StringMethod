using System;
using System.Text;

namespace StringMethod
{
    public class StringBuilderFn
    {
        static int[] _v = new int[]
    {
        1,
        4,
        6
    };
        public void GetStringBuilder()
        {
            StringBuilder MyOtherName = new StringBuilder("Omkar Shankar Pawar");
            Console.WriteLine("------------------------  Remove  ------------------------");
            MyOtherName.Remove(5, 8); 
            Console.WriteLine(MyOtherName);
            Console.WriteLine("------------------------  Insert  ------------------------");
            MyOtherName.Insert(5, " Shankar");
            Console.WriteLine(MyOtherName);
            Console.WriteLine("------------------------  Replace  ------------------------");
            MyOtherName.Replace(' ', '-'); 
            Console.WriteLine(MyOtherName);
            Console.WriteLine("------------------------  Append  ------------------------");
            MyOtherName.Append(Program.Collage);
            Console.WriteLine(MyOtherName);
           Console.WriteLine("------------------------  AppendFormat  ------------------------");
            StringBuilder b = new StringBuilder();
            foreach (int v in _v)
            {
                b.AppendFormat("int: {0:0.0}{1}", v, Environment.NewLine);
            }
            Console.WriteLine(b.ToString());
            Console.WriteLine("========================================================================================");

        }
    }
}
