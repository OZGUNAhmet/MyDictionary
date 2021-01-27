using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> myDictionary = new MyDictionary<string, string>();
            myDictionary.Add("A1 Belge", "3");
            myDictionary.Add("Revize", "4");
            myDictionary.Add("Yeni Başvuru", "2");
            myDictionary.Add("Liste", "4");
            myDictionary.Add("Sertifika", "8");

            myDictionary.ShowAll();


        }
    }
}

