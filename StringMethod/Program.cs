using System;
using System.Reflection;

namespace StringMethod
{
   public class Program
    {
        public static string Name { get; set;}
        public static string AadharName { get; set;}
        public static string Collage { get; set; }

        static Program()
        {
             Name = "Omkar Shankar Pawar";
             AadharName = "Omkar Shankar Pawar";
             Collage = "Willingdon";
        }
        static void Main(string[] args)
        {
            StringFn.Clone();
            StringFn.Compare();
            StringFn.CompareOrdinal();
            StringFn.CompareTo();
            StringFn.Concat();
            StringFn.Contains();
            StringFn.Copy();
            StringFn.CopyTo();
            StringFn.EndsWith();
            StringFn.Equals();
            StringFn.Format();
            StringFn.GetEnumerator();
            StringFn.GetHashCodeOfString();
            StringFn.GetTypeOfString();
            StringFn.GetTypeCodeOfString();
            StringFn.IndexOf();
            StringFn.Insert();
            StringFn.InsertInternIsInterned();
            StringFn.IsNormalized();
            StringFn.IsNullOrEmptyOrWhiteSpace();
            StringFn.Join();
            StringFn.LastIndexOf();
            StringFn.Normalize();
            StringFn.PadLeftRight();
            StringFn.Remove();
            StringFn.ToCharArray();
            StringFn.ToLowerInvariantUpper();
            StringFn.ToStringMethod();
            StringFn.TrimTrimEndTrimStart();
            
            Console.WriteLine("=========================================================================================");

            Console.WriteLine("\t\t\t\tStringBuilder\n");

            StringBuilderFn stringBuilderFn = new StringBuilderFn(); //For StringBuilder Fn 
            stringBuilderFn.GetStringBuilder();

            Console.WriteLine("\t\t\t\tExceptionsHandling");        //For Exceptions Handling Fn 

            ExceptionsHandling exceptionsHandling = new ExceptionsHandling();

            exceptionsHandling.division(25, 0);
            Console.WriteLine("------------------------  Multiple Exception  ------------------------");

            exceptionsHandling.MultipleException();

            Console.WriteLine("------------------------  Finally Exception  ------------------------");

            exceptionsHandling.FinallyException();

            Console.WriteLine("=========================================================================================");
        }
    }
}
