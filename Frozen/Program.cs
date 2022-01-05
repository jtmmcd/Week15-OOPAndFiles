using System;
using System.Collections.Generic;
using System.IO;

namespace Frozen
{
    class Program
    {
        class Frozen
        {
            string nimi;
            string soov;

            public Frozen(string _nimi, string _soov)
            {
                nimi = _nimi;
                soov = _soov;
            }

            //getters
            public string Nimi
            {
                get { return nimi; }
            }

            public string Soov
            {
                get { return soov; }
            }
        }

        

        static void Main(string[] args)
        {
            List<Frozen> myFrozen = new List<Frozen>();
            string[] frozenFromFile = GetDataFromFile();

            foreach (string line in frozenFromFile)
            {
                string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                //Console.WriteLine($"title from TempArray: {tempArray[0]}");
                //Console.WriteLine($"rating from TempArray: {tempArray[1]}");
                //Console.WriteLine($"year from TempArray: {tempArray[2]}");
                Frozen newFrozen = new Frozen(tempArray[0], tempArray[1]);
                myFrozen.Add(newFrozen);

            }

            foreach (Frozen frozenFromList in myFrozen)
            {
                Console.WriteLine($"{frozenFromList.Nimi} wants {frozenFromList.Soov} for Christmas.");
            }


            
                //Anna wants new earrings for Christmas.
          
        }
        public static string[] GetDataFromFile()
        {
            string filePath = @"C:\Users\...\Programmeerimine\Failid\frozen.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);
            return dataFromFile;
        }
    } }
