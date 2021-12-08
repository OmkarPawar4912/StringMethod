using System;
using System.Collections.Generic;
using System.Text;

namespace StringMethod
{
    public static class StringFn
    {
        static string strClone;
        static string str;
        static int num;
        static string strPadLeft50;
        public static void Clone()
        {
            Console.WriteLine("---------------------------------------- Clone() Method ----------------------------------------");
            strClone = (string)Program.Name.Clone();
            Console.WriteLine("{0}", strClone);
        }
        public static void Compare()
        {
            Console.WriteLine("---------------------------------------- Compare() Method --------------------------------------");
            Console.WriteLine("Name and Aadhar Name          :  " + string.Compare(Program.Name, Program.AadharName));
            Console.WriteLine("Collage and Aadhar Name       :  " + string.Compare(Program.Collage, Program.AadharName));
            Console.WriteLine("AadharName and Collage        :  " + string.Compare(Program.Name, Program.Collage));
        }
        public static void CompareOrdinal()
        {
            Console.WriteLine("---------------------------------------- CompareOrdinal() Method --------------------------------------");
            Console.WriteLine("Name and Aadhar Name          :  " + string.CompareOrdinal(Program.Name, Program.AadharName));
            Console.WriteLine("Collage and Aadhar Name       :  " + string.CompareOrdinal(Program.Collage, Program.AadharName));
            Console.WriteLine("AadharName and Collage        :  " + string.CompareOrdinal(Program.Name, Program.Collage));
        }
        public static void CompareTo()
        {
            Console.WriteLine("---------------------------------------- CompareTo() Method --------------------------------------");
            Console.WriteLine("Name and Aadhar Name          :  " + Program.Name.CompareTo(Program.AadharName));
            Console.WriteLine("Collage and Aadhar Name       :  " + Program.Collage.CompareTo(Program.Name));
            Console.WriteLine("AadharName and Collage        :  " + Program.AadharName.CompareTo(Program.Collage));
        }
        public static void Concat()
        {
            Console.WriteLine("---------------------------------------- Concat() Method --------------------------------------");
            Console.WriteLine("Name        : " + Program.Name + "\nAadharName  : " + Program.AadharName + "\nCollage     : " + Program.Collage);
        }
        public static void Contains()
        {
            Console.WriteLine("---------------------------------------- Contains() Method --------------------------------------");
            Console.WriteLine("Name and Aadhar Name          : " + Program.Name.Contains(Program.AadharName));
            Console.WriteLine("Collage and Aadhar Name       : " + Program.Collage.Contains(Program.AadharName));
        }
        public static void Copy()
        {
            Console.WriteLine("---------------------------------------- Copy() Method --------------------------------------");
            string strCopy = String.Copy(strClone);
            Console.WriteLine("Copied String : {0}", strCopy);
        }
        public static void CopyTo()
        {
            Console.WriteLine("---------------------------------------- CopyTo() Method --------------------------------------");
            char[] destArr = new char[20];
            Program.Name.CopyTo(14, destArr, 0, 5);
            Console.WriteLine(destArr);
        }
        public static void EndsWith()
        {
            Console.WriteLine("---------------------------------------- EndsWith() Method --------------------------------------");
            bool x, y;
            x = Program.Name.EndsWith("ar");
            y = Program.Collage.EndsWith("ar");
            Console.WriteLine(x.ToString());
            Console.WriteLine(y.ToString());
        }
        public static void Equals()
        {
            Console.WriteLine("---------------------------------------- Equals() Method --------------------------------------");
            Console.WriteLine("Name and Aadhar Name          : " + Program.Name.Equals(Program.AadharName));
            Console.WriteLine("Collage and Aadhar Name       : " + Program.Collage.Equals(Program.AadharName));
        }
        public static void Format()
        {
            Console.WriteLine("---------------------------------------- Format() Method --------------------------------------");
            // Number formatting  
            num= 302;
            string numStr = String.Format("Number {0, 0:D5}", num);
            Console.WriteLine(numStr);
            // Decimal formatting  
            decimal money = 99.95m;
            string moneyStr = String.Format("Money {0, 0:C2}", money);
            Console.WriteLine(moneyStr);
            // DateTime formatting  
            DateTime now = DateTime.Now;
            string dtStr = String.Format("{0:d} at {0:t}", now);
            Console.WriteLine(dtStr);
        }
        public static void GetEnumerator()
        {
            Console.WriteLine("---------------------------------------- GetEnumerator() Method --------------------------------------");
            CharEnumerator ch = Program.Collage.GetEnumerator();
            while (ch.MoveNext())
            {
                Console.Write("\t" + ch.Current);
            }
            Console.WriteLine();
        }
        public static void GetHashCodeOfString()
        {
            Console.WriteLine("---------------------------------------- GetHashCode() Method --------------------------------------");
            Console.WriteLine("Name         : " + Program.Name.GetHashCode());
            Console.WriteLine("Aadhar Name  : " + Program.AadharName.GetHashCode());
            Console.WriteLine("Collage      : " + Program.Collage.GetHashCode());
        }
        public static void GetTypeOfString()
        {
            Console.WriteLine("---------------------------------------- GetType() Method --------------------------------------");
            Console.WriteLine("Type      : {0}", Program.Name.GetType());
        }
        public static void GetTypeCodeOfString()
        {
            Console.WriteLine("---------------------------------------- GetTypeCode() Method --------------------------------------");
            Console.WriteLine("Type Code : {0}", Program.Name.GetTypeCode());
        }
        public static void IndexOf()
        {
            Console.WriteLine("---------------------------------------- GetTypeCode() Method --------------------------------------");
            Console.WriteLine("Index Of Pawar : {0}", Program.Name.IndexOf("Pawar"));
        }
        public static void Insert()
        {
            Console.WriteLine("---------------------------------------- Insert() Method --------------------------------------");
            Console.WriteLine("Current Collage string: " + Program.Collage);
            Console.WriteLine("New Collage string: " + Program.Collage.Insert(10, ",Sangli"));

            Console.WriteLine("---------------------------------------- Intern() Method --------------------------------------");
            string strIntern = string.Intern(Program.Collage);
            Console.WriteLine(Program.Collage);
            Console.WriteLine(strIntern);
        }
        public static void InsertInternIsInterned()
        {
            Console.WriteLine("---------------------------------------- Insert() Method --------------------------------------");
            Console.WriteLine("Current Collage string: " + Program.Collage);
            Console.WriteLine("New Collage string: " + Program.Collage.Insert(10, ",Sangli"));

            Console.WriteLine("---------------------------------------- Intern() Method --------------------------------------");
            string strIntern = string.Intern(Program.Collage);
            Console.WriteLine(Program.Collage);
            Console.WriteLine(strIntern);

            Console.WriteLine("---------------------------------------- IsInterned() Method ----------------------------------------");
            string strIsInterned = string.IsInterned(Program.Collage);
            Console.WriteLine(Program.Collage);
            Console.WriteLine(strIsInterned);
        }
        public static void IsNormalized()
        {
            Console.WriteLine("---------------------------------------- IsNormalized() Method ----------------------------------------");
            Console.WriteLine(Program.Name.IsNormalized(NormalizationForm.FormD));
            Console.WriteLine(Program.AadharName.IsNormalized(NormalizationForm.FormC));
            Console.WriteLine(Program.Collage.IsNormalized(NormalizationForm.FormKC));
        }
        public static void IsNullOrEmptyOrWhiteSpace()
        {
            Console.WriteLine("---------------------------------------- IsNullOrEmpty() Method ----------------------------------------");
            Console.WriteLine(Program.Name + " is Empty or Null  :  " + string.IsNullOrEmpty(Program.Name));
            Console.WriteLine("\" \" is Empty or Null                  :  " + string.IsNullOrEmpty(" "));
            Console.WriteLine("NULL  is Empty or Null                :  " + string.IsNullOrEmpty(null));

            Console.WriteLine("---------------------------------------- IsNullOrWhiteSpace() Method ----------------------------------------");
            Console.WriteLine(Program.Name + " is WhiteSpace or Null  :  " + string.IsNullOrWhiteSpace(Program.Name));
            Console.WriteLine("\" \" is WhiteSpace or Null                  :  " + string.IsNullOrWhiteSpace(" "));
            Console.WriteLine("NULL  is WhiteSpace or Null                :  " + string.IsNullOrWhiteSpace(null));
        }
        public static void Join()
        {
            Console.WriteLine("---------------------------------------- Join() Method ----------------------------------------");
            string[] strArr = { "One", "Two", "Three", "Four" };

            Console.WriteLine("String Array... \n");

            foreach (string s in strArr)
            {
                Console.WriteLine(s);
            }

            str = string.Join("/", strArr);

            Console.WriteLine("\nResult (after joining '/' ) = " + str);
        }
        public static void LastIndexOf()
        {
            Console.WriteLine("---------------------------------------- LastIndexOf() Method ----------------------------------------");
            Console.WriteLine(" Last Index of Pawar : " + Program.Name.LastIndexOf("Pawar"));
            Console.WriteLine(" Last Index of a     : " + Program.Name.LastIndexOf("a"));
            Console.WriteLine(" Last Index of Omkar : " + Program.Name.LastIndexOf("Omkar"));

            Console.WriteLine("---------------------------------------- LastIndexOfAny() Method ----------------------------------------");

            char[] word = { 'O', 'S', 'P' };
            Console.WriteLine(" Last Index of any Name     : " + Program.Name.LastIndexOfAny(word));
        }
        public static void Normalize()
        {
            Console.WriteLine("---------------------------------------- Normalize() Method ----------------------------------------");

            str = Program.Collage.Normalize();

            Console.WriteLine(" Normalize of College : " + str);
        }
        public static void PadLeftRight()
        {
            Console.WriteLine("---------------------------------------- PadLeft() Method ----------------------------------------");

            strPadLeft50 = Program.Collage.PadLeft(50);

            Console.WriteLine(strPadLeft50);

            strPadLeft50 = Program.Collage.PadLeft(50, '#');

            Console.WriteLine(strPadLeft50);

            Console.WriteLine("---------------------------------------- PadRight() Method ----------------------------------------");

            strPadLeft50 = Program.Collage.PadRight(50);

            Console.Write(strPadLeft50);
            Console.Write("this is PadRight()\n");

            strPadLeft50 = Program.Collage.PadRight(50, '#');

            Console.WriteLine(strPadLeft50);
        }
        public static void Remove()
        {
            Console.WriteLine("---------------------------------------- Remove() Method ----------------------------------------");

            string strRemove = Program.AadharName.Remove(5);

            Console.WriteLine("\' " + Program.Name + " ' from Remove all characters after first 5 chars : " + strRemove);

            strRemove = Program.AadharName.Remove(5, 8);

            Console.WriteLine("\' " + Program.Name + " ' from Remove characters start at the 5th position, next 8 characters : " + strRemove);

            Console.WriteLine("---------------------------------------- Replace() Method ----------------------------------------");
            Console.WriteLine("\' " + Program.Name + " ' from Replace(' Shankar ',' - ') : " + Program.AadharName.Replace(" Shankar ", " - "));

            Console.WriteLine("---------------------------------------- Split() Method ----------------------------------------");

            string str_split_multiple = "Black & White, Yellow and Green, Blue and White. opawar88@gmail.com";

            Console.WriteLine(str_split_multiple + "\n");

            string[] broken_str_multiple = str_split_multiple.Split(',', ' ', '@', '.');

            foreach (var sub_str in broken_str_multiple)
            {
                Console.WriteLine(sub_str);
            }

            Console.WriteLine("---------------------------------------- StartsWith() Method ----------------------------------------");
            Console.WriteLine("Name Starts With O (Capital)      : " + Program.Name.StartsWith("O"));
            Console.WriteLine("Name Starts With o (Lower)        : " + Program.Name.StartsWith("o"));

            Console.WriteLine("---------------------------------------- Substring() Method ----------------------------------------");

            str = "How to find a substring in a string";

            int startIndex = 7;

            int endIndex = str.Length - 7;

            string title = str.Substring(startIndex, endIndex);

            Console.WriteLine("Before 7 start Index :  " + str);
            Console.WriteLine("After 7 start Index  :  " + title);
        }
        public static void ToCharArray()
        {
            Console.WriteLine("---------------------------------------- ToCharArray() Method ----------------------------------------");

            char[] chars = Program.Name.ToCharArray();

            Console.WriteLine("String      : " + Program.Name);
            Console.Write("Character array :");

            for (int i = 0; i < chars.Length; i++)
            {
                Console.Write(" " + chars[i]);
            }
        }
        public static void ToLowerInvariantUpper()
        {
            Console.WriteLine("---------------------------------------- ToLower() Method ----------------------------------------");
            Console.WriteLine("Name        : " + Program.Name + "\nLower Case  : " + Program.Name.ToLower());

            Console.WriteLine("---------------------------------------- ToLowerInvariant() Method ----------------------------------------");
            Console.WriteLine("Name        : " + Program.Collage + "\nLower Case  : " + Program.Collage.ToLowerInvariant());

            Console.WriteLine("---------------------------------------- ToUpper() Method ----------------------------------------");
            Console.WriteLine("Name        : " + Program.Name + "\nUpper Case  : " + Program.Name.ToUpper());

        }
        public static void ToStringMethod()
        {
            Console.WriteLine("---------------------------------------- ToString() Method ----------------------------------------");
            Console.WriteLine("int num value convert into string : " + num.ToString());
        }
        public static void TrimTrimEndTrimStart()
        {
            Console.WriteLine("---------------------------------------- Trim() Method ----------------------------------------");

            Console.Write("Before Trim() : ");
            Console.WriteLine(strPadLeft50);

            Console.Write("After Trim() : ");
            Console.WriteLine(strPadLeft50.Trim('#'));

            Console.WriteLine("---------------------------------------- TrimEnd() Method ----------------------------------------");

            Console.Write("Before Trim() : ");
            Console.WriteLine(strPadLeft50);

            Console.Write("After Trim() : ");
            Console.WriteLine(strPadLeft50.TrimEnd('#'));

            Console.WriteLine("---------------------------------------- TrimStart() Method ----------------------------------------");

            Console.Write("Before Trim() : ");
            Console.WriteLine(strPadLeft50);

            Console.Write("After Trim() : ");
            Console.WriteLine(strPadLeft50.TrimStart('w'));
        }
    }
}