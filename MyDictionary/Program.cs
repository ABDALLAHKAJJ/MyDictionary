using System;

namespace MyDictionarys
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();
            myDictionary.Add("ali", 1);
            myDictionary.Add("ali2", 2);
            myDictionary.Add("ali3", 3);
            myDictionary.Add("ali4", 4);

            foreach (var item in myDictionary.Items)
            {
                Console.WriteLine(item);
            }
        }
    }
}